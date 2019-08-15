using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            var pol = char.Parse(Console.ReadLine());
            double teglo = double.Parse(Console.ReadLine());
            double visochina = double.Parse(Console.ReadLine());
            int vazrast = int.Parse(Console.ReadLine());
            var nivo = Console.ReadLine();
            double bnm;

            if (pol == 'm')
                {
                bnm = 66 + (13.7 * teglo) + (5 * visochina * 100) - (6.8 * vazrast);
                }
            else
                {
                bnm = 655 + (9.6 * teglo) + (1.8 * visochina * 100) - (4.7 * vazrast);
                }

            switch (nivo)
            {
                case "sedentary":
                    {
                        bnm = bnm * 1.2;
                        break;
                    }
                case "lightly active":
                    {
                        bnm = bnm * 1.375;
                        break;
                    }
                case "moderately active":
                    {
                        bnm = bnm * 1.55;
                        break;
                    }
                case "very active":
                    {
                        bnm = bnm * 1.725;
                        break;
                    }
            }

            Console.WriteLine("To maintain your current weight you will need {0} calories per day.", Math.Ceiling(bnm));

        }
    }
}
