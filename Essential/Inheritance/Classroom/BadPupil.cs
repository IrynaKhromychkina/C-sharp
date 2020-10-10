using System;

namespace Classroom
{
    class BadPupil:Pupil
    {
        public override void Study() => Console.WriteLine("Bad pupil does not like to study");
        public override void Read() => Console.WriteLine("Bad pupil does not read books");
        public override void Write() => Console.WriteLine("Bad pupil makes mistakes all the time");
        public override void Relax() => Console.WriteLine("Bad pupil relaxes whenever he wants\n");
    }
}
