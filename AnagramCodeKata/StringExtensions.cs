using System.Linq;

namespace AnagramCodeKata
{
    public static class StringExtensions
    {
        /*
         * This is the method that needs updating during the code kata...
         */
        public static bool IsAnagramOf(this string firstWord, string secondWord)
        {
            return string.Join("", firstWord.OrderBy(c => c)) == string.Join("", secondWord.OrderBy(c => c));
        }
    }
}