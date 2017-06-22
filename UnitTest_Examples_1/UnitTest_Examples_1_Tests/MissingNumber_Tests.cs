using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest_Examples_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static  UnitTest_Examples_1.MissingNumber;

namespace UnitTest_Examples_1.Tests
{
    [TestClass()]
    public class MissingNumberTests
    {
        [AssemblyInitialize()]
        public static void AssemblyInit(TestContext context)
        {
        }

        [TestMethod()]
        public void GetMissingNumberTest1()
        {
            // Arrange 
            int[] input = { 0, 2, 3 };
            int[] expected = { 1 };

            // Act 
            int[] result = GetMissingNumber(input);

            // Assert
            CollectionAssert.AreEqual(expected, result);

        }

        [TestMethod()]
        public void GetMissingNumberTest2()
        {
            // Arrange 
            int[] input = { 1, 3 };
            int[] expected = { 0, 2 };

            // Act 
            int[] result = GetMissingNumber(input);

            // Assert
            CollectionAssert.AreEqual(expected, result);

        }

        [TestMethod()]
        public void GetMissingNumberTest3()
        {
            // Arrange 
            int[] input = { 4, 2, 3 };
            int[] expected = { 0, 1 };

            // Act 
            int[] result = GetMissingNumber(input);

            // Assert
            CollectionAssert.AreEqual(expected, result);

        }
    }
}