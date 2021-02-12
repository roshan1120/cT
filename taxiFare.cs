using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Distance(in km) to be travelled: ");
            double distance=Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Time(in minutes) required to reach the destination: ");
            double time=Convert.ToDouble(Console.ReadLine());
            double fare = (distance * 7 * time) + ( (distance * 7 * time) * (0.07) );
            double fare1 = (fare - (fare * 0.25)) >= (fare - 50) ? (fare - (fare * 0.25)) : (fare - 50);
            if(fare1 >= 35)
            {
            Console.WriteLine("The total fare is Rs "+fare1);
            }
            else
            {
                Console.WriteLine("The total fare is Rs 35");
            }
            Console.ReadLine();

        }
    }
}