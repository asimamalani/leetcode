namespace LeetCodeProblems
{
    public class PivotIndex
    {
        public int Find(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return -1;
            }

            int totalSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                totalSum += nums[i];
            }

            int leftSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (totalSum - nums[i] - leftSum == leftSum)
                {
                    return i;
                }
                leftSum += nums[i];
            }
            return -1;
        }
    }
}
/* *****************************************************
Given an array of integers nums, write a method that returns the "pivot" index of this array.
Input: 
nums = [1, 7, 3, 6, 5, 6]
Output: 3
Explanation: 
The sum of the numbers to the left of index 3 (nums[3] = 6) is equal to the sum of numbers to the right of index 3.
Also, 3 is the first index where this occurs.

Input: 
nums = [1, 2, 3]
Output: -1
Explanation: 
There is no index that satisfies the conditions in the problem statement.
***************************************************** */
