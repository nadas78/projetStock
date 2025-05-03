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

            // Charger les clients dans le DataGridView
            dvgclient.DataSource = repo.GetAll().Select(c => new
            {
                c.Id,
                c.Nom,
                c.Prenom,
                c.Adresse,
                c.Ville,
                c.Telephone,
                c.Email
            }).ToList();
        }

        private void btnajouterclient_Click(object sender, EventArgs e)
        {
            var frm = new FRM_AjouterClient(); // Crée un formulaire d'ajout de client
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ChargerClients(); // Recharger les clients après l'ajout
            }
        }

        private void btnmodifierclient_Click(object sender, EventArgs e)
        {



            if (dvgclient.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un client à modifier.");
                return;
            }

            var selectedRow = dvgclient.SelectedRows[0];
            int clientId = Convert.ToInt32(selectedRow.Cells[0].Value); // Assure-toi que la première colonne contient l'Id

            using (var context = new AppDbContext())
            {
                var repo = new ClientRepository(context);
                var client = repo.GetById(clientId);

                if (client == null)
                {
                    MessageBox.Show("Client introuvable.");
                    return;
                }

                var frm = new FRM_AjouterClient(client); // Passe le client au formulaire

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ChargerClients(); // Recharge la liste des clients après modification
                }
            }
        }

        private void btnsupprimerclient_Click(object sender, EventArgs e)
        {

            // Vérifie qu'une ligne est sélectionnée dans le DataGridView
            if (dvgclient.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un client à supprimer.");
                return;
            }

            // Récupère la première ligne sélectionnée
            var selectedRow = dvgclient.SelectedRows[0];

            // Récupère l'ID du client à partir de la première cellule (supposée contenir l'ID)
            int clientId = Convert.ToInt32(selectedRow.Cells[0].Value);

            // Ouvre une connexion à la base de données
            using (var context = new AppDbContext())
            {
                // Crée une instance du repository des clients
                var repo = new ClientRepository(context);

                // Recherche le client dans la base de données
                var client = repo.GetById(clientId);

                // Vérifie si le client existe
                if (client == null)
                {
                    MessageBox.Show("Client introuvable.");
                    return;
                }

                // Demande à l'utilisateur de confirmer la suppression
                var confirm = MessageBox.Show("Confirmer la suppression du client ?", "Suppression", MessageBoxButtons.YesNo);

                // Si l'utilisateur confirme, supprime le client
                if (confirm == DialogResult.Yes)
                {
                    repo.Supprimer(client.Id); // Supprime le client de la base
                    ChargerClients();       // Recharge la liste des clients dans le DataGridView
                }
            }
        }

        private void RechercheClient_TextChanged(object sender, EventArgs e)
        {
       
            // Récupère le texte saisi dans le champ de recherche et le met en minuscule
            string searchTerm = RechercheClient.Text.Trim().ToLower();

            // Si le champ est vide, on recharge tous les clients
            if (string.IsNullOrEmpty(searchTerm))
            {
                ChargerClients(); // Fonction qui recharge tous les clients dans le DataGridView
            }
            else
            {
                // Sinon, on filtre les clients dont le nom ou le prénom contient le texte saisi
                using (var context = new AppDbContext())
                {
                    var repo = new ClientRepository(context);

                    // Récupère tous les clients et applique le filtre
                    var clientsFiltres = repo.GetAll()
                        .Where(c => c.Nom.ToLower().Contains(searchTerm) ||
                                    c.Prenom.ToLower().Contains(searchTerm))
                        .ToList();

                    // Met à jour l'affichage avec les résultats filtrés
                    dvgclient.DataSource = clientsFiltres;
                }
            }
        }


    }
}


