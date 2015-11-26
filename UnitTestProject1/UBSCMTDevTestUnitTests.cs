using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UBSCMTDevTest;

namespace UBSCMTDevTest.Tests
{
    [TestClass]
    public class UBSCMTDevTestUnitTests
    {
        [TestMethod]
        public void TestExample()
        {
            IWordFrequencyAnalyzer wfa = AFWordFrequencyAnalyzer.GetWordFrequencyAnalyzer();

            String input = "This is a statement, and so is this.";
            String expected = "this-2\nis-2\na-1\nstatement-1\nand-1\nso-1\n";
            String output = wfa.GetWords(input);
            Assert.IsTrue(output.Equals(expected));
        }
        
        [TestMethod]
        public void TestEmptyInput()
        {
            IWordFrequencyAnalyzer wfa = AFWordFrequencyAnalyzer.GetWordFrequencyAnalyzer();

            String input = String.Empty;
            String output = wfa.GetWords(input);
            String expected = String.Empty;
            Assert.IsTrue(output.Equals(expected));

        }
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void TestNullInput()
        {
            IWordFrequencyAnalyzer wfa = AFWordFrequencyAnalyzer.GetWordFrequencyAnalyzer();

            String input = null;
            String output = wfa.GetWords(input);

        }

    }
}
