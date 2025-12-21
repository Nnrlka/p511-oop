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
            private List<Student> students = new List<Student>();

            public void AddStudent(Student student)
            {
                students.Add(student);
            }
            public void PrintAllStudents()
            {
                if (students.Count == 0)
                {
                    Console.WriteLine("Список стундентов пуст");
                    return;
                }
                foreach (Student student in students)
                {
                    Console.WriteLine(student);
                }
            }
            public void SaveToFile(string fileName)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(fileName))
                    {
                        foreach (Student student in students)
                        {
                            writer.WriteLine($"{student.Name}; {student.Age}; {student.AverageGrade}");
                        }
                    }
                    Console.WriteLine("Успешно сохранено");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка при работе с файлом: " + ex.Message);
                }
            }
            public void LoadFromFile(string fileName)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(fileName))
                    {


                        students.Clear();
                        string Line;

                        while ((Line = reader.ReadLine()) != null)
                        {
                            string[] parts = Line.Split(';');
                            if (parts.Length != 3)
                                continue;
                            Student student = new Student(
                                parts[0],
                                int.Parse(parts[1]),
                                double.Parse(parts[2]));
                            students.Add(student);

                        }
                    }
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("Файл не найден");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный формат данных в файле");
                }
                catch (IOException ex)
                {
                    Console.WriteLine("ошибка при работе с файлом");
                }
            }


        }

        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public double AverageGrade { get; set; }

            public Student(string name, int age, double averageGrade)
            {
                Name = name;
                Age = age;
                AverageGrade = averageGrade;
            }
            public override string ToString()
            {
                return $"Фио: {Name}, возраст : {Age}, Средний балл: {AverageGrade}";
            }
        }



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
