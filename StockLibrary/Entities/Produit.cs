using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockLibrary.Entities
{
    public class Produit
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Quantite { get; set; }
        public decimal Prix { get; set; }

        // Clé étrangère
        public int CategorieId { get; set; }
        public virtual Categorie Categorie { get; set; }

        // Propriété pour stocker l'image du produit
        public byte[] Image { get; set; }
    }
}
