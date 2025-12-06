using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Worker worker = new Worker();

            worker.WorkerFullNameInput();
            worker.WorkerBirtdayInput();
            worker.WorkerPhoneNumberInput();
            worker.WorkerEmailInput();
            worker.WorkerDescriptionOfWorksInout();
            worker.WorkerPositionInput();
            worker.PrintWorkerOutput();
        }
    }
}

