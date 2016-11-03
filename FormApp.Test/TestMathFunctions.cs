using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using FormApp.DCL;

namespace FormApp.Test
{
    // Simple test class using the Visual Studio framework

    [TestClass]
    public class TestMathFunctions
    {
        [TestMethod]
        public void TestAddPositive()
        {
            int i = 10;
            int j = 20;

            int iRC = MathFunctions.Add(i, j);
            Assert.AreEqual(30, iRC);
        }
    }
}
