using System;
using System.Linq;


namespace countVowel
{
    internal class Program
    {
        static int CountVowels(string input)
        {
           
            int count = 0;

            foreach (char character in input.ToLower())
            {
                if ("aeiou".Contains(character))
                {
                    count++;
                }
            }

            return count;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            String  input = Console.ReadLine();

            int vowels = CountVowels(input);
            Console.WriteLine("number of vowels: {0}", vowels);
            Console.ReadLine();
        }
    }
}
