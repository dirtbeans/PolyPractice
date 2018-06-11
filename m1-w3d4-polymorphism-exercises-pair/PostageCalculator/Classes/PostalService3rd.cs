using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    class PostalService3rd : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            double rate = 0;
            if (weight > 0 && weight <= 2)
            {
                rate = 0.0020 * distance;
            }
            else if (weight > 2 && weight <= 8)
            {
                rate = 0.0022 * distance;
            }
            else if (weight > 8 && weight <= 15)
            {
                rate = .0024 * distance;
            }
            else if (weight > 15 && weight <= 48)
            {
                rate = .0150 * distance;
            }
            else if (weight > 48 && weight <= 128)
            {
                rate = .0160 * distance;
            }
            else
            {
                rate = .0170 * distance;
            }
            return rate;
        }
    }
}
