using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    public class Student
    {
        public string groupName;
        public string firstName;
        public string lastName;
        public int age;

        public void Introduce()
        {
            Console.WriteLine($"Привет меня зовут {firstName} {lastName}, мне {age} лет, я в {groupName} группе. ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.firstName = "John";
            student1.lastName = "Doe";
            student1.age = 32;
            student1.groupName = "engineer";

            Student student2 = new Student();
            student2.firstName = "Bob";
            student2.lastName = "Doe";
            student2.age = 22;
            student2.groupName = "another engineer";

            student1.Introduce();
            student2.Introduce();

        }
    }
    

}
