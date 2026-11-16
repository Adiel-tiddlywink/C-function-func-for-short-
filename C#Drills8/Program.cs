using System;

class Program
{
    static int Multiply(int a, int b)
    {
        return a * b;
    }
    
    static double Multiply(double a, double b)
    {
        return a * b;
    }
    static int Multiply(int a, int b, int c)
    {
        return a * b * c;
    }
    
    static void Main()
    {
        double Num = Multiply(1, 2, 3);
        Console.WriteLine(Num);
    }
}