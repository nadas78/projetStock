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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dvgcategorie = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categorieBindingSource = new BindingSource(components);
            panel3 = new Panel();
            rechercheCategory = new TextBox();
            btnajoutercategorie = new Button();
            BtnModifierCategorie = new Button();
            BtnSupprimerCategorie = new Button();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 28, 38);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dvgcategorie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dvgcategorie.Size = new Size(1053, 346);
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
            panel3.BackColor = Color.FromArgb(30, 28, 38);
            panel3.Location = new Point(349, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(334, 3);
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
            rechercheCategory.Size = new Size(334, 33);
            rechercheCategory.TabIndex = 19;
            rechercheCategory.TextAlign = HorizontalAlignment.Center;
            rechercheCategory.TextChanged += rechercheCategory_TextChanged;
            // 
            // btnajoutercategorie
            // 
            btnajoutercategorie.BackColor = Color.FromArgb(30, 28, 38);
            btnajoutercategorie.FlatAppearance.BorderSize = 0;
            btnajoutercategorie.FlatStyle = FlatStyle.Flat;
            btnajoutercategorie.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnajoutercategorie.ForeColor = SystemColors.ControlLightLight;
            btnajoutercategorie.ImageAlign = ContentAlignment.MiddleLeft;
            btnajoutercategorie.Location = new Point(41, 485);
            btnajoutercategorie.Name = "btnajoutercategorie";
            btnajoutercategorie.Size = new Size(290, 53);
            btnajoutercategorie.TabIndex = 18;
            btnajoutercategorie.Text = "Ajouter";
            btnajoutercategorie.UseVisualStyleBackColor = false;
            btnajoutercategorie.Click += btnajoutercategorie_Click_1;
            // 
            // BtnModifierCategorie
            // 
            BtnModifierCategorie.BackColor = Color.FromArgb(30, 28, 38);
            BtnModifierCategorie.FlatAppearance.BorderSize = 0;
            BtnModifierCategorie.FlatStyle = FlatStyle.Flat;
            BtnModifierCategorie.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnModifierCategorie.ForeColor = SystemColors.ControlLightLight;
            BtnModifierCategorie.ImageAlign = ContentAlignment.MiddleLeft;
            BtnModifierCategorie.Location = new Point(409, 485);
            BtnModifierCategorie.Name = "BtnModifierCategorie";
            BtnModifierCategorie.Size = new Size(290, 53);
            BtnModifierCategorie.TabIndex = 22;
            BtnModifierCategorie.Text = "Modifier";
            BtnModifierCategorie.UseVisualStyleBackColor = false;
            BtnModifierCategorie.Click += BtnModifierCategorie_Click;
            // 
            // BtnSupprimerCategorie
            // 
            BtnSupprimerCategorie.BackColor = Color.FromArgb(30, 28, 38);
            BtnSupprimerCategorie.FlatAppearance.BorderSize = 0;
            BtnSupprimerCategorie.FlatStyle = FlatStyle.Flat;
            BtnSupprimerCategorie.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSupprimerCategorie.ForeColor = SystemColors.ControlLightLight;
            BtnSupprimerCategorie.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSupprimerCategorie.Location = new Point(742, 485);
            BtnSupprimerCategorie.Name = "BtnSupprimerCategorie";
            BtnSupprimerCategorie.Size = new Size(290, 53);
            BtnSupprimerCategorie.TabIndex = 23;
            BtnSupprimerCategorie.Text = "Supprimer";
            BtnSupprimerCategorie.UseVisualStyleBackColor = false;
            BtnSupprimerCategorie.Click += BtnSupprimerCategorie_Click_1;
            // 
            // FRM_Categorie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 609);
            Controls.Add(BtnSupprimerCategorie);
            Controls.Add(BtnModifierCategorie);
            Controls.Add(dvgcategorie);
            Controls.Add(panel3);
            Controls.Add(rechercheCategory);
            Controls.Add(btnajoutercategorie);
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
    }
}