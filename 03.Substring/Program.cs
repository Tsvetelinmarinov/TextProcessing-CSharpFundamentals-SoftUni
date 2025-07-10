///
/// 03.Substring
/// 

namespace _03.Substring;

using System;

class Program
{
    static void Main()
    {
        string matchPattern = Console.ReadLine()!;
        string text = Console.ReadLine()!;

        while (text.Contains(matchPattern))
        {
            text = text.Remove(text.IndexOf(matchPattern), matchPattern.Length);
        }

        Console.WriteLine(text);
    }
}