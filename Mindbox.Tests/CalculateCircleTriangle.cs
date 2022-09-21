using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void CalculateArea_15and14and16_0return()
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
    }
}