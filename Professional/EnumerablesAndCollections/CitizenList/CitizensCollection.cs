using System;
using System.Collections;
using System.Linq;

namespace CitizenList
{
    class CitizensCollection : IEnumerable
    {
        private Citizen[] citizens = new Citizen [0];

        public IEnumerator GetEnumerator()
        {
            return citizens.GetEnumerator();
        }

        public int Add(Citizen citizen)
        {
            if (Equals(citizen))
            {
                throw new Exception("Citizen is already in the collection");
            }

            if (citizen is Retired)
            {
                int indexRetired = LastRetiredIndex();

                Insert(indexRetired + 1, citizen);

                return indexRetired + 1;
            }

            Insert(citizens.Length, citizen);

            return citizens.Length - 1;
        }

        bool Equals(Citizen citizen)
        {
            bool result = citizens.Any(c => c.Passport == citizen.Passport);
            return result;
        }

        int LastRetiredIndex()
        {
            int indexRetired = 0;

            while (indexRetired < citizens.Length && citizens[indexRetired] is Retired)
            {
                indexRetired++;
            }
            return indexRetired - 1;
        }

        public (bool, int) Contains(Citizen citizen)
        {
            (bool, int) result;
            var index = Array.IndexOf(citizens, citizen);
            result.Item1 = index >= 0;
            result.Item2 = index+1;
            return result;
        }


        private void Insert(int index, Citizen citizen)
        {
            Array.Resize(ref citizens, citizens.Length + 1);

            for (int i = index; i < citizens.Length - 1; i++)
            {
                citizens[i + 1] = citizens[i];
            }

            citizens[index] = citizen;
        }

        public void Clear()
        {
            Array.Resize(ref citizens, 0);
        }

        public (Citizen, int) ReturnLast()
        {
            (Citizen, int) result;
            result.Item1 = citizens.Last();
            result.Item2 = citizens.Length;
            return result;
        }

        public void Remove (Citizen citizen)
        {
            (bool, int) containsResult = Contains(citizen);
            if (!containsResult.Item1)
            {
                return;
            }
            
            for (int i = containsResult.Item2; i < citizens.Length-1; i++)
            {
                citizens[i] = citizens[i+1];
            }
            Array.Resize(ref citizens, citizens.Length - 1);
        }




        //public void PrintContents()
        //{
        //    Console.WriteLine("Список имеет емкость {0} и в настоящее время имеет {1} элементов.", contents.Length, count);
        //    Console.Write("Список содержит:");

        //    for (int i = 0; i < Count; i++)
        //        Console.Write(" {0}", contents[i]);

        //    Console.WriteLine("\n" + new string('-', 55));

        //}
    }
}
