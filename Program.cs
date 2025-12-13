using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new Builder("Bob", "Builder", "Doe");
            Sailor sailor = new Sailor("Bob","Sailor", "sail", "Корабль1");
            Pilot pilot = new Pilot("Plane1b", "Bob", "Pilot", "Fly");

            Worker worker = new Worker();

            builder.PrintInfo();
            builder.Buildhouse();
            Console.WriteLine("------------------");
            sailor.PrintInfo();
            sailor.sail();
            Console.WriteLine("------------------");
            pilot.PrintInfo();
            pilot.fly();
        }

    }
}
