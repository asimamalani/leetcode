using Xunit;

namespace LeetCode.Problems.UnitTests
{
    public class ValidParentheses_IsValidShould
    {
        private readonly ValidParentheses _validParenthesis;

        public ValidParentheses_IsValidShould()
        {
            _validParenthesis = new ValidParentheses();
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("    ")]
        public void IsValidParenthesis_InputNullOrWhitespace_ReturnTrue(string input)
        {
            var result = _validParenthesis.IsValid(input);

            Assert.True(result, $"{input} is a valid parenthesis expression");
        }
    }
}