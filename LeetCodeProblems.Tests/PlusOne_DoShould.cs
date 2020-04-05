using Xunit;

namespace LeetCode.Problems.UnitTests
{
    public class PlusOne_DoShould
    {
        private readonly PlusOne _plusOne;

        public PlusOne_DoShould()
        {
            _plusOne = new PlusOne();
        }

        [Theory]
        [InlineData(new int[] { 1 })]
        public void PlusOne_Input1_Return2(int[] digits)
        {
            var result = _plusOne.Do(digits);
            Assert.Equal<int[]>(new int[] { 2 }, result);
        }

        [Theory]
        [InlineData(new int[] { 9 })]
        public void PlusOne_Input9_Return10(int[] digits)
        {
            var result = _plusOne.Do(digits);
            Assert.Equal<int[]>(new int[] { 1, 0 }, result);
        }

        [Theory]
        [InlineData(new int[] { 2, 8 })]
        public void PlusOne_Input28_Return29(int[] digits)
        {
            var result = _plusOne.Do(digits);
            Assert.Equal<int[]>(new int[] { 2, 9 }, result);
        }

        [Theory]
        [InlineData(new int[] { 9, 9 })]
        public void PlusOne_Input99_Return100(int[] digits)
        {
            var result = _plusOne.Do(digits);
            Assert.Equal<int[]>(new int[] { 1, 0, 0 }, result);
        }
    }
}