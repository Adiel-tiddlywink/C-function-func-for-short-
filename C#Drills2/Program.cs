using System;
class FahrenheitToCelsius
{
    static void Main(string[] args)
    {
        double Fahrenheit = 82;
        double Celsius = (Fahrenheit - 32) * 5 / 9;
        Console.WriteLine("Temperature in celsius is:" + Celsius);
    }
}