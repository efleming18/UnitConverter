using System;
using System.Linq;
using UnitConverter.Interfaces;
using UnitConverter.Models;

namespace UnitConverter.Logic
{
   public class DatabaseAccessor : IDatabaseAccessor
   {
      private UnitConverterContext database;

      public DatabaseAccessor(UnitConverterContext database)
      {
         this.database = database;
      }

      public double GetBaseUnitRatioFromUnitName(string unitName)
      {
         return database.UnitRatio.Find(unitName).Ratio;
      }
   }
}
