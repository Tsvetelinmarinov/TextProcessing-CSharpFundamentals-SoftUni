/*
 * 02.RepeatStrings
 */

using _01.ReverseStrings;
using System;

namespace _02.RepeatStrings
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine()!
                .Split();

            string result = StringModifier.ConcatStrings(words);
            Console.WriteLine(result);
        }
    }
}