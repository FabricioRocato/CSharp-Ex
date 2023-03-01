using System;

class PrintVogais
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma string:");
        string input = Console.ReadLine();
        string vowels = GetVowels(input);
        Console.WriteLine("As vogais na string digitada são: " + vowels);
    }

    static string GetVowels(string input)
    {
        string result = "";
        string vowels = "aeiouAEIOU";
        foreach (char c in input)
        {
            if (vowels.IndexOf(c) >= 0)
            {
                result += c;
            }
        }
        return result;
    }
}

