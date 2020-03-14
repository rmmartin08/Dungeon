using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WerkRoom;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Speciality testSpecial = new Speciality("Shangela");

            Assert.IsNotNull(testSpecial.Value);

        }
    }
}
