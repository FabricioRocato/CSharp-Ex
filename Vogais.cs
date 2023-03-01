using System;

class Vogais
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma string:");
        string input = Console.ReadLine();
        int count = CountVowels(input);
        Console.WriteLine("A string digitada contém " + count + " vogais.");
    }

    static int CountVowels(string input)
    {
        int count = 0;
        string vowels = "aeiouAEIOU";
        foreach (char c in input)
        {
            if (vowels.IndexOf(c) >= 0)
            {
                count++;
            }
        }
        return count;
    }
}

