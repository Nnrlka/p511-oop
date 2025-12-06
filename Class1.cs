using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    public class Worker
    {
        public string FullName { get; set; }
        public DateTime Birtday { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string position { get; set; }
        public string DescriptionOfWork { get; set; }


        public void WorkerFullNameInput()
        {
            Console.Write("Введите ФИО: ");
            FullName = Console.ReadLine();
        }
        public void WorkerBirtdayInput()
        {
            Console.Write("Введите Дату рождения: ");
            Birtday = Convert.ToDateTime(Console.ReadLine());
        }
        public void WorkerPhoneNumberInput()
        {
            Console.Write("Введите Контактный телефон пример (+79448711789): ");
            PhoneNumber = Console.ReadLine();
        }
        public void WorkerEmailInput()
        {
            Console.Write("Введите Email: ");
            Email = Console.ReadLine();
        }
        public void WorkerDescriptionOfWorksInout()
        {
            Console.Write("Введите описание служебных обязанностей: ");
            DescriptionOfWork = Console.ReadLine();
        }

        public void WorkerPositionInput()
        {
            Console.Write("Введите должность: ");
            position = Console.ReadLine();
        }

        public void PrintWorkerOutput()
        {
            Console.WriteLine($"ФИО: {FullName}, Дата рождения: {Birtday}, Контактный номер: {PhoneNumber}, Email: {Email}, Должность: {position},  описание служебных обязанностей: {DescriptionOfWork}");
        }
    }
}
