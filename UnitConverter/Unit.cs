using System;
using System.Linq;

namespace UnitConverter
{
   public class Unit
   {
      public string Name { get; private set; }

      public double Quantity { get; private set; }

      public Unit(double quantity, string name)
      {
         Quantity = quantity;
         Name = name;
      }
   }
}
