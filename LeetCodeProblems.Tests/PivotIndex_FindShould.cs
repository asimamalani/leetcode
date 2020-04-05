using Xunit;

namespace LeetCode.Problems.UnitTests
{
    public class PivotIndex_FindShould
    {
        private readonly PivotIndex _pivotIndex;

        public PivotIndex_FindShould()
        {
            _pivotIndex = new PivotIndex();
        }

        [Theory]
        [InlineData(null)]
        [InlineData(new int[0])]
        public void FindPivotIndex_InputNullOrZeroLength_ReturnMinus1(int[] nums)
        {
            var result = _pivotIndex.Find(nums);
            Assert.StrictEqual<int>(-1, result);
        }

        [Theory]
        [InlineData(new int[6] { 1, 7, 3, 6, 5, 6 })]
        public void FindPivotIndex_InputValid_ReturnValidIndex(int[] nums)
        {
            var result = _pivotIndex.Find(nums);
            Assert.StrictEqual<int>(3, result);
        }

        [Theory]
        [InlineData(new int[3] { 1, 2, 3 })]
        public void FindPivotIndex_InputValid_ReturnMinus1(int[] nums)
        {
            var result = _pivotIndex.Find(nums);
            Assert.StrictEqual<int>(-1, result);
        }
    }
}