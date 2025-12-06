using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Program
    {
        //Наследование (Принцип ООП)
        class Animal
        {
            public string Name { get; set; }
            public Animal(string name)
            {
                Name = name;
            }
            public void Eat()
            {
                Console.WriteLine("Животное ест");
            }
        }

        class Dog : Animal 
        {
            public Dog(string name) : base(name)
            {
                
            }

        }


        static void Main(string[] args)
        { 
        }
    }
    


}

