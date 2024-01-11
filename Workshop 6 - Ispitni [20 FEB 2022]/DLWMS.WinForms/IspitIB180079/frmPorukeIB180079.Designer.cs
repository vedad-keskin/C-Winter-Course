namespace DLWMS.WinForms.IspitIB180079
{
    partial class frmPorukeIB180079
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
            lblStudent = new Label();
            dgvPoruke = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Sadrzaj = new DataGridViewTextBoxColumn();
            Slika = new DataGridViewImageColumn();
            Validnost = new DataGridViewTextBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPoruke).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 14);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Poruke studenta :";
            // 
            // lblStudent
            // 
            lblStudent.Location = new Point(122, 14);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(299, 15);
            lblStudent.TabIndex = 0;
            // 
            // dgvPoruke
            // 
            dgvPoruke.AllowUserToAddRows = false;
            dgvPoruke.AllowUserToDeleteRows = false;
            dgvPoruke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPoruke.Columns.AddRange(new DataGridViewColumn[] { Predmet, Sadrzaj, Slika, Validnost, Brisi });
            dgvPoruke.Location = new Point(10, 40);
            dgvPoruke.Margin = new Padding(3, 2, 3, 2);
            dgvPoruke.Name = "dgvPoruke";
            dgvPoruke.ReadOnly = true;
            dgvPoruke.RowHeadersWidth = 51;
            dgvPoruke.RowTemplate.Height = 29;
            dgvPoruke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPoruke.Size = new Size(887, 204);
            dgvPoruke.TabIndex = 1;
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
            // Sadrzaj
            // 
            Sadrzaj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Sadrzaj.DataPropertyName = "Sadrzaj";
            Sadrzaj.HeaderText = "Sadrzaj";
            Sadrzaj.MinimumWidth = 6;
            Sadrzaj.Name = "Sadrzaj";
            Sadrzaj.ReadOnly = true;
            // 
            // Slika
            // 
            Slika.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Slika.DataPropertyName = "Slika";
            Slika.HeaderText = "Slika";
            Slika.MinimumWidth = 6;
            Slika.Name = "Slika";
            Slika.ReadOnly = true;
            // 
            // Validnost
            // 
            Validnost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Validnost.DataPropertyName = "Validnost";
            Validnost.HeaderText = "Validnost";
            Validnost.MinimumWidth = 6;
            Validnost.Name = "Validnost";
            Validnost.ReadOnly = true;
            // 
            // Brisi
            // 
            Brisi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Brisi.HeaderText = "";
            Brisi.MinimumWidth = 6;
            Brisi.Name = "Brisi";
            Brisi.ReadOnly = true;
            // 
            // button1
            // 
            button1.Location = new Point(766, 256);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(132, 22);
            button1.TabIndex = 2;
            button1.Text = "Printaj";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(766, 14);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(132, 22);
            button2.TabIndex = 2;
            button2.Text = "Nova poruka";
            button2.UseVisualStyleBackColor = true;
            // 
            // frmPorukeIB180079
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 290);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvPoruke);
            Controls.Add(lblStudent);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPorukeIB180079";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPorukeIB180079";
            Load += frmPorukeIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPoruke).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblStudent;
        private DataGridView dgvPoruke;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Sadrzaj;
        private DataGridViewImageColumn Slika;
        private DataGridViewTextBoxColumn Validnost;
        private DataGridViewButtonColumn Brisi;
        private Button button1;
        private Button button2;
    }
}