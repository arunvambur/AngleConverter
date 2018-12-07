using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Angles;

namespace TestAngles
{
    [TestClass]
    public class ConversionTest
    {
        [TestMethod]
        public void TestDegreeToRadiant()
        {
            Angle degree = new Degree(90);

            double radiant = degree.ToRadiant();

            Assert.IsTrue(radiant > 1.5 && radiant < 1.6);
        }

        [TestMethod]
        public void TestRadiantToDegree()
        {
            Angle radiant = new Radiant(1.5);

            double degree = radiant.ToDegree();

            Assert.IsTrue(degree > 85 && degree < 86);
        }
    }
}
