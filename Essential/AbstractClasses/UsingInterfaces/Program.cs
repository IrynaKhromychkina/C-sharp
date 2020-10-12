using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            IPlayable music = player;
            music.Play();
            music.Pause();
            music.Stop();

            IRecordable recorder = player;
            recorder.Record();
            recorder.Pause();
            recorder.Stop();

            Console.ReadKey();
        }
    }
}
