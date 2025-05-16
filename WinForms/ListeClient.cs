using StockLibrary.Entities;
using StockLibrary.Repositories;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WinForms
{
    public partial class ListeClient : Form
    {
        public Client ClientSelectionne { get; private set; }

        public ListeClient()
        {
            InitializeComponent();

            // ✅ Connexion explicite de l'événement double-clic
            dvgclient.CellDoubleClick += dvgclient_CellDoubleClick;

            ChargerClients();
        }

        private void ChargerClients()
        {
            using var context = new AppDbContext();
            var repo = new ClientRepository(context);
            var listeClients = repo.GetAll().ToList();

            dvgclient.AutoGenerateColumns = true;
            dvgclient.DataSource = listeClients;

            // ✅ Configuration de la DataGridView
            dvgclient.ReadOnly = true;
            dvgclient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgclient.MultiSelect = false;
            dvgclient.AllowUserToAddRows = false;
            dvgclient.AllowUserToDeleteRows = false;
        }

        private void dvgclient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dvgclient.Rows.Count)
            {
                ClientSelectionne = dvgclient.Rows[e.RowIndex].DataBoundItem as Client;

                if (ClientSelectionne != null)
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void dvgclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
