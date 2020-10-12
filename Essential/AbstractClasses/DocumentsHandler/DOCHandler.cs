using System;

namespace DocumentsHandler
{
    class DOCHandler : AbstractHandler
    {
        public override void Open() => Console.WriteLine("DOC is open");

        public override void Create() => Console.WriteLine("DOC was created");

        public override void Change() => Console.WriteLine("DOC was changed");

        public override void Save() => Console.WriteLine("DOC was saved");
    }
}
