using System;

namespace Classroom
{
    class ClassRoom
    {
        Pupil[] pupils;
        public ClassRoom(params Pupil[] pupils)
        {
            if (pupils.Length >= 2 && pupils.Length <= 4)
            {
                this.pupils = pupils;
            }
            else
            {
                Console.WriteLine("Class must contain from 2 to 4 pupils.");
            }

        }

        public void ShowPupils()
        {
            if (pupils == null)
            {
                return;
            }
            for (int i = 0; i < pupils.Length; i++)
            {
                Console.WriteLine($"Pupil {i + 1}:");
                pupils[i].Study();
                pupils[i].Read();
                pupils[i].Write();
                pupils[i].Relax();
            }
        }
    }
}
