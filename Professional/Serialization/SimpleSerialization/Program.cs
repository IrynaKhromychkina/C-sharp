using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SimpleSerialization
{

    [Serializable]
    public class Pupil
    {
        private int schoolNumber;
        private string name;
        private int age;

        public Pupil(int schoolNumber, string name, int age)
        {
            this.schoolNumber = schoolNumber;
            this.name = name;
            this.age = age;
        }
        public Pupil() { }
        
        public int SchoolNumber { get { return schoolNumber; } }
        public string Name { get { return name; } }

        public int Age { get { return age; } }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Pupil pupilOne = new Pupil(342, "John Connor", 14);

            FileStream stream = File.Create("PupilInfo.dat");

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, pupilOne);
            stream.Close();
        }
    }
}
