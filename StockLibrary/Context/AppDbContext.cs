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
    public DbSet<Commande> Commandes { get; set; }
    public DbSet<LigneCommande> LignesCommande { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            // Chemin ABSOLU fixe pour test
            var dbPath = @"C:\projetStock\WinForms\bin\Debug\net8.0-windows\app.db";
            Console.WriteLine($"📂 Base de données SQLite : {dbPath}");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
    }

    // Méthode de Seed pour ajouter des données de test dans la base de données
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

        // Ajouter des lignes de commande de test si elles n'existent pas
        if (!LignesCommande.Any())
        {
            var produit1 = Produits.FirstOrDefault(p => p.Nom == "Produit A");
            var produit2 = Produits.FirstOrDefault(p => p.Nom == "Produit B");

            LignesCommande.AddRange(
                new LigneCommande
                {
                    CommandeId = 1,
                    ProduitId = produit1.Id,
                    Quantite = 2,
                    Remise = 5,
                    Prix = produit1.Prix,
                    TotalCalculé = produit1.Prix * 2 - 5
                },
                new LigneCommande
                {
                    CommandeId = 1,
                    ProduitId = produit2.Id,
                    Quantite = 1,
                    Remise = 0,
                    Prix = produit2.Prix,
                    TotalCalculé = produit2.Prix * 1
                }
            );
            SaveChanges();
        }
    }
}
