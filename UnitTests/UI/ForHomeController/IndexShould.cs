using System;
using System.Linq;
using System.Web.Mvc;
using NUnit.Framework;
using UI.Controllers;

namespace UnitTests.UI.ForHomeController
{
   [TestFixture]
   class IndexShould
   {
      private HomeController homeController;
      
      [SetUp]
      public void SetUp()
      {
         homeController = new HomeController();
      }

      [Test]
      public void ReturnTheIndexView()
      {
         ViewResult viewResult = (ViewResult)homeController.Index();
         Assert.AreEqual("Index", viewResult.ViewName);
      }

      [Test]
      public void ReturnTheAboutView()
      {
         ViewResult viewResult = (ViewResult)homeController.About();
         Assert.AreEqual("About", viewResult.ViewName);
      }

      [Test]
      public void ReturnTheContactView()
      {
         ViewResult viewResult = (ViewResult)homeController.Contact();
         Assert.AreEqual("Contact", viewResult.ViewName);
      }
   }
}
