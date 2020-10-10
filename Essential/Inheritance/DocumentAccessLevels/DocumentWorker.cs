using System;

namespace DocumentAccessLevels
{
    class DocumentWorker
    {

        public void OpenDocument()
        {
            Console.WriteLine("Document is open");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Document editing is available in ProVersion");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Saving documents is available in ProVersion");
        }
    }
}
