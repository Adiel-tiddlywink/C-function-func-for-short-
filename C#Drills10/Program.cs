using System;

class Program
{
    static int CountVowels(string word)
    {
       int count = 0;
       foreach(char i in word)
    
            if (i == 'a' || i == 'A' || i == 'e' || i == 'E' || i == 'i' || i == 'I' || i == 'o' || i == 'O' || i == 'u' || i == 'U')
            {
                count++;
            }
        return count;
    
    
    }

static void Main()
    {
        Console.WriteLine($"There are {CountVowels("I am a cat!!")} vowels in this string");
    }
}

