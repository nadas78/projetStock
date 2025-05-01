namespace WinForms
{
    partial class FRM_Produit
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            button5 = new Button();
            btnafficheIm = new Button();
            button2 = new Button();
            buttIprimer = new Button();
            dvglProduit = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantiteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categorieDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            imageDataGridViewImageColumn = new DataGridViewImageColumn();
            produitBindingSource1 = new BindingSource(components);
            produitBindingSource = new BindingSource(components);
            panel3 = new Panel();
            panel1 = new Panel();
            btnmodifierclient = new Button();
            btnsupprimerclient = new Button();
            btnajouterclient = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dvglProduit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produitBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produitBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(30, 28, 38);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(830, 91);
            button5.Name = "button5";
            button5.Size = new Size(242, 53);
            button5.TabIndex = 33;
            button5.Text = "Actualiser";
            button5.UseVisualStyleBackColor = false;
      
            // 
            // btnafficheIm
            // 
            btnafficheIm.BackColor = Color.FromArgb(30, 28, 38);
            btnafficheIm.FlatAppearance.BorderSize = 0;
            btnafficheIm.FlatStyle = FlatStyle.Flat;
            btnafficheIm.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnafficheIm.ForeColor = SystemColors.ControlLightLight;
            btnafficheIm.ImageAlign = ContentAlignment.MiddleLeft;
            btnafficheIm.Location = new Point(817, 11);
            btnafficheIm.Name = "btnafficheIm";
            btnafficheIm.Size = new Size(278, 53);
            btnafficheIm.TabIndex = 32;
            btnafficheIm.Text = "   Afficher Photo";
            btnafficheIm.UseVisualStyleBackColor = false;
            
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(30, 28, 38);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(788, 565);
            button2.Name = "button2";
            button2.Size = new Size(320, 53);
            button2.TabIndex = 31;
            button2.Text = "   Sauvegarder dans Excel";
            button2.UseVisualStyleBackColor = false;
         
            // 
            // buttIprimer
            // 
            buttIprimer.BackColor = Color.FromArgb(30, 28, 38);
            buttIprimer.FlatAppearance.BorderSize = 0;
            buttIprimer.FlatStyle = FlatStyle.Flat;
            buttIprimer.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttIprimer.ForeColor = SystemColors.ControlLightLight;
            buttIprimer.ImageAlign = ContentAlignment.MiddleLeft;
            buttIprimer.Location = new Point(44, 565);
            buttIprimer.Name = "buttIprimer";
            buttIprimer.Size = new Size(301, 53);
            buttIprimer.TabIndex = 30;
            buttIprimer.Text = "   Imprimer PR cocher";
            buttIprimer.UseVisualStyleBackColor = false;
          
            // 
            // dvglProduit
            // 
            dvglProduit.AllowUserToAddRows = false;
            dvglProduit.AutoGenerateColumns = false;
            dvglProduit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvglProduit.BackgroundColor = SystemColors.Control;
            dvglProduit.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 28, 38);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dvglProduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dvglProduit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvglProduit.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomDataGridViewTextBoxColumn, quantiteDataGridViewTextBoxColumn, categorieDataGridViewTextBoxColumn, imageDataGridViewImageColumn });
            dvglProduit.DataSource = produitBindingSource1;
            dvglProduit.EnableHeadersVisualStyles = false;
            dvglProduit.Location = new Point(27, 165);
            dvglProduit.Name = "dvglProduit";
            dvglProduit.RowHeadersVisible = false;
            dvglProduit.RowHeadersWidth = 51;
            dvglProduit.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dvglProduit.Size = new Size(1081, 383);
            dvglProduit.TabIndex = 29;
            
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            nomDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // quantiteDataGridViewTextBoxColumn
            // 
            quantiteDataGridViewTextBoxColumn.DataPropertyName = "Quantite";
            quantiteDataGridViewTextBoxColumn.HeaderText = "Quantite";
            quantiteDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantiteDataGridViewTextBoxColumn.Name = "quantiteDataGridViewTextBoxColumn";
            // 
            // categorieDataGridViewTextBoxColumn
            // 
            categorieDataGridViewTextBoxColumn.DataPropertyName = "Categorie";
            categorieDataGridViewTextBoxColumn.HeaderText = "Categorie";
            categorieDataGridViewTextBoxColumn.MinimumWidth = 6;
            categorieDataGridViewTextBoxColumn.Name = "categorieDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn
            // 
            imageDataGridViewImageColumn.DataPropertyName = "Image";
            imageDataGridViewImageColumn.HeaderText = "Image";
            imageDataGridViewImageColumn.MinimumWidth = 6;
            imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            // 
            // produitBindingSource1
            // 
            produitBindingSource1.DataSource = typeof(StockLibrary.Entities.Produit);
            // 
            // produitBindingSource
            // 
            produitBindingSource.DataSource = typeof(StockLibrary.Entities.Produit);
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 28, 38);
            panel3.Location = new Point(270, 137);
            panel3.Name = "panel3";
            panel3.Size = new Size(526, 3);
            panel3.TabIndex = 28;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(30, 28, 38);
            panel1.Location = new Point(44, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 3);
            panel1.TabIndex = 26;
            // 
            // btnmodifierclient
            // 
            btnmodifierclient.BackColor = Color.FromArgb(30, 28, 38);
            btnmodifierclient.FlatAppearance.BorderSize = 0;
            btnmodifierclient.FlatStyle = FlatStyle.Flat;
            btnmodifierclient.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmodifierclient.ForeColor = SystemColors.ControlLightLight;
            btnmodifierclient.ImageAlign = ContentAlignment.MiddleLeft;
            btnmodifierclient.Location = new Point(295, 11);
            btnmodifierclient.Name = "btnmodifierclient";
            btnmodifierclient.Size = new Size(233, 53);
            btnmodifierclient.TabIndex = 25;
            btnmodifierclient.Text = "Modifier";
            btnmodifierclient.UseVisualStyleBackColor = false;
         
            // 
            // btnsupprimerclient
            // 
            btnsupprimerclient.BackColor = Color.FromArgb(30, 28, 38);
            btnsupprimerclient.FlatAppearance.BorderSize = 0;
            btnsupprimerclient.FlatStyle = FlatStyle.Flat;
            btnsupprimerclient.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsupprimerclient.ForeColor = SystemColors.ControlLightLight;
            btnsupprimerclient.ImageAlign = ContentAlignment.MiddleLeft;
            btnsupprimerclient.Location = new Point(550, 10);
            btnsupprimerclient.Name = "btnsupprimerclient";
            btnsupprimerclient.Size = new Size(246, 53);
            btnsupprimerclient.TabIndex = 24;
            btnsupprimerclient.Text = "Supprimer";
            btnsupprimerclient.UseVisualStyleBackColor = false;
          
            // 
            // btnajouterclient
            // 
            btnajouterclient.BackColor = Color.FromArgb(30, 28, 38);
            btnajouterclient.FlatAppearance.BorderSize = 0;
            btnajouterclient.FlatStyle = FlatStyle.Flat;
            btnajouterclient.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnajouterclient.ForeColor = SystemColors.ControlLightLight;
            btnajouterclient.ImageAlign = ContentAlignment.MiddleLeft;
            btnajouterclient.Location = new Point(44, 10);
            btnajouterclient.Name = "btnajouterclient";
            btnajouterclient.Size = new Size(222, 53);
            btnajouterclient.TabIndex = 23;
            btnajouterclient.Text = "Ajouter";
            btnajouterclient.UseVisualStyleBackColor = false;
            btnajouterclient.Click += btnajouterclient_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.DimGray;
            textBox1.Location = new Point(344, 98);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(297, 33);
            textBox1.TabIndex = 27;
            textBox1.Text = "Recherche";
            textBox1.TextAlign = HorizontalAlignment.Center;
        
            // 
            // FRM_Produit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 629);
            Controls.Add(button5);
            Controls.Add(btnafficheIm);
            Controls.Add(button2);
            Controls.Add(buttIprimer);
            Controls.Add(dvglProduit);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(btnmodifierclient);
            Controls.Add(btnsupprimerclient);
            Controls.Add(btnajouterclient);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FRM_Produit";
            Text = "FRM_Produit";
            ((System.ComponentModel.ISupportInitialize)dvglProduit).EndInit();
            ((System.ComponentModel.ISupportInitialize)produitBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)produitBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Button btnafficheIm;
        private Button button2;
        private Button buttIprimer;
        private DataGridView dvglProduit;
        private Panel panel3;
        private Panel panel1;
        private Button btnmodifierclient;
        private Button btnsupprimerclient;
        private Button btnajouterclient;
        private TextBox textBox1;
        private BindingSource produitBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantiteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categorieDataGridViewTextBoxColumn;
        private DataGridViewImageColumn imageDataGridViewImageColumn;
        private BindingSource produitBindingSource1;
    }
}