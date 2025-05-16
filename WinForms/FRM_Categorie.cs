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
            ChargerCategories(); // La base est déjà migrée dans Program.cs
        }

        private void ChargerCategories()
        {
            try
            {
                using var context = new AppDbContext();
                var repo = new CategorieRepository(context);
                var categories = repo.GetAll().ToList();

                dvgcategorie.AutoGenerateColumns = true; // Active l’auto-génération des colonnes
                dvgcategorie.DataSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Erreur lors du chargement des catégories :\n\n" + ex.Message);
            }
        }

        private void btnajoutercategorie_Click_1(object sender, EventArgs e)
        {
            var frm = new FRM_AjouterCategorie();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ChargerCategories();
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

            var frm = new FRM_AjouterCategorie(selected);
            if (frm.ShowDialog() == DialogResult.OK)
            {
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
                repo.Delete(selected);
                ChargerCategories();
            }
        }

        private void rechercheCategory_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = rechercheCategory.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchTerm))
            {
                ChargerCategories();
            }
            else
            {
                using var context = new AppDbContext();
                var repo = new CategorieRepository(context);
                var filtered = repo.GetAll()
                    .Where(c => c.Nom.ToLower().Contains(searchTerm))
                    .ToList();

                dvgcategorie.AutoGenerateColumns = true;
                dvgcategorie.DataSource = filtered;
            }
        }

        private void dvgcategorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tu peux implémenter des actions ici si tu as des boutons dans les cellules
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bTNAjouter_Click(object sender, EventArgs e)
        {
            var frm = new FRM_AjouterCategorie();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ChargerCategories();
            }
        }
    }
}
