using System;
using Xunit;

namespace MBVTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnTrueForGoodBrackets()
        {
            Assert.True(MultiBracketValidation.Program.MultiBracketValidation("{}()[]"));
        }

        [Fact]
        public void CanReturnFalseForBadBrackets()
        {
            Assert.False(MultiBracketValidation.Program.MultiBracketValidation("{[])"));
        }

        [Fact]
        public void CanReadPastNonBrackets()
        {
            Assert.True(MultiBracketValidation.Program.MultiBracketValidation("{ age = (int)7 }"));
        }

        [Fact]
        public void CanReadEmptyString()
        {
            Assert.True(MultiBracketValidation.Program.MultiBracketValidation(""));
        }

        [Fact]
        public void CanReadSingleChar()
        {
            Assert.False(MultiBracketValidation.Program.MultiBracketValidation("]"));
        }

        [Fact]
        public void CanReadZeroBracketString()
        {
            Assert.True(MultiBracketValidation.Program.MultiBracketValidation("Hello World!"));
        }
    }
}
