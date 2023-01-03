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
    public partial class frmNhapKho : Form
    {
        NhapKhoBUS nhapKhoBUS = new NhapKhoBUS();
        public string Tennv;

        public frmNhapKho(string TenNV)
        {

            InitializeComponent();
            Tennv = TenNV;
            dgvNhapKho.AutoGenerateColumns = false;
            cboDonViTInh.SelectedIndex = 0;

        }

        private void frmNhapKho_Load(object sender, EventArgs e)
        {
            dgvNhapKho.DataSource = nhapKhoBUS.DanhSachKho();

        }

        private void dgvNhapKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhieu.Text =  dgvNhapKho.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMaNV.Text = dgvNhapKho.Rows[e.RowIndex].Cells[2].Value.ToString();
                             dgvNhapKho.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtMaNCC.Text = dgvNhapKho.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTenNL.Text = dgvNhapKho.Rows[e.RowIndex].Cells[5].Value.ToString();
            cboDonViTInh.Text = dgvNhapKho.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtSoluong.Text = dgvNhapKho.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtDonGia.Text = dgvNhapKho.Rows[e.RowIndex].Cells[8].Value.ToString();
           // txtMaPhieu.Text = dgvNhapKho.Rows[e.RowIndex].Cells[9].Value.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhapKhoDTO them = new NhapKhoDTO()
            {
                MaPhieu = txtMaPhieu.Text,
                TenNV =Tennv,
                MaNV = txtMaNV.Text,
                MaNCC = txtMaNCC.Text,
                TenNL = txtTenNL.Text,
                DonViTinh =cboDonViTInh.Text,
                SoLuong = int.Parse(txtSoluong.Text),
                DonGia = decimal.Parse( txtDonGia.Text),
                ThanhTien = decimal.Parse(txtDonGia.Text) * int.Parse(txtSoluong.Text)

            };
            if (txtMaPhieu.Text == string.Empty)
            {
                MessageBox.Show("Chưa điền Mã phiếu ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (nhapKhoBUS.NhapKho(them))
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvNhapKho.DataSource = null;
                dgvNhapKho.DataSource = nhapKhoBUS.DanhSachKho();
            }
            else
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            new loginDoAn.inNhapKho(Tennv, txtMaPhieu.Text).ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtRimKiem.Text.Trim();
            dgvNhapKho.DataSource = nhapKhoBUS.DanhSachKho().Where(u =>
            (
            u.MaNCC + u.TenNL ).Contains(keyword)
            ).ToList();
        }
    }
}
