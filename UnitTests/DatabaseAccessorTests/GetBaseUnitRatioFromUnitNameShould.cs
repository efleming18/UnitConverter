using System;
using System.Linq;
using NUnit.Framework;
using Telerik.JustMock;
using Presenter.Logic;
using Presenter.Models;

namespace UnitTests.DatabaseAccessorTests
{
   [TestFixture]
   class GetBaseUnitRatioFromUnitNameShould
   {
      UnitRatio mockedUnitRatio;
      UnitConverterContext mockedContext;

      [SetUp]
      public void SetUp()
      {
         mockedUnitRatio = Mock.Create<UnitRatio>();
         mockedContext = Mock.Create<UnitConverterContext>();
      }

      [Test]
      public void ReturnOneThousandWhenUnitNameIsKilogram()
      {
         Mock.Arrange(() => mockedUnitRatio.Ratio).Returns(1000);
         Mock.Arrange(() => mockedContext.UnitRatio.Find("kilogram")).Returns(mockedUnitRatio);

         var databaseAccessor = new DatabaseAccessor(mockedContext);
         var unitRatio = databaseAccessor.GetBaseUnitRatioFromUnitName("kilogram");

         Assert.AreEqual(1000, unitRatio);
      }

      [Test]
      public void ReturnPointZeroOneWhenUnitNameIsCentimeter()
      {
         Mock.Arrange(() => mockedUnitRatio.Ratio).Returns(.001);
         Mock.Arrange(() => mockedContext.UnitRatio.Find("centimeter")).Returns(mockedUnitRatio);

         var databaseAccessor = new DatabaseAccessor(mockedContext);
         var unitRatio = databaseAccessor.GetBaseUnitRatioFromUnitName("centimeter");

         Assert.AreEqual(.001, unitRatio);
      }
   }
}
