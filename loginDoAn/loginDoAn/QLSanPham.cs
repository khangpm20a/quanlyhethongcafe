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
    public partial class QLSanPham : Form
    {
        SanPhamBUS sanPhamBUS = new SanPhamBUS();
        NhaCungCapBUS nhaCungCapBUS = new NhaCungCapBUS();
        public string Tennvv;
        public QLSanPham(string TenNV)
        {
            InitializeComponent();
            Tennvv = TenNV;
            dgvDanhSachSp.AutoGenerateColumns = false;
        }


        private void QLSanPham_Load(object sender, EventArgs e)
        {
            dgvDanhSachSp.AllowUserToOrderColumns = false;
            dgvDanhSachSp.DataSource = sanPhamBUS.LaySanPham();

            cboMaNCC.DataSource = nhaCungCapBUS.DsNhaCC();
            cboMaNCC.DisplayMember = "MaNCC";
            //cboMaNV.DataSource = taiKhoanBUS.LayTaiKhoan();
            //cboMaNV.DisplayMember = "MaNV";
        }
       

        private void dgvDanhSachSp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex != -1)
            {
                txtMaSP.Text = dgvDanhSachSp.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTenSp.Text = dgvDanhSachSp.Rows[e.RowIndex].Cells[2].Value.ToString();
                cboMaNCC.Text = dgvDanhSachSp.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDonvi.Text = dgvDanhSachSp.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSoluong.Text = dgvDanhSachSp.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDonGia.Text = dgvDanhSachSp.Rows[e.RowIndex].Cells[6].Value.ToString();

                if (e.ColumnIndex == 0)
                {
                    SanPhamDTO Xoa = new SanPhamDTO()
                    {
                        MaSP = int.Parse(txtMaSP.Text)

                    };
                    if (sanPhamBUS.XoaSanPham(Xoa))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvDanhSachSp.DataSource = null;
                        dgvDanhSachSp.DataSource = sanPhamBUS.LaySanPham();
                    }
                    else
                        MessageBox.Show("Loại sản phẩm đang được sử dụng khôn được xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SanPhamDTO them = new SanPhamDTO()
            {
                MaSP = int.Parse(txtMaSP.Text),
                TenSP = txtTenSp.Text,
                MaNCC = cboMaNCC.Text,
                DonViTinh = txtDonvi.Text,
                SoLuong = short.Parse(txtSoluong.Text),
                DonGia = int.Parse(txtDonGia.Text),
                TrangThai = true

            };
            if (sanPhamBUS.ThemSanPham(them))
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDanhSachSp.DataSource = sanPhamBUS.LaySanPham();
            }
            else
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvDanhSachSp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNhaCC_Click(object sender, EventArgs e)
        {
            NhaCungCap cungCap = new NhaCungCap();
            cungCap.ShowDialog();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenSp.Text = "";
            txtSoluong.Text = "";
            txtDonGia.Text = "";
            txtMaSP.Text = "";
            txtDonvi.Text = "";

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SanPhamDTO sua = new SanPhamDTO()
            {
                MaSP = int.Parse(txtMaSP.Text),
                TenSP = txtTenSp.Text,
                MaNCC = cboMaNCC.Text,
                DonViTinh = txtDonvi.Text,
                SoLuong = short.Parse(txtSoluong.Text),
                DonGia = int.Parse(txtDonGia.Text),
            };
            if (sanPhamBUS.SuaSP(sua))
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDanhSachSp.DataSource = sanPhamBUS.LaySanPham();
            }
            else MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXuatSanPham_Click(object sender, EventArgs e)
        {
            new loginDoAn.inSanPham(Tennvv).ShowDialog();
        }
    }
}
