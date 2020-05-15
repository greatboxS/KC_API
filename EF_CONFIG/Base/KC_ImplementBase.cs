using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CONFIG.Data;
using EF_CONFIG.Models;
using EF_CONFIG.Extends;

namespace EF_CONFIG.Base
{
    public class KC_ImplementBase : IKC_ImplementBase
    {
        private readonly DataContext DataContext;

        public KC_ImplementBase(DataContext context)
        {
            DataContext = context;
        }

        public bool Add_KCPostRecord(KC_PostRecord KC_PostRecord)
        {
            try
            {
                KC_PostRecord = DataContext.KC_PostRecord.Add(KC_PostRecord);
                DataContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public bool Add_KC_DisMachine(KC_DisMachine KC_DisMachine)
        {
            try
            {
                DataContext.KC_DisMachine.Add(KC_DisMachine);
                DataContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public bool Delete_KC_DisMachine(KC_DisMachine KC_DisMachine)
        {
            throw new NotImplementedException();
        }

        public AutoCutMachine Get_AutoCutMachine(string MachineName)
        {
            try
            {
                return DataContext.AutoCutMachine
                    .Where(i => i.MachineName == MachineName)
                    .FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public AutoCutMachine Get_AutoCutMachine(int Id)
        {
            try
            {
                return DataContext.AutoCutMachine
                    .Where(i => i.Id == Id)
                    .FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public KC_Device Get_KCDevice(int id)
        {
            try
            {
                return DataContext.KC_Device
                    .Where(i => i.Id == id)
                    .FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public List<KC_Device> Get_KCDevice(Building Building)
        {
            try
            {
                return DataContext.KC_Device
                    .Where(i => i.BuildingId == Building.Id)
                    .ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public KC_DisMachine Get_KC_DisMachine(int id)
        {
            try
            {
                return DataContext.KC_DisMachine
                    .Where(i => i.Id == id)
                    .FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public List<KC_DisMachine> Get_KC_DisMachines(KC_Device ParentDevice)
        {
            try
            {
                return DataContext.KC_Device
                    .Include("KC_DisMachines")
                    .Where(i => i.Id == ParentDevice.Id)
                    .FirstOrDefault().KC_DisMachines;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public List<KC_DisMachine> Get_KC_DisMachines(KC_PostRecord KC_PostRecord)
        {
            try
            {
                return DataContext.KC_PostRecord
                    .Include("KC_DisMachines")
                    .Where(i => i.Id == KC_PostRecord.Id)
                    .FirstOrDefault().KC_DisMachines;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public List<KC_PostRecord> Get_KC_PostRecord(Building Building)
        {
            try
            {
                return DataContext.Building
                    .Include("KC_PostRecords")
                    .Where(i => i.Id == Building.Id)
                    .FirstOrDefault().KC_PostRecords;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public KC_PostRecord Get_LastPostRecord(AutoCutMachine AutoCutMachine)
        {
            try
            {
                return DataContext.KC_DisMachine
                    .Include("KC_PostRecord")
                    .Where(i => i.AutoCutMachineId == AutoCutMachine.Id)
                    .OrderByDescending(i => i.Id)
                    .FirstOrDefault().KC_PostRecord;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public List<KC_PostRecord> Get_KC_PostRecord(KC_Device KC_Device)
        {
            try
            {
                return DataContext.KC_Device
                    .Include("KC_PostRecords")
                    .Where(i => i.Id == KC_Device.Id)
                    .FirstOrDefault().KC_PostRecords;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public List<KC_PostRecord> Get_KC_PostRecord(KC_Device KC_Device, DateTime GetDate)
        {
            try
            {
                string request_date = GetDate.ToString("dd/MM/yyyy");

                return DataContext.KC_PostRecord
                    .Where(i => i.KC_DeviceId == KC_Device.Id && i.UpdateTimeStr.Contains(request_date))
                    .ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public KC_PostRecord Get_KC_LastPostRecord(KC_Device KC_Device)
        {
            try
            {
                return DataContext.KC_PostRecord
                    .Where(i => i.KC_DeviceId == KC_Device.Id)
                    .OrderByDescending(i => i.Id)
                    .First();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public List<KnifeCaptureTracking> Get_KnifeCaptureTrackings(KC_Device KC_Device)
        {
            try
            {
                return DataContext.KC_Device
                    .Include("KnifeCaptureTrackings")
                    .Where(i => i.Id == KC_Device.Id)
                    .FirstOrDefault().KnifeCaptureTrackings;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public List<KnifeCaptureTracking> Get_KnifeCaptureTrackings(AutoCutMachine AutoCutMachine)
        {
            try
            {
                return DataContext.KnifeCaptureTracking
                    .Where(i => i.MachineId == AutoCutMachine.Id)
                    .ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public List<KnifeCaptureTracking> Get_KnifeCaptureTrackings(AutoCutMachine AutoCutMachine, DateTime Now)
        {
            try
            {
                string current_date = Now.ToString("dd/MM/yyyy");
                return DataContext.KnifeCaptureTracking
                    .Where(i => i.MachineId == AutoCutMachine.Id && i.TimeStr.Contains(current_date))
                    .ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public List<KnifeCaptureTracking> Get_KnifeCaptureTrackingsOnWeek(AutoCutMachine AutoCutMachine)
        {
            try
            {
                var knifeCaptures = Get_KnifeCaptureTrackings(AutoCutMachine);

                if (knifeCaptures == null)
                    return null;

                string current_date = DateTime.Now.ToString("dd/MM/yyyy");

                DateTime FirstDateOfWeek = SysExtends.FirstDayOfWeek(DateTime.Now);
                var result = new List<KnifeCaptureTracking>();

                foreach (var item in knifeCaptures)
                {
                    int sub_days = item.UpdateTime.DayOfYear - FirstDateOfWeek.DayOfYear;
                    if (item.UpdateTime.Year == FirstDateOfWeek.Year)
                    {
                        sub_days = item.UpdateTime.DayOfYear - FirstDateOfWeek.DayOfYear;
                        if (item.UpdateTime.DayOfWeek >= FirstDateOfWeek.DayOfWeek && sub_days >= 0 && sub_days <= 7)
                        {
                            result.Add(item);
                        }
                    }
                    else
                    {
                        if (item.UpdateTime.Year - FirstDateOfWeek.Year == 1)
                        {
                            sub_days = Math.Abs(sub_days);
                            DateTime endofyear = new DateTime(FirstDateOfWeek.Year, FirstDateOfWeek.Month, 31);
                            if (item.UpdateTime.DayOfWeek >= FirstDateOfWeek.DayOfWeek && sub_days >= 0 && sub_days <= 7)
                            {
                                result.Add(item);
                            }
                        }
                    }
                }

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public List<KnifeCaptureTracking> Get_KnifeCaptureTrackingsOnWeek(AutoCutMachine AutoCutMachine, DateTime DateofWeek)
        {
            try
            {
                var knifeCaptures = Get_KnifeCaptureTrackings(AutoCutMachine);

                if (knifeCaptures == null)
                    return null;

                string current_date = DateofWeek.ToString("dd/MM/yyyy");

                DateTime FirstDateOfWeek = SysExtends.FirstDayOfWeek(DateofWeek);
                var result = new List<KnifeCaptureTracking>();

                foreach (var item in knifeCaptures)
                {
                    int sub_days = item.UpdateTime.DayOfYear - FirstDateOfWeek.DayOfYear;
                    if (item.UpdateTime.Year == FirstDateOfWeek.Year)
                    {
                        sub_days = item.UpdateTime.DayOfYear - FirstDateOfWeek.DayOfYear;
                        if (item.UpdateTime.DayOfWeek >= FirstDateOfWeek.DayOfWeek && sub_days >= 0 && sub_days <= 7)
                        {
                            result.Add(item);
                        }
                    }
                    else
                    {
                        if (item.UpdateTime.Year - FirstDateOfWeek.Year == 1)
                        {
                            sub_days = Math.Abs(sub_days);
                            DateTime endofyear = new DateTime(FirstDateOfWeek.Year, FirstDateOfWeek.Month, 31);
                            if (item.UpdateTime.DayOfWeek >= FirstDateOfWeek.DayOfWeek && sub_days >= 0 && sub_days <= 7)
                            {
                                result.Add(item);
                            }
                        }
                    }
                }

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public bool Update_AutoCutMachine(AutoCutMachine AutoCutMachine)
        {
            try
            {
                var machine = Get_AutoCutMachine(AutoCutMachine.Id);

                machine.ResetCounterDate = AutoCutMachine.ResetCounterDate;
                machine.TotalCounterDay = AutoCutMachine.TotalCounterDay;

                DataContext.Entry(machine).State = System.Data.Entity.EntityState.Modified;
                DataContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }



    }
}
