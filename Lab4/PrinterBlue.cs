using System;

namespace Lab4
{
    class PrinterBlue : Printer
{
    public void Print(string value)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        base.Print(value);
    }
}
}
