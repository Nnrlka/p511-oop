using System;

class Program
{
    using System;

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 6 && value <= 100)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Ошибка: возраст должен быть в диапазоне от 6 до 100!");
                }
            }
        }

        public Student(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
    }

    internal class Program
    {
        PrintHeader();

        double number1 = ReadNumber("Введите первое число: ");
        double number2 = ReadNumber("Введите второе число: ");
        char operation = ReadOperation("Введите символ операции: ");

        double result = Calculate(number1, number2, operation);
        
        PrintResult(number1, number2, operation, result);
    }
    static void PrintHeader()
    {
        Console.WriteLine("-- Улучшенный калькулятор ---");
        Console.WriteLine("Доступные операции: +, -, *, /");
    }
    static double ReadNumber(string message)
    {
        Console.Write(message);
        return Convert.ToDouble(Console.ReadLine());
    }
    static char ReadOperation(string message)
    {
        Console.Write(message);
        return Convert.ToChar(Console.ReadLine());
    }
    static double Calculate(double a, double b, char op)
    {
        if (op == '+')
        {
            return a + b;
        }

        else if (op == '-')
        {
                Console.WriteLine("--- Создание профилей студентов ---");

                Console.WriteLine("Студент 1:");
                Console.Write("Введите имя: ");
                string firstName1 = Console.ReadLine();

                Console.Write("Введите фамилию: ");
                string lastName1 = Console.ReadLine();

                Console.Write("Введите возраст: ");
                int age1 = int.Parse(Console.ReadLine());

                Student student1 = new Student(firstName1, lastName1, age1);

                Console.WriteLine($"Привет, меня зовут {student1.FullName}, мне {student1.Age} лет.");
                Console.WriteLine($"Полное имя: {student1.FullName}");

                Console.WriteLine("\nСтудент 2:");
                Console.Write("Введите имя: ");
                string firstName2 = Console.ReadLine();

                Console.Write("Введите фамилию: ");
                string lastName2 = Console.ReadLine();

                Console.Write("Введите возраст: ");
                int age2 = int.Parse(Console.ReadLine());

                Student student2 = new Student(firstName2, lastName2, age2);

                Console.WriteLine($"Привет, меня зовут {student2.FullName}, мне {student2.Age} лет.");
                Console.WriteLine($"Полное имя: {student2.FullName}");

                Console.WriteLine("\n--- Попытка изменить возраст на некорректное значение ---");
                Console.Write("Введите некорректный возраст для студента 1: ");
                int wrongAge = int.Parse(Console.ReadLine());

                student1.Age = wrongAge;

                Console.WriteLine($"Текущий возраст студента 1: {student1.Age}");
            }
        }


    }




