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
    public partial class hoadonnv : Form
    {
        private string txttk, txtmk;
        public hoadonnv(string tk, string mk)
        {
            InitializeComponent();
            txttk = tk;
            txtmk = mk;
        }
        KetNoiCSDL cl = new KetNoiCSDL();
        private void hoadonnv_Load(object sender, EventArgs e)
        {
            DataTable dtHD = cl.GetDataTable("select * from HoaDon where MaNV in(select MaNV from NhanVien where tkNV = '"+txttk+"' )");
            dtHD.Columns["MaHD"].ColumnName = "Mã hóa đơn";
            dtHD.Columns["MaKh"].ColumnName = "Mã khách hàng";
            dtHD.Columns["MaNV"].ColumnName = "Mã Nhân viên";
            dtHD.Columns["NgayMua"].ColumnName = "Thời gian";
            dgHD.DataSource = dtHD;
            dgHD.AutoResizeColumns();
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            frmDonHang lendon = new frmDonHang(txttk, txtmk);
            lendon.ShowDialog();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DataTable dtHD = cl.GetDataTable("select * from HoaDon where MaNV in(select MaNV from NhanVien where tkNV = '" + txttk + "' and NgayMua >= '" + dateTimePicker1.Text + "' and NgayMua <= '" + dateTimePicker2.Text+"')");
            dtHD.Columns["MaHD"].ColumnName = "Mã hóa đơn";
            dtHD.Columns["MaKh"].ColumnName = "Mã khách hàng";
            dtHD.Columns["MaNV"].ColumnName = "Mã Nhân viên";
            dtHD.Columns["NgayMua"].ColumnName = "Thời gian";
            dgHD.DataSource = dtHD;
            dgHD.AutoResizeColumns();
        }




    }
}
