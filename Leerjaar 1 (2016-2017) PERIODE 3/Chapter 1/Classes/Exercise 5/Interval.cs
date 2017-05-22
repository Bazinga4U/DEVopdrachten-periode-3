using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Interval
    {
        public int start = 1;
        public int end = 10;
        public int result = 0;

        public int sum()
        {
            int output = 0;
            for (int i = start; i < end; i++)
            {
                output += i;
            }
            return output;
        }
        public int product()
        {
            int output = 1;
            for (int i = start; i < end; i++)
            {
                output *= i;
            }
            return output;
        }
    }
}
