using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int countmax = 60;
            for (int i = 0; i < countmax; i++)
            {
                number++ ;
                Console.WriteLine(number);

            }
            Console.ReadKey();
        }
    }
}
