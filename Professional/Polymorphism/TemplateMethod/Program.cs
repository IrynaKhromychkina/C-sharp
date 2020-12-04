using System;

namespace TemplateMethod
{
    abstract class PlantingFlowers
    {
        public void Planting()
        {
            Dig();
            Plant();
            PourWater();
        }

        protected void Dig()
        {
            Console.WriteLine("Dig the ground and prepare the place for planting");
        }

        protected abstract void Plant();

        protected virtual void PourWater()
        {
            Console.WriteLine("Pour one cup of water and put a bit of ground on the top");
        }
    }

    class Peony : PlantingFlowers
    {
        protected override void Plant()
        {
            Console.WriteLine("Put the peony plant with root into the hole");
        }

        protected override void PourWater()
        {
            Console.WriteLine("Pour three cups of water and put a bit of ground mixed with compost on the top");
        }
    }

    class Tulip : PlantingFlowers
    {
        protected override void Plant()
        {
            Console.WriteLine("Put the tulip bulb into the hole");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Peony planting instructions");
            Peony redPeony = new Peony();
            redPeony.Planting();

            Console.WriteLine("");

            Console.WriteLine("Tulip planting instructions");

            Tulip velvetTulip = new Tulip();
            velvetTulip.Planting();

            Console.ReadKey();
        }
    }
}
