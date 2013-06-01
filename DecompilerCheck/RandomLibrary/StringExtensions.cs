using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomLibrary
{
    public static class StringExtensions
    {
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
