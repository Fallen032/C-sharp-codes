using System;

namespace BinarySearch
{
    internal class Program
    {
        public static int BinarySearch(int[] arr, int key)
        {
            int left = 0;
            int right = arr.Length;

            while (left < right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] == key)
                {
                    return mid;
                }
                else if (arr[mid] > key)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return -1;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter sorted elements of the array:");

            for (int i = 0; i < size; i++)
            {
                Console.Write("Element: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter the key to search: ");
            int key = Convert.ToInt32(Console.ReadLine());

            int index = BinarySearch(arr, key);

            if (index != -1)
            {
                Console.WriteLine($"Element found at index {index}");
            }
            else
            {
                Console.WriteLine("Element not found in the array");
            }

            Console.ReadLine();
        }
    }
}
