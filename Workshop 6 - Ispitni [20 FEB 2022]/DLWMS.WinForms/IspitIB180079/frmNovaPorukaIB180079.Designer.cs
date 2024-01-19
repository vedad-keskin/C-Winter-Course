namespace DLWMS.WinForms.IspitIB180079
{
    partial class frmNovaPorukaIB180079
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbPredmet = new ComboBox();
            dtpValidnost = new DateTimePicker();
            txtSadrzaj = new TextBox();
            pbSlika = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            openFileDialog1 = new OpenFileDialog();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 0;
            label1.Text = "Poruka je validna do :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 0;
            label2.Text = "Sadržaj poruke :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 9);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 0;
            label3.Text = "Slika :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 0;
            label4.Text = "Odaberite predmet :";
            // 
            // cbPredmet
            // 
            cbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPredmet.FormattingEnabled = true;
            cbPredmet.Location = new Point(12, 27);
            cbPredmet.Name = "cbPredmet";
            cbPredmet.Size = new Size(215, 23);
            cbPredmet.TabIndex = 1;
            // 
            // dtpValidnost
            // 
            dtpValidnost.Location = new Point(12, 69);
            dtpValidnost.Name = "dtpValidnost";
            dtpValidnost.Size = new Size(215, 23);
            dtpValidnost.TabIndex = 2;
            // 
            // txtSadrzaj
            // 
            txtSadrzaj.Location = new Point(12, 116);
            txtSadrzaj.Multiline = true;
            txtSadrzaj.Name = "txtSadrzaj";
            txtSadrzaj.Size = new Size(215, 182);
            txtSadrzaj.TabIndex = 3;
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(252, 27);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(256, 233);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 4;
            pbSlika.TabStop = false;
            pbSlika.DoubleClick += pbSlika_DoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(412, 275);
            button1.Name = "button1";
            button1.Size = new Size(96, 23);
            button1.TabIndex = 5;
            button1.Text = "Sačuvaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(310, 275);
            button2.Name = "button2";
            button2.Size = new Size(96, 23);
            button2.TabIndex = 5;
            button2.Text = "Odustani";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmNovaPorukaIB180079
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 310);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pbSlika);
            Controls.Add(txtSadrzaj);
            Controls.Add(dtpValidnost);
            Controls.Add(cbPredmet);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNovaPorukaIB180079";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Poruka";
            Load += frmNovaPorukaIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbPredmet;
        private DateTimePicker dtpValidnost;
        private TextBox txtSadrzaj;
        private PictureBox pbSlika;
        private Button button1;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider err;
    }
}