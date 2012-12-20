using System;
using System.Linq;
using UnitConverter.Models;

namespace UnitConverter.Logic
{
   public class DatabaseAccessor
   {
      private UnitConverterContext database;

      public DatabaseAccessor(UnitConverterContext database)
      {
         this.database = database;
      }

      public double GetBaseUnitRatioFromUnitName(string unitName)
      {
         var unitRatio = database.UnitRatio.Find(unitName);
         return unitRatio.Ratio;
      }
   }
}
