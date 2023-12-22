namespace DLWMS.WinForms.IspitIB180079
{
    partial class frmPretragaIB180079
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
            label1 = new Label();
            label2 = new Label();
            txtPretraga = new TextBox();
            cbGodina = new ComboBox();
            dgvStudenti = new DataGridView();
            Student = new DataGridViewTextBoxColumn();
            Godina = new DataGridViewTextBoxColumn();
            Prosjek = new DataGridViewTextBoxColumn();
            Konsultacije = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Ime ili prezime : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(689, 9);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 0;
            label2.Text = "Godina studija :";
            // 
            // txtPretraga
            // 
            txtPretraga.Location = new Point(111, 6);
            txtPretraga.Name = "txtPretraga";
            txtPretraga.Size = new Size(562, 23);
            txtPretraga.TabIndex = 1;
            txtPretraga.TextChanged += txtPretraga_TextChanged;
            // 
            // cbGodina
            // 
            cbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGodina.FormattingEnabled = true;
            cbGodina.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cbGodina.Location = new Point(784, 6);
            cbGodina.Name = "cbGodina";
            cbGodina.Size = new Size(121, 23);
            cbGodina.TabIndex = 2;
            cbGodina.SelectedIndexChanged += cbGodina_SelectedIndexChanged;
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { Student, Godina, Prosjek, Konsultacije });
            dgvStudenti.Location = new Point(12, 35);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowTemplate.Height = 25;
            dgvStudenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudenti.Size = new Size(893, 278);
            dgvStudenti.TabIndex = 3;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "Ime i prezime";
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // Godina
            // 
            Godina.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Godina.DataPropertyName = "Godina";
            Godina.HeaderText = "Godina studija";
            Godina.Name = "Godina";
            Godina.ReadOnly = true;
            // 
            // Prosjek
            // 
            Prosjek.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prosjek.DataPropertyName = "Prosjek";
            Prosjek.HeaderText = "Prosjecna ocjena";
            Prosjek.Name = "Prosjek";
            Prosjek.ReadOnly = true;
            // 
            // Konsultacije
            // 
            Konsultacije.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Konsultacije.HeaderText = "";
            Konsultacije.Name = "Konsultacije";
            Konsultacije.ReadOnly = true;
            Konsultacije.Text = "Konsultacije";
            Konsultacije.UseColumnTextForButtonValue = true;
            // 
            // frmPretragaIB180079
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 325);
            Controls.Add(dgvStudenti);
            Controls.Add(cbGodina);
            Controls.Add(txtPretraga);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPretragaIB180079";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pretraga";
            Load += frmPretragaIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPretraga;
        private ComboBox cbGodina;
        private DataGridView dgvStudenti;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Godina;
        private DataGridViewTextBoxColumn Prosjek;
        private DataGridViewButtonColumn Konsultacije;
    }
}