using System;
using System.Text;

namespace LeetCodeProblems
{
    public class UniqueCharsString
    {
        private const int ASCIICharSetLength = 128;

        public bool Is(string str)
        {

            // input check for null empty and whitespaces
            if (string.IsNullOrWhiteSpace(str) || string.Empty == str.Trim())
            {
                return true;
            }

            str = str.Trim();

            // input is unique if only one character
            if (str.Length == 1)
            {
                return true;
            }

            // assume ASCII input. the charset has 128 chars. input is not unique chars if exceeds the limit
            if(str.Length > ASCIICharSetLength)
            {
                return false;
            }

            //// using an array
            //return isUniqueCharsArray(str);

            //// using a bit vector
            //return isUniqueCharsBitVector(str);

            // using brute force, no additional data structures
            return isUniqueCharsNoAdditionalDSBruteForce(str);

        }

        private bool isUniqueCharsNoAdditionalDSBruteForce(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool isUniqueCharsBitVector(string str)
        {
            var checker = 0;
            for (int i = 0; i < str.Length; i++)
            {
                var charVal = str[i] - 'a';
                if ((checker & (1 << charVal)) > 0)
                {
                    return false;
                }

                checker |= 1 << charVal;
            }
            return true;
        }

        private bool IsUniqueCharsArray(string str)
        {
            // using an array
            var map = new bool[ASCIICharSetLength];
            foreach (var c in str.ToCharArray())
            {
                if (map[c])
                {
                    return false;
                }
                map[c] = true;
            }
            return true;
        }
    }
}
