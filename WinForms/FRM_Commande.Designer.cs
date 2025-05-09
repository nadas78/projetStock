namespace WinForms
{
    partial class FRM_Commande
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
            dvgclient = new DataGridView();
            panel1 = new Panel();
            btnajouterclient = new Button();
            commandeBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clientIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            produitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantiteCommandeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            remiseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateCommandeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgclient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)commandeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dvgclient
            // 
            dvgclient.AllowUserToAddRows = false;
            dvgclient.AllowUserToDeleteRows = false;
            dvgclient.AutoGenerateColumns = false;
            dvgclient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgclient.BackgroundColor = SystemColors.Control;
            dvgclient.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.PaleVioletRed;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dvgclient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dvgclient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgclient.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, clientIdDataGridViewTextBoxColumn, produitDataGridViewTextBoxColumn, quantiteCommandeDataGridViewTextBoxColumn, remiseDataGridViewTextBoxColumn, dateCommandeDataGridViewTextBoxColumn, totalDataGridViewTextBoxColumn });
            dvgclient.DataSource = commandeBindingSource;
            dvgclient.EnableHeadersVisualStyles = false;
            dvgclient.GridColor = Color.PaleVioletRed;
            dvgclient.Location = new Point(45, 132);
            dvgclient.Name = "dvgclient";
            dvgclient.ReadOnly = true;
            dvgclient.RowHeadersVisible = false;
            dvgclient.RowHeadersWidth = 51;
            dvgclient.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dvgclient.Size = new Size(1119, 456);
            dvgclient.TabIndex = 42;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(30, 28, 38);
            panel1.Location = new Point(-33, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(1345, 5);
            panel1.TabIndex = 41;
            // 
            // btnajouterclient
            // 
            btnajouterclient.BackColor = Color.PaleVioletRed;
            btnajouterclient.FlatAppearance.BorderSize = 0;
            btnajouterclient.FlatStyle = FlatStyle.Flat;
            btnajouterclient.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnajouterclient.ForeColor = SystemColors.ControlLightLight;
            btnajouterclient.ImageAlign = ContentAlignment.MiddleLeft;
            btnajouterclient.Location = new Point(22, 25);
            btnajouterclient.Name = "btnajouterclient";
            btnajouterclient.Size = new Size(273, 53);
            btnajouterclient.TabIndex = 40;
            btnajouterclient.Text = "Ajouter";
            btnajouterclient.UseVisualStyleBackColor = false;
            btnajouterclient.Click += btnajouterclient_Click;
            // 
            // commandeBindingSource
            // 
            commandeBindingSource.DataSource = typeof(StockLibrary.Entities.Commande);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            clientIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            clientIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produitDataGridViewTextBoxColumn
            // 
            produitDataGridViewTextBoxColumn.DataPropertyName = "Produit";
            produitDataGridViewTextBoxColumn.HeaderText = "Produit";
            produitDataGridViewTextBoxColumn.MinimumWidth = 6;
            produitDataGridViewTextBoxColumn.Name = "produitDataGridViewTextBoxColumn";
            produitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantiteCommandeDataGridViewTextBoxColumn
            // 
            quantiteCommandeDataGridViewTextBoxColumn.DataPropertyName = "QuantiteCommande";
            quantiteCommandeDataGridViewTextBoxColumn.HeaderText = "QuantiteCommande";
            quantiteCommandeDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantiteCommandeDataGridViewTextBoxColumn.Name = "quantiteCommandeDataGridViewTextBoxColumn";
            quantiteCommandeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remiseDataGridViewTextBoxColumn
            // 
            remiseDataGridViewTextBoxColumn.DataPropertyName = "Remise";
            remiseDataGridViewTextBoxColumn.HeaderText = "Remise";
            remiseDataGridViewTextBoxColumn.MinimumWidth = 6;
            remiseDataGridViewTextBoxColumn.Name = "remiseDataGridViewTextBoxColumn";
            remiseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateCommandeDataGridViewTextBoxColumn
            // 
            dateCommandeDataGridViewTextBoxColumn.DataPropertyName = "DateCommande";
            dateCommandeDataGridViewTextBoxColumn.HeaderText = "DateCommande";
            dateCommandeDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateCommandeDataGridViewTextBoxColumn.Name = "dateCommandeDataGridViewTextBoxColumn";
            dateCommandeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            totalDataGridViewTextBoxColumn.HeaderText = "Total";
            totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleVioletRed;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(752, 25);
            button1.Name = "button1";
            button1.Size = new Size(273, 53);
            button1.TabIndex = 43;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleVioletRed;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(370, 25);
            button2.Name = "button2";
            button2.Size = new Size(273, 53);
            button2.TabIndex = 44;
            button2.Text = "Ajouter";
            button2.UseVisualStyleBackColor = false;
            // 
            // FRM_Commande
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 604);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dvgclient);
            Controls.Add(panel1);
            Controls.Add(btnajouterclient);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FRM_Commande";
            Text = "FRM_Commande";
            ((System.ComponentModel.ISupportInitialize)dvgclient).EndInit();
            ((System.ComponentModel.ISupportInitialize)commandeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvgclient;
        private Panel panel1;
        private Button btnajouterclient;
        private BindingSource commandeBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn produitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantiteCommandeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn remiseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateCommandeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private Button button1;
        private Button button2;
    }
}