using System;
using System.Linq;
using System.Web.Mvc;
using NUnit.Framework;
using UI.Controllers;

namespace UnitTests.UI.ForHomeController
{
   [TestFixture]
   class ContactShould
   {
      [Test]
      public void ReturnTheContactView()
      {
         var homeController = new HomeController();
         ViewResult viewResult = (ViewResult)homeController.Contact();
         Assert.AreEqual("Contact", viewResult.ViewName);
      }
   }
}
