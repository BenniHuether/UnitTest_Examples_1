using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest_Examples_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_Examples_1.Tests
{
    [TestClass()]
    public class Firma_Tests
    {
        Ortschaft testOrtschaft1;
        Firma testFirma1;

        [TestInitialize]
        public void Initialize()
        {
            testOrtschaft1 = new Ortschaft(57537, "Wissen(Sieg)", null);
            testFirma1 = new Firma("Benni GmbH", "Teststraße", 1, testOrtschaft1);
        }

        [TestMethod]
        public void OveridedToString_getExpectedOutput_withoutOrtsteil()
        {
            // Arrange 
            
            string Expected = string.Format("Benni GmbH, \r\nTeststraße 1, \r\n57537 Wissen(Sieg)");

            // Act
            string Result = testFirma1.ToString();

            // Assert
            Assert.AreEqual(Expected, Result);

        }
    }
}