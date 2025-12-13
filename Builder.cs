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

        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Привет, я {Name} {Surname}, я строю дома, моя работа называется {Action}");
        }
        public void Buildhouse()
        {
            Console.WriteLine($"{Name} строит дом");
        }


    }
}
