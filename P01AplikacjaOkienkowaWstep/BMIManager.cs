using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01AplikacjaOkienkowaWstep
{
    internal class BMIManager
    {
        public double PoliczBMI(int waga, int wzrost)
        {
            double bmi = waga / Math.Pow(wzrost / 100.0, 2);
            return bmi;
        }
    }
}