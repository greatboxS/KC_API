using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CONFIG.Models
{
    public class MachineComponent
    {
        [Key]
        public int Id { get; set; }
        public int? LocalSetupId { get; set; }   // setting by user
        public string ComponentCategory { get; set; }
        public string ComponentCode { get; set; }
        public string ComponentName { get; set; }
        public string Unit { get; set; }
        public string Description { get; set; }
        public float? Price { get; set; }

        public virtual List<ComponentImage> ComponentImages { get; set; }
        public virtual List<MachineMaintenance> MachineMaintenances { get; set; }
        public virtual List<ComponentStock> ComponentStocks { get; set; }
        public MachineComponent(MachineComponent componentProps)
        {
            ComponentCategory = componentProps.ComponentCategory;
            ComponentCode = componentProps.ComponentCode;
            ComponentName = componentProps.ComponentName;
            Description = componentProps.Description;
            Price = componentProps.Price;
            Unit = componentProps.Unit;
        }

        public MachineComponent() { }
    }
}
