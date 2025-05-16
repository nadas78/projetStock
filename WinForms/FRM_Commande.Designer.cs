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
            dvgcommande = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clientIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateCommandeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lignesCommandeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            commandeBindingSource = new BindingSource(components);
            panel1 = new Panel();
            btnajouterclient = new Button();
            Modifier = new Button();
            Supprimer = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgcommande).BeginInit();
            ((System.ComponentModel.ISupportInitialize)commandeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dvgcommande
            // 
            dvgcommande.AllowUserToAddRows = false;
            dvgcommande.AllowUserToDeleteRows = false;
            dvgcommande.AutoGenerateColumns = false;
            dvgcommande.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgcommande.BackgroundColor = SystemColors.Control;
            dvgcommande.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkCyan;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dvgcommande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dvgcommande.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgcommande.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, clientIdDataGridViewTextBoxColumn, clientDataGridViewTextBoxColumn, dateCommandeDataGridViewTextBoxColumn, lignesCommandeDataGridViewTextBoxColumn, totalDataGridViewTextBoxColumn });
            dvgcommande.DataSource = commandeBindingSource;
            dvgcommande.EnableHeadersVisualStyles = false;
            dvgcommande.GridColor = Color.PaleVioletRed;
            dvgcommande.Location = new Point(45, 132);
            dvgcommande.Name = "dvgcommande";
            dvgcommande.ReadOnly = true;
            dvgcommande.RowHeadersVisible = false;
            dvgcommande.RowHeadersWidth = 51;
            dvgcommande.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dvgcommande.Size = new Size(1119, 456);
            dvgcommande.TabIndex = 42;
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
            // clientDataGridViewTextBoxColumn
            // 
            clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            clientDataGridViewTextBoxColumn.HeaderText = "Client";
            clientDataGridViewTextBoxColumn.MinimumWidth = 6;
            clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            clientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateCommandeDataGridViewTextBoxColumn
            // 
            dateCommandeDataGridViewTextBoxColumn.DataPropertyName = "DateCommande";
            dateCommandeDataGridViewTextBoxColumn.HeaderText = "DateCommande";
            dateCommandeDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateCommandeDataGridViewTextBoxColumn.Name = "dateCommandeDataGridViewTextBoxColumn";
            dateCommandeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lignesCommandeDataGridViewTextBoxColumn
            // 
            lignesCommandeDataGridViewTextBoxColumn.DataPropertyName = "LignesCommande";
            lignesCommandeDataGridViewTextBoxColumn.HeaderText = "LignesCommande";
            lignesCommandeDataGridViewTextBoxColumn.MinimumWidth = 6;
            lignesCommandeDataGridViewTextBoxColumn.Name = "lignesCommandeDataGridViewTextBoxColumn";
            lignesCommandeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            totalDataGridViewTextBoxColumn.HeaderText = "Total";
            totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commandeBindingSource
            // 
            commandeBindingSource.DataSource = typeof(StockLibrary.Entities.Commande);
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
            btnajouterclient.BackColor = Color.DarkCyan;
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
            // Modifier
            // 
            Modifier.BackColor = Color.DarkCyan;
            Modifier.FlatAppearance.BorderSize = 0;
            Modifier.FlatStyle = FlatStyle.Flat;
            Modifier.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Modifier.ForeColor = SystemColors.ControlLightLight;
            Modifier.ImageAlign = ContentAlignment.MiddleLeft;
            Modifier.Location = new Point(802, 25);
            Modifier.Name = "Modifier";
            Modifier.Size = new Size(273, 53);
            Modifier.TabIndex = 43;
            Modifier.Text = "Modifier";
            Modifier.UseVisualStyleBackColor = false;
            // 
            // Supprimer
            // 
            Supprimer.BackColor = Color.DarkCyan;
            Supprimer.FlatAppearance.BorderSize = 0;
            Supprimer.FlatStyle = FlatStyle.Flat;
            Supprimer.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Supprimer.ForeColor = SystemColors.ControlLightLight;
            Supprimer.ImageAlign = ContentAlignment.MiddleLeft;
            Supprimer.Location = new Point(436, 25);
            Supprimer.Name = "Supprimer";
            Supprimer.Size = new Size(273, 53);
            Supprimer.TabIndex = 44;
            Supprimer.Text = "Supprimer";
            Supprimer.UseVisualStyleBackColor = false;
            // 
            // FRM_Commande
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 604);
            Controls.Add(Supprimer);
            Controls.Add(Modifier);
            Controls.Add(dvgcommande);
            Controls.Add(panel1);
            Controls.Add(btnajouterclient);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FRM_Commande";
            Text = "FRM_Commande";
            ((System.ComponentModel.ISupportInitialize)dvgcommande).EndInit();
            ((System.ComponentModel.ISupportInitialize)commandeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvgcommande;
        private Panel panel1;
        private Button btnajouterclient;
        private BindingSource commandeBindingSource;
        private DataGridViewTextBoxColumn produitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantiteCommandeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn remiseDataGridViewTextBoxColumn;
        private Button Modifier;
        private Button Supprimer;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateCommandeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lignesCommandeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}