using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
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
                   
                    db.Seed();              // Ajouter les données de test
                }

                MessageBox.Show("? Base de données initialisée avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"? Erreur lors de l'initialisation de la base :\n\n{ex.Message}");
            }

            Application.Run(new SignIn());
        }
    }
}
