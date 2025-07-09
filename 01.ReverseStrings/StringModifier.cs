/*
 * 01.ReverseStrings
 */

namespace _01.ReverseStrings
{
    /// <summary>
    ///  Provide static methods for modifying strings
    /// </summary>
    public class StringModifier
    {
        ///<summary>
        /// Reverse a string
        ///</summary>
        public static string Reverse(string value)
        {
            string reversed = string.Empty;
            for (int i = value.Length - 1; i >= 0; i--)
            {
                reversed += value[i];
            }

            return reversed;
        }

        ///<summary>
        /// Repeat a string 
        /// </summary>
        public static string Repeat(string value, int repeats)
        {
            string output = string.Empty;
            for (; repeats > 0; repeats--)
            {
                output += value;
            }

            return output;
        }

        ///<summary>
        ///  Concatenate collection of strings to one string, 
        ///  where each substring in the collection is repeated X times in the new string, 
        ///  where X is the length of the substring.
        /// </summary>
        public static string ConcatStrings(string[] values)
        {
            string output = string.Empty;
            foreach (string value in values)
            {
                for (int i = 0; i < value.Length; i++)
                {
                    output += value;
                }
            }

            return output;
        }
    }
}
