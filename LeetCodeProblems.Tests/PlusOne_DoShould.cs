using Xunit;

namespace LeetCodeProblems.UnitTests
{
    public class DoShould
    {
        private readonly PlusOne _plusOne;

        public DoShould()
        {
            _plusOne = new PlusOne();
        }

        [Theory]
        [InlineData(new int[] { 1 })]
        public void Input1_Return2(int[] digits)
        {
            var result = _plusOne.Do(digits);
            Assert.Equal<int[]>(new int[] { 2 }, result);
        }

        [Theory]
        [InlineData(new int[] { 9 })]
        public void Input9_Return10(int[] digits)
        {
            var result = _plusOne.Do(digits);
            Assert.Equal<int[]>(new int[] { 1, 0 }, result);
        }

        [Theory]
        [InlineData(new int[] { 2, 8 })]
        public void Input28_Return29(int[] digits)
        {
            var result = _plusOne.Do(digits);
            Assert.Equal<int[]>(new int[] { 2, 9 }, result);
        }

        [Theory]
        [InlineData(new int[] { 9, 9 })]
        public void Input99_Return100(int[] digits)
        {
            var result = _plusOne.Do(digits);
            Assert.Equal<int[]>(new int[] { 1, 0, 0 }, result);
        }
    }
}