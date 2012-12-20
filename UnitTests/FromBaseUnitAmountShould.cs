﻿using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Telerik.JustMock;
using UnitConverter;

namespace UnitTests
{
   [TestFixture]
   class FromBaseUnitAmountShould
   {
      DatabaseAccessor mockedDatabaseAccessor;

      [SetUp]
      public void SetUp()
      {
         mockedDatabaseAccessor = Mock.Create<DatabaseAccessor>();
      }

      [Test]
      public void ReturnFourKilometersFromFourThousandMeters() {
         Mock.Arrange(() => mockedDatabaseAccessor.GetRatioComparedToBaseUnit("kilometer")).Returns(1000);

         var unitAdjuster = new UnitAdjuster(mockedDatabaseAccessor);
         var newUnitValue = unitAdjuster.FromBaseUnitAmount(4000, "kilometer");

         Assert.AreEqual(4, newUnitValue);
      }

      [Test]
      public void ReturnSevenHundredCentimetersFromSevenMeters()
      {
         Mock.Arrange(() => mockedDatabaseAccessor.GetRatioComparedToBaseUnit("centimeter")).Returns(.01);

         var unitAdjuster = new UnitAdjuster(mockedDatabaseAccessor);
         var newUnitValue = unitAdjuster.FromBaseUnitAmount(7, "centimeter");

         Assert.AreEqual(700, newUnitValue);
      }

      [Test]
      public void ReturnPointZeroZeroTwoKilogramsFromTwoGrams()
      {
         Mock.Arrange(() => mockedDatabaseAccessor.GetRatioComparedToBaseUnit("Kilograms")).Returns(1000);
         var unitAdjuster = new UnitAdjuster(mockedDatabaseAccessor);

         var newUnitValue = unitAdjuster.FromBaseUnitAmount(2, "Kilograms");

         Assert.AreEqual(.002, newUnitValue);
      }
   }
}
