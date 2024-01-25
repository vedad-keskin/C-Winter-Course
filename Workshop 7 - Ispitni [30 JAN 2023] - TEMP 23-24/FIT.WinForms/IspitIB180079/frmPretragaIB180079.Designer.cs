namespace FIT.WinForms.IspitIB180079
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
            label3 = new Label();
            cbSemestar = new ComboBox();
            dtpOd = new DateTimePicker();
            dtpDo = new DateTimePicker();
            label4 = new Label();
            txtImePrezime = new TextBox();
            cbAktivan = new ComboBox();
            label5 = new Label();
            dgvStudentiPredmeti = new DataGridView();
            Indeks = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            Prosjek = new DataGridViewTextBoxColumn();
            DatumRodjenja = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Semestar = new DataGridViewTextBoxColumn();
            Uvjerenja = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudentiPredmeti).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 27);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Semestar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 27);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 1;
            label2.Text = "roden u perioud od:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(718, 32);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 2;
            label3.Text = "do:";
            // 
            // cbSemestar
            // 
            cbSemestar.FormattingEnabled = true;
            cbSemestar.Location = new Point(117, 24);
            cbSemestar.Name = "cbSemestar";
            cbSemestar.Size = new Size(151, 28);
            cbSemestar.TabIndex = 3;
            cbSemestar.SelectedIndexChanged += cbSemestar_SelectedIndexChanged;
            // 
            // dtpOd
            // 
            dtpOd.Location = new Point(445, 27);
            dtpOd.Name = "dtpOd";
            dtpOd.Size = new Size(250, 27);
            dtpOd.TabIndex = 4;
            dtpOd.Value = new DateTime(2000, 1, 21, 21, 29, 0, 0);
            dtpOd.ValueChanged += dtpOd_ValueChanged;
            // 
            // dtpDo
            // 
            dtpDo.Location = new Point(774, 27);
            dtpDo.Name = "dtpDo";
            dtpDo.Size = new Size(250, 27);
            dtpDo.TabIndex = 5;
            dtpDo.ValueChanged += dtpDo_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 80);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 6;
            label4.Text = "Ime i Prezime:";
            // 
            // txtImePrezime
            // 
            txtImePrezime.Location = new Point(163, 80);
            txtImePrezime.Name = "txtImePrezime";
            txtImePrezime.Size = new Size(532, 27);
            txtImePrezime.TabIndex = 7;
            txtImePrezime.TextChanged += txtImePrezime_TextChanged;
            // 
            // cbAktivan
            // 
            cbAktivan.FormattingEnabled = true;
            cbAktivan.Items.AddRange(new object[] { "Svi", "Aktivni", "Neaktivni" });
            cbAktivan.Location = new Point(774, 83);
            cbAktivan.Name = "cbAktivan";
            cbAktivan.Size = new Size(250, 28);
            cbAktivan.TabIndex = 8;
            cbAktivan.SelectedIndexChanged += cbGodina_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(701, 83);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 9;
            label5.Text = "Aktivan:";
            // 
            // dgvStudentiPredmeti
            // 
            dgvStudentiPredmeti.AllowUserToAddRows = false;
            dgvStudentiPredmeti.AllowUserToDeleteRows = false;
            dgvStudentiPredmeti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentiPredmeti.Columns.AddRange(new DataGridViewColumn[] { Indeks, Student, Prosjek, DatumRodjenja, Aktivan, Semestar, Uvjerenja });
            dgvStudentiPredmeti.Location = new Point(41, 123);
            dgvStudentiPredmeti.Name = "dgvStudentiPredmeti";
            dgvStudentiPredmeti.ReadOnly = true;
            dgvStudentiPredmeti.RowHeadersWidth = 51;
            dgvStudentiPredmeti.RowTemplate.Height = 29;
            dgvStudentiPredmeti.Size = new Size(989, 285);
            dgvStudentiPredmeti.TabIndex = 10;
            dgvStudentiPredmeti.CellContentClick += dgvStudentiPredmeti_CellContentClick;
            // 
            // Indeks
            // 
            Indeks.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Indeks.DataPropertyName = "Indeks";
            Indeks.HeaderText = "Broj indeksa";
            Indeks.MinimumWidth = 6;
            Indeks.Name = "Indeks";
            Indeks.ReadOnly = true;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "ImePrezime";
            Student.HeaderText = "Ime i Prezime";
            Student.MinimumWidth = 6;
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // Prosjek
            // 
            Prosjek.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prosjek.DataPropertyName = "Prosjek";
            Prosjek.HeaderText = "Prosjek";
            Prosjek.MinimumWidth = 6;
            Prosjek.Name = "Prosjek";
            Prosjek.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            DatumRodjenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumRodjenja.DataPropertyName = "DatumRodjenja";
            DatumRodjenja.HeaderText = "Datum rodenja";
            DatumRodjenja.MinimumWidth = 6;
            DatumRodjenja.Name = "DatumRodjenja";
            DatumRodjenja.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            // 
            // Semestar
            // 
            Semestar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Semestar.DataPropertyName = "Semestar";
            Semestar.HeaderText = "Semestar";
            Semestar.MinimumWidth = 6;
            Semestar.Name = "Semestar";
            Semestar.ReadOnly = true;
            // 
            // Uvjerenja
            // 
            Uvjerenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Uvjerenja.HeaderText = "";
            Uvjerenja.MinimumWidth = 6;
            Uvjerenja.Name = "Uvjerenja";
            Uvjerenja.ReadOnly = true;
            Uvjerenja.Text = "Uvjerenja";
            Uvjerenja.UseColumnTextForButtonValue = true;
            // 
            // frmPretragaIB180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 468);
            Controls.Add(dgvStudentiPredmeti);
            Controls.Add(label5);
            Controls.Add(cbAktivan);
            Controls.Add(txtImePrezime);
            Controls.Add(label4);
            Controls.Add(dtpDo);
            Controls.Add(dtpOd);
            Controls.Add(cbSemestar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPretragaIB180079";
            Text = "frmPretragaIB180079";
            Load += frmPretragaIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudentiPredmeti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbSemestar;
        private DateTimePicker dtpOd;
        private DateTimePicker dtpDo;
        private Label label4;
        private TextBox txtImePrezime;
        private ComboBox cbAktivan;
        private Label label5;
        private DataGridView dgvStudentiPredmeti;
        private DataGridViewTextBoxColumn Indeks;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Prosjek;
        private DataGridViewTextBoxColumn DatumRodjenja;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewTextBoxColumn Semestar;
        private DataGridViewButtonColumn Uvjerenja;
    }
}