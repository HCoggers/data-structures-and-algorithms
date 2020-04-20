using InsertionSort;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanSortArray()
        {
            int[] arr1 = new int[] { 8, 4, 23, 42, 16, 15 };
            Program.InsertionSort(arr1);
            Assert.Equal(new int[] { 4, 8, 15, 16, 23, 42 }, arr1);
        }

        [Fact]
        public void CanSortSingleInt()
        {
            int[] arr2 = new int[] { 8 };
            Program.InsertionSort(arr2);
            Assert.Equal(new int[] { 8 }, arr2);
        }

        [Fact]
        public void CanSortEmpty()
        {
            int[] arr3 = new int[0];
            Program.InsertionSort(arr3);
            Assert.Equal(new int[0], arr3);
        }

        [Fact]
        public void CanSortDoubles()
        {
            int[] arr4 = new int[] { 8, 8, 14, 63, 7, 14 };
            Program.InsertionSort(arr4);
            Assert.Equal(new int[] { 7, 8, 8, 14, 14, 63 }, arr4);
        }
    }
}
