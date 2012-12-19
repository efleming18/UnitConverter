using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Telerik.JustMock;
using UnitConverter;

namespace UnitTests
{
    [TestFixture]
    public class ToBaseUnitAmountShould
    {
       Unit mockedUnit;
       Dictionary<string, double> toMeterRatio;

       [SetUp]
       public void SetUp()
       {
          mockedUnit = Mock.Create<Unit>();
          toMeterRatio = new Dictionary<string, double>();
       }

       [Test]
       public void ReturnSevenMetersWhenGivenSevenMeters()
       {
          toMeterRatio.Add("meter", 1);
          Mock.Arrange(() => mockedUnit.Quantity).Returns(7);
          Mock.Arrange(() => mockedUnit.Name).Returns("meter");

          var unitAdjuster = new UnitAdjuster(toMeterRatio);
          var newUnitQuantity = unitAdjuster.ToBaseUnitAmount(mockedUnit);

          Assert.AreEqual(7, newUnitQuantity);
       }

       [Test]
       public void ReturnPointZeroZeroOneMetersWhenGivenOneMilimeter()
       {
          toMeterRatio.Add("milimeter", .001);
          Mock.Arrange(() => mockedUnit.Quantity).Returns(1);
          Mock.Arrange(() => mockedUnit.Name).Returns("milimeter");

          var unitAdjuster = new UnitAdjuster(toMeterRatio);
          var newUnitQuantity = unitAdjuster.ToBaseUnitAmount(mockedUnit);

          Assert.AreEqual(.001, newUnitQuantity);
       }

       [Test]
       public void ReturnFourThousandMetersWhenGivenFourKilometers() {
          toMeterRatio.Add("kilometer", 1000);
          Mock.Arrange(() => mockedUnit.Quantity).Returns(4);
          Mock.Arrange(() => mockedUnit.Name).Returns("kilometer");

          var unitAdjuster = new UnitAdjuster(toMeterRatio);
          var newUnitQuantity = unitAdjuster.ToBaseUnitAmount(mockedUnit);

          Assert.AreEqual(4000, newUnitQuantity);
       }
    }
}
