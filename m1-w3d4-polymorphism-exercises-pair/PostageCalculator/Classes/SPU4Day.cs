using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class SPU4Day : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            double rate = (weight * .005) * distance;
            return rate;
        }
        public string TypeOfDelivery
        {
            get { return "SPU (2-day business)"; }
        }
    }
}
