using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinaryClockWinforms;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void OutputsString_PositiveInput()
        {
            int input = 12;
            string expectedValue = "1100";
            BinaryConverter binaryConverter = new BinaryConverter(input);

            string actualValue = binaryConverter.StringBinaryNumber;

            Assert.AreEqual(expectedValue, actualValue, "Int not converted to binary string correctly");
        }

        [TestMethod]
        public void OutputsString_LargePositiveInput()
        {
            int input = 5555;
            string expectedValue = "1010110110011";
            BinaryConverter binaryConverter = new BinaryConverter(input);

            string actualValue = binaryConverter.StringBinaryNumber;

            Assert.AreEqual(expectedValue, actualValue, "Int not converted to binary string correctly");
        }

        [TestMethod]
        public void OutputsString_ZeroInput()
        {
            int input = 0;
            string expectedValue = "0";
            BinaryConverter binaryConverter = new BinaryConverter(input);

            string actualValue = binaryConverter.StringBinaryNumber;

            Assert.AreEqual(expectedValue, actualValue, "0 not converted to binary string correctly");
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void OutputsString_NegativeInput()
        {
            int input = -5;
            BinaryConverter binaryConverter = new BinaryConverter(input);
        }

        [TestMethod]
        public void OutputDecimal_PositiveInput()
        {
            int input = 8675309;
            int expectedValue = 8675309;
            BinaryConverter binaryConverter = new BinaryConverter(input);

            int actualValue = binaryConverter.DecimalNumber;

            Assert.AreEqual(expectedValue, actualValue, "Proper decimal number was not output");
        }

        [TestMethod]
        public void OutputDecimal_ZeroInput()
        {
            int input = 0;
            int expectedValue = 0;
            BinaryConverter binaryConverter = new BinaryConverter(input);

            int actualValue = binaryConverter.DecimalNumber;

            Assert.AreEqual(expectedValue, actualValue, "Proper decimal number was not output");
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void OutputDecimal_NegativeInput()
        {
            int input = -8675309;
            BinaryConverter binaryConverter = new BinaryConverter(input);
        }

        [TestMethod]
        public void SetDecimal_PositiveInput()
        {
            int constructorValue = 10;
            int setDecimalValue = 12;
            int expectedDecimalValue = 12;
            string expectedBinaryValue = "1100";

            BinaryConverter binaryConverter = new BinaryConverter(constructorValue);
            binaryConverter.SetDecimalNumber(setDecimalValue);

            int actualDecimalValue = binaryConverter.DecimalNumber;
            string actualBinaryValue = binaryConverter.StringBinaryNumber;

            Assert.AreEqual(expectedDecimalValue, actualDecimalValue, "Proper decimal number was not output");
            Assert.AreEqual(expectedBinaryValue, actualBinaryValue, "Proper binary string was not output");
        }

        [TestMethod]
        public void SetDecimal_ZeroInput()
        {
            int constructorValue = 10;
            int setDecimalValue = 0;
            int expectedDecimalValue = 0;
            string expectedBinaryValue = "0";

            BinaryConverter binaryConverter = new BinaryConverter(constructorValue);
            binaryConverter.SetDecimalNumber(setDecimalValue);

            int actualDecimalValue = binaryConverter.DecimalNumber;
            string actualBinaryValue = binaryConverter.StringBinaryNumber;

            Assert.AreEqual(expectedDecimalValue, actualDecimalValue, "Proper decimal number was not output");
            Assert.AreEqual(expectedBinaryValue, actualBinaryValue, "Proper binary string was not output");
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void SetDecimal_NegativeInput()
        {
            int constructorValue = 10;
            int setDecimalValue = -40;

            BinaryConverter binaryConverter = new BinaryConverter(constructorValue);
            binaryConverter.SetDecimalNumber(setDecimalValue);
        }

        //TODO: Test the bool list <ListBinaryNumber>
    }
}
