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
    public partial class FRM_Commande : Form
    {
        public FRM_Commande()
        {
            InitializeComponent();
        }

        private void btnajouterclient_Click(object sender, EventArgs e)
        {


       
            // Crée le formulaire enfant
            var frm = new FRM_AjouterCommande();

            // Définit la taille exacte
            frm.Size = new Size(1628, 830) ; 

            // Centre l'enfant à l'écran
            frm.StartPosition = FormStartPosition.CenterScreen;

            // Masquer ce formulaire parent temporairement
            this.Hide();

            // Quand l'enfant se ferme, le parent réapparaît
            frm.FormClosed += (s, args) => this.Show();

            // Affiche le formulaire enfant
            frm.Show();
        }

    }

}




