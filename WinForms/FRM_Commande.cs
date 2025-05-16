using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using StockLibrary.Entities;

namespace WinForms
{
    public partial class FRM_Commande : Form
    {
        public FRM_Commande()
        {
            InitializeComponent();
        }

        private void FRM_Commande_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            ChargerCommandes();
        }

        private void btnajouterclient_Click(object sender, EventArgs e)
        {
            var frm = new FRM_AjouterCommande();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            ChargerCommandes();
        }

        private void ConfigureDataGridView()
        {
            dvgcommande.Columns.Clear();
            dvgcommande.AutoGenerateColumns = false;
            dvgcommande.AllowUserToAddRows = false;

            dvgcommande.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "Id Commande" });
            dvgcommande.Columns.Add(new DataGridViewTextBoxColumn { Name = "Date", HeaderText = "Date Commande" });
            dvgcommande.Columns.Add(new DataGridViewTextBoxColumn { Name = "Produit", HeaderText = "Nom Produit" });
            dvgcommande.Columns.Add(new DataGridViewTextBoxColumn { Name = "Quantite", HeaderText = "Quantité" });
            dvgcommande.Columns.Add(new DataGridViewTextBoxColumn { Name = "Prix", HeaderText = "Prix Unitaire" });
            dvgcommande.Columns.Add(new DataGridViewTextBoxColumn { Name = "Remise", HeaderText = "Remise" });
            dvgcommande.Columns.Add(new DataGridViewTextBoxColumn { Name = "Total", HeaderText = "Total" });
        }

        private void ChargerCommandes()
        {
            try
            {
                using var db = new AppDbContext();
                var commandes = db.Commandes
                    .Include(c => c.LignesCommande)
                    .ThenInclude(l => l.Produit)
                    .ToList();

                dvgcommande.Rows.Clear();

                foreach (var commande in commandes)
                {
                    foreach (var ligne in commande.LignesCommande)
                    {
                        dvgcommande.Rows.Add(
                            commande.Id,
                            commande.DateCommande.ToString("dd/MM/yyyy"),
                            ligne.Produit?.Nom ?? "Inconnu",
                            ligne.Quantite,
                            ligne.Prix.ToString("F2"),
                            ligne.Remise.ToString("F2"),
                            ligne.TotalCalculé.ToString("F2")
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des commandes : " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
