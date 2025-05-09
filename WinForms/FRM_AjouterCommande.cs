using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using StockLibrary.Entities;

namespace WinForms
{
    public partial class FRM_AjouterCommande : Form
    {
        public Client ClientSelectionne { get; private set; }

        public FRM_AjouterCommande(Client client = null)
        {
            InitializeComponent();

            if (client != null)
            {
                ClientSelectionne = client;
                RemplirChampsClient();
            }
        }

        private void FRM_AjouterCommande_Load_1(object sender, EventArgs e)
        {
            ChargerListeProduits();

            // Abonnement à l'événement double clic
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
        }

        private void ChargerListeProduits()
        {
            using (var db = new AppDbContext())
            {
                var produits = db.Produits
                                 .Include(p => p.Categorie)
                                 .Select(p => new
                                 {
                                     p.Id,
                                     p.Nom,
                                     p.Quantite,
                                     p.Prix,
                                     p.CategorieId,
                                     Categorie = p.Categorie.Nom,
                                     p.Image
                                 })
                                 .ToList();

                dataGridView1.DataSource = produits;
            }
        }

        private void RemplirChampsClient()
        {
            if (ClientSelectionne != null)
            {
                IdClient.Text = ClientSelectionne.Id.ToString();
                textBoxnomclient.Text = ClientSelectionne.Nom;
                textBoxprenomClient.Text = ClientSelectionne.Prenom;
                textBoxtelephclient.Text = ClientSelectionne.Telephone;
                textBoxemaiclient.Text = ClientSelectionne.Email;
                textBoxAdresseclient.Text = ClientSelectionne.Adresse;
                textBoxvilleclient.Text = ClientSelectionne.Ville;
            }
            else
            {
                MessageBox.Show("ClientSelectionne est null.");
            }
        }

        private void AfficheClient_Click(object sender, EventArgs e)
        {
            using var frmListeClient = new ListeClient();

            if (frmListeClient.ShowDialog() == DialogResult.OK)
            {
                ClientSelectionne = frmListeClient.ClientSelectionne;
                RemplirChampsClient();
            }
        }

        // ✅ Méthode pour gérer le double clic sur un produit
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // ✅ Affichage des valeurs dans les TextBox correspondants
                textBoxnom.Text = row.Cells["Nom"].Value?.ToString();
                prix.Text = row.Cells["Prix"].Value?.ToString();
                Quantite.Text = row.Cells["Quantite"].Value?.ToString();
            }
        }

        private void btnEnregister_Click(object sender, EventArgs e)
        {
            // Code pour enregistrer la commande
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
        }

        private void IdClient_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
