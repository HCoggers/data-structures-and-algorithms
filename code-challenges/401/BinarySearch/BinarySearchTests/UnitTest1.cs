using System;
using Xunit;
using BinarySearch;

namespace BinarySearchTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindOneIndex()
        {
            Assert.Equal(0, Program.BinarySearch(new int[] { 1 }, 1));
        }

        [Theory]
        [InlineData(new int[] { 4, 8, 15, 16, 23, 42 }, 15, 2)]
        [InlineData(new int[] { 11, 22, 33, 44, 55, 66, 77 }, 90, -1)]
        [InlineData(new int[] { -33, -22, -1, 0, 8, 900, 901 }, -22, 1)]
        public void CanFindIndex(int[] sorted, int key, int index)
        {
            Assert.Equal(index, Program.BinarySearch(sorted, key));
        }
    }
}
