using System;
using Xunit;
using RepeatWord;

namespace RepeatWordTests
{
    public class UnitTest1
    {
        [Fact]
        public void ReturnsFirstRepeatedWord()
        {
            string book = "Red blue blue red";
            Assert.Equal("blue", Program.RepeatedWord(book));
        }

        [Fact]
        public void CanReturnNullForNoRepeats()
        {
            string book = "Two houses, both alike in dignity";
            Assert.Null(Program.RepeatedWord(book));
        }

        [Fact]
        public void CanReturnAnyCasing()
        {
            string book = "COPyCaT copYCat";
            Assert.Equal("copycat", Program.RepeatedWord(book));
        }
    }
}
