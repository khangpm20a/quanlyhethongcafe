using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace loginDoAn
{
    public partial class frmDanhNhap : Form
    {
        string tk, mk;
        public frmDanhNhap()
        {
            InitializeComponent();
            txtDangNhap.Text = "Admin";
            txtMatKhau.Text = "123";
        }
        private void txtDangNhap_Enter(object sender, EventArgs e)
        {
            if (txtDangNhap.Text == "Tài khoản")
            {
                txtDangNhap.Text = "";
                txtDangNhap.ForeColor = Color.Gray;
            }
        }
        private void txtDangNhap_Leave(object sender, EventArgs e)
        {
            if (txtDangNhap.Text == "")
            {
                txtDangNhap.Text = "Tài khoản";
                txtDangNhap.ForeColor = Color.Gray;
            }
        }
        bool isOK;
        private void btnDanhNhap_Click(object sender, EventArgs e)
        {
            tk = txtDangNhap.Text.Trim();
            mk = txtMatKhau.Text.Trim();
            if(new QLTKhoanBUS().DangNhap(tk, mk))
            {
                PhanMem P = new PhanMem(tk);
                this.Hide();
                P.Show();

            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }
        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Mật khẩu")
            {
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Gray;
                txtMatKhau.PasswordChar = '*';
            }
        }
        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
                if (txtMatKhau.Text == "")
                {
                    txtMatKhau.Text = "Mật khẩu";
                    txtMatKhau.ForeColor = Color.Gray;
                }
                if (txtMatKhau.Text == "Mật khẩu")
                {
                    txtMatKhau.PasswordChar = '\0';
                }
        }
        private void pic_Xem_Click_1(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '\0')
            {
                pic_An.BringToFront();
                txtMatKhau.PasswordChar = '*';
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pic_An_Click_1(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                pic_Xem.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }
        }
    }
}
