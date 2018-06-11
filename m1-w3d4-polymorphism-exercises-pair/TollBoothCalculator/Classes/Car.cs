using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator.Classes
{
   public  class Car : IVehicle
    {
        bool hasTrailer;

        public Car(bool hasTrailer)
        {
            this.hasTrailer = hasTrailer;
        }

        public bool HasTrailer
        {
            get;
        }

        public double CalculateToll(int distance)
        {
            double toll = 0;
            if (hasTrailer)
            {
                toll = (distance * .02) + 1;
            }
            else
            {
                toll = (distance * .02);
            }
            return toll;
        }
        public string NameOfVehicle
        {
            get { return "Car"; }
        }
    }
}
