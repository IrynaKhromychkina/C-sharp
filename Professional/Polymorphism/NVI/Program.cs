using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVI
{
    public class Human
    {
        public virtual void PhysicalAbilities()
        {
            GetUp();
            BrushTeeth();
            EatBreakfast();
        }

        protected virtual void GetUp()
        {
            Console.WriteLine("Good morning, I got up!");
        }

        protected virtual void BrushTeeth()
        {
            Console.WriteLine("I brushed my teeth");
        }

        protected virtual void EatBreakfast()
        {
            Console.WriteLine("I ate my breakfast");
        }

    }

    public class Student : Human
    {
        protected override void EatBreakfast()
        {
            Console.WriteLine("Sometimes I forgot to eat my breakfast, because I'm a student and always in a hurry");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human Johnson = new Student();
            Johnson.PhysicalAbilities();

            Console.ReadKey();
        }
    }
}
