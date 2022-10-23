using System;

namespace Lab4._3
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ відкритий");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редагування на версії Про");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Збереження на версії Про");
        }
    }
}
