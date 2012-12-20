using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Interfaces
{
   public interface IDatabaseAccessor
   {
         double GetBaseUnitRatioFromUnitName(string unitName);
   }
}
