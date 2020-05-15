using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CONFIG.Models
{
    public class KC_DisMachine
    {
        [Key]
        public int Id { get; set; }
        public int? KC_DeviceId { get; set; }
        public int? AutoCutMachineId { get; set; }
        public int?  KC_PostRecordId { get; set; }

        public int? OldLeft { get; set; }
        public int? OldRight { get; set; }
        public int?  NewLeft { get; set; }
        public int? NewRight { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public string DateTimeStr { get; set; } = DateTime.Now.ToString("HH:mm:ss, dd/MM/yyyy");

        public virtual List<KC_MachineInitialize> KC_MachineInitializes { get; set; }
        public virtual KC_PostRecord KC_PostRecord { get; set; }
        public virtual KC_Device KC_Device { get; set; }
        public virtual AutoCutMachine AutoCutMachine { get; set; }
    }

    public class KC_MachineInitialize
    {
        [Key]
        public int Id { get; set; }
        public int? AutoCutMachineId { get; set; }
        public string MachineName { get; set; }
        public string DeviceName { get; set; }
        public bool? ResetCounter { get; set; }
        public DateTime UpdateTime { get; set; } = DateTime.Now;

        public virtual AutoCutMachine AutoCutMachine { get; set; }
    }
}
