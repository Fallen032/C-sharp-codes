using System;

namespace RemoveDuplicate
{
    internal class Program
    {
        static void RemoveDuplicates(int[] arr, ref int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n;)
                {
                    if (arr[i] == arr[j])
                    {
                        for (int x = j; x < n; x++)
                        {
                            arr[x] = arr[x + 1];
                        }
                        n--;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int n;

            Console.Write("Enter the array size: ");
            n = int.Parse(Console.ReadLine());

            int[] arr = new int[55];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Original array:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }

            RemoveDuplicates(arr, ref n);

            Console.WriteLine("After removing duplicate elements:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadLine();
        }
    }
}
