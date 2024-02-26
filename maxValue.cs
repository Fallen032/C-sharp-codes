using System;

class maxValue
{
    static int FindMax(int[] numbers)
    {
        int max = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        return max;
    }

    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[size];
        //it compares each element given by the user and displays the bigger value
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        int maxNumber = FindMax(array);

        
        Console.WriteLine("Maximum value of the array: {0}", maxNumber);
        Console.ReadLine();
    }
}

    

