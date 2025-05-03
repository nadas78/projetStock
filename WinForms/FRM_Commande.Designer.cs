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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dvgclient = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            panel1 = new Panel();
            btnajouterclient = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgclient).BeginInit();
            SuspendLayout();
            // 
            // dvgclient
            // 
            dvgclient.AllowUserToAddRows = false;
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
            dvgclient.EnableHeadersVisualStyles = false;
            dvgclient.GridColor = Color.PaleVioletRed;
            dvgclient.Location = new Point(45, 132);
            dvgclient.Name = "dvgclient";
            dvgclient.RowHeadersVisible = false;
            dvgclient.RowHeadersWidth = 51;
            dvgclient.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dvgclient.Size = new Size(988, 456);
            dvgclient.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(717, 37);
            label2.Name = "label2";
            label2.Size = new Size(124, 31);
            label2.TabIndex = 46;
            label2.Text = "Date Fin:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(318, 36);
            label1.Name = "label1";
            label1.Size = new Size(166, 31);
            label1.TabIndex = 45;
            label1.Text = "Date Début :";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(839, 41);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(219, 27);
            dateTimePicker2.TabIndex = 44;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(490, 40);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(204, 27);
            dateTimePicker1.TabIndex = 43;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(30, 28, 38);
            panel1.Location = new Point(-33, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(1228, 5);
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
            // 
            // FRM_Commande
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 616);
            Controls.Add(dvgclient);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(panel1);
            Controls.Add(btnajouterclient);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FRM_Commande";
            Text = "FRM_Commande";
            ((System.ComponentModel.ISupportInitialize)dvgclient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvgclient;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Panel panel1;
        private Button btnajouterclient;
    }
}