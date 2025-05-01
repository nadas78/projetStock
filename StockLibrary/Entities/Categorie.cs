using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockLibrary.Entities
{
   public class Categorie
    {

        public int Id { get; set; }
        public string Nom { get; set; }

        // Navigation
        public virtual ICollection<Produit> Produits { get; set; }
    }
}
