using Microsoft.EntityFrameworkCore;
using StockLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StockLibrary.Repositories
{
    public class CommandeRepository
    {
        private readonly AppDbContext _context;

        public CommandeRepository(AppDbContext context)
        {
            _context = context;
        }

        // Ajouter une commande
        public void AjouterCommande(Commande commande)
        {
            // Recalculer tous les totaux avant d'enregistrer
            foreach (var ligne in commande.LignesCommande)
            {
                // Calculer le total avec remise
                ligne.TotalCalculé = ligne.Prix * ligne.Quantite * (1 - ligne.Remise / 100);
            }

            _context.Commandes.Add(commande);
            _context.SaveChanges(); // Vous pouvez envisager d'utiliser SaveChangesAsync pour des opérations asynchrones
        }

        // Obtenir une commande avec ses lignes
        public Commande GetCommandeAvecDetails(int id)
        {
            return _context.Commandes
                .Include(c => c.Client)
                .Include(c => c.LignesCommande)
                    .ThenInclude(l => l.Produit)
                .FirstOrDefault(c => c.Id == id);
        }

        // Supprimer une commande
        public void SupprimerCommande(int id)
        {
            var commande = _context.Commandes
                .Include(c => c.LignesCommande)
                .FirstOrDefault(c => c.Id == id);

            if (commande != null)
            {
                _context.LignesCommande.RemoveRange(commande.LignesCommande);
                _context.Commandes.Remove(commande);
                _context.SaveChanges();
            }
        }

        // Liste des commandes
        public List<Commande> GetToutesLesCommandes()
        {
            return _context.Commandes
                .Include(c => c.Client)
                .Include(c => c.LignesCommande)
                .ToList();
        }

        // Recalculer les totaux d'une commande (si modifiée)
       
        }
    }
