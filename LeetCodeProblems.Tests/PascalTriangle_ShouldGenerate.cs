using Xunit;

namespace LeetCode.Problems.UnitTests
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
        public void GeneratePascalTriangle_InputValid_ReturnArray(int numRows)
        {
            var result = _pt.Generate(numRows);
            Assert.StrictEqual(result.Count, numRows);
        }
    }
}