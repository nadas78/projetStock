using System;

namespace StockLibrary.Entities
{
    public class Client
    {
        public int Id { get; set; }             // Clé primaire
        public string Nom{ get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
    }
}
