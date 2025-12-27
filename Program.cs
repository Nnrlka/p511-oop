using System;

class Program
{

    class Product
    {
        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; }

        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"Product {{ Id = {Id}, Name = {Name}, Price = {Price} }}";
        }
    }
    class Inventory
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
            Console.WriteLine($"Добавлен товар: {product}");
        }

        public Product FindProductById(int id)
        {
            foreach (Product product in products)
            {
                if (product.Id == id)
                {
                    return product;
                }
            }
            return null;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            Console.WriteLine("--- Управление инвентарем ---");

            Console.Write("Сколько товаров хотите добавить? ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nТовар #{i + 1}:");

                Console.Write("Введите ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Введите название: ");
                string name = Console.ReadLine();

                Console.Write("Введите цену: ");
                decimal price = decimal.Parse(Console.ReadLine());

                Product product = new Product(id, name, price);
                inventory.AddProduct(product);
            }
            while (true)
            {
                Console.Write("\nВведите ID товара для поиска (или 0 для выхода): ");
                int searchId = int.Parse(Console.ReadLine());

                if (searchId == 0)
                    break;

                Product found = inventory.FindProductById(searchId);

                if (found != null)
                    Console.WriteLine($"Найден товар: {found}");
                else
                    Console.WriteLine($"Товар с ID {searchId} не найден.");
            }

            Console.WriteLine("\nПрограмма завершена.");
        }
    }
    static void PrintResult(double a, double b, char op, double result)
    {
        Console.WriteLine($"Результат: {a} {op} {b} = {result}");
    }
}
        
