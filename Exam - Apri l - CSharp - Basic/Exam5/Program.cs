using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (var i = 1; i <= n; i++)
            {
                Console.WriteLine(new String('-', n + 2) + "**" + new String('-', n + 2));
            }

            for (var i = 1; i <= n - 3; i++)
            {
             Console.WriteLine(new String('-', (n + 1)) + "****" + new String('-', n + 1));
            }

            Console.WriteLine(new String('-', n) + "******" + new String('-', n));

            for (var i = 1; i <= n - 4; i++) Console.WriteLine(new String('-', n) + "**--**" + new String('-', n));

            for (var i = 1; i <= n - 3; i++) Console.WriteLine(new String('-', n - 1) + "**----**" + new String('-', n - 1));

            Console.WriteLine(new String('-', n - 2) + new String('*', 10) + new String('-', n - 2));


            int k = 0;
            for (var j = n - 3; j >= 1; j--)
            {
                Console.WriteLine(new String('-', j) + "**" + new String('-', 8 + k) + "**" + new String('-', j));
                k = k + 2;
            }

            Console.WriteLine(new String('*', 3) + new string('-', 2 * n) + new String('*', 3));

        }
    }
}
