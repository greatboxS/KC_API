using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KC_APP2.Services
{
    public class CaptureProps
    {
        public int PostId { get; set; }
        public string MachineName { get; set; }
        public int DeviceId { get; set; }
        public int KPos { get; set; }
        public int KType { get; set; }
        public int KnifePicked { get; set; }
        public int LocalValue { get; set; }
    }
}