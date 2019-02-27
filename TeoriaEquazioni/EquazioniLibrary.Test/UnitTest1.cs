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
            bool respattesa = true, resp = Equazioni.IsDetermired(a,b );
            Assert.AreEqual(respattesa, resp);
        }
        [TestMethod]
        public void TestIsDetermired2()
        {
            double a = 4;
            double b = 3;
            bool respattesa = false, resp = Equazioni.IsDetermired(a, b);
            Assert.AreEqual(respattesa, resp);
        }
        [TestMethod]
        public void IsNotDetermired()
        {
            double a = 0;
            double b = 3;
            bool respattesa = false, resp = Equazioni.IsNotDetermired(a, b);
            Assert.AreEqual(respattesa, resp);
        }
        [TestMethod]
        public void IsNotDetermired1()
        {
            double a = 3;
            double b = 3;
            bool respattesa = false, resp = Equazioni.IsNotDetermired(a, b);
            Assert.AreEqual(respattesa, resp);
        }
        [TestMethod]
        public void IsImpossible()
        {
            double a = 0;
            double b = 3;
            bool respattesa = false, resp = Equazioni.IsImpossible(a, b);
            Assert.AreEqual(respattesa, resp);
        }
        [TestMethod]
        public void IsImpossible1()
        {
            double a = 5;
            double b = 0;
            bool respattesa = false, resp = Equazioni.IsImpossible(a, b);
            Assert.AreEqual(respattesa, resp);
        }
        [TestMethod]
        public void IsImpossible2()
        {
            double a = 0;
            double b = 0;
            bool respattesa = true, resp = Equazioni.IsImpossible(a, b);
            Assert.AreEqual(respattesa, resp);
        }
        [TestMethod]
        public void IsDegree2()
        {
            double a = 0;
            double b = 0;
            double c = 0;
            bool respattesa = true, resp = Equazioni.IsDegree2(a, b, c);
            Assert.AreEqual(respattesa, resp);
        }


    }
}
