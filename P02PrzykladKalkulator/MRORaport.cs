using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02PrzykladKalkulator
{
    internal class MRORaport
    {
        public double Plant { get; set; }
        public DateTime DataRangeFrom { get; set; }
        public DateTime DataRangeTo { get; set; }

        public double CalculateDaysFromDataRange()
        {
            TimeSpan ts = DataRangeFrom - DataRangeTo;
            return ts.TotalDays;
        }
    }
}