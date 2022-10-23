using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._3
{
    class Program
    {
        private const string PRO_LICENSE = "2000";
        private const string EXP_LICENSE = "1984";

        static void Main(string[] args)
        {

            Console.WriteLine("Введіть ключ:");
            var license = Console.ReadLine();


            DocumentWorker worker;
            switch (license)
            {
                case PRO_LICENSE: worker = new ProDocumentWorker(); break;
                case EXP_LICENSE: worker = new ExpertDocumentWorker(); break;
                default: worker = new DocumentWorker(); break;
            }


            while (true)
            {
                Console.WriteLine("Введіть команду (o/e/s/q): ");
                switch (Console.ReadLine())
                {
                    case "o": worker.OpenDocument(); break;
                    case "e": worker.EditDocument(); break;
                    case "s": worker.SaveDocument(); break;
                    case "q": return;
                }
            }
        }
    }
}
