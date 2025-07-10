///
/// 04.TextFilter
/// 

namespace _04.TextFilter;

class Program
{
    static void Main()
    {
        List<string> banned = Console.ReadLine()!
            .Split(", ")
            .ToList();

        string text = Console.ReadLine()!;
        for (int i = 0; i < banned.Count; ++i)
        {
            text = text.Replace(banned[i], new('*', banned[i].Length));
        }

        Console.WriteLine(text);
    }
}