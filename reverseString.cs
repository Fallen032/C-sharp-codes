using System;

namespace ReverseString
{
    internal class reverseString
    {
        public static string Reverse(string input)
        {
            // Converting string to character array 
            char[] charArray = input.ToCharArray();
            // Declaring an empty string
            string reverseString = String.Empty;

            int length = charArray.Length - 1;
            int index = length;

            while (index >= 0)
            {
                reverseString = reverseString + charArray[index];
                index--;
            }

            return reverseString;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string userInput = Console.ReadLine();

            string reverseInput = Reverse(userInput);

            // Displaying both the original input and the reversed string
            Console.WriteLine("Original String: {0}", userInput);
            Console.WriteLine("Reversed String: {0}", reverseInput);

            Console.ReadLine();
        }
    }
}
