using System;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, factor = 1;

            Console.Write("Enter Num: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num <= 1)
            {
                Console.WriteLine("{0}! = {1}", num, factor);
            }
            else
            {
                for (int count = num; count >= 2; count--)
                {
                    factor = factor * count;
                }
                Console.WriteLine("{0}! = {1}", num, factor);
            }
            Console.ReadLine();
        }
    }
}
