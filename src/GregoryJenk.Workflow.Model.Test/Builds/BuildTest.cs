using GregoryJenk.Workflow.Model.Builds;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace GregoryJenk.Workflow.Model.Test.Builds
{
    [TestClass]
    public class BuildTest
    {
        [TestMethod]
        public void IsVersion()
        {
            //Arrange.
            var build = new Build()
            {
                Created = DateTimeOffset.Now,
                Version = 1
            };

            //Act.
            var actualResult = build.IsVersion(1);

            //Assert.
            Assert.AreEqual(true, actualResult);
        }
    }
}