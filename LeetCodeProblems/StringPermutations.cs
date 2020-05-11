using System;
using System.Diagnostics;

namespace LeetCodeProblems
{
    public class StringPermutations
    {
        public bool AreEqual(string str1, string str2)
        {
            // obvious checks
            if (str1 == str2 || (string.IsNullOrWhiteSpace(str1) && string.IsNullOrWhiteSpace(str2)))
            {
                return true;
            }

            if (string.IsNullOrWhiteSpace(str1) || string.IsNullOrWhiteSpace(str2))
            {
                return false;
            }

            if (str1.Length != str2.Length)
            {
                return false;
            }

            //// sort method Big O(n log n)
            //return isPermutationSort(str1, str2);

            // array method
            return isPermutationArr(str1, str2);
        }

        private bool isPermutationArr(string str1, string str2)
        {
            // assume ASCII char set of 128 length

            // store str1 each char count in an array
            var charSet = new int[128];
            for (int i = 0; i < str1.Length; i++)
            {
                charSet[str1[i]]++;
            }

            for (int i = 0; i < str2.Length; i++)
            {
                charSet[str2[i]]--;
                if (charSet[str2[i]] < 0) return false;
            }
            return true;
        }

        private bool isPermutationSort(string str1, string str2)
        {
            var charArr1 = str1.ToCharArray();
            Array.Sort(charArr1);
            //str1 = string.Join("", charArr1);
            str1 = new string(charArr1);

            var charArr2 = str2.ToCharArray();
            Array.Sort(charArr2);
            //str2 = string.Join("", charArr2);
            str2 = new string(charArr2);

            return str1 == str2;
        }
    }
}
