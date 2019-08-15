using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam4
{
    class Program
    {
        static void Main(string[] args)
        {
            int broyKursove = int.Parse(Console.ReadLine());
            double kredit = 0;
            double kraynaOcenka = 0;

            for (var i = 1; i <= broyKursove; i++)
            {
                int kreditOcenka = int.Parse(Console.ReadLine());
                int ocenka = kreditOcenka % 10;
                int krediti = kreditOcenka / 10;
                kraynaOcenka = kraynaOcenka + ocenka;

                switch (ocenka)
                {
                    case 2:
                        {
                            kredit = kredit + krediti * 0;
                            break;
                        }
                    case 3:
                        {
                            kredit = kredit + krediti * 0.5;
                            break;
                        }
                    case 4:
                        {
                            kredit = kredit + krediti * 0.7;
                            break;
                        }
                    case 5:
                        {
                            kredit = kredit + krediti * 0.85;
                            break;
                        }
                    case 6:
                        {
                            kredit = kredit + krediti * 1;
                            break;
                        }
                }

            }

            

            Console.WriteLine("{0:f2}", kredit);
            Console.WriteLine("{0:f2}", kraynaOcenka / broyKursove);
        }
    }
}
