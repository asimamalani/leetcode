using System;

namespace LeetCode.Problems
{
    public class FindNeedleInHaystack
    {
        public int StrStr(string haystack, string needle)
        {
            if (haystack == needle || (String.IsNullOrWhiteSpace(haystack) && String.IsNullOrWhiteSpace(needle)))
            {
                return 0;
            }

            if (String.IsNullOrWhiteSpace(needle))
            {
                return 0;
            }

            if (String.IsNullOrWhiteSpace(haystack))
            {
                return -1;
            }

            var haystackLength = haystack.Length;
            var needleLength = needle.Length;

            if (needleLength > haystackLength)
            {
                return -1;
            }

            if (needleLength == haystackLength && needle[0] != haystack[0])
            {
                return -1;
            }

            for (var i = 0; i < haystackLength; i++)
            {
                if (haystackLength - i < needleLength)
                {
                    return -1;
                }
                for (int j = 0, k = i; j < needleLength; j++, k++)
                {
                    if (haystack[k] != needle[j])
                    {
                        break;
                    }
                    if (j == needleLength - 1)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
    }
}
/* *****************************************************
Implement strStr().
Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
Example 1:
Input: haystack = "hello", needle = "ll"
Output: 2

Example 2:
Input: haystack = "aaaaa", needle = "bba"
Output: -1

Clarification:
Return 0 when needle is an empty string
***************************************************** */
