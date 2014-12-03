using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Project
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Database()
        {
            Assert.IsTrue(SKPL.ClassLibary.Database.Create.DBCreated);
        }
    }
}
