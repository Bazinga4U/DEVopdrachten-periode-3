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
            Person person1 = new Customer(); person1.Name();
            Person person2 = new Customer(); person1.Surname();
            Person person3 = new Customer(); person1.Age();
            Customer person4 = new Customer(); person4.Buy();
            Customer person5 = new Customer(); person4.returnsomething();
            Customer person6 = new Customer(); person4.ask();
            Person person11 = new Student(); person11.Name();
            Person person21 = new Student(); person11.Surname();
            Person person31 = new Student(); person11.Age();
            Student person41 = new Student(); person41.Study();
            Student person51 = new Student(); person41.Work();
            Student person61 = new Student(); person41.Makinghomework();
            Person person12 = new Teacher(); person12.Name();
            Person person22 = new Teacher(); person12.Surname();
            Person person32 = new Teacher(); person12.Age();
            Teacher person42 = new Teacher(); person42.Teach();
            Teacher person52 = new Teacher(); person42.CreatingHomework();
            Teacher person62 = new Teacher(); person42.GradingAssignments();
            Console.ReadKey();
        }
        interface Person
        {
            void Name();
            void Surname();
            void Age();

        }
        class Customer : Person
        {
            public void Name()
            {
                Console.WriteLine("Elise");
            }
            public void Surname()
            {
                Console.WriteLine("Ruizeveld");
            }
            public void Age()
            {
                Console.WriteLine("47");
            }
            public void Buy()
            {
                Console.WriteLine("I want to buy this product.");
            }
            public void returnsomething()
            {
                Console.WriteLine("I want to return this product because it broke.");
            }
            public void ask()
            {
                Console.WriteLine("Where can I find a potato?\n");
            }
        }
        class Student : Person
        {
            public void Name()
            {
                Console.WriteLine("Wessel");
            }
            public void Surname()
            {
                Console.WriteLine("van Meijbeek");
            }
            public void Age()
            {
                Console.WriteLine("17");
            }
            public void Study()
            {
                Console.WriteLine("Im currently to studying for Development");
            }
            public void Work()
            {
                Console.WriteLine("Im going to work tonight from 4pm till 8pm.");
            }
            public void Makinghomework()
            {
                Console.WriteLine("I dont understand exercise 5 of Analysis.\n");
            }
        }
        class Teacher : Person
        {
            public void Name()
            {
                Console.WriteLine("Ernie");
            }
            public void Surname()
            {
                Console.WriteLine("Tippens");
            }
            public void Age()
            {
                Console.WriteLine("55");
            }
            public void Teach()
            {
                Console.WriteLine("Im currently teaching Development to INF1J.");
            }
            public void CreatingHomework()
            {
                Console.WriteLine("Im thinking of new exercises for year 1 students.");
            }
            public void GradingAssignments()
            {
                Console.WriteLine("Im grading the assignments for INF1J.\n");
            }
        }
    }
}
