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
      [Test]
      public void ReturnFourKilometersFromFourThousandMeters() {
         var toMeterRatio = new Dictionary<string, double>();
         toMeterRatio.Add("kilometer", 1000);

         var unitAdjuster = new UnitAdjuster(toMeterRatio);
         var newUnitValue = unitAdjuster.FromBaseUnitAmount(4000, "kilometer");

         Assert.AreEqual(4, newUnitValue);
      }

      [Test]
      public void ReturnSevenHundredCentimetersFromSevenMeters()
      {
         var toMeterRatio = new Dictionary<string, double>();
         toMeterRatio.Add("centimeter", .01);

         var unitAdjuster = new UnitAdjuster(toMeterRatio);
         var newUnitValue = unitAdjuster.FromBaseUnitAmount(7, "centimeter");

         Assert.AreEqual(700, newUnitValue);
      }
   }
}
