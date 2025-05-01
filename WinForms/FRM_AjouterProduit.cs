using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using StockLibrary.Entities;

namespace WinForms
{
    public partial class FRM_AjouterProduit : Form
    {
        private byte[]? _imageBytes;
        public FRM_AjouterProduit()
        {
            InitializeComponent();
        }

        private void FRM_AjouterProduit_Load(object sender, EventArgs e)
        {
            // Charger les catégories depuis la base de données
            using (var context = new AppDbContext())
            {
                var categories = context.Categories.ToList();
                comboBoxCategorie.DataSource = categories;
                comboBoxCategorie.DisplayMember = "Nom";
                comboBoxCategorie.ValueMember = "Id";
            }
        }

        private void btnAjouterProduit_Click(object sender, EventArgs e)
        {
            // Récupérer l'identifiant de la catégorie sélectionnée
            int selectedCategorieId = (int)comboBoxCategorie.SelectedValue;

            // Créer un nouveau produit avec la catégorie sélectionnée
            var nouveauProduit = new Produit
            {
                Nom = textNom.Text, // Nom du produit à partir du TextBox
                Quantite = Convert.ToInt32(textQuantite.Text), // Quantité du produit
                CategorieId = selectedCategorieId, // ID de la catégorie
                Image = ConvertirImageEnOctets() // Conversion de l'image en tableau d'octets
            };

            // Ajouter le produit à la base de données
            using (var context = new AppDbContext())
            {
                context.Produits.Add(nouveauProduit);
                context.SaveChanges();
            }

            // Fermer le formulaire après l'ajout
            MessageBox.Show("Produit ajouté avec succès !");
            this.Close();
        }

        private byte[] ConvertirImageEnOctets()
        {
            if (picture.Image == null)
                return null;

            using (var ms = new MemoryStream())
            {
                picture.Image.Save(ms, picture.Image.RawFormat);
                return ms.ToArray();
            }
        }





        private void pictureBox_Click(object sender, EventArgs e)
        {
            {
                using (OpenFileDialog ofd = new OpenFileDialog { Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp" })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        _imageBytes = File.ReadAllBytes(ofd.FileName);
                        picture.Image = Image.FromFile(ofd.FileName);
                    }
                }

            }
        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {

        }
    }
}
