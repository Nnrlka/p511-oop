using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    class Builder : Human
    {
        public string WorkName { get; set; }
        public Builder(string Name, string Action, string Surname) : base (Name, Action, Surname)
        {
            WorkName = Name;
        }
        public override void Work()
        {
            Console.WriteLine($"Привет, я {Name} {Surname}, я строю {Action}, моя работа называется {WorkName}")
        }
        public void Buildhouse()
        {
            Console.WriteLine("Я строю дом");
        }


    }
}
