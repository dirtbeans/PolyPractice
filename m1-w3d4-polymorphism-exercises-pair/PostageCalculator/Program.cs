using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostageCalculator.Classes;

namespace PostageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDeliveryDriver> deliverList = new List<IDeliveryDriver>();

            deliverList.Add(new PostalService1st());
            deliverList.Add(new PostalService2nd());
            deliverList.Add(new PostalService3rd());
            deliverList.Add(new FexEd());
            deliverList.Add(new SPU4Day());
            deliverList.Add(new SPU2Day());
            deliverList.Add(new SPUNextDay());


            Console.WriteLine("Please enter the weight of the package: ");
            string packageWeightEntry = Console.ReadLine();
            double packageDoubleWeight = double.Parse(packageWeightEntry);
            Console.WriteLine("(P)ounds or (O)unces? ");
            string weightClassEntry = Console.ReadLine().ToUpper();
            Console.WriteLine("What distance will it be traveling to? ");
            string distanceEntry = Console.ReadLine();
            int distanceDouble = int.Parse(distanceEntry);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Delivery Method            $ cost");
            Console.WriteLine();
            
            foreach(IDeliveryDriver deliver in deliverList)
            {
                if (weightClassEntry == "O")
                {
                    Console.WriteLine(deliver.TypeOfDelivery + "           $" + deliver.CalculateRate(distanceDouble, packageDoubleWeight));
                }
                else if (weightClassEntry == "P")
                {
                    Console.WriteLine(deliver.TypeOfDelivery + "           $" + deliver.CalculateRate(distanceDouble, packageDoubleWeight*16));
                }
                else Console.WriteLine("Please enter \"O\" or \"P\"!");
            }
                Console.ReadLine();

        }
    }
}
