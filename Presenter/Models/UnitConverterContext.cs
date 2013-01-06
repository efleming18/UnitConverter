using System.Data.Entity;

namespace Presenter.Models
{
   public class UnitConverterContext : DbContext {
      public DbSet<UnitRatio> UnitRatio { get; set; }
   }
}