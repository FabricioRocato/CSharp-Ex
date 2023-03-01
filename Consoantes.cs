using System;

class Consoantes
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma string:");
        string input = Console.ReadLine();
        string consonants = GetConsonants(input);
        Console.WriteLine("As consoantes na string digitada são: " + consonants);
    }

    static string GetConsonants(string input)
    {
        string result = "";
        string vowels = "aeiouAEIOU";
        foreach (char c in input)
        {
            if (Char.IsLetter(c) && vowels.IndexOf(c) < 0)
            {
                result += c;
            }
        }
        return result;
    }
}
