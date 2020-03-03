using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CONFIG.Data;
using EF_CONFIG.Models;

namespace EF_CONFIG.Base
{
     interface IKC_ImplementBase
    {
        bool Add_KCPostRecord(KC_PostRecord KC_PostRecord);

        bool Add_KC_DisMachine(KC_DisMachine KC_DisMachine);
        bool Delete_KC_DisMachine(KC_DisMachine KC_DisMachine);

        AutoCutMachine Get_AutoCutMachine(string MachineName);

        AutoCutMachine Get_AutoCutMachine(int Id);

        KC_Device Get_KCDevice(int id);

        List<KC_Device> Get_KCDevice(Building Building);

        KC_DisMachine Get_KC_DisMachine(int id);

        List<KC_DisMachine> Get_KC_DisMachines(KC_Device ParentDevice);

        List<KC_DisMachine> Get_KC_DisMachines(KC_PostRecord KC_PostRecord);

        List<KC_PostRecord> Get_KC_PostRecord(Building Building);

        KC_PostRecord Get_LastPostRecord(AutoCutMachine AutoCutMachine);

        List<KC_PostRecord> Get_KC_PostRecord(KC_Device KC_Device);
        List<KC_PostRecord> Get_KC_PostRecord(KC_Device KC_Device, DateTime GetDate);

        List<KnifeCaptureTracking> Get_KnifeCaptureTrackings(KC_Device KC_Device);
        List<KnifeCaptureTracking> Get_KnifeCaptureTrackings(AutoCutMachine AutoCutMachine);

        List<KnifeCaptureTracking> Get_KnifeCaptureTrackings(AutoCutMachine AutoCutMachine, DateTime Now);

        List<KnifeCaptureTracking> Get_KnifeCaptureTrackingsOnWeek(AutoCutMachine AutoCutMachine);

        bool Update_AutoCutMachine(AutoCutMachine AutoCutMachine);
    }
}
