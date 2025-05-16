using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockLibrary.Entities
{
    using System;
    public class LigneCommande
    {
        public int Id { get; set; }

        // Clé étrangère vers Commande
        public int CommandeId { get; set; }
        public virtual Commande Commande { get; set; }

        // Clé étrangère vers Produit
        public int ProduitId { get; set; }
        public virtual Produit Produit { get; set; }

        // Quantité commandée
        public int Quantite { get; set; }

        // Remise appliquée
        public decimal Remise { get; set; }

        // ✅ Prix unitaire du produit au moment de la commande
        public decimal Prix { get; set; }

        // Total calculé de la ligne de commande (persistance)
        public decimal TotalCalculé { get; set; }

        // Total dynamique de la ligne : Prix * Quantité - Remise
        public decimal Total
        {
            get
            {
                decimal montant = Prix * Quantite;
                return montant - Remise;
            }
        }
    }
}