using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal abstract class Human
    {
        protected string Name { get; set; }
        protected string WorkPlace { get; set; }
        protected string Surname { get; set; }

        public Human(string name, string workplace, string surname)
        {
            this.Name = name;
            this.WorkPlace = workplace;
            this.Surname = surname;
        }

    }
}
