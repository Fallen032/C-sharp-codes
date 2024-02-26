using System;

namespace ConsoleApp1
{
    internal class calculatePow
    {
        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result *= baseNum;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the base number: ");
            int baseNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the exponent: ");
            int exponent = Convert.ToInt32(Console.ReadLine());

            int result = GetPow(baseNumber, exponent);

            Console.WriteLine($"{baseNumber}^{exponent} = {result}");
            Console.ReadLine();
        }
    }
}
