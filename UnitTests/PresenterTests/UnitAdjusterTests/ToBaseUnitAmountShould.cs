using System;
using System.Linq;
using NUnit.Framework;
using Telerik.JustMock;
using Presenter.Interfaces;
using Presenter.Logic;
using Models;

namespace UnitTests.PresenterTests.UnitAdjusterTests 
{
   [TestFixture]
   public class ToBaseUnitAmountShould {
      Unit mockedUnit;
      IDatabaseAccessor mockedDatabaseAccessor;

      [SetUp]
      public void SetUp() {
         mockedUnit = Mock.Create<Unit>();
         mockedDatabaseAccessor = Mock.Create<IDatabaseAccessor>();
      }

      [Test]
      public void ReturnSevenMetersWhenGivenSevenMeters() {
         Mock.Arrange(() => mockedDatabaseAccessor.GetBaseUnitRatioFromUnitName("meter")).Returns(1);

         Mock.Arrange(() => mockedUnit.Quantity).Returns(7);
         Mock.Arrange(() => mockedUnit.Name).Returns("meter");

         var unitAdjuster = new UnitAdjuster(mockedDatabaseAccessor);
         var newUnitQuantity = unitAdjuster.ToBaseUnitAmount(mockedUnit);

         Assert.AreEqual(7, newUnitQuantity);
      }

      [Test]
      public void ReturnPointZeroZeroOneMetersWhenGivenOneMillimeter() {
         Mock.Arrange(() => mockedDatabaseAccessor.GetBaseUnitRatioFromUnitName("millimeter")).Returns(.001);

         Mock.Arrange(() => mockedUnit.Quantity).Returns(1);
         Mock.Arrange(() => mockedUnit.Name).Returns("millimeter");

         var unitAdjuster = new UnitAdjuster(mockedDatabaseAccessor);
         var newUnitQuantity = unitAdjuster.ToBaseUnitAmount(mockedUnit);

         Assert.AreEqual(.001, newUnitQuantity);
      }

      [Test]
      public void ReturnFourThousandMetersWhenGivenFourKilometers() {
         Mock.Arrange(() => mockedDatabaseAccessor.GetBaseUnitRatioFromUnitName("kilometer")).Returns(1000);

         Mock.Arrange(() => mockedUnit.Quantity).Returns(4);
         Mock.Arrange(() => mockedUnit.Name).Returns("kilometer");

         var unitAdjuster = new UnitAdjuster(mockedDatabaseAccessor);
         var newUnitQuantity = unitAdjuster.ToBaseUnitAmount(mockedUnit);

         Assert.AreEqual(4000, newUnitQuantity);
      }

      [Test]
      public void ReturnOneMeterWhenGivenOneHundredCentimeters() {
         Mock.Arrange(() => mockedDatabaseAccessor.GetBaseUnitRatioFromUnitName("centimeter")).Returns(.01);

         Mock.Arrange(() => mockedUnit.Quantity).Returns(100);
         Mock.Arrange(() => mockedUnit.Name).Returns("centimeter");

         var unitAdjuster = new UnitAdjuster(mockedDatabaseAccessor);
         var newUnitQuantity = unitAdjuster.ToBaseUnitAmount(mockedUnit);

         Assert.AreEqual(1, newUnitQuantity);
      }
   }
}