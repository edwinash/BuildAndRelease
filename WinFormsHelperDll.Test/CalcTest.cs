using WinFormsHelperDll;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WinFormsHelperDll.Test
{
    
    
    /// <summary>
    ///This is a test class for CalcTest and is intended
    ///to contain all CalcTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CalcTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for PlusOne
        ///</summary>
        [TestMethod()]
        public void PlusOneTest()
        {
            Calc target = new Calc(); // TODO: Initialize to an appropriate value
            int first = 4; // TODO: Initialize to an appropriate value
            int expected = 5; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.PlusOne(first);
            Assert.AreEqual(expected, actual);
           // Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PlusOne
        ///</summary>
        [TestMethod()]
        public void PlusOneTestFail()
        {
            Calc target = new Calc(); // TODO: Initialize to an appropriate value
            int first = 4; // TODO: Initialize to an appropriate value
            int expected =6; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.PlusOne(first);
            Assert.AreEqual(expected, actual);
            // Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
