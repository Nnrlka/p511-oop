using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal abstract class Human
    {
        protected string Name;
        protected string WorkPlace;
        protected string Surname;

        public Human(string name, string workplace, string surname)
        {
            this.Surname = surname;
            this.WorkPlace = workplace;
            this.Name = name;
        }
    }
}