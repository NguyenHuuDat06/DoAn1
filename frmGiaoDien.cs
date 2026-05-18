using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BtlWF
{
    public partial class frmadmin : Form
    {
        public frmadmin()
        {
            InitializeComponent();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien QLNV = new frmQuanLyNhanVien();
            QLNV.ShowDialog();
        }
        private void btnQLKH_Click(object sender, EventArgs e)
        {
            frmQuanLyKhachHang QLKH = new frmQuanLyKhachHang();
            QLKH.ShowDialog();
        }

        private void btnQLHD_Click(object sender, EventArgs e)
        {
           frmQuanLyHoaDon qlhd = new frmQuanLyHoaDon();
            
            qlhd.ShowDialog();
        }
        private void btnQLSP_Click(object sender, EventArgs e)
        {
            frmQuanLySanPham qlsp = new frmQuanLySanPham();
            qlsp.isAdmin = true;
            qlsp.ShowDialog();
        }
        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau dmk = new frmDoiMatKhau();
            dmk.ShowDialog();
        }
    }
}
