namespace DLWMS.WinForms.IspitIB170074
{
    partial class frmPretragaIB170074
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
            txtImePrezime = new TextBox();
            cbGodina = new ComboBox();
            cbAktivnost = new ComboBox();
            dgvStudenti = new DataGridView();
            BrojIndeksa = new DataGridViewTextBoxColumn();
            Ime = new DataGridViewTextBoxColumn();
            Prezime = new DataGridViewTextBoxColumn();
            Spol = new DataGridViewTextBoxColumn();
            GodinaStudija = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Polozeni = new DataGridViewButtonColumn();
            btnPrintaj = new Button();
            label4 = new Label();
            label5 = new Label();
            lblBrojStudenata = new Label();
            lblProsjek = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Ime i Prezime";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(405, 30);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 0;
            label2.Text = "Godina studija";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(733, 30);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 0;
            label3.Text = "Aktivnost";
            // 
            // txtImePrezime
            // 
            txtImePrezime.Location = new Point(117, 23);
            txtImePrezime.Name = "txtImePrezime";
            txtImePrezime.Size = new Size(212, 27);
            txtImePrezime.TabIndex = 1;
            txtImePrezime.TextChanged += txtImePrezime_TextChanged;
            // 
            // cbGodina
            // 
            cbGodina.FormattingEnabled = true;
            cbGodina.Items.AddRange(new object[] { "Sve", "1", "2", "3" });
            cbGodina.Location = new Point(516, 22);
            cbGodina.Name = "cbGodina";
            cbGodina.Size = new Size(119, 28);
            cbGodina.TabIndex = 2;
            cbGodina.SelectedIndexChanged += cbGodina_SelectedIndexChanged;
            // 
            // cbAktivnost
            // 
            cbAktivnost.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAktivnost.FormattingEnabled = true;
            cbAktivnost.Items.AddRange(new object[] { "Svi", "Aktivni", "Neaktivni" });
            cbAktivnost.Location = new Point(809, 22);
            cbAktivnost.Name = "cbAktivnost";
            cbAktivnost.Size = new Size(119, 28);
            cbAktivnost.TabIndex = 2;
            cbAktivnost.SelectedIndexChanged += cbAktivnost_SelectedIndexChanged;
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { BrojIndeksa, Ime, Prezime, Spol, GodinaStudija, Aktivan, Polozeni });
            dgvStudenti.Location = new Point(12, 85);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowHeadersWidth = 51;
            dgvStudenti.RowTemplate.Height = 29;
            dgvStudenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudenti.Size = new Size(961, 293);
            dgvStudenti.TabIndex = 3;
            // 
            // BrojIndeksa
            // 
            BrojIndeksa.DataPropertyName = "BrojIndeksa";
            BrojIndeksa.HeaderText = "Indeks";
            BrojIndeksa.MinimumWidth = 6;
            BrojIndeksa.Name = "BrojIndeksa";
            BrojIndeksa.ReadOnly = true;
            BrojIndeksa.Width = 125;
            // 
            // Ime
            // 
            Ime.DataPropertyName = "Ime";
            Ime.HeaderText = "Ime";
            Ime.MinimumWidth = 6;
            Ime.Name = "Ime";
            Ime.ReadOnly = true;
            Ime.Width = 125;
            // 
            // Prezime
            // 
            Prezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prezime.DataPropertyName = "Prezime";
            Prezime.HeaderText = "Prezime";
            Prezime.MinimumWidth = 6;
            Prezime.Name = "Prezime";
            Prezime.ReadOnly = true;
            // 
            // Spol
            // 
            Spol.DataPropertyName = "Spol";
            Spol.HeaderText = "Spol";
            Spol.MinimumWidth = 6;
            Spol.Name = "Spol";
            Spol.ReadOnly = true;
            Spol.Width = 125;
            // 
            // GodinaStudija
            // 
            GodinaStudija.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GodinaStudija.DataPropertyName = "GodinaStudija";
            GodinaStudija.HeaderText = "Godina Studija";
            GodinaStudija.MinimumWidth = 6;
            GodinaStudija.Name = "GodinaStudija";
            GodinaStudija.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            Aktivan.Resizable = DataGridViewTriState.True;
            Aktivan.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Polozeni
            // 
            Polozeni.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Polozeni.HeaderText = "Polozeni";
            Polozeni.MinimumWidth = 6;
            Polozeni.Name = "Polozeni";
            Polozeni.ReadOnly = true;
            Polozeni.Text = "Polozeni";
            Polozeni.UseColumnTextForButtonValue = true;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(879, 401);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(94, 29);
            btnPrintaj.TabIndex = 4;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += btnPrintaj_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 390);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 5;
            label4.Text = "Broj studenata:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 419);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 5;
            label5.Text = "Prosjecna ocjena:";
            // 
            // lblBrojStudenata
            // 
            lblBrojStudenata.Location = new Point(120, 385);
            lblBrojStudenata.Name = "lblBrojStudenata";
            lblBrojStudenata.Size = new Size(105, 25);
            lblBrojStudenata.TabIndex = 6;
            // 
            // lblProsjek
            // 
            lblProsjek.Location = new Point(141, 419);
            lblProsjek.Name = "lblProsjek";
            lblProsjek.Size = new Size(115, 20);
            lblProsjek.TabIndex = 6;
            // 
            // frmPretragaIB170074
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 459);
            Controls.Add(lblProsjek);
            Controls.Add(lblBrojStudenata);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnPrintaj);
            Controls.Add(dgvStudenti);
            Controls.Add(cbAktivnost);
            Controls.Add(cbGodina);
            Controls.Add(txtImePrezime);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPretragaIB170074";
            Text = "frmPretragaIB170074";
            Load += frmPretragaIB170074_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtImePrezime;
        private ComboBox cbGodina;
        private ComboBox cbAktivnost;
        private DataGridView dgvStudenti;
        private Button btnPrintaj;
        private Label label4;
        private Label label5;
        private Label lblBrojStudenata;
        private Label lblProsjek;
        private DataGridViewTextBoxColumn BrojIndeksa;
        private DataGridViewTextBoxColumn Ime;
        private DataGridViewTextBoxColumn Prezime;
        private DataGridViewTextBoxColumn Spol;
        private DataGridViewTextBoxColumn GodinaStudija;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Polozeni;
    }
}