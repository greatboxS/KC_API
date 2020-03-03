using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CONFIG.Models
{
    public class ComponentStock
    {
        [Key]
        public int Id { get; set; }
        public int? MachineComponentId { get; set; }
        public int? Quantity { get; set; }
        public int? AddUserId { get; set; }
        public DateTime AddTime { get; set; } = DateTime.Now;

        public virtual MachineComponent MachineComponent { get; set; }
        public virtual Staff AddUser { get; set; }
    }
}
