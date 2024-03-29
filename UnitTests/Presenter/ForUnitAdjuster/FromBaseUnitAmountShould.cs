﻿using System;
using System.Linq;
using NUnit.Framework;
using Telerik.JustMock;
using Presenter.Interfaces;
using Presenter.Logic;

namespace UnitTests.Presenter.ForUnitAdjuster 
{
   [TestFixture]
   class FromBaseUnitAmountShould
   {
      IDatabaseAccessor mockedDatabaseAccessor;

      [SetUp]
      public void SetUp()
      {
         mockedDatabaseAccessor = Mock.Create<IDatabaseAccessor>();
      }

      [Test]
      public void ReturnFourKilometersFromFourThousandMeters() {
         Mock.Arrange(() => mockedDatabaseAccessor.GetBaseUnitRatioFromUnitName("kilometer")).Returns(1000);

         var unitAdjuster = new UnitAdjuster(mockedDatabaseAccessor);
         var newUnitValue = unitAdjuster.FromBaseUnitAmount(4000, "kilometer");

         Assert.AreEqual(4, newUnitValue);
      }

      [Test]
      public void ReturnSevenHundredCentimetersFromSevenMeters()
      {
         Mock.Arrange(() => mockedDatabaseAccessor.GetBaseUnitRatioFromUnitName("centimeter")).Returns(.01);

         var unitAdjuster = new UnitAdjuster(mockedDatabaseAccessor);
         var newUnitValue = unitAdjuster.FromBaseUnitAmount(7, "centimeter");

         Assert.AreEqual(700, newUnitValue);
      }

      [Test]
      public void ReturnPointZeroZeroTwoKilogramsFromTwoGrams()
      {
         Mock.Arrange(() => mockedDatabaseAccessor.GetBaseUnitRatioFromUnitName("Kilograms")).Returns(1000);
         var unitAdjuster = new UnitAdjuster(mockedDatabaseAccessor);

         var newUnitValue = unitAdjuster.FromBaseUnitAmount(2, "Kilograms");

         Assert.AreEqual(.002, newUnitValue);
      }
   }
}
