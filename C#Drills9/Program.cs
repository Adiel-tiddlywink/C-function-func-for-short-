using System;

class Program
{
static double CalculatePrice(double price, double taxRate)
    {
        return price + taxRate;
    }
    static void Main()
    {
        Console.WriteLine("Give me a number, pwetty pwease: ");
        double Aniya = Console.Read();
        double Num = CalculatePrice(Aniya, 0.07);
        Console.WriteLine(Num);
    }
}