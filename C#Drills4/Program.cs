using System;

class Program
{
    static bool IsValidPassword()
    {
        Console.WriteLine("Enter password:");
        string password = Console.ReadLine() ?? string.Empty;
        
        Console.WriteLine("Password is: " + password);
        
        if (password.Length < 8)
        {
            Console.WriteLine("Error: Password must be at least eight characters.");
            return false;
        }
        
        if (password.Contains(" "))
        {
            Console.WriteLine("Error: Password cannot contain spaces.");
            return false;
        }

        Console.WriteLine("Is the password more than eight characters? " + (password.Length > 8));
        Console.WriteLine("Does this password contain spaces? " + password.Contains(" "));
        
        return true;
    }

    static void Main(string[] args)
    {
        bool result = IsValidPassword();
        Console.WriteLine("Is password valid? " + result);
    }
}