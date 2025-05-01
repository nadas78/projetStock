using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using StockLibrary.Entities;

namespace StockLibrary.Repositories
{
    public class ProduitRepository
    {
        private readonly AppDbContext _context;

        public ProduitRepository(AppDbContext context)
        {
            _context = context;
        }

        // Create
        public void Add(Produit produit)
        {
            _context.Produits.Add(produit);
            _context.SaveChanges();
        }

        // Read All
        public IEnumerable<Produit> GetAll()
        {
            return _context.Produits.Include(p => p.Categorie).ToList();
        }

        // Read by Id
        public Produit GetById(int id)
        {
            return _context.Produits.Include(p => p.Categorie)
                                    .FirstOrDefault(p => p.Id == id);
        }

        // Update
        public void Update(Produit produit)
        {
            var existing = _context.Produits.Find(produit.Id);
            if (existing != null)
            {
                existing.Nom = produit.Nom;
                existing.Quantite = produit.Quantite;
                existing.CategorieId = produit.CategorieId;

                if (produit.Image != null)
                    existing.Image = produit.Image;

                _context.SaveChanges();
            }
        }

        // Delete
        public void Delete(int id)
        {
            var produit = _context.Produits.Find(id);
            if (produit != null)
            {
                _context.Produits.Remove(produit);
                _context.SaveChanges();
            }
        }
    }
}