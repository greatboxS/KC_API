using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CONFIG.Models
{
    public class MachineMaintenance
    {
        [Key]
        public int Id { get; set; }
        public int? BuildingId { get; set; }
        public int? AutoCutMachineId { get; set; }
        public string MaintainCode { get; set; }     //MaintainCode
        public int? MachineComponentId { get; set; }
        public int? AuthorPeopleId { get; set; }    // who give the component to the maintain people
        public string StartMaintain { get; set; } = DateTime.Now.ToString("dd/MM/yy, hh:mm");
        public string StopMaintain { get; set; }= DateTime.Now.ToString("dd/MM/yy, hh:mm");
        public int? ComponentQty { get; set; }
        public string Problem { get; set; }
        public string Notice { get; set; }  

        public virtual Staff Staff { get; set; }
        public virtual Building Building { get; set; }
        public virtual AutoCutMachine AutoCutMachine { get; set; }
        public virtual MachineComponent MachineComponent { get; set; }
    }

    public enum MaintainCode
    {
        REPLACE,
        FIX,

        CHANGE_BELT,
        CHANGE_KNIFE,
        FIX_PITONS,
        CHANGE_PARAMETERS,
        CLEAN_UP,
        CHANGE_PUNCH,
    }
}
