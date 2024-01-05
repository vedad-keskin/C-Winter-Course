namespace DLWMS.WinForms.IB170074
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
            cbOcjenaOd = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpDatumOd = new DateTimePicker();
            dtpDatumDo = new DateTimePicker();
            label5 = new Label();
            chbAktivan = new CheckBox();
            cbOcjenaDo = new ComboBox();
            dgvStudentiPredmeti = new DataGridView();
            BrojIndeksa = new DataGridViewTextBoxColumn();
            StudentPodaci = new DataGridViewTextBoxColumn();
            PredmetPodaci = new DataGridViewTextBoxColumn();
            Ocjena = new DataGridViewTextBoxColumn();
            Datum = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Poruke = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudentiPredmeti).BeginInit();
            SuspendLayout();
            // 
            // cbOcjenaOd
            // 
            cbOcjenaOd.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOcjenaOd.FormattingEnabled = true;
            cbOcjenaOd.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cbOcjenaOd.Location = new Point(78, 9);
            cbOcjenaOd.Margin = new Padding(3, 2, 3, 2);
            cbOcjenaOd.Name = "cbOcjenaOd";
            cbOcjenaOd.Size = new Size(74, 23);
            cbOcjenaOd.TabIndex = 0;
            cbOcjenaOd.SelectedIndexChanged += cbOcjenaOd_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 11);
            label1.Name = "label1";
            label1.Size = new Size(10, 15);
            label1.TabIndex = 1;
            label1.Text = " ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 11);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "Ocjena od";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 11);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 2;
            label3.Text = "do";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(289, 11);
            label4.Name = "label4";
            label4.Size = new Size(126, 15);
            label4.TabIndex = 2;
            label4.Text = "polozena u periodu od";
            // 
            // dtpDatumOd
            // 
            dtpDatumOd.Location = new Point(424, 10);
            dtpDatumOd.Margin = new Padding(3, 2, 3, 2);
            dtpDatumOd.Name = "dtpDatumOd";
            dtpDatumOd.Size = new Size(219, 23);
            dtpDatumOd.TabIndex = 3;
            dtpDatumOd.ValueChanged += dtpDatumOd_ValueChanged;
            // 
            // dtpDatumDo
            // 
            dtpDatumDo.Location = new Point(691, 9);
            dtpDatumDo.Margin = new Padding(3, 2, 3, 2);
            dtpDatumDo.Name = "dtpDatumDo";
            dtpDatumDo.Size = new Size(219, 23);
            dtpDatumDo.TabIndex = 3;
            dtpDatumDo.ValueChanged += dtpDatumDo_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(657, 14);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 2;
            label5.Text = "do";
            // 
            // chbAktivan
            // 
            chbAktivan.AutoSize = true;
            chbAktivan.Location = new Point(928, 11);
            chbAktivan.Margin = new Padding(3, 2, 3, 2);
            chbAktivan.Name = "chbAktivan";
            chbAktivan.Size = new Size(110, 19);
            chbAktivan.TabIndex = 4;
            chbAktivan.Text = "Student Aktivan";
            chbAktivan.UseVisualStyleBackColor = true;
            chbAktivan.CheckedChanged += chbAktivan_CheckedChanged;
            // 
            // cbOcjenaDo
            // 
            cbOcjenaDo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOcjenaDo.FormattingEnabled = true;
            cbOcjenaDo.Items.AddRange(new object[] { "10", "9", "8", "7", "6" });
            cbOcjenaDo.Location = new Point(194, 9);
            cbOcjenaDo.Margin = new Padding(3, 2, 3, 2);
            cbOcjenaDo.Name = "cbOcjenaDo";
            cbOcjenaDo.Size = new Size(83, 23);
            cbOcjenaDo.TabIndex = 0;
            cbOcjenaDo.SelectedIndexChanged += cbOcjenaDo_SelectedIndexChanged;
            // 
            // dgvStudentiPredmeti
            // 
            dgvStudentiPredmeti.AllowUserToAddRows = false;
            dgvStudentiPredmeti.AllowUserToDeleteRows = false;
            dgvStudentiPredmeti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentiPredmeti.Columns.AddRange(new DataGridViewColumn[] { BrojIndeksa, StudentPodaci, PredmetPodaci, Ocjena, Datum, Aktivan, Poruke });
            dgvStudentiPredmeti.Location = new Point(10, 43);
            dgvStudentiPredmeti.Margin = new Padding(3, 2, 3, 2);
            dgvStudentiPredmeti.Name = "dgvStudentiPredmeti";
            dgvStudentiPredmeti.ReadOnly = true;
            dgvStudentiPredmeti.RowHeadersWidth = 51;
            dgvStudentiPredmeti.RowTemplate.Height = 29;
            dgvStudentiPredmeti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudentiPredmeti.Size = new Size(1028, 245);
            dgvStudentiPredmeti.TabIndex = 5;
            dgvStudentiPredmeti.CellContentClick += dgvStudentiPredmeti_CellContentClick;
            // 
            // BrojIndeksa
            // 
            BrojIndeksa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BrojIndeksa.DataPropertyName = "BrojIndeksa";
            BrojIndeksa.HeaderText = "Broj Indeksa";
            BrojIndeksa.MinimumWidth = 6;
            BrojIndeksa.Name = "BrojIndeksa";
            BrojIndeksa.ReadOnly = true;
            // 
            // StudentPodaci
            // 
            StudentPodaci.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentPodaci.DataPropertyName = "StudentPodaci";
            StudentPodaci.HeaderText = "Student";
            StudentPodaci.MinimumWidth = 6;
            StudentPodaci.Name = "StudentPodaci";
            StudentPodaci.ReadOnly = true;
            // 
            // PredmetPodaci
            // 
            PredmetPodaci.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PredmetPodaci.DataPropertyName = "PredmetPodaci";
            PredmetPodaci.HeaderText = "Predmet";
            PredmetPodaci.MinimumWidth = 6;
            PredmetPodaci.Name = "PredmetPodaci";
            PredmetPodaci.ReadOnly = true;
            // 
            // Ocjena
            // 
            Ocjena.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ocjena.DataPropertyName = "Ocjena";
            Ocjena.HeaderText = "Ocjena";
            Ocjena.MinimumWidth = 6;
            Ocjena.Name = "Ocjena";
            Ocjena.ReadOnly = true;
            // 
            // Datum
            // 
            Datum.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Datum.DataPropertyName = "Datum";
            Datum.HeaderText = "Datum Polaganja";
            Datum.MinimumWidth = 6;
            Datum.Name = "Datum";
            Datum.ReadOnly = true;
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
            // Poruke
            // 
            Poruke.HeaderText = "Poruke";
            Poruke.MinimumWidth = 6;
            Poruke.Name = "Poruke";
            Poruke.ReadOnly = true;
            Poruke.Text = "Poruke";
            Poruke.UseColumnTextForButtonValue = true;
            Poruke.Width = 125;
            // 
            // frmPretragaIB170074
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 296);
            Controls.Add(dgvStudentiPredmeti);
            Controls.Add(chbAktivan);
            Controls.Add(dtpDatumDo);
            Controls.Add(dtpDatumOd);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbOcjenaDo);
            Controls.Add(cbOcjenaOd);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPretragaIB170074";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pretraga studenata";
            Load += frmPretragaIB170074_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudentiPredmeti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbOcjenaOd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpDatumOd;
        private DateTimePicker dtpDatumDo;
        private Label label5;
        private CheckBox chbAktivan;
        private ComboBox cbOcjenaDo;
        private DataGridView dgvStudentiPredmeti;
        private DataGridViewTextBoxColumn BrojIndeksa;
        private DataGridViewTextBoxColumn StudentPodaci;
        private DataGridViewTextBoxColumn PredmetPodaci;
        private DataGridViewTextBoxColumn Ocjena;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Poruke;
    }
}