using System;
using Xunit;

namespace LeetCodeProblems.Tests
{
    public class URLify_DoShould
    {
        private URLify _sut;
        public URLify_DoShould()
        {
            _sut = new URLify();
        }

        [Theory]
        [InlineData("Mr John Smith    ", 13)]
        public void Input1_Return2(string input, int len)
        {
            Assert.Equal("Mr%20John%20Smith", _sut.Do(input, len));
        }
    }
}
