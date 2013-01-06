using System;
using System.Linq;
using Presenter.Interfaces;
using Presenter.Models;

namespace Presenter.Logic
{
   public class UnitAdjuster
   {
      private IDatabaseAccessor databaseAccessor;

      public UnitAdjuster(IDatabaseAccessor databaseAccessor)
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
