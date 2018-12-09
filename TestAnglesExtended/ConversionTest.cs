using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AnglesExtended;
using AnglesExtended.Converter;

namespace TestAnglesExtended
{
    [TestClass]
    public class ConversionTest
    {
        [TestMethod]
        public void TestDegreeToRadiant()
        {
            Degree degree = new Degree(90);
            double radiant = new RadiantConverter().Convert(degree);
            Assert.IsTrue(radiant > 1.5 && radiant < 1.6);

            //TestDegreeToRadiantByCasting
            Degree degree1 = new Degree(90);
            Radiant radiant1 = degree1;
            Assert.IsTrue(radiant1.Metric > 1.5 && radiant1.Metric < 1.6);

            //By using base degree
            Angles.Degree bDegree = new Angles.Degree(90);
            Radiant bRadiant = bDegree;
            Assert.IsTrue(bRadiant.Metric > 1.5 && bRadiant.Metric < 1.6);
        }

        [TestMethod]
        public void TestDegreeToGradian()
        {
        }

        [TestMethod]
        public void TestRadiantToDegree()
        {
            Radiant radiant = new Radiant(1.5);
            double degree = new DegreeConverter().Convert(radiant);
            Assert.IsTrue(degree > 85 && degree < 86);

            //TestRadiantToDegreeByCasting
            Radiant radiant1 = new Radiant(1.5);
            Degree degree1 = radiant1;
            Assert.IsTrue(degree1.Metric > 85 && degree1.Metric < 86);

            //By using base radiant
            Angles.Radiant bRadiant = new Angles.Radiant(1.5);
            Degree bDegree = bRadiant;
            Assert.IsTrue(bDegree.Metric > 85 && bDegree.Metric < 86);
        }

        [TestMethod]
        public void TestRadiantToGradian()
        {
        }

        [TestMethod]
        public void GradianToDegree()
        {

        }

        [TestMethod]
        public void GradianToRadiant()
        {

        }

    }
}
