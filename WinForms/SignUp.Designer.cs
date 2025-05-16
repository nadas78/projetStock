namespace WinForms
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            motdepasee = new TextBox();
            button2 = new Button();
            panel5 = new Panel();
            txtutilisateur = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(584, 230);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 53);
            pictureBox2.TabIndex = 67;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(584, 161);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 44);
            pictureBox1.TabIndex = 66;
            pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkCyan;
            panel6.Location = new Point(639, 272);
            panel6.Name = "panel6";
            panel6.Size = new Size(222, 1);
            panel6.TabIndex = 65;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkCyan;
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(-60, -79);
            panel3.Name = "panel3";
            panel3.Size = new Size(599, 609);
            panel3.TabIndex = 64;
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
            // motdepasee
            // 
            motdepasee.BackColor = Color.White;
            motdepasee.BorderStyle = BorderStyle.None;
            motdepasee.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            motdepasee.ForeColor = Color.FromArgb(255, 192, 192);
            motdepasee.Location = new Point(643, 243);
            motdepasee.Name = "motdepasee";
            motdepasee.PlaceholderText = "Mot de passe";
            motdepasee.Size = new Size(222, 27);
            motdepasee.TabIndex = 69;
            motdepasee.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkCyan;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(584, 395);
            button2.Name = "button2";
            button2.Size = new Size(277, 43);
            button2.TabIndex = 63;
            button2.Text = "Se Connecter";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkCyan;
            panel5.Location = new Point(635, 204);
            panel5.Name = "panel5";
            panel5.Size = new Size(222, 1);
            panel5.TabIndex = 62;
            // 
            // txtutilisateur
            // 
            txtutilisateur.BackColor = Color.White;
            txtutilisateur.BorderStyle = BorderStyle.None;
            txtutilisateur.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtutilisateur.ForeColor = Color.FromArgb(255, 192, 192);
            txtutilisateur.Location = new Point(647, 171);
            txtutilisateur.Name = "txtutilisateur";
            txtutilisateur.PlaceholderText = "Nom d'utilisateur";
            txtutilisateur.Size = new Size(222, 27);
            txtutilisateur.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(635, 34);
            label1.Name = "label1";
            label1.Size = new Size(171, 41);
            label1.TabIndex = 60;
            label1.Text = "S'Inscrire";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkCyan;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 527);
            panel4.Name = "panel4";
            panel4.Size = new Size(928, 2);
            panel4.TabIndex = 59;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(928, 2);
            panel2.TabIndex = 57;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(928, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2, 529);
            panel1.TabIndex = 58;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(585, 298);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 53);
            pictureBox4.TabIndex = 70;
            pictureBox4.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(255, 192, 192);
            textBox1.Location = new Point(647, 314);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Confirmer PWD";
            textBox1.Size = new Size(222, 27);
            textBox1.TabIndex = 71;
            textBox1.UseSystemPasswordChar = true;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 529);
            Controls.Add(pictureBox4);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(motdepasee);
            Controls.Add(button2);
            Controls.Add(panel5);
            Controls.Add(txtutilisateur);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel6;
        private Panel panel3;
        private PictureBox pictureBox3;
        private TextBox motdepasee;
        private Button button2;
        private Panel panel5;
        private TextBox txtutilisateur;
        private Label label1;
        private Panel panel4;
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox4;
        private TextBox textBox1;
    }
}