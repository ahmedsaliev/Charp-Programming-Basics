using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            double hrana = double.Parse(Console.ReadLine());
            double suveniri = double.Parse(Console.ReadLine());
            double hotel = double.Parse(Console.ReadLine());

            double benzin = (double) 420 / 100 * 7 * 1.85;
            double prestoy = 3 * hrana + 3 * suveniri;
            double zaHotel = hotel * 0.9 + hotel * 0.85 + hotel * 0.8;
            double moneyNeeded = benzin + prestoy + zaHotel;

            Console.WriteLine("Money needed: {0:f2}", moneyNeeded);
        }
    }
}
