using Xunit;

namespace LeetCodeProblems.UnitTests
{
    public class FindNeedleInHaystack_StrStrShould
    {
        private readonly FindNeedleInHaystack _findNeedleInHaystack;

        public FindNeedleInHaystack_StrStrShould()
        {
            _findNeedleInHaystack = new FindNeedleInHaystack();
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData(null, "")]
        [InlineData("", null)]
        [InlineData("", "")]
        [InlineData("   ", "   ")]
        [InlineData("haystack", "   ")]
        [InlineData("haystack", "haystack")]
        public void InputNullOrWhitespace_Return0(string haystack, string needle)
        {
            var result = _findNeedleInHaystack.StrStr(haystack, needle);
            Assert.StrictEqual<int>(0, result);
        }

        [Theory]
        [InlineData("haystack", "s")]
        [InlineData("haystack", "st")]
        [InlineData("haystack", "sta")]
        [InlineData("haystack", "stac")]
        [InlineData("haystack", "stack")]
        public void InputValid_ReturnIndex3(string haystack, string needle)
        {
            var result = _findNeedleInHaystack.StrStr(haystack, needle);
            Assert.StrictEqual<int>(3, result);
        }

        [Theory]
        [InlineData("haystack", "a")]
        public void InputValidMultipleMatches_ReturnIndex1(string haystack, string needle)
        {
            var result = _findNeedleInHaystack.StrStr(haystack, needle);
            Assert.StrictEqual<int>(1, result);
        }

        [Theory]
        [InlineData("mississippi", "issip")]
        public void InputValid_ReturnIndex4(string haystack, string needle)
        {
            var result = _findNeedleInHaystack.StrStr(haystack, needle);
            Assert.StrictEqual<int>(4, result);
        }

        [Theory]
        [InlineData("    ", "stack")]
        [InlineData("haystack", "b")]
        [InlineData("haystack", "stack1")]
        [InlineData("haystack", "haystack1")]
        [InlineData("haystack", "aaystack")]
        [InlineData("haystack", "needle")]
        public void InputInvalidNoMatches_ReturnIndexMinus1(string haystack, string needle)
        {
            var result = _findNeedleInHaystack.StrStr(haystack, needle);
            Assert.StrictEqual<int>(-1, result);
        }
    }
}