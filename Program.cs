using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
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

        static void Main(string[] args)
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
}


