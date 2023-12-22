namespace DLWMS.WinForms.IB170074
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
            btnNovaPoruka = new Button();
            dgvPoruke = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Sadrzaj = new DataGridViewTextBoxColumn();
            Slika = new DataGridViewImageColumn();
            Hitnost = new DataGridViewTextBoxColumn();
            Validnost = new DataGridViewTextBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            btnPrintaj = new Button();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPoruke).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Poruke studenta";
            // 
            // lblStudent
            // 
            lblStudent.Location = new Point(123, 7);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(221, 19);
            lblStudent.TabIndex = 1;
            // 
            // btnNovaPoruka
            // 
            btnNovaPoruka.Location = new Point(1006, 9);
            btnNovaPoruka.Margin = new Padding(3, 2, 3, 2);
            btnNovaPoruka.Name = "btnNovaPoruka";
            btnNovaPoruka.Size = new Size(164, 22);
            btnNovaPoruka.TabIndex = 2;
            btnNovaPoruka.Text = "Nova Poruka";
            btnNovaPoruka.UseVisualStyleBackColor = true;
            // 
            // dgvPoruke
            // 
            dgvPoruke.AllowUserToAddRows = false;
            dgvPoruke.AllowUserToDeleteRows = false;
            dgvPoruke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPoruke.Columns.AddRange(new DataGridViewColumn[] { Predmet, Sadrzaj, Slika, Hitnost, Validnost, Brisi });
            dgvPoruke.Location = new Point(10, 35);
            dgvPoruke.Margin = new Padding(3, 2, 3, 2);
            dgvPoruke.Name = "dgvPoruke";
            dgvPoruke.ReadOnly = true;
            dgvPoruke.RowHeadersWidth = 51;
            dgvPoruke.RowTemplate.Height = 29;
            dgvPoruke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPoruke.Size = new Size(1160, 182);
            dgvPoruke.TabIndex = 3;
            dgvPoruke.CellContentClick += dgvPoruke_CellContentClick;
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
            // Hitnost
            // 
            Hitnost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Hitnost.DataPropertyName = "Hitnost";
            Hitnost.HeaderText = "Hitnost";
            Hitnost.MinimumWidth = 6;
            Hitnost.Name = "Hitnost";
            Hitnost.ReadOnly = true;
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
            Brisi.Text = "Brisi";
            Brisi.UseColumnTextForButtonValue = true;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(1006, 231);
            btnPrintaj.Margin = new Padding(3, 2, 3, 2);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(164, 22);
            btnPrintaj.TabIndex = 4;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(10, 257);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1160, 261);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje poruka";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(326, 56);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(829, 199);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(5, 232);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(264, 22);
            button1.TabIndex = 4;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(5, 183);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(265, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(5, 112);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(265, 23);
            comboBox1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 155);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 1;
            label4.Text = "Poruka je validna do";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 95);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 1;
            label3.Text = "Predmet";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(326, 30);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 1;
            label5.Text = "Info";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 30);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Broj Poruka";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(5, 56);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 23);
            textBox1.TabIndex = 0;
            // 
            // frmPorukeIB180079
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 522);
            Controls.Add(groupBox1);
            Controls.Add(btnPrintaj);
            Controls.Add(dgvPoruke);
            Controls.Add(btnNovaPoruka);
            Controls.Add(lblStudent);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPorukeIB180079";
            Text = "frmPorukeIB180079";
            Load += frmPorukeIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPoruke).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblStudent;
        private Button btnNovaPoruka;
        private DataGridView dgvPoruke;
        private Button btnPrintaj;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label4;
        private Label label5;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Sadrzaj;
        private DataGridViewImageColumn Slika;
        private DataGridViewTextBoxColumn Hitnost;
        private DataGridViewTextBoxColumn Validnost;
        private DataGridViewButtonColumn Brisi;
    }
}