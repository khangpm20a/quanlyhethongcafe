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
using DTO;

namespace loginDoAn
{
    public partial class frmDangKyTK : Form
    {
        QLTKhoanBUS qLTKhoanBUS = new QLTKhoanBUS();
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        public string TenNvvv, Manvvv;
        public frmDangKyTK(string TenNV, string MaNV)
        {
            InitializeComponent();
            TenNvvv = TenNV;
            Manvvv = MaNV;
            dgvDanhSachTK.AllowUserToAddRows = false;
            dgvDanhSachTK.AutoGenerateColumns = false;
            //dgvDanhSachTK.AllowUserToOrderColumns = false;
        }

        private void dgvDanhSachTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmDangKyTK_Load(object sender, EventArgs e)
        {
            dgvDanhSachTK.DataSource = qLTKhoanBUS.LayTKDN();
            cboMaNV.DataSource = taiKhoanBUS.LayDSNhanVien();
            cboMaNV.DisplayMember = "MaNV";

            cboChucVu.DataSource = qLTKhoanBUS.LayQuyen();
            cboChucVu.DisplayMember = "TenQuyen";
            cboChucVu.ValueMember = "MaQuyen";

            cboChucVu.DataSource = qLTKhoanBUS.LayQuyen();
            cboChucVu.DisplayMember = "TenQuyen";
            cboChucVu.ValueMember = "MaQuyen";
        }

        private void dgvDanhSachTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Enabled = false;
            if (e.RowIndex != -1)
            {
                cboMaNV.Text = dgvDanhSachTK.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTenTk.Text = dgvDanhSachTK.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtMk.Text = dgvDanhSachTK.Rows[e.RowIndex].Cells[3].Value.ToString();
                cboChucVu.Text = dgvDanhSachTK.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();

                if (e.ColumnIndex == 0)
                {
                    QLTKhoanDTO Xoa = new QLTKhoanDTO()
                    {
                        MaNV = (cboMaNV.Text)
                    };
                    if (qLTKhoanBUS.XoaTK(Xoa))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // dgvDanhSachTK.DataSource = null;
                        dgvDanhSachTK.DataSource = qLTKhoanBUS.LayTKDN();
                    }
                   
                }
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            QLTKhoanDTO them = new QLTKhoanDTO()
            {

                MaNV = cboMaNV.Text,
                TenTK = txtTenTk.Text,
                MatKhau = txtMk.Text,
                MaQuyen = int.Parse(cboChucVu.SelectedValue.ToString()),
                TrangThai = true

            };
            if (txtTenTk.Text == string.Empty)
            {
                MessageBox.Show("Chưa điền tên tài khoản ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (qLTKhoanBUS.ThemTK(them))
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDanhSachTK.DataSource = null;
                dgvDanhSachTK.DataSource = qLTKhoanBUS.LayTKDN();
            }
            else
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cboMaNV_SelectedValueChanged(object sender, EventArgs e)
        {
            //lblTentk.Text = "NV" + cboMaNV.Text;
            txtTenTk.Text = "" + cboMaNV.Text;

        }
    }
}
