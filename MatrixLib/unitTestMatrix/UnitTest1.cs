using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MatrixLib;

namespace unitTestMatrix
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PropertiesTest() // constructurs
        {
            Matrix Transpose  = new Matrix();

            Transpose.A = 10;
            Transpose.B = 20;
            Transpose.C = 30;
            Transpose.D = 40;
            Transpose.E = 50;
            Transpose.F = 60;
            Transpose.G = 100;
            Transpose.H = 200;
            Transpose.I = 500;


            Assert.AreEqual(10, Transpose.A);
            Assert.AreEqual(20, Transpose.B);
            Assert.AreEqual(30, Transpose.C);
            Assert.AreEqual(40, Transpose.D);
            Assert.AreEqual(50, Transpose.E);
            Assert.AreEqual(60, Transpose.F);
            Assert.AreEqual(100, Transpose.G);
            Assert.AreEqual(200, Transpose.H);
            Assert.AreEqual(500, Transpose.I);

        }
        [TestMethod]
        public void SetterGetterTest()
        {
            Matrix Transpose = new Matrix();

            Transpose.A = 10;
            Transpose.B = 20;
            Transpose.C = 30;
            Transpose.D = 40;
            Transpose.E = 50;
            Transpose.F = 60;
            Transpose.G = 100;
            Transpose.H = 200;
            Transpose.I = 500;

            Assert.AreEqual(10, Transpose.A);
            Assert.AreEqual(20, Transpose.B);
            Assert.AreEqual(30, Transpose.C);
            Assert.AreEqual(40, Transpose.D);
            Assert.AreEqual(50, Transpose.E);
            Assert.AreEqual(60, Transpose.F);
            Assert.AreEqual(100, Transpose.G);
            Assert.AreEqual(200, Transpose.H);
            Assert.AreEqual(500, Transpose.I);
        }




    }
}
