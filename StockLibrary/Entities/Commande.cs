using System;
using System.Collections.Generic;

namespace StockLibrary.Entities
{
    public class Commande
    {
        public int Id { get; set; }

        // Identifiant du client
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        // Date de la commande
        public DateTime DateCommande { get; set; }

        // Liste des lignes de commande
        public virtual ICollection<LigneCommande> LignesCommande { get; set; }

        // Total de la commande
        public decimal Total
        {
            get
            {
                if (LignesCommande == null)
                    return 0;

                return LignesCommande.Sum(l => l.Total);
            }
        }
    }
}
