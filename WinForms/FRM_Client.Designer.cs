namespace WinForms
{
    partial class FRM_Client
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
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            prenomDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adresseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            villeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telephoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clientBindingSource = new BindingSource(components);
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            btnmodifierclient = new Button();
            btnsupprimerclient = new Button();
            btnajouterclient = new Button();
            RechercheClient = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dvgclient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dvgclient
            // 
            dvgclient.AllowUserToAddRows = false;
            dvgclient.AutoGenerateColumns = false;
            dvgclient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgclient.BackgroundColor = SystemColors.Control;
            dvgclient.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 28, 38);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dvgclient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dvgclient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgclient.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomDataGridViewTextBoxColumn, prenomDataGridViewTextBoxColumn, adresseDataGridViewTextBoxColumn, villeDataGridViewTextBoxColumn, telephoneDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn });
            dvgclient.DataSource = clientBindingSource;
            dvgclient.EnableHeadersVisualStyles = false;
            dvgclient.Location = new Point(35, 176);
            dvgclient.Name = "dvgclient";
            dvgclient.RowHeadersVisible = false;
            dvgclient.RowHeadersWidth = 51;
            dvgclient.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dvgclient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgclient.Size = new Size(1005, 386);
            dvgclient.TabIndex = 17;
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
            // prenomDataGridViewTextBoxColumn
            // 
            prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            prenomDataGridViewTextBoxColumn.MinimumWidth = 6;
            prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            adresseDataGridViewTextBoxColumn.MinimumWidth = 6;
            adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            // 
            // villeDataGridViewTextBoxColumn
            // 
            villeDataGridViewTextBoxColumn.DataPropertyName = "Ville";
            villeDataGridViewTextBoxColumn.HeaderText = "Ville";
            villeDataGridViewTextBoxColumn.MinimumWidth = 6;
            villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            telephoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // clientBindingSource
            // 
            clientBindingSource.DataSource = typeof(StockLibrary.Entities.Client);
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 28, 38);
            panel3.Location = new Point(643, 154);
            panel3.Name = "panel3";
            panel3.Size = new Size(334, 3);
            panel3.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(30, 28, 38);
            panel2.Location = new Point(41, 176);
            panel2.Name = "panel2";
            panel2.Size = new Size(1212, 3);
            panel2.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(30, 28, 38);
            panel1.Location = new Point(12, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(1212, 3);
            panel1.TabIndex = 12;
            // 
            // btnmodifierclient
            // 
            btnmodifierclient.BackColor = Color.FromArgb(30, 28, 38);
            btnmodifierclient.FlatAppearance.BorderSize = 0;
            btnmodifierclient.FlatStyle = FlatStyle.Flat;
            btnmodifierclient.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmodifierclient.ForeColor = SystemColors.ControlLightLight;
            btnmodifierclient.ImageAlign = ContentAlignment.MiddleLeft;
            btnmodifierclient.Location = new Point(364, 30);
            btnmodifierclient.Name = "btnmodifierclient";
            btnmodifierclient.Size = new Size(307, 53);
            btnmodifierclient.TabIndex = 11;
            btnmodifierclient.Text = "Modifier";
            btnmodifierclient.UseVisualStyleBackColor = false;
            btnmodifierclient.Click += btnmodifierclient_Click;
            // 
            // btnsupprimerclient
            // 
            btnsupprimerclient.BackColor = Color.FromArgb(30, 28, 38);
            btnsupprimerclient.FlatAppearance.BorderSize = 0;
            btnsupprimerclient.FlatStyle = FlatStyle.Flat;
            btnsupprimerclient.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsupprimerclient.ForeColor = SystemColors.ControlLightLight;
            btnsupprimerclient.ImageAlign = ContentAlignment.MiddleLeft;
            btnsupprimerclient.Location = new Point(693, 30);
            btnsupprimerclient.Name = "btnsupprimerclient";
            btnsupprimerclient.Size = new Size(347, 53);
            btnsupprimerclient.TabIndex = 10;
            btnsupprimerclient.Text = "Supprimer";
            btnsupprimerclient.UseVisualStyleBackColor = false;
            btnsupprimerclient.Click += btnsupprimerclient_Click;
            // 
            // btnajouterclient
            // 
            btnajouterclient.BackColor = Color.FromArgb(30, 28, 38);
            btnajouterclient.FlatAppearance.BorderSize = 0;
            btnajouterclient.FlatStyle = FlatStyle.Flat;
            btnajouterclient.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnajouterclient.ForeColor = SystemColors.ControlLightLight;
            btnajouterclient.ImageAlign = ContentAlignment.MiddleLeft;
            btnajouterclient.Location = new Point(41, 30);
            btnajouterclient.Name = "btnajouterclient";
            btnajouterclient.Size = new Size(290, 53);
            btnajouterclient.TabIndex = 9;
            btnajouterclient.Text = "Ajouter";
            btnajouterclient.UseVisualStyleBackColor = false;
            btnajouterclient.Click += btnajouterclient_Click;
            // 
            // RechercheClient
            // 
            RechercheClient.BackColor = SystemColors.Control;
            RechercheClient.BorderStyle = BorderStyle.None;
            RechercheClient.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RechercheClient.ForeColor = Color.DimGray;
            RechercheClient.Location = new Point(643, 115);
            RechercheClient.Multiline = true;
            RechercheClient.Name = "RechercheClient";
            RechercheClient.PlaceholderText = "Recherche";
            RechercheClient.Size = new Size(334, 33);
            RechercheClient.TabIndex = 14;
            RechercheClient.TextAlign = HorizontalAlignment.Center;
            RechercheClient.TextChanged += RechercheClient_TextChanged;
            // 
            // FRM_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 580);
            Controls.Add(dvgclient);
            Controls.Add(panel3);
            Controls.Add(RechercheClient);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnmodifierclient);
            Controls.Add(btnsupprimerclient);
            Controls.Add(btnajouterclient);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FRM_Client";
            Text = "FRM_Client";
            ((System.ComponentModel.ISupportInitialize)dvgclient).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dvgclient;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Button btnmodifierclient;
        private Button btnsupprimerclient;
        private Button btnajouterclient;
        private TextBox RechercheClient;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private BindingSource clientBindingSource;
    }
}