using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;


namespace loginDoAn
{
    public partial class frmDoanhThu : Form
    {
        HoaDonBUS _HoaDonBUS = new HoaDonBUS();
        public string Tennvv;
        public frmDoanhThu(string TenNV)
        {
            InitializeComponent();
            Tennvv = TenNV;
            dgvDanhSachHD.AutoGenerateColumns = false;

        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            dgvDanhSachHD.AllowUserToOrderColumns = false;
            dgvDanhSachHD.DataSource = _HoaDonBUS.LayHoaDon();

        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            new loginDoAn.inDoanhThu(Tennvv).ShowDialog();
        }

        private void dgvDanhSachHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDanhSachHD.Rows[e.RowIndex].Cells[1].Value.ToString();
            dgvDanhSachHD.Rows[e.RowIndex].Cells[2].Value.ToString();
            dgvDanhSachHD.Rows[e.RowIndex].Cells[3].Value.ToString();
            dgvDanhSachHD.Rows[e.RowIndex].Cells[4].Value.ToString();
            dgvDanhSachHD.Rows[e.RowIndex].Cells[5].Value.ToString();
            dgvDanhSachHD.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            //DateTime keyword = dtpTuNgay.Value;
            //dgvDanhSachHD.DataSource = _HoaDonBUS.LayHoaDon().Where(u =>u.NgayLapHD.ToString().Contains(keyword)
            //).ToList();
        }
    }
}
