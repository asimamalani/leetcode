using Xunit;

namespace LeetCodeProblems.UnitTests
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
        public void InputNullOrWhitespace_ReturnTrue(string input)
        {
            var result = _validParenthesis.IsValid(input);

            Assert.True(result, $"{input} is a valid parenthesis expression");
        }

        [Theory]
        [InlineData("()")]
        [InlineData("{}")]
        [InlineData("[]")]
        [InlineData("[({[[({})]]})]")]
        public void InputValidParenthesisExpressions_ReturnTrue(string input)
        {
            var result = _validParenthesis.IsValid(input);

            Assert.True(result, $"{input} is a valid parenthesis expression");
        }

        [Theory]
        [InlineData("{")]
        [InlineData("[")]
        [InlineData("(")]
        [InlineData("}")]
        [InlineData("]")]
        [InlineData(")")]
        [InlineData("(]")]
        [InlineData("(])")]
        [InlineData("(((((((()))))))]")]
        [InlineData("( )")]
        [InlineData("( a )")]
        public void InputInvalidParnethesisExpressions_ReturnFalse(string input)
        {
            var result = _validParenthesis.IsValid(input);

            Assert.False(result, $"{input} is not a valid parenthesis expression");
        }
    }
}