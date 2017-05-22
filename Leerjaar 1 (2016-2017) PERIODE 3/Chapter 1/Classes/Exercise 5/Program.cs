using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class run_Exercise_5
    {
        static void Main(string[] args)
        {
            Interval interval = new Interval();
            Console.WriteLine(interval.sum());
            Console.WriteLine(interval.product());
            Console.ReadKey();
        }
    }
}
