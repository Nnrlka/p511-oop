using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    public class Rectangle
    {
        private double _width;
        private double _height;

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    Console.WriteLine("Error, width must be true");
                }
            }
        }

        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
                else
                {
                    Console.WriteLine("error, height must be True");
                }
            }
        }
        public double GetArea()
        {
            return _width * _height;
        }
        public double GetPerimeter()
        {
            return 2 * (_width + _height);
        }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Создаем корректный прямоугольник ---");
            Rectangle rect1 = new Rectangle(10, 5);

            Console.WriteLine($"Ширина : {rect1.Width}");
            Console.WriteLine($"Высота : {rect1.Width}");
            Console.WriteLine($"Площадь : {rect1.GetArea()}");
            Console.WriteLine($"Периметр : {rect1.GetPerimeter()}");

            Console.WriteLine("\n-- Попытка создать некорректный прямоугольник --- ");
            Rectangle rect2 = new Rectangle(-10, 0);
            Console.WriteLine($"Ширина rect2: {rect2.Width}");
            Console.WriteLine($"Высота rect2: {rect2.Height}");
            Console.WriteLine("\n--- Попытка изменить свойства на некорректное значение ---");
            rect1.Width = -20;
            Console.WriteLine($"Новая ширина rect1 после попытки изменения: {rect1.Width}");
        }
    }
}
