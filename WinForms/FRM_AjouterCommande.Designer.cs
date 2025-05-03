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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label6 = new Label();
            dataGridView1 = new DataGridView();
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
            button2 = new Button();
            textBoxtotalttc = new TextBox();
            groupBox3 = new GroupBox();
            dvgCommande = new DataGridView();
            label8 = new Label();
            label9 = new Label();
            textBoxtvacommand = new TextBox();
            label10 = new Label();
            textBoxtotalhtt = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgCommande).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Elephant", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(480, 182);
            label6.Name = "label6";
            label6.Size = new Size(211, 30);
            label6.TabIndex = 69;
            label6.Text = "Date Commande:";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(4, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(319, 462);
            dataGridView1.TabIndex = 25;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Crimson;
            groupBox1.Location = new Point(9, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(324, 547);
            groupBox1.TabIndex = 66;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produit";
            // 
            // panel3
            // 
            panel3.BackColor = Color.PaleVioletRed;
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
            textBox1.ForeColor = Color.HotPink;
            textBox1.Location = new Point(27, 30);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 33);
            textBox1.TabIndex = 23;
            textBox1.Text = "Recherche";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(686, 185);
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
            panel2.Size = new Size(1395, 10);
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
            label3.ForeColor = Color.PaleVioletRed;
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
            // button2
            // 
            button2.BackColor = Color.FromArgb(178, 5, 55);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(554, 516);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(221, 59);
            button2.TabIndex = 72;
            button2.Text = "Enregistrer";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBoxtotalttc
            // 
            textBoxtotalttc.Enabled = false;
            textBoxtotalttc.Location = new Point(535, 248);
            textBoxtotalttc.Multiline = true;
            textBoxtotalttc.Name = "textBoxtotalttc";
            textBoxtotalttc.Size = new Size(123, 40);
            textBoxtotalttc.TabIndex = 30;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxtotalttc);
            groupBox3.Controls.Add(dvgCommande);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(textBoxtvacommand);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(textBoxtotalhtt);
            groupBox3.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.Crimson;
            groupBox3.Location = new Point(356, 215);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(658, 294);
            groupBox3.TabIndex = 68;
            groupBox3.TabStop = false;
            groupBox3.Text = "Commande";
            // 
            // dvgCommande
            // 
            dvgCommande.AllowUserToAddRows = false;
            dvgCommande.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgCommande.BackgroundColor = SystemColors.Control;
            dvgCommande.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.PaleVioletRed;
            dataGridViewCellStyle2.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dvgCommande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dvgCommande.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgCommande.EnableHeadersVisualStyles = false;
            dvgCommande.GridColor = Color.PaleVioletRed;
            dvgCommande.Location = new Point(6, 36);
            dvgCommande.Name = "dvgCommande";
            dvgCommande.RowHeadersVisible = false;
            dvgCommande.RowHeadersWidth = 51;
            dvgCommande.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dvgCommande.Size = new Size(646, 206);
            dvgCommande.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.PaleVioletRed;
            label8.Location = new Point(428, 251);
            label8.Name = "label8";
            label8.Size = new Size(101, 22);
            label8.TabIndex = 29;
            label8.Text = "Total_TTC:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.PaleVioletRed;
            label9.Location = new Point(255, 248);
            label9.Name = "label9";
            label9.Size = new Size(48, 22);
            label9.TabIndex = 27;
            label9.Text = "TVA:";
            // 
            // textBoxtvacommand
            // 
            textBoxtvacommand.Enabled = false;
            textBoxtvacommand.Location = new Point(309, 248);
            textBoxtvacommand.Multiline = true;
            textBoxtvacommand.Name = "textBoxtvacommand";
            textBoxtvacommand.Size = new Size(96, 40);
            textBoxtvacommand.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.PaleVioletRed;
            label10.Location = new Point(19, 248);
            label10.Name = "label10";
            label10.Size = new Size(92, 22);
            label10.TabIndex = 25;
            label10.Text = "Total_HT:";
            // 
            // textBoxtotalhtt
            // 
            textBoxtotalhtt.Enabled = false;
            textBoxtotalhtt.Location = new Point(111, 248);
            textBoxtotalhtt.Multiline = true;
            textBoxtotalhtt.Name = "textBoxtotalhtt";
            textBoxtotalhtt.Size = new Size(125, 40);
            textBoxtotalhtt.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.PaleVioletRed;
            label4.Location = new Point(224, 84);
            label4.Name = "label4";
            label4.Size = new Size(93, 22);
            label4.TabIndex = 8;
            label4.Text = "Adresse :";
            // 
            // textBoxemaiclient
            // 
            textBoxemaiclient.Enabled = false;
            textBoxemaiclient.Location = new Point(70, 78);
            textBoxemaiclient.Multiline = true;
            textBoxemaiclient.Name = "textBoxemaiclient";
            textBoxemaiclient.Size = new Size(146, 40);
            textBoxemaiclient.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.PaleVioletRed;
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
            label2.ForeColor = Color.PaleVioletRed;
            label2.Location = new Point(366, 36);
            label2.Name = "label2";
            label2.Size = new Size(105, 22);
            label2.TabIndex = 4;
            label2.Text = "Telephone:";
            // 
            // textBoxprenomClient
            // 
            textBoxprenomClient.Enabled = false;
            textBoxprenomClient.Location = new Point(252, 33);
            textBoxprenomClient.Multiline = true;
            textBoxprenomClient.Name = "textBoxprenomClient";
            textBoxprenomClient.Size = new Size(96, 34);
            textBoxprenomClient.TabIndex = 3;
            // 
            // Prenom
            // 
            Prenom.AutoSize = true;
            Prenom.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Prenom.ForeColor = Color.PaleVioletRed;
            Prenom.Location = new Point(167, 33);
            Prenom.Name = "Prenom";
            Prenom.Size = new Size(91, 22);
            Prenom.TabIndex = 2;
            Prenom.Text = "Prenom :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.PaleVioletRed;
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
            groupBox2.ForeColor = Color.Crimson;
            groupBox2.Location = new Point(356, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(658, 137);
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
            // FRM_AjouterCommande
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 598);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FRM_AjouterCommande";
            Text = "FRM_AjouterCommande";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgCommande).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private Button button2;
        private TextBox textBoxtotalttc;
        private GroupBox groupBox3;
        private DataGridView dvgCommande;
        private Label label8;
        private Label label9;
        private TextBox textBoxtvacommand;
        private Label label10;
        private TextBox textBoxtotalhtt;
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
    }
}