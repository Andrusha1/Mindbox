using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel;
using System.Security.Cryptography;

namespace Mindbox.Tests
{
    [TestClass]
    public class CalculateCircleTriangle
    {
        [TestMethod]
        public void CalculateArea_3and4and5_6return()
        {
            //arrange
            int a = 3;
            int b = 4;
            int c = 5;
            int expected = 6;

            //act
            CalculateAreas calc = new CalculateAreas();
            double actual = calc.CalculateArea(a, b, c);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateArea_5_78dot54return()
        {
            //arrange
            int a = 5;
            double expected = 78.54;

            //act
            CalculateAreas calc = new CalculateAreas();
            double actual = calc.CalculateArea(a);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateArea_7and4and8_14return()
        {
            //arrange
            int a = 7;
            int b = 4;
            int c = 8;
            double expected = 14;

            //act
            CalculateAreas calc = new CalculateAreas();
            double actual = calc.CalculateArea(a, b, c);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateArea_3_28dot27return()
        {
            //arrange
            int a = 3;
            double expected = 28.27;

            //act
            CalculateAreas calc = new CalculateAreas();
            double actual = calc.CalculateArea(a);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateArea_15and14and16_96dot56return()
        {
            //arrange
            int a = 15;
            int b = 14;
            int c = 16;
            double expected = 96.56;

            //act
            CalculateAreas calc = new CalculateAreas();
            double actual = calc.CalculateArea(a, b, c);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateArea_20and10and12_45dot6return()
        {
            //arrange
            int a = 20;
            int b = 10;
            int c = 12;
            double expected = 45.6;

            //act
            CalculateAreas calc = new CalculateAreas();
            double actual = calc.CalculateArea(a, b, c);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcualteArea_12_452dot39return()
        {
            //arrage
            int a = 12;
            double expected = 452.39;

            //act
            CalculateAreas calc = new CalculateAreas();
            double actual = calc.CalculateArea(a);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcualteArea_1_32dot14return()
        {
            //arrage
            int a = 1;
            double expected = 3.14;

            //act
            CalculateAreas calc = new CalculateAreas();
            double actual = calc.CalculateArea(a);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}