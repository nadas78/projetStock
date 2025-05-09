namespace WinForms
{
    partial class FRM_AjouterCommande
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantiteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            prixDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categorieIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categorieDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            imageDataGridViewImageColumn = new DataGridViewImageColumn();
            produitBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            panel3 = new Panel();
            textBox1 = new TextBox();
            fontDialog1 = new FontDialog();
            dateTimePicker1 = new DateTimePicker();
            AfficheClient = new Button();
            panel2 = new Panel();
            textBoxvilleclient = new TextBox();
            label3 = new Label();
            textBoxAdresseclient = new TextBox();
            label4 = new Label();
            textBoxemaiclient = new TextBox();
            label5 = new Label();
            textBoxtelephclient = new TextBox();
            label2 = new Label();
            textBoxprenomClient = new TextBox();
            Prenom = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBoxnomclient = new TextBox();
            label7 = new Label();
            label11 = new Label();
            groupBox3 = new GroupBox();
            textBoxTotal = new TextBox();
            groupBox4 = new GroupBox();
            prix = new TextBox();
            Quantite = new TextBox();
            textBoxnom = new TextBox();
            IdClient = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            idlabel = new Label();
            label13 = new Label();
            label14 = new Label();
            textBoxremise = new TextBox();
            label15 = new Label();
            textBoxquantit = new TextBox();
            label16 = new Label();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            btnquiter = new Button();
            btnEnregister = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel11 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produitBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Elephant", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(820, 104);
            label6.Name = "label6";
            label6.Size = new Size(211, 30);
            label6.TabIndex = 69;
            label6.Text = "Date Commande:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomDataGridViewTextBoxColumn, quantiteDataGridViewTextBoxColumn, prixDataGridViewTextBoxColumn, categorieIdDataGridViewTextBoxColumn, categorieDataGridViewTextBoxColumn, imageDataGridViewImageColumn });
            dataGridView1.DataSource = produitBindingSource;
            dataGridView1.Location = new Point(0, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(803, 558);
            dataGridView1.TabIndex = 25;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            nomDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            nomDataGridViewTextBoxColumn.ReadOnly = true;
            nomDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantiteDataGridViewTextBoxColumn
            // 
            quantiteDataGridViewTextBoxColumn.DataPropertyName = "Quantite";
            quantiteDataGridViewTextBoxColumn.HeaderText = "Quantite";
            quantiteDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantiteDataGridViewTextBoxColumn.Name = "quantiteDataGridViewTextBoxColumn";
            quantiteDataGridViewTextBoxColumn.ReadOnly = true;
            quantiteDataGridViewTextBoxColumn.Width = 125;
            // 
            // prixDataGridViewTextBoxColumn
            // 
            prixDataGridViewTextBoxColumn.DataPropertyName = "Prix";
            prixDataGridViewTextBoxColumn.HeaderText = "Prix";
            prixDataGridViewTextBoxColumn.MinimumWidth = 6;
            prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            prixDataGridViewTextBoxColumn.ReadOnly = true;
            prixDataGridViewTextBoxColumn.Width = 125;
            // 
            // categorieIdDataGridViewTextBoxColumn
            // 
            categorieIdDataGridViewTextBoxColumn.DataPropertyName = "CategorieId";
            categorieIdDataGridViewTextBoxColumn.HeaderText = "CategorieId";
            categorieIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            categorieIdDataGridViewTextBoxColumn.Name = "categorieIdDataGridViewTextBoxColumn";
            categorieIdDataGridViewTextBoxColumn.ReadOnly = true;
            categorieIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // categorieDataGridViewTextBoxColumn
            // 
            categorieDataGridViewTextBoxColumn.DataPropertyName = "Categorie";
            categorieDataGridViewTextBoxColumn.HeaderText = "Categorie";
            categorieDataGridViewTextBoxColumn.MinimumWidth = 6;
            categorieDataGridViewTextBoxColumn.Name = "categorieDataGridViewTextBoxColumn";
            categorieDataGridViewTextBoxColumn.ReadOnly = true;
            categorieDataGridViewTextBoxColumn.Width = 125;
            // 
            // imageDataGridViewImageColumn
            // 
            imageDataGridViewImageColumn.DataPropertyName = "Image";
            imageDataGridViewImageColumn.HeaderText = "Image";
            imageDataGridViewImageColumn.MinimumWidth = 6;
            imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            imageDataGridViewImageColumn.ReadOnly = true;
            imageDataGridViewImageColumn.Width = 125;
            // 
            // produitBindingSource
            // 
            produitBindingSource.DataSource = typeof(StockLibrary.Entities.Produit);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Teal;
            groupBox1.Location = new Point(10, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(804, 657);
            groupBox1.TabIndex = 66;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produit";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(6, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(313, 3);
            panel3.TabIndex = 24;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Teal;
            textBox1.Location = new Point(27, 30);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(472, 33);
            textBox1.TabIndex = 23;
            textBox1.Text = "Recherche";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1052, 107);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(221, 27);
            dateTimePicker1.TabIndex = 70;
            // 
            // AfficheClient
            // 
            AfficheClient.BackColor = SystemColors.Control;
            AfficheClient.FlatAppearance.BorderColor = Color.Gainsboro;
            AfficheClient.FlatAppearance.BorderSize = 0;
            AfficheClient.Font = new Font("Snap ITC", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AfficheClient.Location = new Point(595, 22);
            AfficheClient.Name = "AfficheClient";
            AfficheClient.Size = new Size(65, 45);
            AfficheClient.TabIndex = 25;
            AfficheClient.Text = "...";
            AfficheClient.UseVisualStyleBackColor = false;
            AfficheClient.Click += AfficheClient_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(30, 28, 38);
            panel2.Location = new Point(-88, -102);
            panel2.Name = "panel2";
            panel2.Size = new Size(1546, 10);
            panel2.TabIndex = 24;
            // 
            // textBoxvilleclient
            // 
            textBoxvilleclient.Enabled = false;
            textBoxvilleclient.Location = new Point(477, 84);
            textBoxvilleclient.Multiline = true;
            textBoxvilleclient.Name = "textBoxvilleclient";
            textBoxvilleclient.Size = new Size(123, 34);
            textBoxvilleclient.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(425, 87);
            label3.Name = "label3";
            label3.Size = new Size(59, 22);
            label3.TabIndex = 10;
            label3.Text = "Ville :";
            // 
            // textBoxAdresseclient
            // 
            textBoxAdresseclient.Enabled = false;
            textBoxAdresseclient.Location = new Point(323, 81);
            textBoxAdresseclient.Multiline = true;
            textBoxAdresseclient.Name = "textBoxAdresseclient";
            textBoxAdresseclient.Size = new Size(96, 37);
            textBoxAdresseclient.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(222, 90);
            label4.Name = "label4";
            label4.Size = new Size(93, 22);
            label4.TabIndex = 8;
            label4.Text = "Adresse :";
            // 
            // textBoxemaiclient
            // 
            textBoxemaiclient.Enabled = false;
            textBoxemaiclient.Location = new Point(70, 81);
            textBoxemaiclient.Multiline = true;
            textBoxemaiclient.Name = "textBoxemaiclient";
            textBoxemaiclient.Size = new Size(146, 40);
            textBoxemaiclient.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(3, 81);
            label5.Name = "label5";
            label5.Size = new Size(71, 22);
            label5.TabIndex = 6;
            label5.Text = "Email :";
            // 
            // textBoxtelephclient
            // 
            textBoxtelephclient.Enabled = false;
            textBoxtelephclient.Location = new Point(466, 36);
            textBoxtelephclient.Multiline = true;
            textBoxtelephclient.Name = "textBoxtelephclient";
            textBoxtelephclient.Size = new Size(123, 31);
            textBoxtelephclient.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(366, 36);
            label2.Name = "label2";
            label2.Size = new Size(105, 22);
            label2.TabIndex = 4;
            label2.Text = "Telephone:";
            // 
            // textBoxprenomClient
            // 
            textBoxprenomClient.Enabled = false;
            textBoxprenomClient.Location = new Point(264, 27);
            textBoxprenomClient.Multiline = true;
            textBoxprenomClient.Name = "textBoxprenomClient";
            textBoxprenomClient.Size = new Size(96, 34);
            textBoxprenomClient.TabIndex = 3;
            // 
            // Prenom
            // 
            Prenom.AutoSize = true;
            Prenom.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Prenom.ForeColor = Color.Teal;
            Prenom.Location = new Point(162, 33);
            Prenom.Name = "Prenom";
            Prenom.Size = new Size(91, 22);
            Prenom.TabIndex = 2;
            Prenom.Text = "Prenom :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(3, 33);
            label1.Name = "label1";
            label1.Size = new Size(61, 22);
            label1.TabIndex = 0;
            label1.Text = "Nom :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(AfficheClient);
            groupBox2.Controls.Add(panel2);
            groupBox2.Controls.Add(textBoxvilleclient);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBoxAdresseclient);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBoxemaiclient);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBoxtelephclient);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxprenomClient);
            groupBox2.Controls.Add(Prenom);
            groupBox2.Controls.Add(textBoxnomclient);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Teal;
            groupBox2.Location = new Point(819, 140);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(809, 678);
            groupBox2.TabIndex = 67;
            groupBox2.TabStop = false;
            groupBox2.Text = "Client";
            // 
            // textBoxnomclient
            // 
            textBoxnomclient.Enabled = false;
            textBoxnomclient.Location = new Point(60, 33);
            textBoxnomclient.Multiline = true;
            textBoxnomclient.Name = "textBoxnomclient";
            textBoxnomclient.Size = new Size(96, 34);
            textBoxnomclient.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Elephant", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(403, -41);
            label7.Name = "label7";
            label7.Size = new Size(372, 43);
            label7.TabIndex = 71;
            label7.Text = "Ajouter Commande:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Elephant", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Teal;
            label11.Location = new Point(345, 9);
            label11.Name = "label11";
            label11.Size = new Size(372, 43);
            label11.TabIndex = 73;
            label11.Text = "Ajouter Commande:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Teal;
            groupBox3.Controls.Add(textBoxTotal);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(textBoxremise);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(textBoxquantit);
            groupBox3.Controls.Add(label16);
            groupBox3.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(820, 301);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(796, 361);
            groupBox3.TabIndex = 108;
            groupBox3.TabStop = false;
            groupBox3.Text = "Vendre roduit";
            // 
            // textBoxTotal
            // 
            textBoxTotal.Enabled = false;
            textBoxTotal.Location = new Point(572, 276);
            textBoxTotal.Multiline = true;
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.Size = new Size(210, 42);
            textBoxTotal.TabIndex = 96;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(prix);
            groupBox4.Controls.Add(Quantite);
            groupBox4.Controls.Add(textBoxnom);
            groupBox4.Controls.Add(IdClient);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(idlabel);
            groupBox4.Font = new Font("Cooper Black", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(0, 30);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(338, 328);
            groupBox4.TabIndex = 96;
            groupBox4.TabStop = false;
            groupBox4.Text = "Detail produit";
            // 
            // prix
            // 
            prix.Location = new Point(137, 254);
            prix.Multiline = true;
            prix.Name = "prix";
            prix.ReadOnly = true;
            prix.Size = new Size(152, 30);
            prix.TabIndex = 95;
            // 
            // Quantite
            // 
            Quantite.Location = new Point(137, 187);
            Quantite.Multiline = true;
            Quantite.Name = "Quantite";
            Quantite.ReadOnly = true;
            Quantite.Size = new Size(152, 30);
            Quantite.TabIndex = 94;
            // 
            // textBoxnom
            // 
            textBoxnom.Location = new Point(137, 111);
            textBoxnom.Multiline = true;
            textBoxnom.Name = "textBoxnom";
            textBoxnom.ReadOnly = true;
            textBoxnom.Size = new Size(152, 30);
            textBoxnom.TabIndex = 93;
            // 
            // IdClient
            // 
            IdClient.Location = new Point(137, 55);
            IdClient.Multiline = true;
            IdClient.Name = "IdClient";
            IdClient.ReadOnly = true;
            IdClient.Size = new Size(152, 30);
            IdClient.TabIndex = 92;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 254);
            label8.Name = "label8";
            label8.Size = new Size(57, 24);
            label8.TabIndex = 91;
            label8.Text = "Prix:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 193);
            label9.Name = "label9";
            label9.Size = new Size(104, 24);
            label9.TabIndex = 90;
            label9.Text = "Quantité:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(2, 117);
            label10.Name = "label10";
            label10.Size = new Size(137, 24);
            label10.TabIndex = 89;
            label10.Text = "NomProduit:";
            // 
            // idlabel
            // 
            idlabel.AutoSize = true;
            idlabel.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            idlabel.Location = new Point(2, 56);
            idlabel.Name = "idlabel";
            idlabel.Size = new Size(98, 24);
            idlabel.TabIndex = 71;
            idlabel.Text = "IdClient:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ControlLightLight;
            label13.Location = new Point(465, 183);
            label13.Name = "label13";
            label13.Size = new Size(34, 24);
            label13.TabIndex = 88;
            label13.Text = "%";
            
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ControlLightLight;
            label14.Location = new Point(380, 285);
            label14.Name = "label14";
            label14.Size = new Size(73, 24);
            label14.TabIndex = 86;
            label14.Text = "Total :";
            // 
            // textBoxremise
            // 
            textBoxremise.Location = new Point(572, 169);
            textBoxremise.Multiline = true;
            textBoxremise.Name = "textBoxremise";
            textBoxremise.Size = new Size(210, 38);
            textBoxremise.TabIndex = 85;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.ControlLightLight;
            label15.Location = new Point(379, 183);
            label15.Name = "label15";
            label15.Size = new Size(91, 24);
            label15.TabIndex = 84;
            label15.Text = "Remise:";
            // 
            // textBoxquantit
            // 
            textBoxquantit.Location = new Point(572, 85);
            textBoxquantit.Multiline = true;
            textBoxquantit.Name = "textBoxquantit";
            textBoxquantit.Size = new Size(210, 38);
            textBoxquantit.TabIndex = 83;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.ControlLightLight;
            label16.Location = new Point(344, 91);
            label16.Name = "label16";
            label16.Size = new Size(222, 24);
            label16.TabIndex = 82;
            label16.Text = "QuantitéCommandée";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(178, 8, 55);
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(3, 6);
            panel8.Name = "panel8";
            panel8.Size = new Size(3, 818);
            panel8.TabIndex = 106;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(178, 8, 55);
            panel9.Dock = DockStyle.Right;
            panel9.Location = new Point(1622, 6);
            panel9.Name = "panel9";
            panel9.Size = new Size(3, 818);
            panel9.TabIndex = 105;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(178, 8, 55);
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(3, 824);
            panel10.Name = "panel10";
            panel10.Size = new Size(1622, 3);
            panel10.TabIndex = 107;
            // 
            // btnquiter
            // 
            btnquiter.FlatAppearance.BorderSize = 0;
            btnquiter.FlatStyle = FlatStyle.Flat;
            btnquiter.Location = new Point(1649, 298);
            btnquiter.Name = "btnquiter";
            btnquiter.Size = new Size(36, 41);
            btnquiter.TabIndex = 103;
            btnquiter.UseVisualStyleBackColor = true;
            // 
            // btnEnregister
            // 
            btnEnregister.BackColor = Color.Teal;
            btnEnregister.FlatAppearance.BorderSize = 0;
            btnEnregister.FlatStyle = FlatStyle.Flat;
            btnEnregister.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnregister.ForeColor = SystemColors.ControlLightLight;
            btnEnregister.Location = new Point(1119, 683);
            btnEnregister.Name = "btnEnregister";
            btnEnregister.Size = new Size(248, 43);
            btnEnregister.TabIndex = 102;
            btnEnregister.Text = "Enregistrer";
            btnEnregister.UseVisualStyleBackColor = false;
            btnEnregister.Click += btnEnregister_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(178, 8, 55);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(3, 821);
            panel1.TabIndex = 100;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(178, 8, 55);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1625, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(3, 821);
            panel4.TabIndex = 99;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(178, 8, 55);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 827);
            panel5.Name = "panel5";
            panel5.Size = new Size(1628, 3);
            panel5.TabIndex = 101;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(178, 8, 55);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(1628, 3);
            panel6.TabIndex = 98;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(178, 8, 55);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(1628, 3);
            panel11.TabIndex = 104;
            // 
            // FRM_AjouterCommande
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1628, 830);
            Controls.Add(groupBox3);
            Controls.Add(panel8);
            Controls.Add(panel9);
            Controls.Add(panel10);
            Controls.Add(btnquiter);
            Controls.Add(btnEnregister);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel11);
            Controls.Add(label11);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(groupBox2);
            Controls.Add(label7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FRM_AjouterCommande";
            Text = "FRM_AjouterCommande";
            Load += FRM_AjouterCommande_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)produitBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Panel panel3;
        private TextBox textBox1;
        private FontDialog fontDialog1;
        private DateTimePicker dateTimePicker1;
        private Button AfficheClient;
        private Panel panel2;
        private TextBox textBoxvilleclient;
        private Label label3;
        private TextBox textBoxAdresseclient;
        private Label label4;
        private TextBox textBoxemaiclient;
        private Label label5;
        private TextBox textBoxtelephclient;
        private Label label2;
        private TextBox textBoxprenomClient;
        private Label Prenom;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox textBoxnomclient;
        private Label label7;
        private Label label11;
        private GroupBox groupBox3;
        private TextBox textBoxTotal;
        private GroupBox groupBox4;
        private TextBox prix;
        private TextBox Quantite;
        private TextBox textBoxnom;
        private TextBox IdClient;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label idlabel;
        private Label label13;
        private Label label14;
        private TextBox textBoxremise;
        private Label label15;
        private TextBox textBoxquantit;
        private Label label16;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Button btnquiter;
        private Button btnEnregister;
        private Panel panel1;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel11;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantiteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categorieIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categorieDataGridViewTextBoxColumn;
        private DataGridViewImageColumn imageDataGridViewImageColumn;
        private BindingSource produitBindingSource;
    }
}