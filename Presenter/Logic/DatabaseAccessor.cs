using System;
using System.Linq;
using Presenter.Interfaces;
using Presenter.Models;

namespace Presenter.Logic
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
