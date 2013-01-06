using System.Data.Entity;

namespace Models {
   public class UnitConverterContext : DbContext {
      public DbSet<UnitRatio> UnitRatio { get; set; }
   }
}