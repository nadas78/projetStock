using System;
using System.Windows.Forms;
using StockLibrary.Entities;
using StockLibrary.Repositories;

namespace WinForms
{
    public partial class FRM_Client : Form
    {
        public FRM_Client()
        {
            InitializeComponent();
            ChargerClients();
        }

        private void ChargerClients()
        {
            using var context = new AppDbContext();
            var repo = new ClientRepository(context);
            var listeClients = repo.GetAll().ToList();

            // Data Binding direct
            dvgclient.AutoGenerateColumns = true;
            dvgclient.DataSource = listeClients;

            // Configuration de la grille
            dvgclient.ReadOnly = true;
            dvgclient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgclient.MultiSelect = false;
            dvgclient.AllowUserToAddRows = false;
            dvgclient.AllowUserToDeleteRows = false;
        }

        private void btnajouterclient_Click(object sender, EventArgs e)
        {
            var frm = new FRM_AjouterClient();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ChargerClients();
            }
        }

        private void btnmodifierclient_Click(object sender, EventArgs e)
        {
            if (dvgclient.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un client à modifier.");
                return;
            }

            var selectedClient = dvgclient.SelectedRows[0].DataBoundItem as Client;

            if (selectedClient == null)
            {
                MessageBox.Show("Client introuvable.");
                return;
            }

            using var context = new AppDbContext();
            var repo = new ClientRepository(context);
            var client = repo.GetById(selectedClient.Id);

            var frm = new FRM_AjouterClient(client);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ChargerClients();
            }
        }

        private void btnsupprimerclient_Click(object sender, EventArgs e)
        {
            if (dvgclient.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un client à supprimer.");
                return;
            }

            var selectedClient = dvgclient.SelectedRows[0].DataBoundItem as Client;

            if (selectedClient == null)
            {
                MessageBox.Show("Client introuvable.");
                return;
            }

            var confirm = MessageBox.Show("Confirmer la suppression du client ?", "Suppression", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using var context = new AppDbContext();
                var repo = new ClientRepository(context);
                repo.Supprimer(selectedClient.Id);
                ChargerClients();
            }
        }

        private void RechercheClient_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = RechercheClient.Text.Trim().ToLower();

            using var context = new AppDbContext();
            var repo = new ClientRepository(context);
            var listeClients = repo.GetAll();

            var filtres = string.IsNullOrEmpty(searchTerm)
                ? listeClients.ToList()
                : listeClients
                    .Where(c => c.Nom.ToLower().Contains(searchTerm) || c.Prenom.ToLower().Contains(searchTerm))
                    .ToList();

            dvgclient.DataSource = filtres;
        }

        private void dvgclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
