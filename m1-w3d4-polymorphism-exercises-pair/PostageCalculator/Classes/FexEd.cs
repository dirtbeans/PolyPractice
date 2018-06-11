using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class FexEd : IDeliveryDriver
    {

        public double CalculateRate(int distance, double weight)
        {
            double rate = 20.00;
            if (distance > 500 && weight > 48)
            {
                rate += 8.0;
            }
            else if (distance > 500)
            {
                rate += 5.0;
            }
            else if (weight > 48)
            {
                rate += 3.0;
            }
            return rate;
        }

        public string TypeOfDelivery
        {
            get { return "FexEd"; }
        }

    }
}
