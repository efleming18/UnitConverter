using System;
using System.Linq;
using System.Web.Mvc;
using NUnit.Framework;
using Presenter.Interfaces;
using Telerik.JustMock;
using UI.Controllers;

namespace UnitTests.UI.ForHomeController
{
   [TestFixture]
   class ConvertUnitShould
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

      public void CallConverUnitOnConversionPresenterWithGivenArguement()
      {
         var mockedConversionPresenter = Mock.Create<IConversionPresenter>();

         homeController.ConvertUnit("Kilogram");

         Mock.Assert(() => mockedConversionPresenter.ConvertUnit("Kilogram"), Occurs.Once());
      }
   }
}