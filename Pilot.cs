using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    public class Pilot : Human
    {
        public string Plane { get; set; }

        public Pilot(string plane, string Name, string Surname, string Action) : base(Name, Action, Surname)
        {
            this.Plane = plane;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Проффесия: пилот, обычно летаю на {Plane}");

        }
        public void fly()
        {
            Console.WriteLine($"{Name} управляет самолетом");
        }
    }
}
