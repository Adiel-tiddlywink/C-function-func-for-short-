using System;
class Program
{
    static bool isEven(int n)
    {
        // finding remainder of n
        int rem = n % 2;
        // rem = remainder
        if (rem == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    static void Main()
    {
        // n = number
        // if int n is even, it'll print true. if not, false.
        int n = 16;
        if (isEven(n))
            Console.WriteLine("true");
        else
            Console.WriteLine("false");
    }
}