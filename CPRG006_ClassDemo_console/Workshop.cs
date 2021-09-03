using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG006_ClassDemo_console
{
    static class Workshop
    {
        public static void Fix(Car car)
        {
            car.Broken = false;
        }

        public static string NeedFix(Car cr)
        {
            return cr.Broken ? "It needs fixing" : "It doesn't need fixing";
        }
    }
}
