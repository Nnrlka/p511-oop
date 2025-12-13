using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    public class Human
    {
        public string Name;
        public string Action;
        public string Surname;

        public Human(string name, string action, string surname)
        {
            this.Surname = surname;
            this.Action = action;
            this.Name = name;
        }
        public virtual void Work()
        {
            Console.WriteLine("я работаю");
        }
    }
}