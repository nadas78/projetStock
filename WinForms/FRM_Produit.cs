using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using StockLibrary.Repositories;
using StockLibrary.Entities;

namespace WinForms
{
    public partial class FRM_Produit : Form
    {
      

        public FRM_Produit()
        {
            InitializeComponent();
            ChargerProduits();
        }

        private void ChargerProduits()
        {
            using var context = new AppDbContext();
            var repo = new ProduitRepository(context);

            dvglProduit.DataSource = repo.GetAll().Select(p => new
            {
                p.Id,
                p.Nom,
                p.Quantite,
                Categorie = p.Categorie.Nom
            }).ToList();
        }

        private void btnajouterclient_Click(object sender, EventArgs e)
        {
            var frm = new FRM_AjouterProduit();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ChargerProduits();
            }
        }

       
        }
    
}