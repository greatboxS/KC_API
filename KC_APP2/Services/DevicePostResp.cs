using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EF_CONFIG.Data;
using EF_CONFIG.Models;
using EF_CONFIG.Base;

namespace KC_APP2.Services
{
    public class DevicePostResp
    {
        private DataContext DataContext;
        private KC_ImplementBase IKC_ImplementBase;

        public DevicePostResp()
        {

        }
        public DevicePostResp(DataContext DataContext, LocalPostData LocalPostData)
        {
            Deviceid = LocalPostData.KC_DeviceId;
            this.DataContext = DataContext;
            IKC_ImplementBase = new KC_ImplementBase(this.DataContext);

            if (LocalPostData == null)
            {
                Exception = "Post data is empty!";
                return;
            }

            string record_time = DateTime.Now.ToString("HH:mm, dd/MM/yyyy");

            var kc_device = IKC_ImplementBase.Get_KCDevice(Deviceid);

            if (kc_device == null)
            {
                Exception = "KC_Device is null!";
                return;
            }

            var KC_PostRecord = new KC_PostRecord
            {
                UpdateTimeStr = record_time,
                KC_DeviceId = kc_device.Id,
                BuildingId = kc_device.BuildingId,
            };

            if (!IKC_ImplementBase.Add_KCPostRecord(KC_PostRecord))
            {
                Exception = "Can not add new post record to database!";
                return;
            }

            if (LocalPostData.Machines != null)
            {
                foreach (var machine in LocalPostData.Machines)
                {
                    var autoCutmachine = IKC_ImplementBase.Get_AutoCutMachine(machine.MachineName);
                    if (autoCutmachine == null)
                        continue;

                    var KC_DisMachine = new KC_DisMachine
                    {
                        AutoCutMachineId = autoCutmachine.Id,
                        KC_DeviceId = kc_device.Id,
                        DateTimeStr = record_time,
                        KC_PostRecordId = KC_PostRecord.Id,
                        NewLeft = machine.LeftKnife.NewKnife,
                        NewRight = machine.RightKnife.NewKnife,
                        OldLeft = machine.LeftKnife.OldKnife,
                        OldRight = machine.RightKnife.OldKnife,
                    };

                    if(!IKC_ImplementBase.Add_KC_DisMachine(KC_DisMachine))
                    {
                        Exception = "Add KC_DisMachine to database failed!";
                    }
                }
            }
        }

        public int Deviceid { get; set; }
        public string CurrentTime { get; set; } = DateTime.Now.ToString("HH:mm, dd/MM/yyyy");
        public string Exception { get; set; }
        public string EOP { get; set; } = "post_resp";
    }
}