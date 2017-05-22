using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class SumNum
    {
        public static int sum1and2(int num1, int num2)
        {
            int output = 0;
            for (int i = num1; i < num2; i++)
            {
                output += i;
            }
            return output;
        }

    }
    class TestInput
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number to sum");
            int numb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number to sum");
            int numb2 = Convert.ToInt32(Console.ReadLine());

            int SumNumb = SumNum.sum1and2(numb1, numb2);
            Console.WriteLine("The sum of filled in numbers is:");
            Console.WriteLine(SumNumb);
            Console.ReadKey();

        }
    }
}
