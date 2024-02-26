using System;

namespace fizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                String result = "";

                if (i % 3 == 0)
                {
                    result = "Fizz";
                }
                if (i % 5 == 0)
                {
                    result += "Buzz";
                }
                if (result.Length == 0)
                {
                    result = i.ToString();
                }

                Console.WriteLine(result);
            }

            Console.ReadLine(); 
        }
    }
}
