using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class PostalService1st : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            double rate = 0;
            if(weight > 0 && weight <= 2)
            {
                rate = 0.035 * distance;
            }
            else if (weight > 2 && weight <= 8)
            {
                rate = 0.40 * distance;
            }
            else if (weight > 8 && weight <= 15)
            {
                rate = .047 * distance;
            }
            else if( weight > 15 && weight <= 48)
            {
                rate = .195 * distance;
            }
            else if (weight > 48 && weight <= 128)
            {
                rate = .450 * distance;
            }
            else
            {
                rate = .500 * distance;
            }
            return rate;

        }

        public string TypeOfDelivery
        {
            get { return "Postal Service (1st Class)"; }
        }
    }

}
