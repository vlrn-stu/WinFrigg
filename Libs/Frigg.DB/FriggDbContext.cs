using System.Text.Json;
using Frigg.Model;
using Microsoft.EntityFrameworkCore;

namespace Frigg.DB
{
    public class FriggDbContext : DbContext
    {
        public DbSet<CTCStep> Steps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder.Entity<CTCStep>(entity =>
            {
#pragma warning disable IDE0028 // Simplify collection initialization
                _ = entity.Property(e => e.Parameters)
                    .HasConversion(
                        v => JsonSerializer.Serialize(v, (JsonSerializerOptions?)null),
                        v => JsonSerializer.Deserialize<StepParameterDictionary>(v, (JsonSerializerOptions?)null) ?? new());
#pragma warning restore IDE0028 // Simplify collection initialization
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _ = optionsBuilder.UseInMemoryDatabase("FriggDatabase");
        }
    }
}