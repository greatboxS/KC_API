using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EF_CONFIG.Models
{
    public class KC_Device
    {
        [Key]
        public int Id { get; set; }
        public int? LocalDeviceId { get; set; }
        public string DeviceName { get; set; }
        public int BuildingId { get; set; }

        public virtual List<KC_PostRecord> KC_PostRecords { get; set; }
        public virtual Building Building { get; set; }
        public virtual List<KnifeCaptureTracking> KnifeCaptureTrackings { get; set; }
        public virtual List<KC_DisMachine> KC_DisMachines { get; set; }
    }
}
