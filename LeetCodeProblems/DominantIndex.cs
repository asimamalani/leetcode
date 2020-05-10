namespace LeetCodeProblems
{
    public class DominantIndex
    {
        public int Find(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return -1;
            }

            if (nums.Length == 1)
            {
                return 0;
            }

            int p1, p2;

            if (nums[0] > nums[1])
            {
                p1 = 0;
                p2 = 1;
            }
            else
            {
                p1 = 1;
                p2 = 0;
            }

            for (int i = 2; i < nums.Length; i++)
            {
                if (nums[p1] <= nums[i])
                {
                    p2 = p1;
                    p1 = i;
                }
                else if (nums[p2] < nums[i])
                {
                    p2 = i;
                }
            }

            if (nums[p1] >= (nums[p2] * 2))
            {
                return p1;
            }
            return -1;
        }
    }
}
/* *****************************************************
In a given integer array nums, there is always exactly one largest element.
Find whether the largest element in the array is at least twice as much as every other number in the array.
If it is, return the index of the largest element, otherwise return -1.

Input: nums = [3, 6, 1, 0]
Output: 1
Explanation: 6 is the largest integer, and for every other number in the array x,
6 is more than twice as big as x.  The index of value 6 is 1, so we return 1.

Input: nums = [1, 2, 3, 4]
Output: -1
Explanation: 4 isn't at least as big as twice the value of 3, so we return -1.
***************************************************** */
