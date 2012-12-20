using System;
using System.Linq;
using UnitConverter.Models;

namespace UnitConverter.Logic
{
   public class UnitAdjuster
   {
      private DatabaseAccessor databaseAccessor;

      public UnitAdjuster(DatabaseAccessor databaseAccessor)
      {
         this.databaseAccessor = databaseAccessor;
      }

      public double ToBaseUnitAmount(Unit unit) 
      {
         return unit.Quantity * databaseAccessor.GetBaseUnitRatioFromUnitName(unit.Name);
      }

      public double FromBaseUnitAmount(double baseUnitQuantity, string targetUnitName)
      {
         return baseUnitQuantity / databaseAccessor.GetBaseUnitRatioFromUnitName(targetUnitName);
         
      }
   }
}
