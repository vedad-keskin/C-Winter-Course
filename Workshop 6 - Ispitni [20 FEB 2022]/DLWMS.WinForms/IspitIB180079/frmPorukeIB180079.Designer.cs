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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lblStudent = new Label();
            dgvPoruke = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Sadrzaj = new DataGridViewTextBoxColumn();
            Slika = new DataGridViewImageColumn();
            Validnost = new DataGridViewTextBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            button1 = new Button();
            groupBox1 = new GroupBox();
            txtInfo = new TextBox();
            btnDodaj = new Button();
            cbPredmet = new ComboBox();
            dtpValidnost = new DateTimePicker();
            txtBroj = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvPoruke).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Poruke studenta";
            // 
            // lblStudent
            // 
            lblStudent.Location = new Point(111, 9);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(223, 15);
            lblStudent.TabIndex = 0;
            // 
            // dgvPoruke
            // 
            dgvPoruke.AllowUserToAddRows = false;
            dgvPoruke.AllowUserToDeleteRows = false;
            dgvPoruke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPoruke.Columns.AddRange(new DataGridViewColumn[] { Predmet, Sadrzaj, Slika, Validnost, Brisi });
            dgvPoruke.Location = new Point(12, 38);
            dgvPoruke.Name = "dgvPoruke";
            dgvPoruke.ReadOnly = true;
            dgvPoruke.RowTemplate.Height = 25;
            dgvPoruke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPoruke.Size = new Size(802, 204);
            dgvPoruke.TabIndex = 1;
            dgvPoruke.CellContentClick += dgvPoruke_CellContentClick;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // Sadrzaj
            // 
            Sadrzaj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Sadrzaj.DataPropertyName = "Sadrzaj";
            Sadrzaj.HeaderText = "Sadrzaj";
            Sadrzaj.Name = "Sadrzaj";
            Sadrzaj.ReadOnly = true;
            // 
            // Slika
            // 
            Slika.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Slika.DataPropertyName = "Slika";
            Slika.HeaderText = "Slika";
            Slika.Name = "Slika";
            Slika.ReadOnly = true;
            // 
            // Validnost
            // 
            Validnost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Validnost.DataPropertyName = "Validnost";
            Validnost.HeaderText = "Validnost";
            Validnost.Name = "Validnost";
            Validnost.ReadOnly = true;
            // 
            // Brisi
            // 
            Brisi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Brisi.HeaderText = "";
            Brisi.Name = "Brisi";
            Brisi.ReadOnly = true;
            Brisi.Text = "Briši";
            Brisi.UseColumnTextForButtonValue = true;
            // 
            // button1
            // 
            button1.Location = new Point(672, 8);
            button1.Name = "button1";
            button1.Size = new Size(142, 23);
            button1.TabIndex = 2;
            button1.Text = "Nova poruka";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(cbPredmet);
            groupBox1.Controls.Add(dtpValidnost);
            groupBox1.Controls.Add(txtBroj);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 285);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(802, 186);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje poruka :";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(230, 37);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(566, 143);
            txtInfo.TabIndex = 5;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(6, 157);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(200, 23);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj => ";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // cbPredmet
            // 
            cbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPredmet.FormattingEnabled = true;
            cbPredmet.Location = new Point(6, 80);
            cbPredmet.Name = "cbPredmet";
            cbPredmet.Size = new Size(200, 23);
            cbPredmet.TabIndex = 3;
            // 
            // dtpValidnost
            // 
            dtpValidnost.Location = new Point(6, 123);
            dtpValidnost.Name = "dtpValidnost";
            dtpValidnost.Size = new Size(200, 23);
            dtpValidnost.TabIndex = 2;
            // 
            // txtBroj
            // 
            txtBroj.Location = new Point(6, 37);
            txtBroj.Name = "txtBroj";
            txtBroj.Size = new Size(200, 23);
            txtBroj.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(230, 19);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 0;
            label5.Text = "Info :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 63);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 0;
            label4.Text = "Predmet :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 106);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 0;
            label3.Text = "Poruka je validna do :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 0;
            label2.Text = "Broj poruka :";
            // 
            // button2
            // 
            button2.Location = new Point(699, 256);
            button2.Name = "button2";
            button2.Size = new Size(115, 23);
            button2.TabIndex = 4;
            button2.Text = "Printaj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmPorukeIB180079
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 483);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(dgvPoruke);
            Controls.Add(lblStudent);
            Controls.Add(label1);
            Name = "frmPorukeIB180079";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPorukeIB180079";
            Load += frmPorukeIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPoruke).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
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
        private GroupBox groupBox1;
        private TextBox txtInfo;
        private Button btnDodaj;
        private ComboBox cbPredmet;
        private DateTimePicker dtpValidnost;
        private TextBox txtBroj;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
        private ErrorProvider err;
    }
}