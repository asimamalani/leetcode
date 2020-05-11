using System;
namespace LeetCodeProblems
{
    public class URLify
    {
        public string Do(string input, int len)
        {
            // one-liner
            //return input.Trim().Replace(" ", "%20");

            return urlifyInPlace(input, len);
        }

        private string urlifyInPlace(string input, int len)
        {
            // find out how many whitespaces in the input
            var whitespaceCounter = 0;
            for (int i = 0; i < len; i++)
            {
                if (char.IsWhiteSpace(input[i]))
                {
                    whitespaceCounter++;
                }
            }

            if (whitespaceCounter == 0)
            {
                return input;
            }

            var endIndex = len -1 + whitespaceCounter * 2;
            var inputChars = input.ToCharArray();

            // loop through the array backwards and URLify as needed
            for (int i = len - 1; i >= 0; i--)
            {
                if (!char.IsWhiteSpace(inputChars[i]))
                {
                    // letter except whitespace -> copy as is
                    inputChars[endIndex--] = inputChars[i];
                } else
                {
                    // whitespace replace with %20
                    inputChars[endIndex] = '0';
                    inputChars[endIndex - 1] = '2';
                    inputChars[endIndex - 2] = '%';
                    endIndex -= 3;
                }
            }

            return new string(inputChars);
        }
    }
}
