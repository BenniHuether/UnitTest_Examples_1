using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest_Examples_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UnitTest_Examples_1.SimpleSort_Class;

namespace UnitTest_Examples_1.Tests
{
    [TestClass()]
    public class SimpleSort_Class_Tests
    {
        [TestMethod()]
        public void Simple_SortTest1()
        {
            // Arrange
            string input = "cba";
            string expected = "abc";

            // Act
            char[] result = Simple_Sort(input.ToCharArray());

            // Assert
            CollectionAssert.AreEqual(expected.ToCharArray(), result);

        }

        [TestMethod]
        public void Simple_SortTest2()
        {
            // Arrange
            string input = "dgehf";
            string expected = "defgh";

            // Act
            char[] result = Simple_Sort(input.ToCharArray());

            // Assert
            CollectionAssert.AreEqual(expected.ToCharArray(), result);
        }

        [TestMethod]
        public void Simple_SortTest3()
        {
            // Arrange

            string input = "zxyw";
            string expected = "wxyz";

            // Act
            char[] result = Simple_Sort(input.ToCharArray());

            // Assert
            CollectionAssert.AreEqual(expected.ToCharArray(), result);
        }
    }
}