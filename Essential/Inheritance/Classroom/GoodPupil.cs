using System;

namespace Classroom
{
    class GoodPupil:Pupil
    {
        public override void Study() => Console.WriteLine("Good pupil studies properly");
        public override void Read() => Console.WriteLine("Good pupil reads new books sometimes");
        public override void Write() => Console.WriteLine("Good pupil sometimes makes mistakes");
        public override void Relax() => Console.WriteLine("Good pupil relaxes at evenings and during the day\n");
    }
}
