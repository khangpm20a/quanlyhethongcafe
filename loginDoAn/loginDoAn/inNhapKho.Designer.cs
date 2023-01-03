
namespace loginDoAn
{
    partial class inNhapKho
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
            this.rptNhapKho = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptNhapKho
            // 
            this.rptNhapKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptNhapKho.Location = new System.Drawing.Point(0, 0);
            this.rptNhapKho.Name = "rptNhapKho";
            this.rptNhapKho.ServerReport.BearerToken = null;
            this.rptNhapKho.Size = new System.Drawing.Size(800, 450);
            this.rptNhapKho.TabIndex = 0;
            // 
            // inNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptNhapKho);
            this.Name = "inNhapKho";
            this.Text = "inNhapKho";
            this.Load += new System.EventHandler(this.inNhapKho_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptNhapKho;
    }
}