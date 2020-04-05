using Xunit;

namespace LeetCode.Problems.UnitTests
{
    public class DominantIndex_FindShould
    {
        private readonly DominantIndex _dominantIndex;

        public DominantIndex_FindShould()
        {
            _dominantIndex = new DominantIndex();
        }

        [Theory]
        [InlineData(null)]
        [InlineData(new int[0])]
        public void FindDominantIndex_InputNullOrZeroLength_ReturnMinus1(int[] nums)
        {
            var result = _dominantIndex.Find(nums);
            Assert.StrictEqual<int>(-1, result);
        }

        [Theory]
        [InlineData(new int[] { -1 })]
        public void FindDominantIndex_InputLengthOne_Return0(int[] nums)
        {
            var result = _dominantIndex.Find(nums);
            Assert.StrictEqual<int>(0, result);
        }

        [Theory]
        [InlineData(new int[] { 3, 6, 1, 0 })]
        public void FindDominantIndex_InputValid_Return1(int[] nums)
        {
            var result = _dominantIndex.Find(nums);
            Assert.StrictEqual<int>(1, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 })]
        public void FindDominantIndex_InputValid_ReturnMinus1(int[] nums)
        {
            var result = _dominantIndex.Find(nums);
            Assert.StrictEqual<int>(-1, result);
        }
    }
}