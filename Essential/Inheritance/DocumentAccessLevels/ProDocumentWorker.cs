using System;

namespace DocumentAccessLevels
{
    class ProDocumentWorker : DocumentWorker
    {

        public override void EditDocument()
        {
            Console.WriteLine("Document is edited");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Document saved in old format. Saving on other formats is available in ExpertVersion");
        }
    }
}
