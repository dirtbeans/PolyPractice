using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothCalculator.Classes;

namespace TollBoothCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVehicle> vehicleList = new List<IVehicle>();

            //Random distanceTraveled = new Random(10);
            int randomDistance1 = 34;
            int randomDistance2 = 56;
            int randomDistance3 = 101;
            int randomDistance4 = 222;

            vehicleList.Add(new Tank());
            vehicleList.Add(new Car(false));
            vehicleList.Add(new Car(true));
            vehicleList.Add(new Truck(4));

            int totalRandomDistance = (randomDistance1 + randomDistance2 + randomDistance3 + randomDistance4);
            double revenue1 = vehicleList[0].CalculateToll(randomDistance1);
            double revenue2 = vehicleList[1].CalculateToll(randomDistance2);
            double revenue3 = vehicleList[2].CalculateToll(randomDistance3);
            double revenue4 = vehicleList[3].CalculateToll(randomDistance4);
            double totalRevenue = (revenue1 + revenue2 + revenue3 + revenue4);

            Console.WriteLine(vehicleList[0].NameOfVehicle + "   " + randomDistance1 + "    $" + vehicleList[0].CalculateToll(randomDistance1));
            Console.WriteLine(vehicleList[1].NameOfVehicle + "   " + randomDistance2 + "    $" + vehicleList[1].CalculateToll(randomDistance2));
            Console.WriteLine(vehicleList[2].NameOfVehicle + "   " + randomDistance3 + "    $" + vehicleList[2].CalculateToll(randomDistance3));
            Console.WriteLine(vehicleList[3].NameOfVehicle + "   " + randomDistance4 + "    $" + vehicleList[3].CalculateToll(randomDistance4));
            Console.WriteLine("Total Miles Traveled: " + totalRandomDistance);
            Console.WriteLine("Total Tollbooth Revenue: $" + totalRevenue);

            Console.ReadLine();


        }
    }
}
