using System;
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
      Dictionary<string, double> toMeterRatio;

      [SetUp]
      public void SetUp()
      {
         toMeterRatio = new Dictionary<string, double>();
      }

      [Test]
      public void ReturnFourKilometersFromFourThousandMeters() {
         toMeterRatio.Add("kilometer", 1000);

         var unitAdjuster = new UnitAdjuster(toMeterRatio);
         var newUnitValue = unitAdjuster.FromBaseUnitAmount(4000, "kilometer");

         Assert.AreEqual(4, newUnitValue);
      }

      [Test]
      public void ReturnSevenHundredCentimetersFromSevenMeters()
      {
         toMeterRatio.Add("centimeter", .01);

         var unitAdjuster = new UnitAdjuster(toMeterRatio);
         var newUnitValue = unitAdjuster.FromBaseUnitAmount(7, "centimeter");

         Assert.AreEqual(700, newUnitValue);
      }
   }
}
