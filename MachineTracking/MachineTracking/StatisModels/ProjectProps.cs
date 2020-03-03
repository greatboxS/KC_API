using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineTracking.StatisModels
{
    public class ProjectProps
    {
        public static string FakeServer { get; set; } = @"Data Source=10.4.2.23;Initial Catalog=__KNIFE_CAPTURE__;User ID=sa;Password=shc@1234;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";//fake
        public static string RealServer { get; set; } = @"Data Source=DESKTOP-7N0K68V\SQLEXPRESS;Initial Catalog=__KNIFE_CAPTURE__;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    }
}
