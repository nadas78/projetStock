﻿namespace WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            linkLabel1 = new LinkLabel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(584, 240);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 53);
            pictureBox2.TabIndex = 54;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(584, 171);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 44);
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkCyan;
            panel6.Location = new Point(635, 282);
            panel6.Name = "panel6";
            panel6.Size = new Size(222, 1);
            panel6.TabIndex = 52;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkCyan;
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(-60, -69);
            panel3.Name = "panel3";
            panel3.Size = new Size(599, 609);
            panel3.TabIndex = 51;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(83, 154);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(450, 347);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // motdepasee
            // 
            motdepasee.BackColor = Color.White;
            motdepasee.BorderStyle = BorderStyle.None;
            motdepasee.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            motdepasee.ForeColor = Color.FromArgb(255, 192, 192);
            motdepasee.Location = new Point(639, 253);
            motdepasee.Name = "motdepasee";
            motdepasee.PlaceholderText = "Mot de passe";
            motdepasee.Size = new Size(222, 27);
            motdepasee.TabIndex = 56;
            motdepasee.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkCyan;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(584, 344);
            button2.Name = "button2";
            button2.Size = new Size(277, 43);
            button2.TabIndex = 50;
            button2.Text = "Se Connecter";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkCyan;
            panel5.Location = new Point(635, 214);
            panel5.Name = "panel5";
            panel5.Size = new Size(222, 1);
            panel5.TabIndex = 49;
            // 
            // txtutilisateur
            // 
            txtutilisateur.BackColor = Color.White;
            txtutilisateur.BorderStyle = BorderStyle.None;
            txtutilisateur.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtutilisateur.ForeColor = Color.FromArgb(255, 192, 192);
            txtutilisateur.Location = new Point(639, 181);
            txtutilisateur.Name = "txtutilisateur";
            txtutilisateur.PlaceholderText = "Nom d'utilisateur";
            txtutilisateur.Size = new Size(222, 27);
            txtutilisateur.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(635, 44);
            label1.Name = "label1";
            label1.Size = new Size(199, 41);
            label1.TabIndex = 47;
            label1.Text = "Connexion ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkCyan;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 538);
            panel4.Name = "panel4";
            panel4.Size = new Size(922, 2);
            panel4.TabIndex = 46;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(922, 2);
            panel2.TabIndex = 44;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.DarkCyan;
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(661, 412);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(129, 20);
            linkLabel1.TabIndex = 55;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Jai pas de compte";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(922, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2, 540);
            panel1.TabIndex = 45;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 540);
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
            Controls.Add(linkLabel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private LinkLabel linkLabel1;
        private Panel panel1;
    }
}
