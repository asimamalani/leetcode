using Xunit;

namespace LeetCodeProblems.UnitTests
{
    public class PascalTriangle_ShouldGenerate
    {
        private readonly PascalTriangle _pt;

        public PascalTriangle_ShouldGenerate()
        {
            _pt = new PascalTriangle();
        }

        [Theory]
        [InlineData(5)]
        public void InputValid_ReturnArray(int numRows)
        {
            var result = _pt.Generate(numRows);
            Assert.StrictEqual(result.Count, numRows);
        }
    }
}