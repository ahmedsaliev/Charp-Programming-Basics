using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam6
{
    class Program
    {
        static void Main(string[] args)
        {
         int n = int.Parse(Console.ReadLine());
         bool flagg = false;

            for (var a = 1; a <= 9; a++)
            {
                if (flagg == true) break;
                else
                    for (var b = 9; b >= a; b--)
                    {
                        if (flagg == true) break;
                        else
                        {
                            for (var c = 0; c <= 9; c++)
                            {
                                if (flagg == true) break;
                                else
                                {
                                    for (var d = 9; d >= c; d--)
                                    {
                                        if ((a + b + c + d == a * b * c * d) && (n % 10 == 5))
                                        {
                                            flagg = true;
                                            Console.WriteLine("{0}{1}{2}{3}", a, b, c, d);
                                            break;
                                        }
                                        else if ((c != 0) && (a * b * c * d / (a + b + c + d) == 3) && (n % 3 == 0))
                                            {
                                            flagg = true;
                                            Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
            }

         if (flagg == false) Console.WriteLine("Nothing found");
        }
    }
}
