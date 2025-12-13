using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    public class Sailor : Human
    {
        public string ShipName { get; set; }

        public Sailor(string Name, string Surname, string Action, string shipName) : base(Name, Action, Surname)
        {
            ShipName = shipName;
        }

        public virtual void Work()
        {
            Console.WriteLine($"Меня зовут : {Name} {Surname}, и езжу на корабле {ShipName} я работаю");
        }
    }
}
