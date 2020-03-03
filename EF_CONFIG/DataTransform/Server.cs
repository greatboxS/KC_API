using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CONFIG.DataTransform
{
    public static class Server
    {
        public static string RealDb { get; set; } = @"Data Source=10.4.2.23;Initial Catalog=__KNIFE_CAPTURE__;User ID=sa;Password=shc@1234;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static string  FakeDb { get; set; }
    }
}
