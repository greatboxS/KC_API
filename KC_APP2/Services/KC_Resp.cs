
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_CONFIG.Data;
using EF_CONFIG.Models;

namespace KC_APP2.Services
{
    public class KC_Resp
    {
        public int KC_DeviceId { get; set; }
        public string EOP { get; set; } = "knife_capture";
        public List<Machine> Machines { get; set; } = new List<Machine>();
        public string CurrentTime { get; set; } = DateTime.Now.ToString("HH:mm, dd/MM/yy");

        public KC_Resp()
        {

        }
        public KC_Resp(DataContext DataContext, int deviceId, string machine_name, int pos, int type, int knife_picked, int local_val)
        {
            var machine = DataContext.AutoCutMachine.Where(i => i.MachineName == machine_name).FirstOrDefault();
            if (machine == null)
                return;

            var lastRecord = DataContext.KnifeCaptureTracking
                .Where(i => i.MachineId == machine.Id)
                .OrderByDescending(i => i.Id)
                .FirstOrDefault();

            if (lastRecord != null)
            {
                DateTime lastUpdate = lastRecord.UpdateTime;

                if (lastUpdate.Year == DateTime.Now.Year &&
                    lastUpdate.Hour == DateTime.Now.Hour &&
                    lastUpdate.Minute == DateTime.Now.Minute &&
                    lastRecord.KnifeHeadPos == pos)
                {
                    //duplicate update detected
                    return;
                }
            }

            if (pos > 1 || pos < 0)
                return;

            if (type > 1 || type < 0)
                return;

            if (local_val < 0)
                return;

            var device = DataContext.KC_Device.Where(i => i.Id == deviceId).FirstOrDefault();
            if (device == null)
                return;

            string position = pos == 0 ? "T" : "P";
            string ktype = type == 0 ? "C" : "M";

            CurrentTime = $"{position}-{ktype}/ {CurrentTime}";

            var added = DataContext.KnifeCaptureTracking.Add(new KnifeCaptureTracking
            {
                MachineId = machine.Id,
                KC_DeviceId = device.Id,
                KnifeHeadPos = pos,
                KnifeType = type,
                LocalValue = local_val,
                LocalKnifeId = knife_picked
            });
            DataContext.SaveChanges();

            var knife = DataContext.MachineComponent
                .Where(i => i.ComponentCategory.Contains("Knife") && i.LocalSetupId == knife_picked)
                .FirstOrDefault();

            string knife_name = knife != null ? knife.ComponentName.Remove(0, 2) : "";

            Machines = new List<Machine>(new Machine[]
            {
                new Machine(machine_name, pos, type, knife_name)
            });
        }
        // machine1,machine2,machine3...
        public KC_Resp(DataContext DataContext, string machines)
        {
            EOP = "kc_initial";
            try
            {
                machines = machines.Replace(" ", "");
                machines = machines.ToUpper();
                string[] machineList = machines.Split(new string[] { "," }, StringSplitOptions.None);
                foreach (var str in machineList)
                {
                    var mch = DataContext.AutoCutMachine.Where(i => i.MachineName == str).FirstOrDefault();
                    if (mch == null)
                        continue;

                    string date = DateTime.Now.ToString("dd/MM/yyyy");

                    var lastInitialize = DataContext.KC_MachineInitialize
                        .Where(i => i.AutoCutMachineId == mch.Id)
                        .OrderByDescending(i => i.Id)
                        .FirstOrDefault();

                    bool reset = false;

                    if (lastInitialize != null)
                    {
                        if (!(lastInitialize.UpdateTime.Day == DateTime.Now.Day
                            && lastInitialize.UpdateTime.Month == DateTime.Now.Month
                            && lastInitialize.UpdateTime.Year == DateTime.Now.Year))
                        {
                            if (mch.ResetCounterDate != null && DateTime.Now.DayOfWeek.ToString().Contains(mch.ResetCounterDate))
                            {
                                reset = true;
                            }

                            DataContext.KC_MachineInitialize.Add(new KC_MachineInitialize
                            {
                                UpdateTime = DateTime.Now,
                                AutoCutMachineId = mch.Id,
                                MachineName = str,
                                ResetCounter = reset,
                            });
                            DataContext.SaveChanges();


                        }
                    }
                    else
                    {
                        if (mch.ResetCounterDate != null && DateTime.Now.DayOfWeek.ToString().Contains(mch.ResetCounterDate))
                        {
                            reset = true;
                        }

                        DataContext.KC_MachineInitialize.Add(new KC_MachineInitialize
                        {
                            UpdateTime = DateTime.Now,
                            AutoCutMachineId = mch.Id,
                            MachineName = str,
                            ResetCounter = reset,
                        });
                        DataContext.SaveChanges();
                    }

                    Machines.Add(new Machine
                    {
                        MachineName = str,
                        ResetCounter = reset
                    });
                }
            }
            catch (Exception ex)
            {
                CurrentTime = ex.ToString();
            }
        }

        public KC_Resp(DataContext DataContext, CaptureProps captureProps)
        {
            if (captureProps == null)
                return;

            var machine = DataContext.AutoCutMachine.Where(i => i.MachineName == captureProps.MachineName).FirstOrDefault();
            if (machine == null)
                return;

            if (captureProps.KPos > 1 || captureProps.KPos < 0)
                return;

            if (captureProps.KType > 1 || captureProps.KType < 0)
                return;

            if (captureProps.LocalValue < 0)
                return;

            var device = DataContext.AutoCutMachine.Where(i => i.Id == captureProps.DeviceId).FirstOrDefault();
            if (device == null)
                return;


            string position = captureProps.KPos == 0 ? "T" : "P";
            string ktype = captureProps.KType == 0 ? "C" : "M";

            CurrentTime = $"{position}-{ktype}/ {CurrentTime}";

            var added = DataContext.KnifeCaptureTracking.Add(new KnifeCaptureTracking
            {
                MachineId = machine.Id,
                KC_DeviceId = device.Id,
                KnifeHeadPos = captureProps.KPos,
                KnifeType = captureProps.KType,
                LocalValue = captureProps.LocalValue,
                LocalKnifeId = captureProps.KnifePicked
            });
            DataContext.SaveChanges();

            var knife = DataContext.MachineComponent
                .Where(i => i.ComponentCategory.Contains("Knife") && i.LocalSetupId == captureProps.KnifePicked)
                .FirstOrDefault();

            string knife_name = knife != null ? knife.ComponentName.Remove(0, 2) : "";

            Machines = new List<Machine>(new Machine[]
            {
                new Machine(captureProps.MachineName, captureProps.KPos, captureProps.KType, knife_name)
            });
        }
    }

    public struct KnifeHead
    {
        public int OldKnife { get; set; }
        public int NewKnife { get; set; }
    }

    public class Machine
    {
        public Machine()
        {

        }

        public Machine(string Name, int pos, int type, string knifeName)
        {
            MachineName = Name;
            string position = pos == 0 ? "T" : "P";
            string ktype = type == 0 ? "C" : "M";
            LastUpdateTime = DateTime.Now.ToString("HH:mm, dd/MM");
            //string knife = knifeCode != string.Empty ? knifeCode.Remove(0, knifeCode.Length - 3) : "";
            LastUpdateTime = $"{position}-{ktype}-{knifeName}/{LastUpdateTime}";
        }
        public string MachineName { get; set; }
        public string LastUpdateTime { get; set; } = DateTime.Now.ToString("HH:mm, dd/MM");
        public KnifeHead LeftKnife { get; set; }
        public KnifeHead RightKnife { get; set; }
        public bool ResetCounter { get; set; } = false;
    }
}
