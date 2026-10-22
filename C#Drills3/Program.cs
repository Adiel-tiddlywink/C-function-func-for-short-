using System;
class Program
{
    static bool isEven(int n)
    {
        // finding remainder of n
        int rem = n % 2;
        if (rem == 0){
            return true;
        }
        else
        {
            return false;
        }
    }
    
    static void Main()
    {
        int n = 15;
        if (isEven(n))
            Console.WriteLine("true");
        else
            Console.WriteLine("false");
    }
}