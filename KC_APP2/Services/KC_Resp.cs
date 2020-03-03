
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

        public KC_Resp(DataContext DataContext, int deviceId, string machine_name, int pos, int type, int knife_picked, int local_val)
        {
            var machine = DataContext.AutoCutMachine.Where(i => i.MachineName == machine_name).FirstOrDefault();
            if (machine == null)
                return;

            if (pos > 1 || pos < 0)
                return;

            if (type > 1 || type < 0)
                return;

            if (local_val < 0)
                return;

            var device = DataContext.AutoCutMachine.Where(i => i.Id == deviceId).FirstOrDefault();
            if (device == null)
                return;

            DataContext.KnifeCaptureTracking.Add(new KnifeCaptureTracking
            {
                MachineId = machine.Id,
                KC_DeviceId = device.Id,
                KnifeHeadPos = pos,
                KnifeType = type,
                LocalValue = local_val,
                LocalKnifeId = knife_picked
            });
            DataContext.SaveChanges();

            Machines = new List<Machine>(new Machine[]
            {
                new Machine{MachineName = machine_name }
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
                    var knifecapture = DataContext.KnifeCaptureTracking.Where(i => i.TimeStr.Contains(date) && i.MachineId == mch.Id).FirstOrDefault();

                    if (knifecapture != null)
                        continue;

                    bool reset = false;
                    if (mch.ResetCounterDate != null && DateTime.Now.DayOfWeek.ToString().Contains(mch.ResetCounterDate))
                    {
                        reset = true;
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
    }

    public struct KnifeHead
    {
        public int OldKnife { get; set; }
        public int NewKnife { get; set; }
    }

    public class Machine
    {
        public string MachineName { get; set; }
        public string LastUpdateTime { get; set; } = DateTime.Now.ToString("HH:mm, dd/MM/yy");
        public KnifeHead LeftKnife { get; set; }
        public KnifeHead RightKnife { get; set; }
        public bool ResetCounter { get; set; } = false;
    }
}
