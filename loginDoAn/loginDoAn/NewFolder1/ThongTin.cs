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
    public partial class frmThongTin : Form
    {
        public string Tennv;
        public string Manv;
        public string chucvuu;
        public frmThongTin(string TenNV, string Chucvu, string MaNV)
        {
            InitializeComponent();
            Tennv = TenNV;
            Manv = MaNV;
            chucvuu = Chucvu;
            lblMaNV.Text = Manv;
            lblTen.Text = Tennv;
            lblChucvu.Text = chucvuu;
        }

        private void frmThongTin_Load(object sender, EventArgs e)
        {

        }
    }
}
