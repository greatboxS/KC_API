using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EF_CONFIG.Models
{
    public class AutoCutMachine
    {
        [Key]
        public int Id { get; set; }
        public string MachineName { get; set; }
        public string ResetCounterDate { get; set; }
        public int? TotalCounterDay { get; set; }
        public string MachineCode { get; set; }
        public string Description { get; set; }
        public DateTime StartUsingTime { get; set; } = DateTime.Now;
        public string MachineType { get; set; }
        public int? BuildingId { get; set; }
        public virtual Building Building { get; set; }
        public virtual List<KnifeCaptureTracking> KnifeCaptureTrackings { get; set; }
        public virtual List<MachineMaintenance> MachineMaintenances { get; set; }
        public virtual List<KC_MachineInitialize> KC_MachineInitializes { get; set; }
    }
}
