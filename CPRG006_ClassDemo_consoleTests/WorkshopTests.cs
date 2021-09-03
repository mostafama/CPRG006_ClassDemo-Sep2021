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
    public class WorkshopTests
    {
        [TestMethod()]
        public void FixTest()
        {
            // Create the need objects
            Car c = new Car();
            // Take the action
            Workshop.Fix(c);
            // Assert the result as expected
            Assert.IsFalse(c.Broken);
        }

        [TestMethod()]
        public void FixTest_Fixing()
        {
            // Create the need objects
            Car c = new Car() { Broken = true };
            // Take the action
            Workshop.Fix(c);
            // Assert the result as expected
            Assert.IsFalse(c.Broken);
        }

        [TestMethod()]
        public void NeedFixTest()
        {
            // Create the need objects
            Car c = new Car();
            string expected = "It doesn't need fixing";
            // Take the action
            string actual = Workshop.NeedFix(c);
            // Assert the result as expected
            Assert.AreEqual(expected , actual);
        }

        [TestMethod()]
        public void NeedFixTest_NeedFix()
        {
            // Create the need objects
            Car c = new Car() { Broken = true };
            string expected = "It needs fixing";
            // Take the action
            string actual = Workshop.NeedFix(c);
            // Assert the result as expected
            Assert.AreEqual(expected, actual);
        }
    }
}