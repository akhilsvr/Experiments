using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomLibrary
{
    public static class StringExtensions
    {
        /// <summary>
        /// Generates a Sequence of Random Strings from a seed string.
        /// </summary>
        /// <param name="charColl">The seed string for characters</param>
        /// <param name="strLen">The length of the random string</param>
        /// <returns>Sequence of Random Strings from a seed string.</returns>
        public static IEnumerable<string> GenerateRandStringSeq(this string charColl, int strLen)
        {
            var rand = new Random();

            int maxCharCount = charColl.Length;
            var newStringCharColl = new char[strLen];

            while (true)
            {
                for (int i = 0; i < strLen; i++)
                {
                    char nextChar = charColl[rand.Next(maxCharCount)];
                    newStringCharColl[i] = nextChar;
                }

                yield return new string(newStringCharColl);
            }

            yield break;
        }
    }
}
