using Xunit;

namespace LeetCodeProblems.UnitTests
{
    public class InsertPosition_SearchShould
    {
        private readonly InsertPosition _insertPosition;

        public InsertPosition_SearchShould()
        {
            _insertPosition = new InsertPosition();
        }

        [Theory]
        [InlineData(null, 10)]
        [InlineData(new int[0], 100)]
        public void InputArrayNullOrEmpty_Return0(int[] nums, int target)
        {
            var result = _insertPosition.Search(nums, target);
            Assert.StrictEqual<int>(0, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 3, 5, 6, 10, 100, 120, 122, 125, 150, 1000, 1001, 2000, 5000 }, 5)]
        public void InputValid_Return2(int[] nums, int target)
        {
            var result = _insertPosition.Search(nums, target);
            Assert.StrictEqual<int>(2, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 3, 5, 6, 10, 100, 120, 122, 125, 150, 1000, 1001, 2000, 5000 }, 120)]
        public void InputValid_Return6(int[] nums, int target)
        {
            var result = _insertPosition.Search(nums, target);
            Assert.StrictEqual<int>(6, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 3, 5, 6 }, 6)]
        public void InputValidTargetLastIndex_Return3(int[] nums, int target)
        {
            var result = _insertPosition.Search(nums, target);
            Assert.StrictEqual<int>(3, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 3, 5, 6 }, 1)]
        public void InputValidTargetFirstIndex_Return0(int[] nums, int target)
        {
            var result = _insertPosition.Search(nums, target);
            Assert.StrictEqual<int>(0, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 3, 5, 6 }, 0)]
        public void InputValidTargetLeast_Return0(int[] nums, int target)
        {
            var result = _insertPosition.Search(nums, target);
            Assert.StrictEqual<int>(0, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 3, 5, 6 }, 10)]
        public void InputValidTargetMost_Return4(int[] nums, int target)
        {
            var result = _insertPosition.Search(nums, target);
            Assert.StrictEqual<int>(4, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 3, 5, 6, 10, 15, 20, 50, 70, 100 }, 12)]
        public void InputValidTargetInMiddle_Return5(int[] nums, int target)
        {
            var result = _insertPosition.Search(nums, target);
            Assert.StrictEqual<int>(5, result);
        }
    }
}