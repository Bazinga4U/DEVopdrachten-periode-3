using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        interface Fuel
        {
            string Fuel();
        }
        interface Vehicle
        {
            Fuel loadFuel();
            bool move();
        }

        class gasoline 
        {
            string fuel = "gasoline";
        }

        class diesel
        {
            string fuel = "diesel";
        }

        class dilithium
        {
            string fuel = "dilithium";
        }

        class Car : Vehicle, Fuel
        {
            int amountFuel = 100;
            string fuel;

            public void removeFuel()
            {
                if (amountFuel > 0)
                {
                    Console.WriteLine("Removing fuel");
                }
                else
                {
                    Console.WriteLine("Stopped removing fuel");
                }
            }

            public Fuel loadFuel()
            {
                if (fuel == "gasoline")
                {
                    Console.WriteLine("You have the correct Fuel");
                }
                else
                {
                    Console.WriteLine("You have the incorrect Fuel");
                }
            }

            public bool move()
            {
                if (amountFuel > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        class Truck : Vehicle, Fuel
        {
            int amountFuel = 100;
            string fuel;

            public void removeFuel()
            {
                if (amountFuel > 0)
                {
                    Console.WriteLine("Removing fuel");
                }
                else
                {
                    Console.WriteLine("Stopped removing fuel");
                }
            }

            public Fuel loadFuel()
            {
                if (fuel == "diesel")
                {
                    Console.WriteLine("You have the correct Fuel");
                }
                else
                {
                    Console.WriteLine("You have the incorrect Fuel");
                }
            }

            public bool move()
            {
                if (amountFuel > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        class Enterprise : Vehicle, Fuel
        {
            int amountFuel = 100;
            string fuel;

            public void removeFuel()
            {
                if (amountFuel > 0)
                {
                    Console.WriteLine("Removing fuel");
                }
                else
                {
                    Console.WriteLine("Stopped removing fuel");
                }
            }

            public Fuel loadFuel()
            {
                if (fuel == "dilithium")
                {
                    Console.WriteLine("You have the correct Fuel");
                }
                else
                {
                    Console.WriteLine("You have the incorrect Fuel");
                }
            }

            public bool move()
            {
                if (amountFuel > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}


