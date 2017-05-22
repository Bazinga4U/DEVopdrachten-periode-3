using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    public static class InRangeExt
    {
        public static bool InRange(this int value, int start, int end)
        {
            if (value >= start && value <= end)
                return true;
            return false;
        }

        public static bool InRange(this double value, double start, double end)
        {
            if (value >= start && value <= end)
                return true;
            return false;
        }
    }
}
