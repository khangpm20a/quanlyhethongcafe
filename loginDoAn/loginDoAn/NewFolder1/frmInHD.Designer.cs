
namespace loginDoAn.NewFolder1
{
    partial class frmInHD
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
            this.components = new System.ComponentModel.Container();
            this.persistentRepository1 = new DevExpress.XtraEditors.Repository.PersistentRepository(this.components);
            this.repHD = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // repHD
            // 
            this.repHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repHD.LocalReport.ReportEmbeddedResource = "loginDoAn.ReportHoaDon.rdlc";
            this.repHD.Location = new System.Drawing.Point(0, 0);
            this.repHD.Name = "repHD";
            this.repHD.ServerReport.BearerToken = null;
            this.repHD.Size = new System.Drawing.Size(800, 450);
            this.repHD.TabIndex = 0;
            // 
            // frmInHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.repHD);
            this.Name = "frmInHD";
            this.Text = "frmInHD";
            this.Load += new System.EventHandler(this.frmInHD_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.PersistentRepository persistentRepository1;
        private Microsoft.Reporting.WinForms.ReportViewer repHD;
    }
}