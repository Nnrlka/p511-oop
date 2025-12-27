using System;

class Program
{
    class Rectangle
    {
        public double width;
        public double height;

        public double GetArea()
        {
            return width * height;
        }
        public double GetPerimeter()
        {
            return 2 * (width + height);
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
            Rectangle rect1 = new Rectangle();
            rect1.width = 5;
            rect1.height = 10;

            double area1 = rect1.GetArea();
            double perimeter1 = rect1.GetPerimeter();

            Console.WriteLine("Прямоугольник 1:");
            Console.WriteLine($"Ширина: {rect1.width}");
            Console.WriteLine($"Высота: {rect1.height}");
            Console.WriteLine($"Площадь: {area1}");
            Console.WriteLine($"Периметр: {perimeter1}");

            Console.WriteLine();

            Rectangle rect2 = new Rectangle();
            rect2.width = 3.5;
            rect2.height = 7;

            double area2 = rect2.GetArea();
            double perimeter2 = rect2.GetPerimeter();

            Console.WriteLine("Прямоугольник 2:");
            Console.WriteLine($"Ширина: {rect2.width}");
            Console.WriteLine($"Высота: {rect2.height}");
            Console.WriteLine($"Площадь: {area2}");
            Console.WriteLine($"Периметр: {perimeter2}");

        }

    }
    static void PrintResult(double a, double b, char op, double result)
    {
        Console.WriteLine($"Результат: {a} {op} {b} = {result}");
    }
}


