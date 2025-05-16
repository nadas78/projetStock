using System;
using System.Windows.Forms;

namespace WinForms
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            // Vérifier les identifiants (ici exemple simple avec des valeurs statiques)
            string utilisateur = txtutilisateur.Text;
            string motDePasse = motdepasee.Text;

            // Exemple de vérification avec des valeurs statiques
            if (utilisateur == "admin" && motDePasse == "1234")
            {
                // Si l'utilisateur et le mot de passe sont corrects, ouvrir frm_menu
                FRM_Menu menu = new FRM_Menu();
                menu.Show();
                this.Hide(); // Masquer le formulaire de connexion
            }
            else
            {
                // Afficher un message d'erreur si les identifiants sont incorrects
                MessageBox.Show("Identifiants incorrects", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
