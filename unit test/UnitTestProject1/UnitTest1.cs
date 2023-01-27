using MatrixLibraryTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestMatrixProjectTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConstructor() // constructurs
        {
            MatrixLibraryTest.Matrix Transpose = new Matrix();

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
            MatrixLibraryTest.Matrix Transpose = new Matrix();

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
        public void AdditionTest()
        {
            MatrixLibraryTest.Matrix op1 = new Matrix();
            MatrixLibraryTest.Matrix op2 = new Matrix();
            MatrixLibraryTest.Matrix result;

            op1.A = 1;
            op1.B = 2;
            op1.C = 3;
            op1.D = 4;
            op1.E = 5;
            op1.F = 6;
            op1.G = 7;
            op1.H = 8;
            op1.I = 9;

            op2.A = 10;
            op2.B = 11;
            op2.C = 12;
            op2.D = 13;
            op2.E = 14;
            op2.F = 15;
            op2.G = 16;
            op2.H = 17;
            op2.I = 18;

            result = op1 + op2;

            Assert.AreEqual(result.A, 11);
            Assert.AreEqual(result.B, 13);
            Assert.AreEqual(result.C, 15);
            Assert.AreEqual(result.D, 17);
            Assert.AreEqual(result.E, 19);
            Assert.AreEqual(result.F, 21);
            Assert.AreEqual(result.G, 23);
            Assert.AreEqual(result.H, 25);
            Assert.AreEqual(result.I, 27);
        }

        [TestMethod]
        public void SubtractionTest()
        {
            MatrixLibraryTest.Matrix op1 = new Matrix();
            MatrixLibraryTest.Matrix op2 = new Matrix();
            MatrixLibraryTest.Matrix result;

            op1.A = 10;
            op1.B = 20;
            op1.C = 30;
            op1.D = 40;
            op1.E = 50;
            op1.F = 60;
            op1.G = 70;
            op1.H = 80;
            op1.I = 90;

            op2.A = 2;
            op2.B = 4;
            op2.C = 6;
            op2.D = 8;
            op2.E = 10;
            op2.F = 20;
            op2.G = 30;
            op2.H = 40;
            op2.I = 50;

            result = op1 - op2;

            Assert.AreEqual(result.A, 8);
            Assert.AreEqual(result.B, 16);
            Assert.AreEqual(result.C, 24);
            Assert.AreEqual(result.D, 32);
            Assert.AreEqual(result.E, 40);
            Assert.AreEqual(result.F, 40);
            Assert.AreEqual(result.G, 40);
            Assert.AreEqual(result.H, 40);
            Assert.AreEqual(result.I, 40);
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            MatrixLibraryTest.Matrix op1 = new Matrix();
            MatrixLibraryTest.Matrix op2 = new Matrix();
            MatrixLibraryTest.Matrix result;

            op1.A = 1;
            op1.B = 2;
            op1.C = 3;
            op1.D = 4;
            op1.E = 5;
            op1.F = 6;
            op1.G = 7;
            op1.H = 8;
            op1.I = 9;

            op2.A = 10;
            op2.B = 11;
            op2.C = 12;
            op2.D = 13;
            op2.E = 14;
            op2.F = 15;
            op2.G = 16;
            op2.H = 17;
            op2.I = 18;

            result = op1 * op2;

            Assert.AreEqual(result.A, 84);
            Assert.AreEqual(result.B, 90);
            Assert.AreEqual(result.C, 96);
            Assert.AreEqual(result.D, 201);
            Assert.AreEqual(result.E, 216);
            Assert.AreEqual(result.F, 231);
            Assert.AreEqual(result.G, 318);
            Assert.AreEqual(result.H, 342);
            Assert.AreEqual(result.I, 366);
        }
    }
}
