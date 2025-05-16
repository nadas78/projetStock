namespace WinForms
{
    partial class FRM_Categorie
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
            dvgcategorie = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categorieBindingSource = new BindingSource(components);
            panel3 = new Panel();
            rechercheCategory = new TextBox();
            BtnModifierCategorie = new Button();
            BtnSupprimerCategorie = new Button();
            bTNAjouter = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgcategorie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categorieBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dvgcategorie
            // 
            dvgcategorie.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgcategorie.AutoGenerateColumns = false;
            dvgcategorie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgcategorie.BackgroundColor = SystemColors.Control;
            dvgcategorie.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkCyan;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dvgcategorie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dvgcategorie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgcategorie.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomDataGridViewTextBoxColumn });
            dvgcategorie.DataSource = categorieBindingSource;
            dvgcategorie.EnableHeadersVisualStyles = false;
            dvgcategorie.Location = new Point(1, 82);
            dvgcategorie.Name = "dvgcategorie";
            dvgcategorie.RowHeadersVisible = false;
            dvgcategorie.RowHeadersWidth = 51;
            dvgcategorie.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dvgcategorie.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgcategorie.Size = new Size(1053, 343);
            dvgcategorie.TabIndex = 21;
            dvgcategorie.CellContentClick += dvgcategorie_CellContentClick;
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
            // categorieBindingSource
            // 
            categorieBindingSource.DataSource = typeof(StockLibrary.Entities.Categorie);
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSlateGray;
            panel3.Location = new Point(349, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(334, 10);
            panel3.TabIndex = 20;
            // 
            // rechercheCategory
            // 
            rechercheCategory.BackColor = SystemColors.Control;
            rechercheCategory.BorderStyle = BorderStyle.None;
            rechercheCategory.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rechercheCategory.ForeColor = Color.DimGray;
            rechercheCategory.Location = new Point(349, 26);
            rechercheCategory.Multiline = true;
            rechercheCategory.Name = "rechercheCategory";
            rechercheCategory.PlaceholderText = "Recherche";
            rechercheCategory.Size = new Size(334, 34);
            rechercheCategory.TabIndex = 19;
            rechercheCategory.TextAlign = HorizontalAlignment.Center;
            rechercheCategory.TextChanged += rechercheCategory_TextChanged;
            // 
            // BtnModifierCategorie
            // 
            BtnModifierCategorie.BackColor = Color.DarkCyan;
            BtnModifierCategorie.FlatAppearance.BorderSize = 0;
            BtnModifierCategorie.FlatStyle = FlatStyle.Flat;
            BtnModifierCategorie.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnModifierCategorie.ForeColor = SystemColors.ControlLightLight;
            BtnModifierCategorie.ImageAlign = ContentAlignment.MiddleLeft;
            BtnModifierCategorie.Location = new Point(373, 485);
            BtnModifierCategorie.Name = "BtnModifierCategorie";
            BtnModifierCategorie.Size = new Size(290, 54);
            BtnModifierCategorie.TabIndex = 22;
            BtnModifierCategorie.Text = "Modifier";
            BtnModifierCategorie.UseVisualStyleBackColor = false;
            BtnModifierCategorie.Click += BtnModifierCategorie_Click;
            // 
            // BtnSupprimerCategorie
            // 
            BtnSupprimerCategorie.BackColor = Color.DarkCyan;
            BtnSupprimerCategorie.FlatAppearance.BorderSize = 0;
            BtnSupprimerCategorie.FlatStyle = FlatStyle.Flat;
            BtnSupprimerCategorie.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSupprimerCategorie.ForeColor = SystemColors.ControlLightLight;
            BtnSupprimerCategorie.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSupprimerCategorie.Location = new Point(742, 485);
            BtnSupprimerCategorie.Name = "BtnSupprimerCategorie";
            BtnSupprimerCategorie.Size = new Size(290, 54);
            BtnSupprimerCategorie.TabIndex = 23;
            BtnSupprimerCategorie.Text = "Supprimer";
            BtnSupprimerCategorie.UseVisualStyleBackColor = false;
            BtnSupprimerCategorie.Click += BtnSupprimerCategorie_Click_1;
            // 
            // bTNAjouter
            // 
            bTNAjouter.BackColor = Color.DarkCyan;
            bTNAjouter.FlatAppearance.BorderSize = 0;
            bTNAjouter.FlatStyle = FlatStyle.Flat;
            bTNAjouter.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bTNAjouter.ForeColor = SystemColors.ControlLightLight;
            bTNAjouter.ImageAlign = ContentAlignment.MiddleLeft;
            bTNAjouter.Location = new Point(31, 485);
            bTNAjouter.Name = "bTNAjouter";
            bTNAjouter.Size = new Size(290, 54);
            bTNAjouter.TabIndex = 24;
            bTNAjouter.Text = "Ajouter";
            bTNAjouter.UseVisualStyleBackColor = false;
            bTNAjouter.Click += bTNAjouter_Click;
            // 
            // FRM_Categorie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 605);
            Controls.Add(bTNAjouter);
            Controls.Add(BtnSupprimerCategorie);
            Controls.Add(BtnModifierCategorie);
            Controls.Add(dvgcategorie);
            Controls.Add(panel3);
            Controls.Add(rechercheCategory);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FRM_Categorie";
            Text = "FRM_Categorie";
            Load += FRM_Categorie_Load;
            ((System.ComponentModel.ISupportInitialize)dvgcategorie).EndInit();
            ((System.ComponentModel.ISupportInitialize)categorieBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvgcategorie;
        private Panel panel3;
        private TextBox rechercheCategory;
        private BindingSource categorieBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private Button btnajoutercategorie;
        private Button BtnModifierCategorie;
        private Button BtnSupprimerCategorie;
        private Button bTNAjouter;
    }
}