using System;

namespace DocumentsHandler
{
    class XMLHandler : AbstractHandler
    {
        public override void Open() => Console.WriteLine("XML document is open");
        public override void Create() => Console.WriteLine("XML document was created");
        public override void Change() => Console.WriteLine("XML document was changed");
        public override void Save() => Console.WriteLine("XML document was saved");
    }
}
