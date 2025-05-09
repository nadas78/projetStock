using System;
using System.Windows.Forms;
using StockLibrary;

namespace WinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            try
            {
                using (var db = new AppDbContext())
                {
                    db.Database.EnsureDeleted();  // Supprime l'ancienne base
                    db.Database.EnsureCreated();  // Crée une nouvelle base
                    db.Seed();                    // Ajoute des données de test
                }

                MessageBox.Show("? Base créée avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"? Erreur lors de la création de la base :\n\n{ex.Message}");
            }

            Application.Run(new FRM_Commande());
        }
    }
}
