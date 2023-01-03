
namespace loginDoAn
{
    partial class frmTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangChu));
            this.pic_TrangChu = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TrangChu)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_TrangChu
            // 
            this.pic_TrangChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(202)))), ((int)(((byte)(200)))));
            this.pic_TrangChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_TrangChu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_TrangChu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(202)))), ((int)(((byte)(200)))));
            this.pic_TrangChu.Image = ((System.Drawing.Image)(resources.GetObject("pic_TrangChu.Image")));
            this.pic_TrangChu.ImageRotate = 0F;
            this.pic_TrangChu.Location = new System.Drawing.Point(0, 0);
            this.pic_TrangChu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic_TrangChu.Name = "pic_TrangChu";
            this.pic_TrangChu.Size = new System.Drawing.Size(1061, 615);
            this.pic_TrangChu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_TrangChu.TabIndex = 0;
            this.pic_TrangChu.TabStop = false;
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1061, 615);
            this.Controls.Add(this.pic_TrangChu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTrangChu";
            this.Text = "TrangChu";
            ((System.ComponentModel.ISupportInitialize)(this.pic_TrangChu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pic_TrangChu;
    }
}