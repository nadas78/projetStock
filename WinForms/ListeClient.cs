using StockLibrary.Entities;
using StockLibrary.Repositories;

namespace WinForms
{
    public partial class ListeClient : Form
    {
        public Client ClientSelectionne { get; private set; }  // Propriété pour exposer le client sélectionné

        public ListeClient()
        {
            InitializeComponent();
            ChargerClients();
        }

        private void ChargerClients()
        {
            using var context = new AppDbContext();
            var repo = new ClientRepository(context);

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

        private void dvgclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var clientIdCellValue = dvgclient.Rows[e.RowIndex].Cells["Id"].Value;
                if (clientIdCellValue != null && clientIdCellValue != DBNull.Value)
                {
                    int clientId = (int)clientIdCellValue;

                    using var context = new AppDbContext();
                    var repo = new ClientRepository(context);
                    ClientSelectionne = repo.GetAll().FirstOrDefault(c => c.Id == clientId);

                    if (ClientSelectionne != null)
                    {
                        this.DialogResult = DialogResult.OK; // Indiquer que le client a été sélectionné
                        this.Close();  // Fermer le formulaire ListeClient
                    }
                    else
                    {
                        MessageBox.Show("Client non trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
