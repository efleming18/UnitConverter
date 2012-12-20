using System.Data.Entity;

namespace UnitConverter.Models
{
   public class UnitConverterContext : DbContext {
      public DbSet<UnitRatio> UnitRatio { get; set; }
   }
}