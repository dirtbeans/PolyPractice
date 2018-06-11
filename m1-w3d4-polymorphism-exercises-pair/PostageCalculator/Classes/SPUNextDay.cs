using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class SPUNextDay : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            double rate = (weight * .075) * distance;
            return rate;
        }
        public string TypeOfDelivery
        {
            get { return "SPU (next-day)"; }
        }
    }
}
