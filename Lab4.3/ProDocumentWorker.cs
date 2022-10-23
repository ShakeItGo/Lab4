using System;

namespace Lab4._3
{
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ відредагований");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережений в старому форматі, збереження в інших форматах доступно в версії Експерт");
        }
    }
}
