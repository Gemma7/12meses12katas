using KataStringCalculator;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace KataStringCalculatorTests
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class StringCalculatorTests
    {
        private StringCalculator calculator; 
        public StringCalculatorTests()
        {
            calculator = new StringCalculator();
        }

        [TestMethod]
        public void AddTest_EmptyString()
        {
            string numberString = "";

            var result = calculator.Add(numberString);

            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void AddTest_OneNumber()
        {
            string numberString = "7";

            var result = calculator.Add(numberString);

            Assert.IsTrue(result == 7);
        }

        [TestMethod]
        public void AddTest_TwoNumbers()
        { 
            string numberString = "1,2";

            var result = calculator.Add(numberString);

            Assert.IsTrue(result == 3);
            
        }
        // There is no need to test for invalid inputs 
        //[ExpectedException(typeof(FormatException))]
        //[TestMethod]
        //public void AddTest_InvalidFormat()
        //{
        //    string numberString = "1-2";

        //    var result = calculator.Add(numberString);
        //}   
    }
}
