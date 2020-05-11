using System;
using Xunit;

namespace LeetCodeProblems.Tests
{
    public class StringPermutations_AreEqualShould
    {
        private StringPermutations _sut;

        public StringPermutations_AreEqualShould()
        {
            _sut = new StringPermutations();
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData("", "")]
        [InlineData("   ", "       ")]
        public void ReturnTrue_ForNullWhitespace(string str1, string str2)
        {
            Assert.True(_sut.AreEqual(str1, str2));
        }

        [Theory]
        [InlineData(null, "a")]
        [InlineData("b", null)]
        public void ReturnFalse_ForOneNull(string str1, string str2)
        {
            Assert.False(_sut.AreEqual(str1, str2));
        }

        [Theory]
        [InlineData("helloworld", "helloworld1")]
        public void ReturnFalse_LengthMismatch(string str1, string str2)
        {
            Assert.False(_sut.AreEqual(str1, str2));
        }

        [Theory]
        [InlineData("hello", "lhoel")]
        public void ReturnTrue_ForValidPerm(string str1, string str2)
        {
            Assert.True(_sut.AreEqual(str1, str2));
        }

        [Theory]
        [InlineData("hellof", "lhoelb")]
        public void ReturnFalse_ForInvalidPerm(string str1, string str2)
        {
            Assert.False(_sut.AreEqual(str1, str2));
        }
    }
}
