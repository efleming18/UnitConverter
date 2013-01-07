using System;
using System.Linq;
using System.Web.Mvc;
using NUnit.Framework;
using UI.Controllers;

namespace UnitTests.UI.ForHomeController
{
   [TestFixture]
   class AboutShould
   {
      [Test]
      public void ReturnTheAboutView()
      {
         var homeController = new HomeController();
         ViewResult viewResult = (ViewResult)homeController.About();
         Assert.AreEqual("About", viewResult.ViewName);
      }
   }
}
