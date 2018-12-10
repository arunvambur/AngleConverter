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
            Assert.IsTrue(radiant1.Value > 1.5 && radiant1.Value < 1.6);

            //By using base degree
            Angles.Degree bDegree = new Angles.Degree(90);
            Radiant bRadiant = bDegree;
            Assert.IsTrue(bRadiant.Value > 1.5 && bRadiant.Value < 1.6);
        }

        [TestMethod]
        public void TestDegreeToGradian()
        {
            Degree degree = new Degree(90);
            double gradian = new GradianConverter().Convert(degree);
            Assert.IsTrue(gradian == 100);

            //By using base degree
            Angles.Degree degree1 = new Angles.Degree(90);
            double gradian2 = new GradianConverter().Convert(degree);
            Assert.IsTrue(gradian2 == 100);
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
            Assert.IsTrue(degree1.Value > 85 && degree1.Value < 86);

            //By using base radiant
            Angles.Radiant bRadiant = new Angles.Radiant(1.5);
            Degree bDegree = bRadiant;
            Assert.IsTrue(bDegree.Value > 85 && bDegree.Value < 86);
        }

        [TestMethod]
        public void TestRadiantToGradian()
        {
        }

        [TestMethod]
        public void GradianToDegree()
        {
            Gradian gradian = new Gradian(100);
            double degree = new DegreeConverter().Convert(gradian);
            Assert.IsTrue(degree == 90);
        }

        [TestMethod]
        public void GradianToRadiant()
        {

        }

    }
}
