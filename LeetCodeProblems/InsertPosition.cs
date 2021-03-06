﻿namespace LeetCodeProblems
{
    public class InsertPosition
    {
        public int Search(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            int low = 0;
            int high = nums.Length - 1;
            while (low <= high)
            {
                int mid = (high + low) / 2;
                int current = nums[mid];
                if (current == target)
                {
                    return mid;
                }
                else if (current < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            // if still not found, return low since it has the index for insert
            return low;
        }
    }
}
/* *****************************************************
Search Insert Position
Given a sorted array and a target value, return the index if the target is found. 
If not, return the index where it would be if it were inserted in order.
You may assume no duplicates in the array.

Example 1:
Input: [1,3,5,6], 5
Output: 2

Example 2:
Input: [1,3,5,6], 2
Output: 1

Example 3:
Input: [1,3,5,6], 7
Output: 4

Example 4:
Input: [1,3,5,6], 0
Output: 0
***************************************************** */
