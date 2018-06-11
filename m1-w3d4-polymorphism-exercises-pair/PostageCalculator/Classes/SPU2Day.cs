using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class SPU2Day : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            double rate = (weight * .05) * distance;
            return rate;
        }
        public string TypeOfDelivery
        {
            get { return "SPU (4-day ground)"; }
        }
    }
}
