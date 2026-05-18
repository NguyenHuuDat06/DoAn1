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
    public partial class nhanvien : Form
    {
        private string txttk, txtmk;
        public nhanvien(string tk, string mk)
        {
            InitializeComponent();
            txttk = tk;
            txtmk = mk; 
        }
        KetNoiCSDL cl = new KetNoiCSDL();
        private void btnQLKH_Click(object sender, EventArgs e)
        {
            frmQuanLyKhachHang qlkh = new frmQuanLyKhachHang();
            qlkh.ShowDialog();
        }
        private void btnQLHD_Click(object sender, EventArgs e)
        {
            hoadonnv hdnv = new hoadonnv(txtmk,txtmk);
            hdnv.ShowDialog();
        }
        private void btnQLSP_Click(object sender, EventArgs e)
        {
            frmQuanLySanPham qlsp = new frmQuanLySanPham();
            qlsp.ShowDialog();
        }


        private void nhanvien_Load(object sender, EventArgs e)
        {
            frmDangNhapNV frmDangNhapNV = new frmDangNhapNV();
            DataTable dt = cl.GetDataTable("select * from NhanVien where tkNV = '" + txttk + "' and mkNV = '" + txtmk + "' ");
            DataColumn dcl1, dcl2;
            dcl1 = dt.Columns["MaNV"];
            dcl2 = dt.Columns["TenNV"];
            DataRow dr;
            dr = dt.Rows[0];
            object value = dr[dcl1];
            object value2 = dr[dcl2];
        }
    }
}
