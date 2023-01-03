
namespace loginDoAn
{
    partial class inSanPham
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
            this.rptSanPham = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptSanPham
            // 
            this.rptSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptSanPham.Location = new System.Drawing.Point(0, 0);
            this.rptSanPham.Name = "rptSanPham";
            this.rptSanPham.ServerReport.BearerToken = null;
            this.rptSanPham.Size = new System.Drawing.Size(800, 450);
            this.rptSanPham.TabIndex = 0;
            this.rptSanPham.Load += new System.EventHandler(this.rptSanPham_Load);
            // 
            // inSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptSanPham);
            this.Name = "inSanPham";
            this.Text = "inSanPham";
            this.Load += new System.EventHandler(this.inSanPham_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptSanPham;
    }
}