using System;

class Program
{
    abstract class Document
    {
        public string Author { get; set; }
        public abstract void Render();
    }

    class TextDocument : Document
    {
        public string Content { get; set; }

        public override void Render()
        {
            Console.WriteLine("Текстовый документ:");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Содержимое: {Content}");
        }
    }

    class ImageDocument : Document
    {
        public string Resolution { get; set; }

        public override void Render()
        {
            Console.WriteLine("Изображение:");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Разрешение: {Resolution}");
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
                List<Document> documents = new List<Document>();

                TextDocument textDoc = new TextDocument();
                textDoc.Author = "Иван Петров";
                textDoc.Content = "Это пример текстового документа.";

                ImageDocument imageDoc = new ImageDocument();
                imageDoc.Author = "Анна Сидорова";
                imageDoc.Resolution = "1920x1080";

                documents.Add(textDoc);
                documents.Add(imageDoc);

                foreach (Document doc in documents)
                {
                    doc.Render();
                    Console.WriteLine();
                }
            
        }

    }
    static void PrintResult(double a, double b, char op, double result)
    {
        Console.WriteLine($"Результат: {a} {op} {b} = {result}");
    }
}


