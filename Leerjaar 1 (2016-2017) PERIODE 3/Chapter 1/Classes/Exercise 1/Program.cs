using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How big would you like your smiley to be?");
            int size = Convert.ToInt32(Console.ReadLine());
            string result = "";
            int eenderde = size / 3;
            int tweederde = size / 3 * 2;
            int helft = size / 2;

            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    if (x == 0 || x == (size - 1) || y == 0 || y == (size - 1))
                    {
                        result += "#";
                    }
                    else if (x == eenderde && (y == eenderde || y == tweederde))
                    {
                        result += "O";
                    }
                    else if (x == helft && y == helft)
                    {
                        result += 7;
                    }
                    else if (x == tweederde && (y >= eenderde && y <= tweederde))
                    {
                        result += "_";
                    }
                    else
                    {
                        result += " ";
                    }
                }
                result += "\n";
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
