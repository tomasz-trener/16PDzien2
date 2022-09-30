using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02PrzykladKalkulator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int liczba = 5;

            //new Kalkulator();

            Kalkulator kalkulator;
            //new Kalkulator();
            //Kalkulator kalkulator = new Kalkulator();

            kalkulator = new Kalkulator();

            new Kalkulator();

            Kalkulator kalkulator2 = kalkulator;
            kalkulator2 = new Kalkulator();
            //kalkulator2 = null;

            Kalkulator k1 = new Kalkulator();
            // Kalkulator k2 = new Kalkulator();

            MRORaport r1 = new MRORaport();
            MRORaport r2 = new MRORaport();

            MRORaport[] raporty = new MRORaport[100];
            raporty[0] = r1;
            raporty[1] = r2;
            raporty[2] = new MRORaport();

            double sum = 0;
            double sr = 0;
            for (int i = 0; i < raporty.Length; i++)
            {
                sum += raporty[i].Plant;
                sr += raporty[i].CalculateDaysFromDataRange();
            }

            double wyn = sr / raporty.Length;

            //double srednia=  raporty.Select(x=>x.CalculateDaysFromDataRange()).Average(x=>x);

            Console.WriteLine(sum);
        }
    }
}