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
            List<Human> humans = new List<Human>()
            {
                new Builder(Bob, Building, Doe),
                new Sailor(2,3,5,8),
                new Pilot(),
            };
        }
    }
    


}

