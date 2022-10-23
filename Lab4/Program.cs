using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Print("Перша строка");

            PrinterBlue printerBlue = new PrinterBlue();
            printerBlue.Print("Друга строка");

            Console.ReadKey();
        }
    }
}