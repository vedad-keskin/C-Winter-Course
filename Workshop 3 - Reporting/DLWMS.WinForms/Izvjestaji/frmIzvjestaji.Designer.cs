namespace DLWMS.WinForms.Izvjestaji
{
    partial class frmIzvjestaji
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
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.LocalReport.ReportEmbeddedResource = "DLWMS.WinForms.Izvjestaji.rptUvjerenje.rdlc";
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Margin = new Padding(3, 4, 3, 4);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(892, 509);
            reportViewer1.TabIndex = 0;
            // 
            // frmIzvjestaji
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 509);
            Controls.Add(reportViewer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmIzvjestaji";
            Text = "frmIzvjestaji";
            Load += frmIzvjestaji_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}