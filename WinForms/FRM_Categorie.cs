using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using StockLibrary.Context;
using StockLibrary.Entities;
using StockLibrary.Repositories;

namespace WinForms
{
    public partial class FRM_Categorie : Form
    {
        public FRM_Categorie()
        {
            InitializeComponent();
        }

        private void FRM_Categorie_Load(object sender, EventArgs e)
        {
            using var ctx = new AppDbContext();
            ctx.Database.Migrate();   // Crée les tables manquantes si nécessaire
            ctx.Seed();               // Si tu as une méthode pour pré-remplir la base
            ChargerCategories();
        }

        private void ChargerCategories()
        {
            using var context = new AppDbContext();
            var repo = new CategorieRepository(context);
            dvgcategorie.DataSource = repo.GetAll().ToList();  // Remplir le DataGridView
        }

        private void btnajoutercategorie_Click_1(object sender, EventArgs e)
        {
            var frm = new FRM_AjouterCategorie();  // Ouvrir le formulaire d'ajout
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ChargerCategories();  // Recharger les catégories si l'ajout est réussi
            }
        }

        private void BtnModifierCategorie_Click(object sender, EventArgs e)
        {
            if (dvgcategorie.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une catégorie.");
                return;
            }

            var selected = dvgcategorie.SelectedRows[0].DataBoundItem as Categorie;
            if (selected == null)
            {
                MessageBox.Show("Erreur lors de la récupération de la catégorie.");
                return;
            }

            var frm = new FRM_AjouterCategorie(selected);  // Passer la catégorie pour modification
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // Si l'utilisateur ferme le formulaire avec succès, recharger les catégories
                ChargerCategories();
            }
        }

        private void BtnSupprimerCategorie_Click_1(object sender, EventArgs e)
        {
            if (dvgcategorie.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une catégorie à supprimer.");
                return;
            }

            var selected = dvgcategorie.SelectedRows[0].DataBoundItem as Categorie;
            if (selected == null) return;

            var confirm = MessageBox.Show("Confirmer la suppression ?", "Suppression", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using var context = new AppDbContext();
                var repo = new CategorieRepository(context);
                repo.Delete(selected);  // Supprimer la catégorie de la base
                ChargerCategories();    // Recharger les catégories
            }
        }

        private void rechercheCategory_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = rechercheCategory.Text.Trim().ToLower(); // Récupérer le texte saisi et le convertir en minuscule pour éviter la casse

            if (string.IsNullOrEmpty(searchTerm))
            {
                // Si le champ de recherche est vide, on recharge toutes les catégories
                ChargerCategories();
            }
            else
            {
                // Sinon, on filtre les catégories en fonction du texte saisi
                using (var context = new AppDbContext())
                {
                    var repo = new CategorieRepository(context);
                    var categoriesFiltered = repo.GetAll()
                        .Where(c => c.Nom.ToLower().Contains(searchTerm)) // Filtrer les catégories par nom
                        .ToList();

                    // Mettre à jour le DataGridView avec les résultats filtrés
                    dvgcategorie.DataSource = categoriesFiltered;
                }
            }
        }

        private void dvgcategorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
