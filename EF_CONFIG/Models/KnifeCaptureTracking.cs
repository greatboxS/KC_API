using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EF_CONFIG.Models
{
    public class KnifeCaptureTracking
    {
        [Key]
        public int Id { get; set; }
        public int MachineId { get; set; }
        public virtual AutoCutMachine AutoCutMachine { get; set; }

        public int? KC_DeviceId { get; set; }
        public virtual KC_Device KC_Device { get; set; }
        public int KnifeType { get; set; }
        public int KnifeHeadPos { get; set; }

        public int LocalValue { get; set; }
        public DateTime UpdateTime { get; set; } = DateTime.Now;

        public string TimeStr { get; set; } = DateTime.Now.ToString("hh:mm, dd/MM/yyyy");

        public int LocalKnifeId { get; set; }

        [NotMapped]
        public string KType
        {
            get
            {
                if (KnifeType == 0)
                    return "Old knife";
                if (KnifeType == 1)
                    return "New knife";
                return null;
            }
        }

        [NotMapped]
        public string KPosition
        {
            get
            {
                if (KnifeHeadPos == 0)
                    return "Left side";
                if (KnifeHeadPos == 1)
                    return "Right side";
                return null;

            }
        }
    }
}
