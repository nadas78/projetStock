using Microsoft.EntityFrameworkCore;
using StockLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinForms
{
    public partial class FRM_AjouterCommande : Form
    {
        public Client ClientSelectionne { get; private set; }
        public Produit ProduitSelectionne { get; private set; }

        public FRM_AjouterCommande(Client client = null)
        {
            InitializeComponent();
            Quantite.KeyPress += NumericOnly_KeyPress;
            textBoxremise.KeyPress += NumericOnly_KeyPress;
            AfficheClient.Click += AfficheClient_Click;

            if (client != null)
            {
                ClientSelectionne = client;
                RemplirChampsClient();
            }
        }

        private void FRM_AjouterCommande_Load(object sender, EventArgs e)
        {
            try
            {
                ChargerListeProduits();
                dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
                Quantite.TextChanged += Quantite_TextChanged;
                textBoxremise.TextChanged += (s, e) => CalculerTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de chargement : " + ex.Message);
            }
        }

        private void ChargerListeProduits()
        {
            using var db = new AppDbContext();
            var produits = db.Produits.Include(p => p.Categorie).ToList();
            dataGridView1.DataSource = produits;

            // Vérification explicite des colonnes avant modification
            if (dataGridView1.Columns["CategorieId"] != null)
                dataGridView1.Columns["CategorieId"].Visible = false;

            if (dataGridView1.Columns["Image"] != null)
                dataGridView1.Columns["Image"].Visible = false;

            if (dataGridView1.Columns["Categorie"] != null)
                dataGridView1.Columns["Categorie"].HeaderText = "Catégorie";

        }

        private void RemplirChampsClient()
        {
            if (ClientSelectionne == null) return;

            IdClient.Text = ClientSelectionne.Id.ToString();
            textBoxnomclient.Text = ClientSelectionne.Nom;
            textBoxprenomClient.Text = ClientSelectionne.Prenom;
            textBoxtelephclient.Text = ClientSelectionne.Telephone;
            textBoxemaiclient.Text = ClientSelectionne.Email;
            textBoxAdresseclient.Text = ClientSelectionne.Adresse;
            textBoxvilleclient.Text = ClientSelectionne.Ville;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var produit = dataGridView1.Rows[e.RowIndex].DataBoundItem as Produit;
                if (produit != null)
                {
                    ProduitSelectionne = produit;
                    textBoxnom.Text = produit.Nom;
                    prix.Text = produit.Prix.ToString("F2");

                    Quantite.Text = produit.Quantite.ToString();
                    textBoxremise.Text = "0";
                    CalculerTotal();
                }
            }
        }

        private void Quantite_TextChanged(object sender, EventArgs e)
        {
            if (ProduitSelectionne != null && int.TryParse(Quantite.Text, out int qte))
            {
                if (qte > ProduitSelectionne.Quantite)
                {
                    MessageBox.Show($"Stock insuffisant ! Disponible : {ProduitSelectionne.Quantite}");
                    Quantite.Text = ProduitSelectionne.Quantite.ToString();
                    Quantite.Focus();
                }
            }
            CalculerTotal();
        }

        private void CalculerTotal()
        {
            if (ProduitSelectionne == null) return;

            if (int.TryParse(Quantite.Text, out int quantite) &&
                decimal.TryParse(textBoxremise.Text, out decimal remise))
            {
                decimal total = ProduitSelectionne.Prix * quantite * (1 - remise / 100);
                textBoxTotal.Text = total.ToString("F2") + " €";
            }
            else
            {
                textBoxTotal.Text = "0,00 €";
            }
        }
        private bool ValiderDonnees()
        {
            if (ProduitSelectionne == null || ClientSelectionne == null)
            {
                MessageBox.Show("Sélectionnez un client et un produit");
                return false;
            }

            if (!int.TryParse(Quantite.Text, out int qte) || qte < 1)
            {
                MessageBox.Show("Quantité invalide !");
                return false;
            }

            if (!decimal.TryParse(textBoxremise.Text, out decimal remise) || remise < 0 || remise > 100)
            {
                MessageBox.Show("Remise invalide (0-100%) !");
                return false;
            }

            return true;
        }

        private void btnEnregister_Click(object sender, EventArgs e)
        {

            if (!ValiderDonnees()) return;

            using (var db = new AppDbContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        if (ProduitSelectionne == null)
                        {
                            MessageBox.Show("Produit non sélectionné !");
                            return;
                        }

                        var produit = db.Produits.Find(ProduitSelectionne.Id);
                        if (produit == null)
                        {
                            MessageBox.Show("Produit introuvable !");
                            return;
                        }

                        int quantite = int.Parse(Quantite.Text);
                        decimal remise = decimal.Parse(textBoxremise.Text);

                        if (quantite > produit.Quantite)
                        {
                            MessageBox.Show($"Stock insuffisant ! Stock actuel : {produit.Quantite}");
                            return;
                        }

                        produit.Quantite -= quantite;

                        var commande = new Commande
                        {
                            ClientId = ClientSelectionne.Id,
                            DateCommande = DateTime.Now,
                            LignesCommande = new List<LigneCommande>
                    {
                        new LigneCommande
                        {
                            ProduitId = produit.Id, // Assurez-vous que ceci est bien assigné
                            Quantite = quantite,
                            Prix = produit.Prix,
                            Remise = remise,
                            TotalCalculé = produit.Prix * quantite * (1 - remise / 100)
                        }
                    }
                        };

                        // Débogage
                        MessageBox.Show($"ProduitId: {commande.LignesCommande.First().ProduitId}, Quantité: {quantite}");

                        db.Commandes.Add(commande);
                        db.SaveChanges(); // Validation des données ici
                        transaction.Commit();

                        MessageBox.Show("Commande enregistrée avec succès !");
                        this.Close();
                    }
                    catch (DbUpdateException ex)
                    {
                        transaction.Rollback();
                        string erreur = ex.InnerException?.Message ?? ex.Message;
                        MessageBox.Show($"Erreur de base de données : {erreur}");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Erreur : {ex.Message}");
                    }
                }
            }
        }



        private void NumericOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void AfficheClient_Click(object sender, EventArgs e)
        {
            using var frm = new ListeClient();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ClientSelectionne = frm.ClientSelectionne;
                RemplirChampsClient();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}