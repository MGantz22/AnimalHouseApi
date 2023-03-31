using Microsoft.EntityFrameworkCore;

namespace AnimalHouseApi.Models
{
  public class AnimalHouseApiContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public AnimalHouseApiContext(DbContextOptions<AnimalHouseApiContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
        new Animal { AnimalId = 1, Name = "Goji", Species = "Dog", SubSpecies = "Pitbull", Age = 1 },
        new Animal { AnimalId = 2, Name = "Darryl", Species = "Dog", SubSpecies = "Australian Cattle Dog", Age = 1 },
        new Animal { AnimalId = 3, Name = "ChopSticks", Species = "Cat", SubSpecies = "Siamese", Age = 6 },
        new Animal { AnimalId = 4, Name = "FuzzyWasHe", Species = "Cat", SubSpecies = "Persian", Age = 2 },
        new Animal { AnimalId = 5, Name = "Olaf", Species = "Dog", SubSpecies = "Wolfhound", Age = 3 },
        new Animal { AnimalId = 6, Name = "Tuna", Species = "Cat", SubSpecies = "Snowshoe", Age = 3 },
        new Animal { AnimalId = 8, Name = "Shark", Species = "Dog", SubSpecies = "Pitbull", Age = 2 },
        new Animal { AnimalId = 9, Name = "Bologna", Species = "Dog", SubSpecies = "Pitbull", Age = 2 },
        new Animal { AnimalId = 10, Name = "Steeze", Species = "Cat", SubSpecies = "Abyssinian", Age = 2 }
        );
    }
  }
}