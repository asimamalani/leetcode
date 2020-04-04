using System;

namespace LeetCode.Problems
{
    public class ValidParentheses
    {
        public bool IsValid(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                return true;
            }
            while (input.Contains("()") || input.Contains("{}") || input.Contains("[]"))
            {
                input = input.Replace("()", "").Replace("{}", "").Replace("[]", "");
            }
            if (input == String.Empty)
            {
                return true;
            }
            return false;
        }
    }
}
/* *****************************************************
Valid Parentheses
Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
An input string is valid if:
Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Note that an empty string is also considered valid.
Example 1:
Input: "()"
Output: true
Example 2:
Input: "()[]{}"
Output: true
Example 3:
Input: "(]"
Output: false
Example 4:
Input: "([)]"
Output: false
Example 5:
Input: "{[]}"
Output: true 
***************************************************** */
