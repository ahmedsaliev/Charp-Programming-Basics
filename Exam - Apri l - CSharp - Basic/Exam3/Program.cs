using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
    class Program
    {
        static void Main(string[] args)
        {
            double suma = double.Parse(Console.ReadLine());
            var pol = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            var sport = Console.ReadLine();
            double money = 0;

            if (pol == 'm')
            {
                switch (sport)
                {
                case "Gym":
                    {
                        money = 42;
                        break;
                    }
                case "Boxing":
                    {
                        money = 41;
                        break;
                    }
                case "Yoga":
                    {
                        money = 45;
                        break;
                    }
                case "Zumba":
                    {
                        money = 34;
                        break;
                    }
                case "Dances":
                    {
                        money = 51;
                        break;
                    }
                case "Pilates":
                    {
                        money = 39;
                        break;
                    }
                }
            }
            else
            {
                switch (sport)
                {
                case "Gym":
                    {
                        money = 35;
                        break;
                    }
                case "Boxing":
                    {
                        money = 37;
                        break;
                    }
                case "Yoga":
                    {
                        money = 42;
                        break;
                    }
                case "Zumba":
                    {
                        money = 31;
                        break;
                    }
                case "Dances":
                    {
                        money = 53;
                        break;
                    }
                case "Pilates":
                    {
                        money = 37;
                        break;
                    }
                }
            }

            if (age <= 19)
            {
                money = money * 0.8;
            }

            if (suma >= money)
            {
                Console.WriteLine("You purchased a 1 month pass for {0}.", sport);
            }
            else
            {
                Console.WriteLine("You don't have enough money! You need ${0:f2} more.", money - suma);
            }
        }
    }
}
