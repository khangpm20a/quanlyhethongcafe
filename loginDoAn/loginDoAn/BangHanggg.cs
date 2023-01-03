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

    public partial class BangHanggg : Form
    {
        BangHangBUS bangHangBUS = new BangHangBUS();
        ThemHDBUS hd = new ThemHDBUS();
        HoaDonBUS _HoaDonBUS = new HoaDonBUS();
        public string Tennv;
        public string Manv;
        public BangHanggg(string TenNV ,string MaNV)
        {
            InitializeComponent();
            Tennv = TenNV;
            Manv = MaNV;
            dgvSanPham.AutoGenerateColumns = false;
            
            nuSL.Minimum = 1;
            nuSL.Maximum = 100;
            DisableControls();
            LoadData();
        }

        private void LoadData()
        {
            cboSP.DataSource = bangHangBUS.LaySapPham();
            cboSP.DisplayMember = "TenSP";
            cboSP.ValueMember = "MaSP";
            

        }

        public void DisableControls()
        {
            txtMS.Enabled = false;
            nuSL.Enabled = false;
            cboSP.Enabled = false;
            btnThem.Visible = false;
            btnSua.Visible = false;
        

        }
        public void EnControls()
        {
            txtMS.Enabled = true;
            nuSL.Enabled = true;
            cboSP.Enabled = true;

        }
        string time;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            time = rd.Next(0, 99) + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + rd.Next(0, 99);
            txtMS.Text = time;
            EnControls();
            btnThem.Visible = true;
            
        }
        public string macthd_;

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            btnThem.Enabled = false;
            btnCreate.Enabled = false;
            if (e.RowIndex != -1)
            {
                var a = dgvSanPham.Rows[e.RowIndex];
                cboSP.Text = a.Cells["Column2"].Value.ToString();
                nuSL.Value = Decimal.Parse(a.Cells["Column4"].Value.ToString());
                lblDonGia.Text = a.Cells["Column3"].Value.ToString();
                txtMS.Text = a.Cells["cMaCTHD"].Value.ToString();
                btnSua.Visible = true;
            }
        }
        int dem = 0;
        string macthd = DateTime.Now.Year.ToString() +
                DateTime.Now.Day.ToString() +
                DateTime.Now.Month.ToString() + new Random().Next(0, 100);
        private void btnThem_Click(object sender, EventArgs e)
        {

            var a = new ThemHDBUS().ThemHD(txtMS.Text, macthd + dem, cboSP.SelectedValue.ToString(),
               cboSP.Text, nuSL.Value.ToString(), lblDonGia.Text.Trim());
            //if (a == )
            //{
            //    new ThemHDBUS().ThemHD(null, null,null,
            // null, nuSL.Value.ToString()+1, null);
            //}
            if (a != -100)
                {
                   
                    dem++;

                    new ThemHDBUS().XemDSHD(dgvSanPham, txtMS.Text);
                    TinhTien();
                    macthd_ = txtMS.Text;
                MessageBox.Show("Thêm thành công ");
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
         
         
        }

        private void TinhTien()
        {
            int tong = 0;
            string tong_;

            for (int i = 0; i < dgvSanPham.RowCount; i++)
            {
                var ncc = dgvSanPham.Rows[i].Cells[3].Value.ToString();
                var b = dgvSanPham.Rows[i].Cells[4].Value.ToString();
                string[] str = b.Split('.');
                tong += int.Parse(ncc) * int.Parse(str[0]);
            }
            if (tong.ToString().Length == 4)
            {
                string stt_1 = tong.ToString().Substring(0, 1);
                string stt_2 = tong.ToString().Substring(1);
                tong_ = stt_1 + "." + stt_2 + ".000 VND";
            }
            else
            {
                tong_ = tong.ToString();// + ".000 VND";
            }
            lblTinhTien.Text = tong_;

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = null;
        }

        private void cboSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            var r = new ThemHDBUS().DonGia(cboSP.SelectedValue.ToString());
            try
            {
                lblDonGia.Text = r["DonGia"].ToString();
            }
            catch
            {
                return;
            }
        }

        private void BangHanggg_Load(object sender, EventArgs e)
        {
            txtMS.Text = "";
            lblDonGia.Text = "0";


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnCreate.Enabled = true;
            var a = new ThemHDBUS().Sua(macthd_, cboSP.SelectedValue.ToString(), cboSP.Text, nuSL.Value.ToString(), lblDonGia.Text);
            if (a != -100)
            {
                btnSua.Visible = false;
                new ThemHDBUS().XemDSHD(dgvSanPham, txtMS.Text);
                TinhTien();
            }
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            QLSanPham qLSanPham = new QLSanPham(Tennv);
            qLSanPham.ShowDialog();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            double ThanhTien = double.Parse(lblTinhTien.Text);
            double tongtienHD = ThanhTien * 0.08 + ThanhTien;
            HoaDonDTO them = new HoaDonDTO()
            {
                MaHD = int.Parse(txtMS.Text),
                TenNV = Tennv,
                MaNV = Manv,
         //       MaKH = 0,
           //     NoiDung = null,
            //    ChiecKhau = 8,
                ThanhTien = (decimal)(ThanhTien),
                TongTien = (decimal)tongtienHD,
                NgayLapHD = DateTime.Now
            };
           // MessageBox.Show(tonghddon + "   " + tongtien2);

            if (_HoaDonBUS.ThemHoaDon(them))
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            new loginDoAn.NewFolder1.frmInHD(txtMS.Text, DateTime.Now.ToString(), Tennv).ShowDialog();
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnThanhToan_Click(this, new EventArgs());
        }

        private void làmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLamMoi_Click(this, new EventArgs());
        }
    }
}
