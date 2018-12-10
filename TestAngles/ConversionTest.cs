using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Angles;
using Angles.Converter;

namespace TestAngles
{
    [TestClass]
    public class ConversionTest
    {
        [TestMethod]
        public void TestDegreeToRadiant()
        {
            Angle degree = new Degree(90);
            double radiant = new RadiantConverter().Convert(degree);
            Assert.IsTrue(radiant > 1.5 && radiant < 1.6);

            //TestDegreeToRadiantByCasting
            Degree degree1 = new Degree(90);
            Radiant radiant1 = degree1;
            Assert.IsTrue(radiant1.Value > 1.5 && radiant1.Value < 1.6);
        }

        [TestMethod]
        public void TestRadiantToDegree()
        {
            Angle radiant = new Radiant(1.5);
            double degree = new DegreeConverter().Convert(radiant);
            Assert.IsTrue(degree > 85 && degree < 86);

            //TestRadiantToDegreeByCasting
            Radiant radiant1 = new Radiant(1.5);
            Degree degree1 = radiant1;
            Assert.IsTrue(degree1.Value > 85 && degree1.Value < 86);

        }
        
    }
}
