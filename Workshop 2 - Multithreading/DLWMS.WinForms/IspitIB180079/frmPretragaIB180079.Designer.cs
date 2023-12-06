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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtPretraga = new TextBox();
            dgvStudentiPredmeti = new DataGridView();
            Student = new DataGridViewTextBoxColumn();
            Predmet = new DataGridViewTextBoxColumn();
            Datum = new DataGridViewTextBoxColumn();
            Ocjena = new DataGridViewTextBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            Slike = new DataGridViewButtonColumn();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBrojDo = new TextBox();
            txtSuma = new TextBox();
            txtBrojOd = new TextBox();
            button1 = new Button();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvStudentiPredmeti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "Naziv predmeta : ";
            // 
            // txtPretraga
            // 
            txtPretraga.Location = new Point(144, 6);
            txtPretraga.Name = "txtPretraga";
            txtPretraga.Size = new Size(887, 27);
            txtPretraga.TabIndex = 1;
            txtPretraga.TextChanged += txtPretraga_TextChanged;
            // 
            // dgvStudentiPredmeti
            // 
            dgvStudentiPredmeti.AllowUserToAddRows = false;
            dgvStudentiPredmeti.AllowUserToDeleteRows = false;
            dgvStudentiPredmeti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentiPredmeti.Columns.AddRange(new DataGridViewColumn[] { Student, Predmet, Datum, Ocjena, Brisi, Slike });
            dgvStudentiPredmeti.Location = new Point(12, 39);
            dgvStudentiPredmeti.Name = "dgvStudentiPredmeti";
            dgvStudentiPredmeti.ReadOnly = true;
            dgvStudentiPredmeti.RowHeadersWidth = 51;
            dgvStudentiPredmeti.RowTemplate.Height = 29;
            dgvStudentiPredmeti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudentiPredmeti.Size = new Size(1019, 298);
            dgvStudentiPredmeti.TabIndex = 2;
            dgvStudentiPredmeti.CellContentClick += dgvStudentiPredmeti_CellContentClick;
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
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.MinimumWidth = 6;
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            Predmet.Width = 125;
            // 
            // Datum
            // 
            Datum.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Datum.DataPropertyName = "Datum";
            Datum.HeaderText = "Datum polaganja";
            Datum.MinimumWidth = 6;
            Datum.Name = "Datum";
            Datum.ReadOnly = true;
            // 
            // Ocjena
            // 
            Ocjena.DataPropertyName = "Ocjena";
            Ocjena.HeaderText = "Ocjena";
            Ocjena.MinimumWidth = 6;
            Ocjena.Name = "Ocjena";
            Ocjena.ReadOnly = true;
            Ocjena.Width = 125;
            // 
            // Brisi
            // 
            Brisi.HeaderText = "";
            Brisi.MinimumWidth = 6;
            Brisi.Name = "Brisi";
            Brisi.ReadOnly = true;
            Brisi.Text = "Briši predmet";
            Brisi.UseColumnTextForButtonValue = true;
            Brisi.Width = 125;
            // 
            // Slike
            // 
            Slike.HeaderText = "";
            Slike.MinimumWidth = 6;
            Slike.Name = "Slike";
            Slike.ReadOnly = true;
            Slike.Text = "Slike";
            Slike.UseColumnTextForButtonValue = true;
            Slike.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 340);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 3;
            label2.Text = "Sumiraj brojeve";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 360);
            label3.Name = "label3";
            label3.Size = new Size(29, 20);
            label3.TabIndex = 3;
            label3.Text = "Do";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(616, 360);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 3;
            label4.Text = "Suma";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 360);
            label5.Name = "label5";
            label5.Size = new Size(29, 20);
            label5.TabIndex = 3;
            label5.Text = "Od";
            // 
            // txtBrojDo
            // 
            txtBrojDo.Location = new Point(239, 389);
            txtBrojDo.Name = "txtBrojDo";
            txtBrojDo.Size = new Size(208, 27);
            txtBrojDo.TabIndex = 4;
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(616, 389);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(339, 27);
            txtSuma.TabIndex = 4;
            // 
            // txtBrojOd
            // 
            txtBrojOd.Location = new Point(12, 389);
            txtBrojOd.Name = "txtBrojOd";
            txtBrojOd.Size = new Size(206, 27);
            txtBrojOd.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(453, 389);
            button1.Name = "button1";
            button1.Size = new Size(157, 29);
            button1.TabIndex = 5;
            button1.Text = "Sumiraj => ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmPretragaIB180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 428);
            Controls.Add(button1);
            Controls.Add(txtBrojOd);
            Controls.Add(txtSuma);
            Controls.Add(txtBrojDo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvStudentiPredmeti);
            Controls.Add(txtPretraga);
            Controls.Add(label1);
            Name = "frmPretragaIB180079";
            Text = "frmPretragaIB180079";
            Load += frmPretragaIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudentiPredmeti).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPretraga;
        private DataGridView dgvStudentiPredmeti;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewTextBoxColumn Ocjena;
        private DataGridViewButtonColumn Brisi;
        private DataGridViewButtonColumn Slike;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBrojDo;
        private TextBox txtSuma;
        private TextBox txtBrojOd;
        private Button button1;
        private ErrorProvider err;
    }
}