using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace loginDoAn
{
    public partial class NhaCungCap : Form
    {
        NhaCungCapBUS nhaCungCapBUS = new NhaCungCapBUS();
        public NhaCungCap()
        {
            InitializeComponent();
            dgvDanhSachNCC.AutoGenerateColumns = false;
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            dgvDanhSachNCC.AllowUserToOrderColumns = false;
            dgvDanhSachNCC.DataSource = nhaCungCapBUS.DsNhaCC();
        }

        private void dgvDanhSachNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtMaNCC.Text = dgvDanhSachNCC.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTenNCC.Text = dgvDanhSachNCC.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSDT.Text = dgvDanhSachNCC.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvDanhSachNCC.Rows[e.RowIndex].Cells[4].Value.ToString();

                if (e.ColumnIndex == 0)
                {
                    NhaCungCapDTO Xoa = new NhaCungCapDTO()
                    {
                        MaNCC = txtMaNCC.Text

                    };
                    if (nhaCungCapBUS.XoaNCC(Xoa))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvDanhSachNCC.DataSource = null;
                        dgvDanhSachNCC.DataSource = nhaCungCapBUS.DsNhaCC();
                    }
                    else
                        MessageBox.Show("Loại sản phẩm đang được sử dụng khôn được xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            NhaCungCapDTO them = new NhaCungCapDTO()
            {
                //  MaPhieu = txtMaPhieu.Text,
                TenNCC = txtTenNCC.Text,
                MaNCC = txtMaNCC.Text,
                SDT = txtSDT.Text,
                DiaChi = txtDiaChi.Text,

            };
            if (txtMaNCC.Text == string.Empty)
            {
                MessageBox.Show("Chưa điền Mã Nhà cung cấp ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (nhaCungCapBUS.ThemNCC(them))
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDanhSachNCC.DataSource = null;
                dgvDanhSachNCC.DataSource = nhaCungCapBUS.DsNhaCC();
            }
            else
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO sua = new NhaCungCapDTO()
            {
                TenNCC = txtTenNCC.Text,
                MaNCC = txtMaNCC.Text,
                SDT = txtSDT.Text,
                DiaChi = txtDiaChi.Text,
            };
            if (nhaCungCapBUS.SuaNCC(sua))
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDanhSachNCC.DataSource = nhaCungCapBUS.DsNhaCC();
            }
            else MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDiaChi.Text = string.Empty;
            txtMaNCC.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtTenNCC.Text = string.Empty;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
        }
    }
}

