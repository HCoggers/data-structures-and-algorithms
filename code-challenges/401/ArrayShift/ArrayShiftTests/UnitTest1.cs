using System;
using Xunit;
using ArrayShift;

namespace ArrayShiftTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanLengthenArray()
        {
            int[] input = new int[5];
            int[] output = new int[6];
            Assert.Equal(output, Program.InsertShiftArray(input, 0));
        }
        [Fact]
        public void CanFindEvenCenter()
        {
            int[] input = { 4, 4, 8, 8 };
            int[] output = Program.InsertShiftArray(input, 6);
            Assert.Equal(6, output[2]);
        }
        [Fact]
        public void CanFindOddCenter()
        {
            int[] input = { 3, 5, 9 };
            int[] output = Program.InsertShiftArray(input, 7);
            Assert.Equal(7, output[2]);
        }
        [Fact]
        public void CanInsert5()
        {
            int[] input = { 1, 3, 7, 9 };
            int[] output = { 1, 3, 5, 7, 9 };
            Assert.Equal(output, Program.InsertShiftArray(input, 5));
        }
    }
}
