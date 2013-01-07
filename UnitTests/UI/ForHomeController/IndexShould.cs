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
      [Test]
      public void ReturnTheIndexView()
      {
         var homeController = new HomeController();
         ViewResult viewResult = (ViewResult)homeController.Index();
         Assert.AreEqual("Index", viewResult.ViewName);
      }
   }
}
