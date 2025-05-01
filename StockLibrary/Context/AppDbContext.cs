using Microsoft.EntityFrameworkCore;
using StockLibrary.Entities;

public class AppDbContext : DbContext
{
    public AppDbContext() { }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Categorie> Categories { get; set; }
    public DbSet<Produit> Produits { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=app.db");
        }
    }

    public void Seed()
    {
        if (!Categories.Any())
        {
            Categories.AddRange(
                new Categorie { Nom = "Électronique" },
                new Categorie { Nom = "Alimentaire" },
                new Categorie { Nom = "Vêtements" }
            );
            SaveChanges();
        }
    }
}
