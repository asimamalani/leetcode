using System;
using Xunit;

namespace LeetCodeProblems.Tests
{
    public class UniqueCharsString_IsShould
    {
        private readonly UniqueCharsString _sut;

        public UniqueCharsString_IsShould()
        {
            _sut = new UniqueCharsString();
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        [InlineData("a")]
        [InlineData("   a   ")]
        public void ReturnTrue_ForNullEmptyOneChar(string input)
        {
            Assert.True(_sut.Is(input));
        }

        [Theory]
        [InlineData("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz")]
        public void ReturnFalse_ForInputExceeds128Chars(string input)
        {
            Assert.False(_sut.Is(input));
        }

        [Theory]
        [InlineData("this")]
        public void ReturnTrue_ForUniqueStr(string input)
        {
            Assert.True(_sut.Is(input));
        }

        [Theory]
        [InlineData("thisis")]
        public void ReturnFalse_ForNonUniqueCharStr(string input)
        {
            Assert.False(_sut.Is(input));
        }
    }
}
