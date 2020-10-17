using System;

namespace SpinWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Roar flower";
            char[] chars = myString.ToCharArray();

            string newString = SpinWords(chars);
            Console.WriteLine(newString);

            Console.ReadKey();
        }

        static string SpinWords(char[] chars)
        {
            int startPosition = 0;
            int wordLength;
            for (int i = 0; i < chars.Length; i++)
            {
                if ((i == chars.Length - 1) || Char.IsWhiteSpace(chars[i + 1]))

                {
                    wordLength = i - startPosition + 1;

                    if (wordLength > 4)
                    {
                        int counter = i;
                        for (int k = startPosition; k <= counter; k++)
                        {
                            char temp = chars[k];
                            chars[k] = chars[counter];
                            chars[counter] = temp;
                            counter--;
                        }
                    }
                    startPosition = i + 2;
                }
            }
            string newString = new string(chars);
            return newString;
        }
    }
}
