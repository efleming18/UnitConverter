using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitConverter
{
   public class UnitAdjuster
   {
      private Dictionary<string, double> ToBaseUnitRatio;

      public UnitAdjuster(Dictionary<string, double> toBaseUnitRatio)
      {
         ToBaseUnitRatio = toBaseUnitRatio;
      }

      public double ToBaseUnitAmount(Unit unit) 
      {
         return unit.Quantity * ToBaseUnitRatio[unit.Name]; 
      }

      public double FromBaseUnitAmount(double baseUnitQuantity, string targetUnitName)
      {
         return baseUnitQuantity / ToBaseUnitRatio[targetUnitName];
      }
   }
}
