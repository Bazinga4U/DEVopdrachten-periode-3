using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_0
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    result += "*";
                }
                result += "\n";
            }
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}