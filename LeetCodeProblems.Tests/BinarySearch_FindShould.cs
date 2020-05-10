using Xunit;

namespace LeetCodeProblems.UnitTests
{
    public class BinarySearch_FindShould
    {
        private readonly BinarySearch _binarySearch;

        public BinarySearch_FindShould()
        {
            _binarySearch = new BinarySearch();
        }

        [Theory]
        [InlineData(null, 18)]
        [InlineData(new int[] {}, 18)]
        public void NullEmptyInput_ReturnMinus1(int[] nums, int target)
        {
            var result = _binarySearch.Find(nums, target);
            Assert.StrictEqual<int>(-1, result);
        }

        [Theory]
        [InlineData(new int[] { 1 }, 18)]
        public void InputSingleItem_ReturnMinus1(int[] nums, int target)
        {
            var result = _binarySearch.Find(nums, target);
            Assert.StrictEqual<int>(-1, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 10, 20 }, 18)]
        public void ValidInput_ReturnMinus1(int[] nums, int target)
        {
            var result = _binarySearch.Find(nums, target);
            Assert.StrictEqual<int>(-1, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 3, 6, 11, 14, 16, 18, 20, 25, 29, 50, 100, 150, 200, 201 }, 18)]
        public void ValidInput_Return6(int[] nums, int target)
        {
            var result = _binarySearch.Find(nums, target);
            Assert.StrictEqual<int>(6, result);
        }
    }
}