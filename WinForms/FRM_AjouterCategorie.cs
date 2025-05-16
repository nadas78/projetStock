using System;
using System.Windows.Forms;
using StockLibrary.Context;
using StockLibrary.Entities;
using StockLibrary.Repositories;

namespace WinForms
{
    public partial class FRM_AjouterCategorie : Form
    {
        private readonly Categorie _categorie;

        // Constructeur avec option de modification
        public FRM_AjouterCategorie(Categorie categorie = null)
        {
            InitializeComponent();
            _categorie = categorie ?? new Categorie();  // Si aucune catégorie n'est fournie, créer une nouvelle
        }

        private void FRM_AjouterCategorie_Load(object sender, EventArgs e)
        {
            if (_categorie != null)
            {
                // Si c'est une modification, pré-remplir le champ avec les données de la catégorie
                NomCategorie.Text = _categorie.Nom;

                // Modifier le texte du bouton en fonction de l'action (Ajouter ou Modifier)
                btnEnregistercategorie.Text = _categorie.Id == 0 ? "Ajouter" : "Modifier";
            }
        }

        private void EnregistreCategorie_Click(object sender, EventArgs e)
        {
            string nom = NomCategorie.Text.Trim();

            if (string.IsNullOrWhiteSpace(nom))
            {
                MessageBox.Show("Veuillez entrer un nom.");
                return;
            }

            // Mettre à jour ou créer la catégorie
            _categorie.Nom = nom;

            using (var context = new AppDbContext())
            {
                var repo = new CategorieRepository(context);

                // Si la catégorie a un ID, c'est une modification, sinon c'est un ajout
                if (_categorie.Id == 0)
                {
                    repo.Add(_categorie);  // Ajouter la nouvelle catégorie
                }
                else
                {
                    repo.Update(_categorie);  // Mettre à jour la catégorie existante
                }
            }

            // Fermer le formulaire après l'enregistrement
            MessageBox.Show("Catégorie enregistrée avec succès !");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void NomCategorie_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
