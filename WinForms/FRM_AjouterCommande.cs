using System;
using System.Windows.Forms;
using StockLibrary.Entities;

namespace WinForms
{
    public partial class FRM_AjouterCommande : Form
    {
        public Client ClientSelectionne { get; private set; }  // Propriété pour exposer le client sélectionné

        public FRM_AjouterCommande(Client client = null)
        {
            InitializeComponent();
            if (client != null)
            {
                ClientSelectionne = client;

            }
        }

        // Méthode pour remplir les informations du client dans les cases


        // Exemple de bouton pour ouvrir le formulaire ListeClient et sélectionner un client
        private void btnChoisirClient_Click(object sender, EventArgs e)
        {
            var frmListeClient = new ListeClient();
            if (frmListeClient.ShowDialog() == DialogResult.OK && frmListeClient.ClientSelectionne != null)
            {
                ClientSelectionne = frmListeClient.ClientSelectionne;

            }
        }

        private void AfficheClient_Click(object sender, EventArgs e)
        {
            var frm = new ListeClient();  // Crée un formulaire ListeClient pour sélectionner un client
            if (frm.ShowDialog() == DialogResult.OK)
            {
                 // Affiche les informations du client dans les champs
            }
        }
    }
}
