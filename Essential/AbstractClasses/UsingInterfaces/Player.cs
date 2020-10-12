using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingInterfaces
{
    public class Player : IRecordable, IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Audio is playing");
        }
        
        void IPlayable.Pause()
        {
            Console.WriteLine("Audio is paused");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Audio stopped");
        }

         void IRecordable.Record()
        {
            Console.WriteLine("Audio is recording");
        }

        void IRecordable.Pause()
        {
            Console.WriteLine("Audio is paused");
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("Audio stopped");
        }
    }
}
