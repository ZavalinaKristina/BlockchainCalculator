using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCalc;

namespace ConsoleTest
{
    [TestClass]
    public class CalcTest
    {

        [TestMethod]
        public void TestSub()
        {
            //Arrange
            var calc = new Calc();
            var x = 10;
            var y = 5.5;

            //Act
            var result = calc.Sub(x, y);
            var result3 = calc.Segm(x, y);
            var result4 = calc.Pow(x, y);

            //Assert
            Assert.AreEqual(4.5, result);
        }

        [TestMethod]
        public void TestSum()
        {
            //Arrange
            var calc = new Calc();
            var x = 10;
            var y = 5;

            //Act
            var result = calc.Sum(x, y);

            //Assert
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void TestMult()
        {
            //Arrange
            var calc = new Calc();
            var x = 10;
            var y = 5;

            //Act
            var result = calc.Mult(x, y);

            //Assert
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void TestSegm()
        {
            //Arrange
            var calc = new Calc();
            var x = 10;
            var y = 5;

            //Act
            var result = calc.Segm(x, y);

            //Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestPow()
        {
            //Arrange
            var calc = new Calc();
            var x = 10;
            var y = 5;

            //Act
            var result = calc.Pow(x, y);

            //Assert
            Assert.AreEqual(100000, result);
        }
    }
}
