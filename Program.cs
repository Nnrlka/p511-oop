using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Program
    {
        public class StudentManager
        {
            //sdf
            Console.WriteLine("Test")
        }
    }
    

            Worker worker = new Worker();


        static void Main(string[] args)
        {

            Console.WriteLine("                                                                                            ");
            Console.WriteLine("             ------Добро пожаловать в консольное приложения для учета студентоввв------");
            Console.WriteLine("                             выберите цифру для взаимодействия \n     1.Добавить студента, 2. Показать всех студентов, 3. сохранить в файл, 4. Загрузить из файла, 0. Выход ");
            Console.WriteLine("                                                                                            ");
            StudentManager manager = new StudentManager();
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("1. Добавить студента");
                Console.WriteLine("2. Показать всех студентов");
                Console.WriteLine("3. Сохранить в файл");
                Console.WriteLine("4. Загрузить из файла");
                Console.WriteLine("5. Выход");
                Console.Write("Выберите пункт: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введите ФИО: ");
                        string name = Console.ReadLine();

                        Console.Write("Введите возраст: ");
                        if (!int.TryParse(Console.ReadLine(), out int age))
                        {
                            Console.WriteLine("Возраст введён неверно!");
                            break;
                        }
                        
                        Console.Write("Введите средний балл: ");
                        if (!double.TryParse(Console.ReadLine(), out double averageGrade))
                        {
                            Console.WriteLine("Средний балл введён неверно!");
                            break;
                        }

                        manager.AddStudent(new Student(name, age, averageGrade));
                        Console.WriteLine("Студент добавлен!");
                        break;

                    case "2":
                        manager.PrintAllStudents();
                        break;

                    case "3":
                        Console.Write("Введите имя файла: ");
                        manager.SaveToFile(Console.ReadLine());
                        break;

                    case "4":
                        Console.Write("Введите имя файла: ");
                        manager.LoadFromFile(Console.ReadLine());
                        break;

                    case "5":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Неверный пункт меню!");
                        break;
                }

                Console.WriteLine("\nНажмите любую клавишу...");
                Console.ReadKey();
            }
        }
    }
}
