using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using SimpleSerialization;


namespace SimpleDeserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream streamDeserialization = File.OpenRead(@"C:\Sources\csharp\Professional\Serialization\SimpleSerialization\bin\Debug\PupilInfo.dat");
            BinaryFormatter formatterDeserialization = new BinaryFormatter();
            Pupil pupilOneDeserialized = formatterDeserialization.Deserialize(streamDeserialization) as Pupil;

            Console.WriteLine($"School number: {pupilOneDeserialized.SchoolNumber}, name: {pupilOneDeserialized.Name}, age: {pupilOneDeserialized.Age}");

            Console.ReadKey();
        }
    }
}
