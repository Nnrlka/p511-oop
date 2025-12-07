using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Program
    {
        //Наследование
        
        static void Main(string[] args)
        {
            Student student = new Student("John", "Doe", "p511");
            student.Print();

            Aspirant aspirant = new Aspirant("bob", "Doe", "p511", "Work1");
            aspirant.Print();
        }
    }
    


}

