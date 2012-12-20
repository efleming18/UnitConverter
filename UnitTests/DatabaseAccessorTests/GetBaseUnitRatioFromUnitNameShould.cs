using System;
using System.Linq;
using NUnit.Framework;
using Telerik.JustMock;
using UnitConverter.Logic;
using UnitConverter.Models;

namespace UnitTests.DatabaseAccessorTests
{
   [TestFixture]
   class GetBaseUnitRatioFromUnitNameShould
   {
      [Test]
      public void ReturnOneThousandWhenUnitNameIsKilogram()
      {
         var mockedUnitRatio = Mock.Create<UnitRatio>();
         Mock.Arrange(() => mockedUnitRatio.Ratio).Returns(1000);

         var mockedContext = Mock.Create<UnitConverterContext>();
         Mock.Arrange(() => mockedContext.UnitRatio.Find("kilogram")).Returns(mockedUnitRatio);

         var databaseAccessor = new DatabaseAccessor(mockedContext);
         var unitRatio = databaseAccessor.GetBaseUnitRatioFromUnitName("kilogram");

         Assert.AreEqual(1000, unitRatio);
      }
   }
}
