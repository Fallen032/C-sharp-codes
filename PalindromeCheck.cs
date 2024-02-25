using System;

namespace PalindromeCheck
{
    internal class Program
    {
        private static bool IsPalindrome(string wordOrPhrase)
        {
            var min = 0;
            var max = wordOrPhrase.Length - 1;

            while (min < max)
            {
                while (min < max && !char.IsLetterOrDigit(wordOrPhrase[min]))
                {
                    min++;
                }

                while (min < max && !char.IsLetterOrDigit(wordOrPhrase[max]))
                {
                    max--;
                }

                if (char.ToLower(wordOrPhrase[min]) != char.ToLower(wordOrPhrase[max]))
                {
                    return false;
                }

                min++;
                max--;
            }

            return true;
        }

        static void Main(string[] args)
        {
            char input;

            do
            {
                Console.Write("Enter a word or phrase: ");
                var wordOrPhrase = Console.ReadLine();

                if (IsPalindrome(wordOrPhrase))
                {
                    Console.WriteLine("The phrase or word you entered is a palindrome!");
                }
                else
                {
                    Console.WriteLine("The phrase or word you entered is not a palindrome!");
                }

                Console.WriteLine("Do you want to try again? Press [y] to continue and [n] for no");
                input = Convert.ToChar(Console.ReadLine());

            } while (char.ToLower(input) == 'y');
        }
    }
}
