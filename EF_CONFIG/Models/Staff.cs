using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CONFIG.Models
{
    public class Staff
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }


        public virtual List<ComponentStock> ComponentStocks{ get; set; }
        public virtual List<MachineMaintenance> MachineMaintenances { get; set; }
    }
}
