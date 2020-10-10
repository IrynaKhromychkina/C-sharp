using System;

namespace Classroom
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcellentPupil first = new ExcellentPupil();
            BadPupil second = new BadPupil();
            
            ClassRoom classroom = new ClassRoom(first, second);
            classroom.ShowPupils();

            Console.ReadKey();
        }
    }
}
