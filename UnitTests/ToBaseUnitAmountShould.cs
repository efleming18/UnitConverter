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
       DatabaseAccessor mockedDatabaseAccessor;
       Dictionary<string, double> toMeterRatio;

       [SetUp]
       public void SetUp()
       {
          mockedUnit = Mock.Create<Unit>();
          mockedDatabaseAccessor = Mock.Create<DatabaseAccessor>();
       }

       [Test]
       public void ReturnSevenMetersWhenGivenSevenMeters()
       {
          Mock.Arrange(() => mockedDatabaseAccessor.GetRatioComparedToBaseUnit("meter")).Returns(1);

          Mock.Arrange(() => mockedUnit.Quantity).Returns(7);
          Mock.Arrange(() => mockedUnit.Name).Returns("meter");

          var unitAdjuster = new UnitAdjuster(mockedDatabaseAccessor);
          var newUnitQuantity = unitAdjuster.ToBaseUnitAmount(mockedUnit);

          Assert.AreEqual(7, newUnitQuantity);
       }

       [Test]
       public void ReturnPointZeroZeroOneMetersWhenGivenOneMilimeter()
       {
          Mock.Arrange(() => mockedDatabaseAccessor.GetRatioComparedToBaseUnit("milimeter")).Returns(.001);

          Mock.Arrange(() => mockedUnit.Quantity).Returns(1);
          Mock.Arrange(() => mockedUnit.Name).Returns("milimeter");

          var unitAdjuster = new UnitAdjuster(mockedDatabaseAccessor);
          var newUnitQuantity = unitAdjuster.ToBaseUnitAmount(mockedUnit);

          Assert.AreEqual(.001, newUnitQuantity);
       }

       [Test]
       public void ReturnFourThousandMetersWhenGivenFourKilometers() 
       {
          Mock.Arrange(() => mockedDatabaseAccessor.GetRatioComparedToBaseUnit("kilometer")).Returns(1000);

          Mock.Arrange(() => mockedUnit.Quantity).Returns(4);
          Mock.Arrange(() => mockedUnit.Name).Returns("kilometer");

          var unitAdjuster = new UnitAdjuster(mockedDatabaseAccessor);
          var newUnitQuantity = unitAdjuster.ToBaseUnitAmount(mockedUnit);

          Assert.AreEqual(4000, newUnitQuantity);
       }
    }
}
