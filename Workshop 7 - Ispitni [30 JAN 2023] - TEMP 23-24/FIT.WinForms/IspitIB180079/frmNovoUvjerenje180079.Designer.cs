namespace FIT.WinForms.IspitIB180079
{
    partial class frmNovoUvjerenje180079
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
            txtSvrha = new TextBox();
            btnSacuvaj = new Button();
            pbUplatnica = new PictureBox();
            cbVrsta = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            ofd = new OpenFileDialog();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 0;
            label1.Text = "Vrsta uvjerenja";
            // 
            // txtSvrha
            // 
            txtSvrha.Location = new Point(12, 86);
            txtSvrha.Multiline = true;
            txtSvrha.Name = "txtSvrha";
            txtSvrha.Size = new Size(242, 212);
            txtSvrha.TabIndex = 1;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(694, 304);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 2;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // pbUplatnica
            // 
            pbUplatnica.Location = new Point(285, 32);
            pbUplatnica.Name = "pbUplatnica";
            pbUplatnica.Size = new Size(503, 266);
            pbUplatnica.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUplatnica.TabIndex = 3;
            pbUplatnica.TabStop = false;
            pbUplatnica.Click += pbUplatnica_Click;
            // 
            // cbVrsta
            // 
            cbVrsta.FormattingEnabled = true;
            cbVrsta.Items.AddRange(new object[] { "Potvrda o statusu studenta", "Potvrda o polozenim predmetima" });
            cbVrsta.Location = new Point(12, 32);
            cbVrsta.Name = "cbVrsta";
            cbVrsta.Size = new Size(242, 28);
            cbVrsta.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 5;
            label2.Text = "Svrha uvjerenja";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(285, 9);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 6;
            label3.Text = "Uplatnica";
            // 
            // ofd
            // 
            ofd.FileName = "ofd";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmNovoUvjerenje180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 341);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbVrsta);
            Controls.Add(pbUplatnica);
            Controls.Add(btnSacuvaj);
            Controls.Add(txtSvrha);
            Controls.Add(label1);
            Name = "frmNovoUvjerenje180079";
            Text = "frmNovoUvjerenje180079";
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSvrha;
        private Button btnSacuvaj;
        private PictureBox pbUplatnica;
        private ComboBox cbVrsta;
        private Label label2;
        private Label label3;
        private OpenFileDialog ofd;
        private ErrorProvider err;
    }
}