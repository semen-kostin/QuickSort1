using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSorter;

namespace Sort.Tester
{
    [TestClass]
    public class SortTest
    {
        [TestMethod]
        public void Test3Elements()
        {
            var array = new int[] { 3, 2, 1 };
            Program.HoareSort(array);

            Assert.IsTrue(array[1] > array[0]);
            Assert.IsTrue(array[2] > array[1]);
        }

        [TestMethod]
        public void Test100Elements()
        {
            var array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 42;
            }
            Program.HoareSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(array[i], 42);
            }
        }

        [TestMethod]
        public void Test1000Elements()
        {
            var array = new int[1000];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 420;
            }
            Program.HoareSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(array[i], 420);
            }
        }

        [TestMethod]
        public void TestSortТullElements()
        {
            var array = new int[0];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 42;
            }

            Program.HoareSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(array[i], 42);
            }
        }
    }
}
