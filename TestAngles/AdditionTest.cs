using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Angles;

namespace TestAngles
{
    [TestClass]
    public class AdditionTest
    {
        [TestMethod]
        public void TestDegree()
        {
            Angle degree = new Degree(30);
            Angle degree1 = new Degree(30);

            Angle add = degree + degree1;

            Assert.IsTrue(add.Metric == 60);
            
        }

        [TestMethod]
        public void TestRadiant()
        {
            Angle degree = new Radiant(1);
            Angle degree1 = new Radiant(0.5);

            Angle add = degree + degree1;

            Assert.IsTrue(add.Metric == 1.5);

        }

        [TestMethod]
        public void MixedUnitTest()
        {
            Angle degree = new Degree(30);
            Angle radiant = new Radiant(1);

            Angle result = degree + radiant;

        }


    }
}
