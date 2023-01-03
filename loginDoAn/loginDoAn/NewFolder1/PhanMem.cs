using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginDoAn
{
    public partial class PhanMem : Form
    {
        string tk;
        string TenNvv;
        public PhanMem(string tk)
        {
            InitializeComponent();
            timer1.Start();
            this.tk = tk;
            TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
            NhapKhoBUS nhapKhoBUS = new NhapKhoBUS();

            var gtri = new QLTKhoanBUS().TruyVan(tk);
            lblTenNV.Text = gtri["HoNV"].ToString() + gtri["TenLotNV"].ToString() + gtri["TenNV"].ToString();
            TenNvv = gtri["TenNV"].ToString();
            lblChucVu.Text = gtri["Tenquyen"].ToString();
            MaNV = gtri["MaNV"].ToString();

            if (lblChucVu.Text == "Bán Hàng")
            {
                btnNhapKho.Enabled = false;
                btnTaiKhoan.Enabled = false;
            }
            if (lblChucVu.Text == "Thủ kho")
            {
                btnDoanhThu.Enabled = false;
                btnBanHang.Enabled = false;
                btnTaiKhoan.Enabled = false;
            }
        }
        public string MaNV  ;

        private Form currentFormChild;
        private void OpenChildForm(Form ChildForm)
        {
            if(currentFormChild!=null)
            {
                currentFormChild.Close();
            }
            currentFormChild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel_NoiDung.Controls.Add(ChildForm);
            panel_NoiDung.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "TRANG CHỦ";
            OpenChildForm(new frmTrangChu());
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "BÁN HÀNG";
            OpenChildForm(new BangHanggg(TenNvv , MaNV));
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "TÀI KHOẢN";
            OpenChildForm(new frmDanhSachNV(TenNvv, MaNV));
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "DOANH THU";
            OpenChildForm(new frmDoanhThu(TenNvv));
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "NHẬP KHO";
            OpenChildForm(new frmNhapKho(TenNvv));
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "THÔNG TIN";
             OpenChildForm(new frmThongTin(lblTenNV.Text,lblChucVu.Text, MaNV));

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDanhNhap a = new frmDanhNhap();
            a.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblThoiGian.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
