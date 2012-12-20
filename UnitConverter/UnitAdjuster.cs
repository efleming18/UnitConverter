using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitConverter
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
         return unit.Quantity * databaseAccessor.GetRatioComparedToBaseUnit(unit.Name);
      }

      public double FromBaseUnitAmount(double baseUnitQuantity, string targetUnit)
      {
         return baseUnitQuantity / databaseAccessor.GetRatioComparedToBaseUnit(targetUnit);
         
      }
   }
}
