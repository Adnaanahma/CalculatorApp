using Calculator.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace CalculatorMigration.MigrationSpace
{
    public class CalculatorContext:DbContext
    {
        public DbSet<CalculationHistory> Calculator { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source = .; Initial Catalog=CalculatorDb;Integrated Security=True;MultipleActiveResultSets=True");
        }
    }
}    