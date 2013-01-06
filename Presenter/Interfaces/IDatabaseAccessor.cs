using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Interfaces
{
   public interface IDatabaseAccessor
   {
         double GetBaseUnitRatioFromUnitName(string unitName);
   }
}
