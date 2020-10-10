using System;

namespace Classroom
{
    class ExcellentPupil : Pupil
    {
        public override void Study() => Console.WriteLine("Excellent pupil studies hard");
        public override void Read() => Console.WriteLine("Excellent pupil reads many books");
        public override void Write() => Console.WriteLine("Excellent pupil writes without mistakes");
        public override void Relax() => Console.WriteLine("Excellent pupil relaxes at evenings\n");
    }
}
