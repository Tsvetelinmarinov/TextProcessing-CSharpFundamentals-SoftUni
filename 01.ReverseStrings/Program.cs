/*
 * 01.ReverseStrings
 */

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> reversedWords = new();
            string word = Console.ReadLine()!;
            while (word != "end")
            {
                string reversed = StringModifier.Reverse(word);
                reversedWords.Add(word, reversed);

                word = Console.ReadLine()!;
            }

            foreach (KeyValuePair<string, string> pair in reversedWords)
            {
                Console.WriteLine($"{pair.Key} = {pair.Value}");
            }
        }
    }
}