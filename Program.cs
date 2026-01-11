using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

class Program
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
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
    

        else if (op == '-')
        {
            return a - b;
        }

        else if (op == '*')
        {
            return a * b;
        }

        else if (op == '/')
        {
            if (b == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль!");
                return 0;
            }

            return a / b;
        }

        else
        {
            Console.WriteLine("Неизвестная операция!");
            return 0;
        }
    }
    static void PrintResult(double a, double b, char op, double result)
    {
        Console.WriteLine($"Результат: {a} {op} {b} = {result}");
    }
}
