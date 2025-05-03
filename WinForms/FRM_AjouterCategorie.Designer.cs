namespace WinForms
{
    partial class FRM_AjouterCategorie
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
            panel3 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            panel5 = new Panel();
            NomCategorie = new TextBox();
            label1 = new Label();
            btnquiter = new Button();
            panel4 = new Panel();
            btnEnregistercategorie = new Button();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(178, 8, 55);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(2, 332);
            panel3.TabIndex = 27;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(178, 8, 55);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(387, 2);
            panel2.TabIndex = 25;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(178, 8, 55);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(387, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2, 334);
            panel1.TabIndex = 26;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(89, 182);
            panel5.Name = "panel5";
            panel5.Size = new Size(222, 1);
            panel5.TabIndex = 32;
            // 
            // NomCategorie
            // 
            NomCategorie.BackColor = Color.FromArgb(30, 28, 38);
            NomCategorie.BorderStyle = BorderStyle.None;
            NomCategorie.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NomCategorie.ForeColor = Color.FromArgb(224, 224, 224);
            NomCategorie.Location = new Point(89, 149);
            NomCategorie.Name = "NomCategorie";
            NomCategorie.Size = new Size(222, 27);
            NomCategorie.TabIndex = 31;
            NomCategorie.Text = "Nom de Catégorie";
            NomCategorie.TextChanged += NomCategorie_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(64, 52);
            label1.Name = "label1";
            label1.Size = new Size(247, 36);
            label1.TabIndex = 30;
            label1.Text = "Ajouter Catégorie";
            // 
            // btnquiter
            // 
            btnquiter.FlatAppearance.BorderSize = 0;
            btnquiter.FlatStyle = FlatStyle.Flat;
            btnquiter.Location = new Point(279, -34);
            btnquiter.Name = "btnquiter";
            btnquiter.Size = new Size(36, 41);
            btnquiter.TabIndex = 29;
            btnquiter.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(178, 8, 55);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 334);
            panel4.Name = "panel4";
            panel4.Size = new Size(389, 2);
            panel4.TabIndex = 28;
            // 
            // btnEnregistercategorie
            // 
            btnEnregistercategorie.BackColor = Color.Red;
            btnEnregistercategorie.FlatAppearance.BorderSize = 0;
            btnEnregistercategorie.FlatStyle = FlatStyle.Flat;
            btnEnregistercategorie.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnregistercategorie.ForeColor = SystemColors.ControlLightLight;
            btnEnregistercategorie.ImageAlign = ContentAlignment.MiddleLeft;
            btnEnregistercategorie.Location = new Point(46, 229);
            btnEnregistercategorie.Name = "btnEnregistercategorie";
            btnEnregistercategorie.Size = new Size(290, 53);
            btnEnregistercategorie.TabIndex = 33;
            btnEnregistercategorie.Text = "Enregister";
            btnEnregistercategorie.UseVisualStyleBackColor = false;
            btnEnregistercategorie.Click += EnregistreCategorie_Click;
            // 
            // FRM_AjouterCategorie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 28, 38);
            ClientSize = new Size(389, 336);
            Controls.Add(btnEnregistercategorie);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(NomCategorie);
            Controls.Add(label1);
            Controls.Add(btnquiter);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FRM_AjouterCategorie";
            Text = "FRM_AjouterCategorie";
            Load += FRM_AjouterCategorie_Load;
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Button button1;
        private Panel panel2;
        private Panel panel1;
        private Button button2;
        private PictureBox pictureBox1;
        private Panel panel5;
        private TextBox NomCategorie;
        private Label label1;
        private Button btnquiter;
        private Panel panel4;
        private Button btnEnregistercategorie;
    }
}