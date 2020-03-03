using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EF_CONFIG.Models
{
    public class Building
    {
        [Key]
        public int Id { get; set; }
        public string BuildingName { get; set; }
        public string BuildingDes { get; set; }
        public int? DivisionId { get; set; }

        public virtual List<MachineMaintenance> MachineMaintenances { get; set; }
        public virtual AutoCutDivision AutoCutDivision { get; set; }
        public virtual List<AutoCutMachine> AutoCutMachines { get; set; }
        public virtual List<KC_Device> KC_Devices { get; set; }
        public virtual List<KC_PostRecord> KC_PostRecords{ get; set; }
}
}
