using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

using WinFormsHelperDll;

namespace WinFormsHelperDll.Test.NUnit.Test
{
    [TestFixture]
    public class NUnitCalcTest
    {
        [Test]
        public void PlusOneTest()
        {
            Calc clc = new Calc();
            Assert.AreEqual(5, clc.PlusOne(4));
        }
    }
}
