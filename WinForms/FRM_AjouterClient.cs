using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using StockLibrary.Entities;
using StockLibrary.Repositories;

namespace WinForms
{
    public partial class FRM_AjouterClient : Form
    {
        private Client? _client;

        // Constructeur pour l'ajout
        public FRM_AjouterClient()
        {
            InitializeComponent();
        }

        // Constructeur pour la modification
        public FRM_AjouterClient(Client client) : this()
        {
            _client = client;
        }

        private void FRM_AjouterClient_Load(object sender, EventArgs e)
        {
            // Ici, tu peux charger des données supplémentaires si nécessaire, par exemple des villes, des types de clients, etc.
            // Par exemple :
            // using (var context = new AppDbContext())
            // {
            //     var villes = context.Villes.ToList();
            //     comboBoxVilles.DataSource = villes;
            //     comboBoxVilles.DisplayMember = "Nom";
            //     comboBoxVilles.ValueMember = "Id";
            // }

            if (_client != null)
            {
                // Si un client existe (modification)
                NomClient.Text = _client.Nom;
                PrenomClient.Text = _client.Prenom;
                AdresseClient.Text = _client.Adresse;
                VilleClient.Text = _client.Ville;
                TelephoneClient.Text = _client.Telephone;
                EmailClient.Text = _client.Email;
            }
        }

        private void EnregistrerClient_Click(object sender, EventArgs e)
        {

        
        // Validation des champs
        string nom = NomClient.Text.Trim();
            string prenom = PrenomClient.Text.Trim();
            string adresse = AdresseClient.Text.Trim();
            string ville = VilleClient.Text.Trim();
            string telephone = TelephoneClient.Text.Trim();
            string email = EmailClient.Text.Trim();

            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) || string.IsNullOrWhiteSpace(adresse) ||
                string.IsNullOrWhiteSpace(ville) || string.IsNullOrWhiteSpace(telephone) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            // Ajout ou modification du client
            using (var context = new AppDbContext())
            {
                var repo = new ClientRepository(context);

                if (_client == null) // Ajout
                {
                    _client = new Client();
                    context.Clients.Add(_client);
                }
                else // Modification
                {
                    context.Clients.Attach(_client);
                }

                _client.Nom = nom;
                _client.Prenom = prenom;
                _client.Adresse = adresse;
                _client.Ville = ville;
                _client.Telephone = telephone;
                _client.Email = email;

                context.SaveChanges();
            }

            MessageBox.Show("Client enregistré avec succès !");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        

        
    }
}
