namespace WinForms
{
    partial class FRM_AjouterClient
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_AjouterClient));
            pictureBox7 = new PictureBox();
            VilleClient = new TextBox();
            clientBindingSource = new BindingSource(components);
            panel8 = new Panel();
            panel11 = new Panel();
            EnregistrerClient = new Button();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel12 = new Panel();
            panel9 = new Panel();
            panel6 = new Panel();
            TelephoneClient = new TextBox();
            EmailClient = new TextBox();
            PrenomClient = new TextBox();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            panel5 = new Panel();
            AdresseClient = new TextBox();
            NomClient = new TextBox();
            label1 = new Label();
            panel7 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(12, 368);
            pictureBox7.Margin = new Padding(3, 4, 3, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(33, 49);
            pictureBox7.TabIndex = 81;
            pictureBox7.TabStop = false;
            // 
            // VilleClient
            // 
            VilleClient.BackColor = Color.FromArgb(30, 28, 38);
            VilleClient.BorderStyle = BorderStyle.None;
            VilleClient.DataBindings.Add(new Binding("Text", clientBindingSource, "Ville", true));
            VilleClient.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VilleClient.ForeColor = Color.FromArgb(224, 224, 224);
            VilleClient.Location = new Point(52, 364);
            VilleClient.Margin = new Padding(3, 4, 3, 4);
            VilleClient.Multiline = true;
            VilleClient.Name = "VilleClient";
            VilleClient.Size = new Size(208, 41);
            VilleClient.TabIndex = 80;
            VilleClient.Text = "Ville Client";
            // 
            // clientBindingSource
            // 
            clientBindingSource.DataSource = typeof(StockLibrary.Entities.Client);
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(178, 5, 55);
            panel8.Location = new Point(136, 126);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(200, 125);
            panel8.TabIndex = 2;
            // 
            // panel11
            // 
            panel11.BackColor = Color.White;
            panel11.Location = new Point(53, 412);
            panel11.Margin = new Padding(3, 4, 3, 4);
            panel11.Name = "panel11";
            panel11.Size = new Size(238, 4);
            panel11.TabIndex = 79;
            // 
            // EnregistrerClient
            // 
            EnregistrerClient.BackColor = Color.FromArgb(178, 5, 55);
            EnregistrerClient.ForeColor = SystemColors.ControlLightLight;
            EnregistrerClient.Location = new Point(177, 480);
            EnregistrerClient.Margin = new Padding(3, 4, 3, 4);
            EnregistrerClient.Name = "EnregistrerClient";
            EnregistrerClient.Size = new Size(280, 59);
            EnregistrerClient.TabIndex = 78;
            EnregistrerClient.Text = "Enregistrer";
            EnregistrerClient.UseVisualStyleBackColor = false;
            EnregistrerClient.Click += EnregistrerClient_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(383, 364);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(44, 52);
            pictureBox6.TabIndex = 76;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(384, 257);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 52);
            pictureBox5.TabIndex = 75;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(383, 127);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(44, 52);
            pictureBox4.TabIndex = 74;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 220);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 52);
            pictureBox2.TabIndex = 72;
            pictureBox2.TabStop = false;
            // 
            // panel12
            // 
            panel12.BackColor = Color.White;
            panel12.Location = new Point(433, 413);
            panel12.Margin = new Padding(3, 4, 3, 4);
            panel12.Name = "panel12";
            panel12.Size = new Size(219, 4);
            panel12.TabIndex = 71;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Location = new Point(422, 312);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(229, 4);
            panel9.TabIndex = 63;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(433, 176);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(219, 4);
            panel6.TabIndex = 62;
            // 
            // TelephoneClient
            // 
            TelephoneClient.BackColor = Color.FromArgb(30, 28, 38);
            TelephoneClient.BorderStyle = BorderStyle.None;
            TelephoneClient.DataBindings.Add(new Binding("Text", clientBindingSource, "Telephone", true));
            TelephoneClient.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TelephoneClient.ForeColor = Color.FromArgb(224, 224, 224);
            TelephoneClient.Location = new Point(422, 256);
            TelephoneClient.Margin = new Padding(3, 4, 3, 4);
            TelephoneClient.Multiline = true;
            TelephoneClient.Name = "TelephoneClient";
            TelephoneClient.Size = new Size(208, 41);
            TelephoneClient.TabIndex = 70;
            TelephoneClient.Text = "Telephone Client";
            // 
            // EmailClient
            // 
            EmailClient.BackColor = Color.FromArgb(30, 28, 38);
            EmailClient.BorderStyle = BorderStyle.None;
            EmailClient.DataBindings.Add(new Binding("Text", clientBindingSource, "Ville", true));
            EmailClient.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailClient.ForeColor = Color.FromArgb(224, 224, 224);
            EmailClient.Location = new Point(433, 364);
            EmailClient.Margin = new Padding(3, 4, 3, 4);
            EmailClient.Multiline = true;
            EmailClient.Name = "EmailClient";
            EmailClient.Size = new Size(208, 41);
            EmailClient.TabIndex = 68;
            EmailClient.Text = "Email Client";
            // 
            // PrenomClient
            // 
            PrenomClient.BackColor = Color.FromArgb(30, 28, 38);
            PrenomClient.BorderStyle = BorderStyle.None;
            PrenomClient.DataBindings.Add(new Binding("Text", clientBindingSource, "Prenom", true));
            PrenomClient.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrenomClient.ForeColor = Color.FromArgb(224, 224, 224);
            PrenomClient.Location = new Point(433, 127);
            PrenomClient.Margin = new Padding(3, 4, 3, 4);
            PrenomClient.Multiline = true;
            PrenomClient.Name = "PrenomClient";
            PrenomClient.Size = new Size(208, 41);
            PrenomClient.TabIndex = 67;
            PrenomClient.Text = "Prenom de Client";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 127);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 52);
            pictureBox1.TabIndex = 66;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(70, 176);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(228, 4);
            panel4.TabIndex = 64;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(52, 268);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(230, 4);
            panel5.TabIndex = 61;
            // 
            // AdresseClient
            // 
            AdresseClient.BackColor = Color.FromArgb(30, 28, 38);
            AdresseClient.BorderStyle = BorderStyle.None;
            AdresseClient.DataBindings.Add(new Binding("Text", clientBindingSource, "Adresse", true));
            AdresseClient.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdresseClient.ForeColor = Color.FromArgb(224, 224, 224);
            AdresseClient.Location = new Point(60, 231);
            AdresseClient.Margin = new Padding(3, 4, 3, 4);
            AdresseClient.Multiline = true;
            AdresseClient.Name = "AdresseClient";
            AdresseClient.Size = new Size(208, 41);
            AdresseClient.TabIndex = 60;
            AdresseClient.Text = "Adresse Client";
            // 
            // NomClient
            // 
            NomClient.BackColor = Color.FromArgb(30, 28, 38);
            NomClient.BorderStyle = BorderStyle.None;
            NomClient.DataBindings.Add(new Binding("Text", clientBindingSource, "Nom", true));
            NomClient.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NomClient.ForeColor = Color.FromArgb(224, 224, 224);
            NomClient.Location = new Point(70, 127);
            NomClient.Margin = new Padding(3, 4, 3, 4);
            NomClient.Multiline = true;
            NomClient.Name = "NomClient";
            NomClient.Size = new Size(208, 41);
            NomClient.TabIndex = 59;
            NomClient.Text = "Nom de Client";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(216, 18);
            label1.Name = "label1";
            label1.Size = new Size(241, 42);
            label1.TabIndex = 58;
            label1.Text = "Ajouter Client";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(178, 5, 55);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(3, 563);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(671, 4);
            panel7.TabIndex = 57;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(178, 5, 55);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(674, 4);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(3, 563);
            panel3.TabIndex = 56;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(178, 5, 55);
            panel2.Controls.Add(panel8);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 563);
            panel2.TabIndex = 55;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(178, 5, 55);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(677, 4);
            panel1.TabIndex = 54;
            // 
            // FRM_AjouterClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 28, 38);
            ClientSize = new Size(677, 567);
            Controls.Add(pictureBox7);
            Controls.Add(VilleClient);
            Controls.Add(panel11);
            Controls.Add(EnregistrerClient);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(panel12);
            Controls.Add(panel9);
            Controls.Add(panel6);
            Controls.Add(TelephoneClient);
            Controls.Add(EmailClient);
            Controls.Add(PrenomClient);
            Controls.Add(pictureBox1);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(AdresseClient);
            Controls.Add(NomClient);
            Controls.Add(label1);
            Controls.Add(panel7);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FRM_AjouterClient";
            Text = "FRM_AjouterClient";
            Load += FRM_AjouterClient_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox7;
        private TextBox VilleClient;
        private Panel panel8;
        private Panel panel11;
        private Button EnregistrerClient;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private Panel panel12;
        private Panel panel9;
        private Panel panel6;
        private TextBox TelephoneClient;
        private TextBox EmailClient;
        private TextBox PrenomClient;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Panel panel5;
        private TextBox AdresseClient;
        private TextBox NomClient;
        private Label label1;
        private Panel panel7;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private BindingSource clientBindingSource;
    }
}