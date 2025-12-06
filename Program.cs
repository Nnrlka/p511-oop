using System;

class Program
{
    static void Main()
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
