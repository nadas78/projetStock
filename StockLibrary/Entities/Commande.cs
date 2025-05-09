using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockLibrary.Entities
{
    public class Commande
    {
      
        
            public int Id { get; set; }

            // Identifiant du client sélectionné
            public int ClientId { get; set; }

            // Produit sélectionné
            public int ProduitId { get; set; }
            public virtual Produit Produit { get; set; }

            // Quantité que le client veut commander
            public int QuantiteCommande { get; set; }

            // Remise appliquée en valeur (ex: 10dh de réduction)
            public decimal Remise { get; set; }

            // Date de commande (affichée tout en haut)
            public DateTime DateCommande { get; set; }

            // Prix total automatiquement calculé
            public decimal Total
            {
                get
                {
                    if (Produit != null)
                    {
                        decimal montant = Produit.Prix * QuantiteCommande;
                        return montant - Remise;
                    }
                    return 0;
                }
            }

            // Méthode pour vérifier que la quantité commandée ne dépasse pas le stock
            public bool EstValide()
            {
                return Produit != null && QuantiteCommande <= Produit.Quantite;
            }
        }
    }



