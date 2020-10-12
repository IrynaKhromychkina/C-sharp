using System;

namespace DocumentsHandler
{
    class TXTHandler : AbstractHandler
    {
        public override void Open() => Console.WriteLine("TXT document is open");
        public override void Create() => Console.WriteLine("TXT document was created");
        public override void Change() => Console.WriteLine("TXT document was changed");
        public override void Save() => Console.WriteLine("TXT document was saved");
    }
}
