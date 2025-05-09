using Microsoft.EntityFrameworkCore;
using StockLibrary.Entities;
using System.IO;

public class AppDbContext : DbContext
{
    public AppDbContext() { }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Categorie> Categories { get; set; }
    public DbSet<Produit> Produits { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Commande> Commandes{ get; set; }




   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "app.db");
            Console.WriteLine($"📂 Base de données : {dbPath}");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");

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
