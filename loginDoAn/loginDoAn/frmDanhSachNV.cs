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
    public partial class frmDanhSachNV : Form
    {
        
        TaiKhoanBUS _taiKhoanBUS = new TaiKhoanBUS();
        public string Tennv;
        public string Manv;
        

        public frmDanhSachNV(string TenNV, string MaNV)
        {

            InitializeComponent();
            Tennv = TenNV;
            Manv = MaNV;
            dgvDanhSachNV.AutoGenerateColumns = false;


            txtMaNV.Enabled = false;
            cboCaLam.SelectedIndex = 0;
            cboGioiTinh.SelectedIndex = 0;
        }
        private void frmDanhSachNV_Load(object sender, EventArgs e)
        {
            dgvDanhSachNV.AllowUserToOrderColumns = false;
            dgvDanhSachNV.DataSource = _taiKhoanBUS.LayDSNhanVien();
        }
        private void btnThongTinTK_Click(object sender, EventArgs e)
        {
            frmDangKyTK _dangky = new frmDangKyTK(Tennv,Manv);
            _dangky.ShowDialog();
        }

        private void dgvDanhSachNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex != -1)
            {
                isAdd_ = false;
                btnLuu.Text = "Sửa NV";

                txtMaNV.Text= dgvDanhSachNV.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtHo.Text = dgvDanhSachNV.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtLot.Text = dgvDanhSachNV.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTen.Text = dgvDanhSachNV.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSDT.Text = dgvDanhSachNV.Rows[e.RowIndex].Cells[5].Value.ToString();
                cboGioiTinh.Text = dgvDanhSachNV.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtDiaChi.Text = dgvDanhSachNV.Rows[e.RowIndex].Cells[7].Value.ToString();
                dtpNgaySinh.Text = dgvDanhSachNV.Rows[e.RowIndex].Cells[8].Value.ToString();
                cboCaLam.Text = dgvDanhSachNV.Rows[e.RowIndex].Cells[9].Value.ToString();
                if (e.ColumnIndex == 0)
                {
                    TaiKhoanDTO Xoa = new TaiKhoanDTO()
                    {
                        MaNV = dgvDanhSachNV.Rows[e.RowIndex].Cells[1].Value.ToString(),
                        HoNV = dgvDanhSachNV.Rows[e.RowIndex].Cells[2].Value.ToString(),
                        TenLotNV = dgvDanhSachNV.Rows[e.RowIndex].Cells[3].Value.ToString(),
                        TenNV = dgvDanhSachNV.Rows[e.RowIndex].Cells[4].Value.ToString(),
                        SDT = dgvDanhSachNV.Rows[e.RowIndex].Cells[5].Value.ToString(),
                        GioiTinh = dgvDanhSachNV.Rows[e.RowIndex].Cells[6].Value.ToString(),
                        DiaChi = dgvDanhSachNV.Rows[e.RowIndex].Cells[7].Value.ToString(),
                        NgaySinh = (DateTime)dgvDanhSachNV.Rows[e.RowIndex].Cells[8].Value,
                        CaLam = dgvDanhSachNV.Rows[e.RowIndex].Cells[9].Value.ToString(),
                    };
                    if (_taiKhoanBUS.XoaNV(Xoa))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        dgvDanhSachNV.DataSource = _taiKhoanBUS.LayDSNhanVien();
                    }
                    else
                        MessageBox.Show("Loại sản phẩm đang được sử dụng khôn được xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void dgvDanhSachNV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmTaiKhoann a = new frmTaiKhoann();
            a.ShowDialog();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!isAdd_)
            {
             
                TaiKhoanDTO sua = new TaiKhoanDTO()
                {
                    MaNV = txtMaNV.Text,
                    HoNV = txtHo.Text,
                    TenLotNV = txtLot.Text,
                    TenNV = txtTen.Text,
                    HinhNV = null,
                    SDT = txtSDT.Text,
                    GioiTinh = cboGioiTinh.Text,
                    DiaChi = txtDiaChi.Text,
                    NgaySinh = (DateTime)dtpNgaySinh.Value,
                    Email = null,
                    CaLam = txtTen.Text,
                };
                if (txtTen.Text == string.Empty)
                {
                    MessageBox.Show("Chưa điền tên ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //if (!_taiKhoanBUS.KTTenKH(sua))
                //{
                //    MessageBox.Show("Tên nhân viên bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
                else
                {
                    if (_taiKhoanBUS.SuaNV(sua))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                TaiKhoanDTO them = new TaiKhoanDTO()
                {

                    MaNV = txtMaNV.Text,
                    HoNV = txtHo.Text,
                    TenLotNV = txtLot.Text,
                    TenNV = txtTen.Text,
                    HinhNV = null,
                    SDT = txtSDT.Text,
                    GioiTinh = cboGioiTinh.Text,
                    DiaChi = txtDiaChi.Text,
                    NgaySinh = (DateTime)dtpNgaySinh.Value,
                    Email = null,
                    CaLam = txtTen.Text,
                    TrangThai = true

                };
                if (_taiKhoanBUS.ThemNV(them))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgvDanhSachNV.DataSource = null;
            dgvDanhSachNV.DataSource = _taiKhoanBUS.LayDSNhanVien();
        }
        private string ID_New;
        bool isAdd_ = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            ID_New = "NV"+
                DateTime.Now.Minute.ToString()+DateTime.Now.Millisecond.ToString()+new Random().Next(0,100);
            txtMaNV.Text = ID_New;
            isAdd_ = true;
            btnLuu.Text = "Thêm NV";
            ResetDataTxt();
        }

        private void ResetDataTxt()
        {
            txtHo.Text = string.Empty;
            txtLot.Text = string.Empty;
            txtTen.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
        }

        private void txtHo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
            else
            {
                e.Handled = false;
            }

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }

        private void dgvDanhSachNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
          //  dgvDanhSachNV.DataSource = this.txtTimKiem(txtTimKiem.Text)
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            dgvDanhSachNV.DataSource = _taiKhoanBUS.LayDSNhanVien().Where(u =>
            (
            u.HoNV  + u.TenLotNV + u.TenNV).Contains(keyword)
            ).ToList();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvDanhSachNV.DataSource = _taiKhoanBUS.LayDSNhanVien();
        }
    }
}
