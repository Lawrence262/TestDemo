using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryTestProject;
namespace UnitTestDemo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTest()
        {
            try
            {
                Class1 c = new Class1();
                int ans = c.Add(20, 30);
                int exp = 50;
                //Assert.AreEqual(exp, ans);
                Assert.AreNotEqual(exp, ans);
            }
            catch (UnitTestAssertException ex)
            {

                throw(ex);
            }
           
        }
    }
}
