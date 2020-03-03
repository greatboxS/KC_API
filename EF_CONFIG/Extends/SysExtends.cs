using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CONFIG.Extends
{
    public static class SysExtends
    {
        public static DateTime FirstDayOfWeek(DateTime dt)
        {
            var culture = System.Threading.Thread.CurrentThread.CurrentCulture;
            var FormatedFirstDate = culture.DateTimeFormat.FirstDayOfWeek;

            if (FormatedFirstDate != DayOfWeek.Monday)
                FormatedFirstDate = DayOfWeek.Monday;

            var diff = dt.DayOfWeek - FormatedFirstDate;
            if (diff < 0)
                diff += 7;

            return dt.AddDays(-diff).Date;
        }
    }
}
