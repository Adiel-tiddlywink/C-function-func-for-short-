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
        int n = 0;
        // if (isEven(n))
        //     Console.WriteLine("true");
        // else
        //     Console.WriteLine("false");
        bool v = isEven(n);
        Console.WriteLine(v);
    }
}