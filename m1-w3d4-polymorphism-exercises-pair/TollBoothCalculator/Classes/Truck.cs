using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator.Classes
{
    public class Truck : IVehicle
    {
        private int numberOfAxles;

        public Truck(int numberOfAxles)
        {
            this.numberOfAxles = numberOfAxles;
        }

        public int NumberOfAxles
        {
            get
            {
                return numberOfAxles;
                    }
        }

        public double CalculateToll(int distance)
        {
            double toll = 0;
            if (numberOfAxles == 4)
            {
                toll = (distance * .04);
            }
            else if (numberOfAxles == 6)
            {
                toll = (distance * .045);
            }
            else if (numberOfAxles == 8)
            {
                toll = (distance * .048);
            }
            return toll;
        }
        public string NameOfVehicle
        {
            get { return "Truck"; }
        }
    }
}
