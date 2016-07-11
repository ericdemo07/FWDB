using System;
using FWDBApp.Controllers;
using NUnit.Framework;
using FWDBApp.Repository;
using System.Web.Mvc;
using FWDBApp.Models;
using System.Collections.Generic;

namespace FWDBApp.UnitTests
{
    [TestFixture]
    public class ControllerTest
    {
        [Test]
        public void TestInitiator()
        {
            Framework framework = new Framework(1, "Jquery", 265, "Open");
            List<Framework> listOfFrameworks = new List<Framework>();
            listOfFrameworks.Add(framework);
            FrameworkRepositoryFake db = new FrameworkRepositoryFake(listOfFrameworks);
            var controller = new DefaultController(db);
            var result = controller.Initiator() as ViewResult;
            Assert.IsNotNull(result);
        }

        [Test]
        public void TestIndex()
        {
            Framework framework = new Framework(1, "Jquery", 265, "Open");
            List<Framework> listOfFrameworks = new List<Framework>();
            listOfFrameworks.Add(framework);

            FrameworkRepositoryFake db = new FrameworkRepositoryFake(listOfFrameworks);
            var controller = new DefaultController(db);
            var result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
            List<Framework> resultAsList = result.Model as List<Framework>;
            Assert.AreEqual("Jquery", resultAsList[0].FrameworkName);
        }

        [Test]
        public void TestGetFrameworkDetail()
        {
            Framework framework = new Framework(1, "Jquery", 265, "Open");
            List<Framework> listOfFrameworks = new List<Framework>();
            listOfFrameworks.Add(framework);

            FrameworkRepositoryFake db = new FrameworkRepositoryFake(listOfFrameworks);
            var controller = new DefaultController(db);
            JsonResult result = controller.GetFrameworkDetail() as JsonResult;
            List<Framework> resultAsList = result.Data as List<Framework>;
            Assert.That(result.Data, Is.Not.Null, "There should be some data for the JsonResult");
            Assert.AreEqual(1, resultAsList.Count);
        }
    }
}
