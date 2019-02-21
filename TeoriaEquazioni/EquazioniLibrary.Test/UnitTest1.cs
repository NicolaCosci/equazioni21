using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsDetermined()
        {
            double a = 3;
            double b = 0;
            bool respattesa = true;
            bool resp = Equazioni.IsDetermired(a,b);
            Assert.AreEqual(respattesa, resp);
        }
        [TestMethod]
        public void TestIsDetermired1()
        { 
            double a = 0; 
            double b= 0 ;
            bool respattesa = false, resp = Equazioni.IsDetermired(a,b );
            Assert.AreEqual(respattesa, resp);
        }
        [TestMethod]
        public void TestIsDetermired2()
        {
            double a = -2;
            double b = 0;
            bool respattesa = true, resp = Equazioni.IsDetermired(a, b);
            Assert.AreEqual(respattesa, resp);
        }
        [TestMethod]
        public void TestIsDetermired3()
        {
            double a = 0;
                double b = 0;
            bool respattesa = false, resp = Equazioni.IsDetermired(a, b);
            Assert.AreEqual(respattesa, resp);
        }
    }
}
