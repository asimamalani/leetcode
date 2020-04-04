using System;

namespace LeetCode.Problems
{
    public class FindNeedleInHaystack
    {
        public int StrStr(string haystack, string needle)
        {
            if (haystack == needle || String.IsNullOrWhiteSpace(haystack) || String.IsNullOrWhiteSpace(needle))
            {
                return 0;
            }

            var haystackLength = haystack.Length;
            int needleLength = needle.Length;
            var resultIndex = -1;
            
            if (needleLength > haystackLength)
            {
                return resultIndex;
            }

            if (needleLength == haystackLength && needle[0] != haystack[0])
            {
                return resultIndex;
            }

            var needleIndexCounter = 0;
            
            for (int i = 0; i < haystackLength; i++)
            {
                var haystackChar = haystack[i];

                if (needleIndexCounter < needleLength)
                {
                    if (haystackChar == needle[needleIndexCounter])
                    {
                        if (needleIndexCounter == 0)
                        {
                            if (haystackLength - i < needleLength)
                            {
                                return -1;
                            }
                            resultIndex = i;
                        }

                        needleIndexCounter++;
                    }
                    else if (needleIndexCounter > 0)
                    {
                        return -1;
                    }
                }
                else {
                    return resultIndex;
                }
            }

            return resultIndex;
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
