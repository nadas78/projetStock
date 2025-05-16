namespace WinForms
{
    partial class FRM_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Menu));
            panal1 = new Button();
            btncommande = new Button();
            btnproduit = new Button();
            btnclient = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button10 = new Button();
            button4 = new Button();
            btncategorie = new Button();
            panelParametre = new Panel();
            button1 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            pnlaficher = new Panel();
            panelParametre.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panal1
            // 
            panal1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panal1.FlatAppearance.BorderSize = 0;
            panal1.FlatStyle = FlatStyle.Flat;
            panal1.Location = new Point(183, 15);
            panal1.Name = "panal1";
            panal1.Size = new Size(29, 23);
            panal1.TabIndex = 7;
            panal1.UseVisualStyleBackColor = true;
            // 
            // btncommande
            // 
            btncommande.BackColor = Color.DarkCyan;
            btncommande.FlatAppearance.BorderColor = Color.White;
            btncommande.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            btncommande.FlatStyle = FlatStyle.Flat;
            btncommande.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncommande.ForeColor = SystemColors.ControlLightLight;
            btncommande.Image = Properties.Resources.icons8_panier_481;
            btncommande.ImageAlign = ContentAlignment.MiddleLeft;
            btncommande.Location = new Point(3, 576);
            btncommande.Name = "btncommande";
            btncommande.Size = new Size(205, 69);
            btncommande.TabIndex = 6;
            btncommande.Text = "       Commande";
            btncommande.UseVisualStyleBackColor = false;
            btncommande.Click += btncommande_Click;
            // 
            // btnproduit
            // 
            btnproduit.BackColor = Color.DarkCyan;
            btnproduit.FlatAppearance.BorderColor = Color.White;
            btnproduit.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            btnproduit.FlatStyle = FlatStyle.Flat;
            btnproduit.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnproduit.ForeColor = SystemColors.ControlLightLight;
            btnproduit.Image = (Image)resources.GetObject("btnproduit.Image");
            btnproduit.ImageAlign = ContentAlignment.MiddleLeft;
            btnproduit.Location = new Point(0, 248);
            btnproduit.Name = "btnproduit";
            btnproduit.Size = new Size(205, 64);
            btnproduit.TabIndex = 4;
            btnproduit.Text = "    Produit";
            btnproduit.UseVisualStyleBackColor = false;
            btnproduit.Click += btnproduit_Click;
            // 
            // btnclient
            // 
            btnclient.BackColor = Color.DarkCyan;
            btnclient.FlatAppearance.BorderColor = Color.White;
            btnclient.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            btnclient.FlatStyle = FlatStyle.Flat;
            btnclient.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclient.ForeColor = SystemColors.ControlLightLight;
            btnclient.Image = (Image)resources.GetObject("btnclient.Image");
            btnclient.ImageAlign = ContentAlignment.MiddleLeft;
            btnclient.Location = new Point(2, 88);
            btnclient.Name = "btnclient";
            btnclient.Size = new Size(205, 62);
            btnclient.TabIndex = 0;
            btnclient.Text = "    Client";
            btnclient.UseVisualStyleBackColor = false;
            btnclient.Click += btnclient_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(41, 39, 40);
            button7.FlatAppearance.BorderColor = Color.FromArgb(178, 8, 55);
            button7.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ControlLight;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(3, 156);
            button7.Name = "button7";
            button7.Size = new Size(352, 45);
            button7.TabIndex = 3;
            button7.Text = "Déonnecter";
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(41, 39, 40);
            button6.FlatAppearance.BorderColor = Color.FromArgb(178, 8, 55);
            button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ControlLight;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(3, 105);
            button6.Name = "button6";
            button6.Size = new Size(352, 45);
            button6.TabIndex = 2;
            button6.Text = "      Réstaurer une copie de l'application";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(41, 39, 40);
            button5.FlatAppearance.BorderColor = Color.FromArgb(178, 8, 55);
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlLight;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(3, 54);
            button5.Name = "button5";
            button5.Size = new Size(352, 45);
            button5.TabIndex = 1;
            button5.Text = "Créer une copie de l'application";
            button5.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.DarkCyan;
            button10.FlatAppearance.BorderColor = Color.White;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.ForeColor = SystemColors.ControlLightLight;
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.Location = new Point(119, 711);
            button10.Name = "button10";
            button10.Size = new Size(93, 101);
            button10.TabIndex = 13;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(41, 39, 40);
            button4.FlatAppearance.BorderColor = Color.FromArgb(178, 8, 55);
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlLight;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 3);
            button4.Name = "button4";
            button4.Size = new Size(352, 45);
            button4.TabIndex = 0;
            button4.Text = "Connecter";
            button4.UseVisualStyleBackColor = false;
            // 
            // btncategorie
            // 
            btncategorie.BackColor = Color.DarkCyan;
            btncategorie.FlatAppearance.BorderColor = Color.White;
            btncategorie.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            btncategorie.FlatStyle = FlatStyle.Flat;
            btncategorie.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncategorie.ForeColor = SystemColors.ControlLightLight;
            btncategorie.Image = Properties.Resources.icons8_classer_par_catégories_40;
            btncategorie.ImageAlign = ContentAlignment.MiddleLeft;
            btncategorie.Location = new Point(0, 413);
            btncategorie.Name = "btncategorie";
            btncategorie.Size = new Size(204, 63);
            btncategorie.TabIndex = 3;
            btncategorie.Text = "    Categorie";
            btncategorie.UseVisualStyleBackColor = false;
            btncategorie.Click += btncategorie_Click;
            // 
            // panelParametre
            // 
            panelParametre.BackColor = Color.FromArgb(41, 39, 40);
            panelParametre.Controls.Add(button7);
            panelParametre.Controls.Add(button6);
            panelParametre.Controls.Add(button5);
            panelParametre.Controls.Add(button4);
            panelParametre.Location = new Point(49, 12);
            panelParametre.Name = "panelParametre";
            panelParametre.Size = new Size(359, 21);
            panelParametre.TabIndex = 9;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1271, 16);
            button1.Name = "button1";
            button1.Size = new Size(37, 27);
            button1.TabIndex = 19;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1236, 18);
            button2.Name = "button2";
            button2.Size = new Size(29, 23);
            button2.TabIndex = 20;
            button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Controls.Add(panelParametre);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(213, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1139, 10);
            panel2.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(button10);
            panel1.Controls.Add(panal1);
            panel1.Controls.Add(btncommande);
            panel1.Controls.Add(btnproduit);
            panel1.Controls.Add(btncategorie);
            panel1.Controls.Add(btnclient);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 837);
            panel1.TabIndex = 17;
            // 
            // pnlaficher
            // 
            pnlaficher.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlaficher.BackColor = SystemColors.Control;
            pnlaficher.Location = new Point(233, 47);
            pnlaficher.Name = "pnlaficher";
            pnlaficher.Size = new Size(1089, 783);
            pnlaficher.TabIndex = 21;
            pnlaficher.Paint += pnlaficher_Paint;
            // 
            // FRM_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1352, 837);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlaficher);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FRM_Menu";
            Text = "FRM_Menu";
            Load += FRM_Menu_Load;
            panelParametre.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button panal1;
        private Button btncommande;
        private Button btnproduit;
        private Button btnclient;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button10;
        private Button button4;
        private Button btncategorie;
        private Panel panelParametre;
        private Button button1;
        private Button button2;
        private Panel panel2;
        private Panel panel1;
        private Panel pnlaficher;
    }
}