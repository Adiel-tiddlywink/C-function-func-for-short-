using System;

class Program
{
    static void Main()
    {
        int[] nums = [6000, 178, 254, 3678];

        int max = FindMax(nums);
        Console.WriteLine($"The max is {max}");
    }

    static int FindMax(int[] numbers)
    {
        int maximum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > maximum)
            {
                maximum = numbers[i];
            }
        }
        return maximum;
    }
}