using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPRG006_ClassDemo_console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG006_ClassDemo_console.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void isOldTest()
        {
            Car c = new Car() { Year = 2020 };

            Assert.IsFalse(c.isOld());
        }

        [TestMethod()]
        public void isOldTest_Old()
        {
            Car c = new Car() { Year = (ushort)(DateTime.Now.Year - 11) };

            Assert.IsTrue(c.isOld());
        }

        [TestMethod()]
        public void CarTest()
        {
            // Arrange
            Car c;
            // Act
            c = new Car();
            ushort expectedYear = (ushort)DateTime.Now.Year;
            short expecterColor = 200;
            // Assert 
            Assert.AreEqual(expectedYear, c.Year);
            Assert.AreEqual(expecterColor, c.Color);
        }

        [TestMethod()]
        public void CarTest1()
        {
            // Arrange
            Car c;
            // Act
            c = new Car(2000, "Ford", 100);
            ushort expectedYear = 2000;
            short expectedColor = 100;
            string expectedMake = "Ford";
            // Assert 
            Assert.AreEqual(expectedYear, c.Year);
            Assert.AreEqual(expectedColor, c.Color);
            Assert.AreEqual(expectedMake, c.Make);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            // Arrange
            Car c = new Car(2000, "Ford", 100);

            // Act
            string expected = " * The car color is 100, the make is Ford, " +
                "the year is 2000, the car is Old, It doesn't need fixing";
            string actual = c.ToString();

            // Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ToStringTest_New()
        {
            // Arrange
            Car c = new Car((ushort)DateTime.Now.Year, "Ford", 100);

            // Act
            string expected = $" * The car color is 100, the make is Ford, " +
                $"the year is {DateTime.Now.Year}, the car is New, It doesn't need fixing";
            string actual = c.ToString();

            // Assert 
            Assert.AreEqual(expected, actual);
        }
    }
}