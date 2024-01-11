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
            label3 = new Label();
            label4 = new Label();
            cbOcjenaDo = new ComboBox();
            cbOcjenaOd = new ComboBox();
            dtpDatumOd = new DateTimePicker();
            dtpDatumDo = new DateTimePicker();
            dgvStudentiPredmeti = new DataGridView();
            BrojIndeksa = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            Predmet = new DataGridViewTextBoxColumn();
            Ocjena = new DataGridViewTextBoxColumn();
            Datum = new DataGridViewTextBoxColumn();
            Poruke = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudentiPredmeti).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Ocjena od";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 7);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 0;
            label2.Text = "do";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(301, 7);
            label3.Name = "label3";
            label3.Size = new Size(126, 15);
            label3.TabIndex = 0;
            label3.Text = "položena u periodu od";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(680, 8);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 0;
            label4.Text = "do";
            // 
            // cbOcjenaDo
            // 
            cbOcjenaDo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOcjenaDo.FormattingEnabled = true;
            cbOcjenaDo.Items.AddRange(new object[] { "10", "9", "8", "7", "6" });
            cbOcjenaDo.Location = new Point(211, 4);
            cbOcjenaDo.Margin = new Padding(3, 2, 3, 2);
            cbOcjenaDo.Name = "cbOcjenaDo";
            cbOcjenaDo.Size = new Size(77, 23);
            cbOcjenaDo.TabIndex = 1;
            cbOcjenaDo.SelectedIndexChanged += cbOcjenaDo_SelectedIndexChanged;
            // 
            // cbOcjenaOd
            // 
            cbOcjenaOd.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOcjenaOd.FormattingEnabled = true;
            cbOcjenaOd.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cbOcjenaOd.Location = new Point(83, 4);
            cbOcjenaOd.Margin = new Padding(3, 2, 3, 2);
            cbOcjenaOd.Name = "cbOcjenaOd";
            cbOcjenaOd.Size = new Size(77, 23);
            cbOcjenaOd.TabIndex = 1;
            cbOcjenaOd.SelectedIndexChanged += cbOcjenaOd_SelectedIndexChanged;
            // 
            // dtpDatumOd
            // 
            dtpDatumOd.Location = new Point(447, 7);
            dtpDatumOd.Margin = new Padding(3, 2, 3, 2);
            dtpDatumOd.Name = "dtpDatumOd";
            dtpDatumOd.Size = new Size(219, 23);
            dtpDatumOd.TabIndex = 2;
            dtpDatumOd.Value = new DateTime(2020, 1, 11, 15, 16, 0, 0);
            dtpDatumOd.ValueChanged += dtpDatumOd_ValueChanged;
            // 
            // dtpDatumDo
            // 
            dtpDatumDo.Location = new Point(713, 6);
            dtpDatumDo.Margin = new Padding(3, 2, 3, 2);
            dtpDatumDo.Name = "dtpDatumDo";
            dtpDatumDo.Size = new Size(219, 23);
            dtpDatumDo.TabIndex = 2;
            dtpDatumDo.ValueChanged += dtpDatumDo_ValueChanged;
            // 
            // dgvStudentiPredmeti
            // 
            dgvStudentiPredmeti.AllowUserToAddRows = false;
            dgvStudentiPredmeti.AllowUserToDeleteRows = false;
            dgvStudentiPredmeti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentiPredmeti.Columns.AddRange(new DataGridViewColumn[] { BrojIndeksa, Student, Predmet, Ocjena, Datum, Poruke });
            dgvStudentiPredmeti.Location = new Point(10, 30);
            dgvStudentiPredmeti.Margin = new Padding(3, 2, 3, 2);
            dgvStudentiPredmeti.Name = "dgvStudentiPredmeti";
            dgvStudentiPredmeti.ReadOnly = true;
            dgvStudentiPredmeti.RowHeadersWidth = 51;
            dgvStudentiPredmeti.RowTemplate.Height = 29;
            dgvStudentiPredmeti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudentiPredmeti.Size = new Size(921, 218);
            dgvStudentiPredmeti.TabIndex = 3;
            dgvStudentiPredmeti.CellContentClick += dgvStudentiPredmeti_CellContentClick;
            // 
            // BrojIndeksa
            // 
            BrojIndeksa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BrojIndeksa.DataPropertyName = "BrojIndeksa";
            BrojIndeksa.HeaderText = "Indeks";
            BrojIndeksa.MinimumWidth = 6;
            BrojIndeksa.Name = "BrojIndeksa";
            BrojIndeksa.ReadOnly = true;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "Ime i prezime";
            Student.MinimumWidth = 6;
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.MinimumWidth = 6;
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
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
            Datum.HeaderText = "DatumPolaganja";
            Datum.MinimumWidth = 6;
            Datum.Name = "Datum";
            Datum.ReadOnly = true;
            // 
            // Poruke
            // 
            Poruke.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Poruke.HeaderText = "";
            Poruke.MinimumWidth = 6;
            Poruke.Name = "Poruke";
            Poruke.ReadOnly = true;
            Poruke.Text = "Poruke";
            Poruke.UseColumnTextForButtonValue = true;
            // 
            // frmPretragaIB180079
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 260);
            Controls.Add(dgvStudentiPredmeti);
            Controls.Add(dtpDatumDo);
            Controls.Add(dtpDatumOd);
            Controls.Add(cbOcjenaOd);
            Controls.Add(cbOcjenaDo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPretragaIB180079";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPretragaIB180089";
            Load += frmPretragaIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudentiPredmeti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbOcjenaDo;
        private ComboBox cbOcjenaOd;
        private DateTimePicker dtpDatumOd;
        private DateTimePicker dtpDatumDo;
        private DataGridView dgvStudentiPredmeti;
        private DataGridViewTextBoxColumn BrojIndeksa;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Ocjena;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewButtonColumn Poruke;
    }
}