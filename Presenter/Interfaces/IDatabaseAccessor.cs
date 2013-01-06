using System;
using System.Linq;

namespace Presenter.Interfaces
{
   public interface IDatabaseAccessor
   {
         double GetBaseUnitRatioFromUnitName(string unitName);
   }
}
