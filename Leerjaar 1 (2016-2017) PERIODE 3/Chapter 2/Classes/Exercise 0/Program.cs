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
            IAnimal animal1 = new Cat(); animal1.SaySomething();
            IAnimal animal2 = new Dog(); animal2.SaySomething();
            IAnimal animal3 = new Cow(); animal3.SaySomething();
            Console.ReadKey();
        }
        interface IAnimal
        {
            void SaySomething();
        }

        class Cat : IAnimal
        {
            public void SaySomething()
            {
                Console.WriteLine("Miao");
                                
            }

        }
        class Dog : IAnimal
        {
            public void SaySomething()
            {
                Console.WriteLine("Bao");
                                
            }
        }
        class Cow : IAnimal
        {
            public void SaySomething()
            {
                Console.WriteLine("Muuu");
                                
            }
        }
    }

}
