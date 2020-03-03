using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KC_APP2.Services
{
    public class LocalPostData
    {
        public int KC_DeviceId { get; set; }
        public string EOP { get; set; }
        public List<Machine> Machines { get; set; }
        public string CurrentTime { get; set; } 
    }
}