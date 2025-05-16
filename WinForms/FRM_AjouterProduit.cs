using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using StockLibrary.Entities;
using StockLibrary.Repositories;

namespace WinForms
{
    public partial class FRM_AjouterProduit : Form
    {
        private Produit? _produit;
        private byte[]? _imageBytes;

        // Constructeur pour l'ajout
        public FRM_AjouterProduit()
        {
            InitializeComponent();
        }

        // Constructeur pour la modification
        public FRM_AjouterProduit(Produit produit) : this()
        {
            _produit = produit;
        }

        private void FRM_AjouterProduit_Load(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var categories = context.Categories.ToList();
                comboBoxCategorie.DataSource = categories;
                comboBoxCategorie.DisplayMember = "Nom";
                comboBoxCategorie.ValueMember = "Id";
            }

            if (_produit != null)
            {
                textNom.Text = _produit.Nom;
                textQuantite.Text = _produit.Quantite.ToString();
                textPrix.Text = _produit.Prix.ToString("F2");
                comboBoxCategorie.SelectedValue = _produit.CategorieId;

                if (_produit.Image != null)
                {
                    using (var ms = new MemoryStream(_produit.Image))
                    {
                        picture.Image = Image.FromStream(ms);
                    }
                    _imageBytes = _produit.Image;
                }
            }
        }

       

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            string nom = textNom.Text.Trim();
            string quantiteText = textQuantite.Text.Trim();
            string prixText = textPrix.Text.Trim();

            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(quantiteText) || string.IsNullOrWhiteSpace(prixText))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            if (!int.TryParse(quantiteText, out int quantite))
            {
                MessageBox.Show("La quantité doit être un nombre entier.");
                return;
            }

            if (!decimal.TryParse(prixText, out decimal prix))
            {
                MessageBox.Show("Le prix doit être un nombre décimal.");
                return;
            }

            int selectedCategorieId = (int)comboBoxCategorie.SelectedValue;

            using (var context = new AppDbContext())
            {
                var repo = new ProduitRepository(context);

                if (_produit == null) // Ajout
                {
                    _produit = new Produit();
                    context.Produits.Add(_produit);
                }
                else
                {
                    context.Produits.Attach(_produit);
                }

                _produit.Nom = nom;
                _produit.Quantite = quantite;
                _produit.Prix = prix;
                _produit.CategorieId = selectedCategorieId;
                _produit.Image = _imageBytes;

                context.SaveChanges();
            }

            MessageBox.Show("Produit enregistré avec succès !");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        
        private void picture_Click(object sender, EventArgs e)
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
