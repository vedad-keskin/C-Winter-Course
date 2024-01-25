namespace FIT.WinForms.IspitIB180079
{
    partial class frmStudentInfoIB180079
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
            pbProfilePhoto = new PictureBox();
            lbImePrezime = new Label();
            lbProsjek = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbProfilePhoto).BeginInit();
            SuspendLayout();
            // 
            // pbProfilePhoto
            // 
            pbProfilePhoto.Location = new Point(62, 82);
            pbProfilePhoto.Name = "pbProfilePhoto";
            pbProfilePhoto.Size = new Size(286, 246);
            pbProfilePhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProfilePhoto.TabIndex = 0;
            pbProfilePhoto.TabStop = false;
            // 
            // lbImePrezime
            // 
            lbImePrezime.AutoSize = true;
            lbImePrezime.Location = new Point(184, 341);
            lbImePrezime.Name = "lbImePrezime";
            lbImePrezime.Size = new Size(50, 20);
            lbImePrezime.TabIndex = 1;
            lbImePrezime.Text = "label1";
            // 
            // lbProsjek
            // 
            lbProsjek.AutoSize = true;
            lbProsjek.Location = new Point(184, 403);
            lbProsjek.Name = "lbProsjek";
            lbProsjek.Size = new Size(50, 20);
            lbProsjek.TabIndex = 2;
            lbProsjek.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 47);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 3;
            label3.Text = "frmStudentInfo1";
            // 
            // frmStudentInfoIB180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 460);
            Controls.Add(label3);
            Controls.Add(lbProsjek);
            Controls.Add(lbImePrezime);
            Controls.Add(pbProfilePhoto);
            Name = "frmStudentInfoIB180079";
            Text = "frmStudentInfoIB180079";
            Load += frmStudentInfoIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)pbProfilePhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbProfilePhoto;
        private Label lbImePrezime;
        private Label lbProsjek;
        private Label label3;
    }
}