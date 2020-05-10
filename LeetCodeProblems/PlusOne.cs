namespace LeetCodeProblems
{
    public class PlusOne
    {
        public int[] Do(int[] digits)
        {
            int carry = 1;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (carry == 0)
                {
                    break;
                }
                int sum = digits[i] + carry;
                if (sum > 9)
                {
                    digits[i] = 0;
                    carry = sum - 9;
                }
                else
                {
                    digits[i] = sum;
                    carry = 0;
                }
            }
            if (carry > 0)
            {
                digits = new int[digits.Length + 1];
                digits[0] = 1;
            }
            return digits;
        }
    }
}
/* *****************************************************
Given a non-empty array of digits representing a non-negative integer, plus one to the integer.
The digits are stored such that the most significant digit is at the head of the list, 
and each element in the array contain a single digit.
You may assume the integer does not contain any leading zero, except the number 0 itself.

Example 1:
Input: [1,2,3]
Output: [1,2,4]
Explanation: The array represents the integer 123.

Example 2:
Input: [4,3,2,1]
Output: [4,3,2,2]
Explanation: The array represents the integer 4321.

Example 3:
Input: [9,9,9]
Output: [1,0,0,0]
Explanation: The array represents the integer 999.
***************************************************** */