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
    public partial class frmTaiKhoann : Form
    {
        public frmTaiKhoann()
        {
            InitializeComponent();
        }

    
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDanhNhap a = new frmDanhNhap();
            a.Show(); 

        }

        private void btnQuanLiTK_Click(object sender, EventArgs e)
        {

        }
    }
}
