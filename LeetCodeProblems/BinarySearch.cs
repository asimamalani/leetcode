namespace LeetCodeProblems
{
    public class BinarySearch
    {
        // [1, 3, 6, 11, 14, 16, 18, 20, 25, 29, 50, 100, 150, 200, 201]
        // find 18
        public int Find(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return -1;
            }
            return bin_searchR(0, nums.Length - 1, target, nums);
        }

        private int bin_searchR(int low, int high, int target, int[] nums)
        {
            if (low == high)
            {
                if (nums[low] == target)
                {
                    return low;
                }
                else
                {
                    return -1;
                }
            }
            else if (low < high)
            {
                int mid = (low + high) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    return bin_searchR(mid + 1, high, target, nums);
                }
                else
                {
                    return bin_searchR(low, mid - 1, target, nums);
                }
            }
            else
            {
                return -1;
            }
        }
    }
}
/* *****************************************************
Search element in a sorted array
***************************************************** */
