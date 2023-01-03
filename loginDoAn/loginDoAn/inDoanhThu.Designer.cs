
namespace loginDoAn
{
    partial class inDoanhThu
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
            this.rptDoanhThu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptDoanhThu
            // 
            this.rptDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.rptDoanhThu.Name = "rptDoanhThu";
            this.rptDoanhThu.ServerReport.BearerToken = null;
            this.rptDoanhThu.Size = new System.Drawing.Size(800, 450);
            this.rptDoanhThu.TabIndex = 0;
            // 
            // inDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptDoanhThu);
            this.Name = "inDoanhThu";
            this.Text = "inDoanhThu";
            this.Load += new System.EventHandler(this.inDoanhThu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptDoanhThu;
    }
}