namespace WinForms
{
    partial class SignIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            btnconnect = new Button();
            panel5 = new Panel();
            txtutilisateur = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            panel6 = new Panel();
            pictureBox2 = new PictureBox();
            motdepasee = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(580, 161);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 44);
            pictureBox1.TabIndex = 81;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkCyan;
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(-64, -79);
            panel3.Name = "panel3";
            panel3.Size = new Size(599, 609);
            panel3.TabIndex = 79;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(72, 138);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(502, 379);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // btnconnect
            // 
            btnconnect.BackColor = Color.DarkCyan;
            btnconnect.FlatAppearance.BorderSize = 0;
            btnconnect.FlatStyle = FlatStyle.Flat;
            btnconnect.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnconnect.ForeColor = SystemColors.ControlLightLight;
            btnconnect.Location = new Point(580, 366);
            btnconnect.Name = "btnconnect";
            btnconnect.Size = new Size(277, 43);
            btnconnect.TabIndex = 78;
            btnconnect.Text = "Se Connecter";
            btnconnect.UseVisualStyleBackColor = false;
            btnconnect.Click += btnconnect_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkCyan;
            panel5.Location = new Point(631, 204);
            panel5.Name = "panel5";
            panel5.Size = new Size(222, 1);
            panel5.TabIndex = 77;
            // 
            // txtutilisateur
            // 
            txtutilisateur.BackColor = Color.White;
            txtutilisateur.BorderStyle = BorderStyle.None;
            txtutilisateur.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtutilisateur.ForeColor = Color.Black;
            txtutilisateur.Location = new Point(643, 171);
            txtutilisateur.Name = "txtutilisateur";
            txtutilisateur.PlaceholderText = "Nom d'utilisateur";
            txtutilisateur.Size = new Size(222, 27);
            txtutilisateur.TabIndex = 76;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(631, 34);
            label1.Name = "label1";
            label1.Size = new Size(188, 41);
            label1.TabIndex = 75;
            label1.Text = "Connexion";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkCyan;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 470);
            panel4.Name = "panel4";
            panel4.Size = new Size(873, 2);
            panel4.TabIndex = 74;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(873, 2);
            panel2.TabIndex = 72;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(873, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2, 472);
            panel1.TabIndex = 73;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkCyan;
            panel6.Location = new Point(635, 302);
            panel6.Name = "panel6";
            panel6.Size = new Size(222, 1);
            panel6.TabIndex = 80;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(580, 256);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 53);
            pictureBox2.TabIndex = 82;
            pictureBox2.TabStop = false;
            // 
            // motdepasee
            // 
            motdepasee.BackColor = Color.White;
            motdepasee.BorderStyle = BorderStyle.None;
            motdepasee.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            motdepasee.ForeColor = Color.Black;
            motdepasee.Location = new Point(639, 269);
            motdepasee.Name = "motdepasee";
            motdepasee.PlaceholderText = "Mot de passe";
            motdepasee.Size = new Size(222, 27);
            motdepasee.TabIndex = 83;
            motdepasee.UseSystemPasswordChar = true;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 472);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(motdepasee);
            Controls.Add(btnconnect);
            Controls.Add(panel5);
            Controls.Add(txtutilisateur);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignIn";
            Text = "SignIn";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Button btnconnect;
        private Panel panel5;
        private TextBox txtutilisateur;
        private Label label1;
        private Panel panel4;
        private Panel panel2;
        private Panel panel1;
        private Panel panel6;
        private PictureBox pictureBox2;
        private TextBox motdepasee;
    }
}