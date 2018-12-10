using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnglesExtended;
using AnglesExtended.Converter;

namespace TestAnglesExtended
{
    [TestClass]
    public class AdditionTest
    {
        [TestMethod]
        public void TestDegree()
        {
            Degree degree = new Degree(30);
            Degree degree1 = new Degree(30);

            Angles.Angle add = degree + degree1;
            Assert.IsTrue(add.Value == 60);
            
        }

        [TestMethod]
        public void TestRadiant()
        {
            Radiant radiant = new Radiant(1);
            Radiant radiant1 = new Radiant(0.5);

            Angles.Angle add = radiant + radiant1;

            Assert.IsTrue(add.Value == 1.5);

        }

        [TestMethod]
        public void TestGradian()
        {
            Gradian gradian = new Gradian(1);
            Gradian gradian1 = new Gradian(0.5);

            Angles.Angle  add = gradian + gradian1;

            Assert.IsTrue(add.Value == 1.5);

        }


        [TestMethod]
        public void MixedUnitTest()
        {
            Angles.Angle degree = new Degree(30);
            Angles.Angle radiant = new Radiant(1);
            Angles.Angle gradian = new Gradian(50);

            Angles.Angle result = gradian + degree + radiant;

            Assert.IsTrue(result.Value > 140 && result.Value < 141);

            //By passing converter in base units
            Angles.Angle degree1 = new Angles.Degree(30, new DegreeConverter());
            Angles.Angle radiant1 = new Radiant(1, new RadiantConverter());
            Angles.Angle gradian1 = new Gradian(50);

            Angles.Angle result1 = gradian1 + degree1 + radiant1;

            Assert.IsTrue(result1.Value > 140 && result1.Value < 141);
        }


    }
}
