using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Transport> transports = new List<Transport>()
            {
                new Car(),
                new Bicycle(2,3,5,8),
            };

            double distance = 100;
            int passenger = 2;
            double cargo = 0.3;

            foreach (Transport transport in transports)
            {
                Console.WriteLine($"Время: {transport.GetTime(distance)}");
                Console.WriteLine($"Время: {transport.GetCost(distance, passenger, cargo)}");
            }
        }
    }


}

