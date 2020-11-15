using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic key;
            dynamic value;
            var dictionary = new Dictionary<dynamic, dynamic>
            {
                {new {Word = "Apfel"}, new {Translation = "apple"}},
                {new {Word = "Haus"}, new {Translation = "house"}},
                {new {Word = "Frage"}, new {Translation = "question"}},
                {new {Word = "vielleicht"}, new {Translation = "maybe"}},
                {new {Word = "Göttin"}, new {Translation = "goddes"}},
                {new {Word = "prüfen"}, new {Translation = "check"}},
                {new {Word = "Meister"}, new {Translation = "master"}},
                {new {Word = "Arbeiter"}, new {Translation = "worker"}},
                {new {Word = "Mitarbeiter"}, new {Translation = "employee"}},
                {new {Word = "Bild"}, new {Translation = "picture"}},
            };

            foreach (var keyValuePair in dictionary)
            {
                Console.WriteLine($"{keyValuePair.Key.Word} - {keyValuePair.Value.Translation}");
            }

            Console.ReadKey();
        }
    }
}

