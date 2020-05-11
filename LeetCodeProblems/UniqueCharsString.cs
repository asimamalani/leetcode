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

            // using an array
            var map = new bool[ASCIICharSetLength];
            foreach (var c in str.ToCharArray())
            {
                if(map[c])
                {
                    return false;
                }
                map[c] = true;
            }
            return true;
        }
    }
}
