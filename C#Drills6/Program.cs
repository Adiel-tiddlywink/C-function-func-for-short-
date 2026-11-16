using System;

class Program{
    static void Main()
        
    {
        //. 0 1 2 
        int total = CalcSum([178, 254, 3678]);
        Console.WriteLine($"The total is {total}");
    }

        //create a method that loops thru an array and sums total elems
        // @return int sum
        // @para int[] number
        static int CalcSum(int[] numbers)
        {
            int sum = 0;
            for (int i=0; i< numbers.Length; i++)
            {
                sum += numbers[i];
                //Console.WriteLine(sum);
            }
    return sum;
        }
}