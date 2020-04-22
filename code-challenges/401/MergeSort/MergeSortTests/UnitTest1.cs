using MergeSort;
using System;
using Xunit;

namespace MergeSortTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanSortGivenArray()
        {
            int[] mixed = new int[] { 8, 4, 23, 42, 16, 15 };
            Program.MergeSort(mixed);

            Assert.Equal(new int[] { 4, 8, 15, 16, 23, 42 }, mixed);
        }

        [Fact]
        public void CanSortOddArray()
        {
            int[] five = new int[] { 8, 4, 23, 42, 16 };
            Program.MergeSort(five);

            Assert.Equal(new int[] { 4, 8, 16, 23, 42 }, five);
        }

        [Fact]
        public void CanSortDuplicates()
        {
            int[] dupes = new int[] { 8, 4, 8, 42, 16, 16 };
            Program.MergeSort(dupes);

            Assert.Equal(new int[] { 4, 8, 8, 16, 16, 42 }, dupes);
        }

        [Fact]
        public void CanSortEmptyArray()
        {
            int[] empty = new int[0];
            Program.MergeSort(empty);

            Assert.Equal(new int[0], empty);
        }

        [Fact]
        public void CanSortSingle()
        {
            int[] alone = new int[] { 8 };
            Program.MergeSort(alone);

            Assert.Equal(new int[] { 8 }, alone);
        }
    }
}
