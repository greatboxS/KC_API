using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CONFIG.Models
{
    public class KC_PostRecord
    {
        public int Id { get; set; }
        public string UpdateTimeStr { get; set; } = DateTime.Now.ToString("HH:mm:ss, dd/MM/yyyy");
        public DateTime UpdateTime { get; set; } = DateTime.Now;
        public int? KC_DeviceId { get; set; }
        public int? BuildingId { get; set; }

        public virtual Building Building { get; set; }
        public virtual KC_Device KC_Device { get; set; }
        public virtual List<KC_DisMachine> KC_DisMachines { get; set; }
    }
}
