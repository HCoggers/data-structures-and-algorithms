using System;
using Xunit;
using QuickSort;

namespace QuickSortTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanSortGivenArray()
        {
            int[] mixed = new int[] { 8, 4, 23, 42, 16, 15 };
            Program.QuickSort(mixed, 0, mixed.Length - 1);

            Assert.Equal(new int[] { 4, 8, 15, 16, 23, 42 }, mixed);
        }

        [Fact]
        public void CanSortOddArray()
        {
            int[] five = new int[] { 8, 4, 23, 42, 16 };
            Program.QuickSort(five, 0, five.Length - 1);

            Assert.Equal(new int[] { 4, 8, 16, 23, 42 }, five);
        }

        [Fact]
        public void CanSortDuplicates()
        {
            int[] dupes = new int[] { 8, 4, 8, 42, 16, 16 };
            Program.QuickSort(dupes, 0, dupes.Length - 1);

            Assert.Equal(new int[] { 4, 8, 8, 16, 16, 42 }, dupes);
        }

        [Fact]
        public void CanSortEmptyArray()
        {
            int[] empty = new int[0];
            Program.QuickSort(empty, 0, empty.Length - 1);

            Assert.Equal(new int[0], empty);
        }

        [Fact]
        public void CanSortSingle()
        {
            int[] alone = new int[] { 8 };
            Program.QuickSort(alone, 0, alone.Length - 1);

            Assert.Equal(new int[] { 8 }, alone);
        }
    }
}
