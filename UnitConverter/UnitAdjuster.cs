using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitConverter
{
   public class UnitAdjuster
   {
      private Dictionary<string, double> ToBaseUnitRatio;
      private DatabaseAccessor DatabaseAccessor;

      public UnitAdjuster(Dictionary<string, double> toBaseUnitRatio)
      {
         ToBaseUnitRatio = toBaseUnitRatio;
      }

      public UnitAdjuster(DatabaseAccessor databaseAccessor)
      {
         DatabaseAccessor = databaseAccessor;
      }

      public double ToBaseUnitAmount(Unit unit) 
      {
         return unit.Quantity * ToBaseUnitRatio[unit.Name]; 
      }

      public double FromBaseUnitAmount(double baseUnitQuantity, string targetUnit)
      {
         return (ToBaseUnitRatio != null) ? baseUnitQuantity / ToBaseUnitRatio[targetUnit]
                                        : baseUnitQuantity / DatabaseAccessor.GetRatioComparedToBaseUnit(targetUnit);
         
      }
   }
}
