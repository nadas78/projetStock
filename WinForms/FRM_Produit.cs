using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using StockLibrary.Repositories;
using StockLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace WinForms
{
    public partial class FRM_Produit : Form
    {
        public FRM_Produit()
        {
            InitializeComponent();
            ChargerProduits();
        }

        // Correction : Rendre la méthode publique
        public void ChargerProduits()
        { 
            using var context = new AppDbContext();

            // Récupérer les produits avec la catégorie directement du contexte
            var produits = context.Produits
                .Include(p => p.Categorie) // Assure le chargement de la catégorie
                .Select(p => new
                {
                    p.Id,
                    p.Nom,
                    p.Quantite,
                    Categorie = p.Categorie.Nom
                })
                .ToList();

            dvglProduit.DataSource = produits; // Assignez les données directement au DataGridView
        }

        private void btnajouterclient_Click(object sender, EventArgs e)
        {
            var frm = new FRM_AjouterProduit();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ChargerProduits(); // Actualise après ajout
            }
        }

        private void btnsupprimerclient_Click(object sender, EventArgs e)
        {
            if (dvglProduit.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un produit.");
                return;
            }

            int produitId = Convert.ToInt32(dvglProduit.SelectedRows[0].Cells["Id"].Value); // Accès par nom

            using (var context = new AppDbContext())
            {
                var repo = new ProduitRepository(context);
                var confirm = MessageBox.Show("Confirmer la suppression ?", "Suppression", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    repo.Delete(produitId);
                    ChargerProduits(); // Actualise après suppression
                }
            }
        }
            

        private void btnmodifierclient_Click(object sender, EventArgs e)
        {
            if (dvglProduit.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un produit à modifier.");
                return;
            }

            var selectedRow = dvglProduit.SelectedRows[0];
            int produitId = Convert.ToInt32(selectedRow.Cells[0].Value); // 0 si Id est la première colonne

            using (var context = new AppDbContext())
            {
                var repo = new ProduitRepository(context);
                var produit = repo.GetById(produitId);

                if (produit == null)
                {
                    MessageBox.Show("Produit introuvable.");
                    return;
                }

                var frm = new FRM_AjouterProduit(produit); // passe le produit ici

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ChargerProduits();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text.Trim().ToLower(); // Récupérer le texte saisi et le convertir en minuscule pour éviter la casse

            if (string.IsNullOrEmpty(searchTerm))
            {
                // Si le champ de recherche est vide, on recharge toutes les catégories
                ChargerProduits();
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
                    dvglProduit.DataSource = categoriesFiltered;
                }
            }
        }

        private void btnafficheIm_Click(object sender, EventArgs e)
        {
            // Vérifie si une ligne est sélectionnée
            if (dvglProduit.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un produit", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Vérifie si la colonne "Id" existe dans le DataGridView
            if (dvglProduit.Columns.Count == 0 || dvglProduit.Columns[0].Name != "Id")
            {
                MessageBox.Show("La colonne 'Id' est introuvable dans le DataGridView.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Récupère l'ID de la ligne sélectionnée à partir de la colonne "Id" (en utilisant l'index)
            int selectedId = Convert.ToInt32(dvglProduit.SelectedRows[0].Cells[0].Value); // 0 : l'index de la colonne "Id"

            // Accède à l'objet Produit avec l'ID sélectionné
            using (var context = new AppDbContext())
            {
                var produit = context.Produits.Find(selectedId);

                if (produit?.Image == null)
                {
                    MessageBox.Show("Aucune image disponible", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                try
                {
                    // Charger l'image à partir des données binaires
                    using (MemoryStream ms = new(produit.Image))
                    {
                        Image img = Image.FromStream(ms);

                        using (Form viewer = new Form())
                        {
                            viewer.Text = $"Image du produit: {produit.Nom}";
                            viewer.Size = new Size(600, 600);
                            viewer.StartPosition = FormStartPosition.CenterScreen;

                            var pictureBox = new PictureBox
                            {
                                Dock = DockStyle.Fill,
                                SizeMode = PictureBoxSizeMode.Zoom, // Maintenir l'image en proportion
                                Image = img
                            };

                            viewer.Controls.Add(pictureBox);
                            viewer.ShowDialog(); // Afficher le formulaire
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }

}
















    


