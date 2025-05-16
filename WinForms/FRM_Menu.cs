using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class FRM_Menu : Form
    {
        public FRM_Menu()
        {
            InitializeComponent();
        }

        private void FRM_Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnclient_Click(object sender, EventArgs e)
        {


            pnlaficher.Controls.Clear(); // Nettoyer l'ancien contenu

            var frm = new FRM_Client();
            frm.TopLevel = false; // Très important !
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnlaficher.Controls.Add(frm);
            frm.Show();
        }



        private void pnlaficher_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnproduit_Click(object sender, EventArgs e)
        {
            pnlaficher.Controls.Clear(); // Nettoyer l'ancien contenu

            var frm = new FRM_Produit();
            frm.TopLevel = false; // Très important !
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnlaficher.Controls.Add(frm);
            frm.Show();
        }

        private void btncategorie_Click(object sender, EventArgs e)
        {
            pnlaficher.Controls.Clear(); // Nettoyer l'ancien contenu

            var frm = new FRM_Categorie();
            frm.TopLevel = false; // Très important !
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnlaficher.Controls.Add(frm);
            frm.Show();
        }

        private void btncommande_Click(object sender, EventArgs e)
        {
            pnlaficher.Controls.Clear(); // Nettoyer l'ancien contenu

            var frm = new FRM_Commande();
            frm.TopLevel = false; // Très important !
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnlaficher.Controls.Add(frm);
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
        
            // Ouvre la page SignIn
            SignIn signInForm = new SignIn(); // Crée une nouvelle instance de la page SignIn
            signInForm.Show(); // Affiche le formulaire SignIn

            // Facultatif : Ferme la fenêtre actuelle si tu veux que l'utilisateur n'ait qu'une seule fenêtre ouverte.
            this.Hide(); // Masque la fenêtre actuelle
        }

    }
}

