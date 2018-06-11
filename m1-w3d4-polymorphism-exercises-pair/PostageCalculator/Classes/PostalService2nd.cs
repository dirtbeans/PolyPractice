using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    class PostalService2nd : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            double rate = 0;
            if (weight > 0 && weight <= 2)
            {
                rate = 0.0035 * distance;
            }
            else if (weight > 2 && weight <= 8)
            {
                rate = 0.040 * distance;
            }
            else if (weight > 8 && weight <= 15)
            {
                rate = .0047 * distance;
            }
            else if (weight > 15 && weight <= 48)
            {
                rate = .0195 * distance;
            }
            else if (weight > 48 && weight <= 128)
            {
                rate = .0450 * distance;
            }
            else
            {
                rate = .0500 * distance;
            }
            return rate;
        }
    }
}
