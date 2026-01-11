using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace p511_oop
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Person person = new Person
            {
                Name = "john",
                Age = 30
            };
            // Создание JSON
            string json = JsonSerializer.Serialize(person);
            Console.WriteLine(json);
            //Преобразование из JSON в объект 
            Person deserialized = JsonSerializer.Deserialize < Person>(json);

        }  
    }
    


}

