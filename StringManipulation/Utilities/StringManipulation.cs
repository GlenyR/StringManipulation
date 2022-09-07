using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation.Utilities
{
    public class StringManipulation
    {

        public string[] SortingOperations(string[] strs)
        {
            string[] sortedStrs = new string[strs.Length];
            for (int strIdx = 0; strIdx < strs.Length; strIdx++)
            {
                var alphabetFrecuency = GetAlphabetCount(strs[strIdx]);
                sortedStrs[strIdx] = string.Join("", alphabetFrecuency.OrderByDescending(o => o.Item2).Select(s => new string(s.Item1, s.Item2)).ToArray());
            }
            return sortedStrs;
        }

        private List<Tuple<char, int>>  GetAlphabetCount(string str)
        {
            var alphabetFrecuency = new List<Tuple<char, int>>();
            for (int i = 0; i < 26; i++)
            {
                char character = (char)(i + 'a');
                char[] charArray = str.ToCharArray();
                var count = 0;
                for (int p = 0; p < charArray.Length; p++)
                {

                    if (charArray[p] == character)
                    {
                        count++;
                    }
                }
                
                if (count > 0)
                {
                    alphabetFrecuency.Add(Tuple.Create(character, count));
                }
            }
            return alphabetFrecuency;
        }

    }
}
