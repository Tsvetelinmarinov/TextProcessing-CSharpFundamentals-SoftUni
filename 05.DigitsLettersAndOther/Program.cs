///
/// 05.DigitsLettersAndOther
///

namespace _05.DigitsLettersAndOther
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine()!;
            SplitByCategoryAndPrint(input);
        }

        /// <summary>
        ///  Splits a string in tree different lists of strings:
        ///   - One for numbers
        ///   - One for letters
        ///   - One for other symbols
        ///  and print the lists each on a new line
        /// </summary>
        /// <param name="text">The text to be splitted</param>
        /// <returns></returns>
        static void SplitByCategoryAndPrint(string text)
        {
            List<string> nums = new();
            List<string> letters = new();
            List<string> chars = new();

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    nums.Add(text[i].ToString());
                }
                else if (char.IsLetter(text[i]))
                {
                    letters.Add(text[i].ToString());
                }
                else
                {
                    chars.Add(text[i].ToString());
                }
            }

            nums.ForEach(Console.Write);
            Console.WriteLine();

            letters.ForEach(Console.Write);
            Console.WriteLine();

            chars.ForEach(Console.Write);
            Console.WriteLine();
        }
    }
}
