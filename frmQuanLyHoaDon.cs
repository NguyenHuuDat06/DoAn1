using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BtlWF
{
    public partial class frmQuanLyHoaDon : Form
    {
        public frmQuanLyHoaDon()
        {
            InitializeComponent();
        }

        KetNoiCSDL cl = new KetNoiCSDL();
        void loadHD()
        {
            DataTable dtHD = cl.GetDataTable("select * from HoaDon");
            dtHD.Columns["MaHD"].ColumnName = "Mã hóa đơn";
            dtHD.Columns["MaKh"].ColumnName = "Mã khách hàng";
            dtHD.Columns["MaNV"].ColumnName = "Mã Nhân viên";
            dtHD.Columns["NgayMua"].ColumnName = "Thời gian";
            dgHD.DataSource = dtHD;
            dgHD.AutoResizeColumns();
        }
        void loadCTHD()
        {
            DataTable dtCTHD = cl.GetDataTable("select * from ChiTietHoaDon");
            dtCTHD.Columns["MaHD"].ColumnName = "Mã hóa đơn";
            dtCTHD.Columns["MaSP"].ColumnName = "Mã sản phẩm";
            dtCTHD.Columns["SL"].ColumnName = "Số lượng";
            dtCTHD.Columns["ThanhTien"].ColumnName = "Đơn giá";
            dgCTHD.DataSource = dtCTHD;
            dgCTHD.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgCTHD.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgCTHD.AutoResizeColumns();
        }
        void loadThongKe()
        {
            DataTable dt1 = cl.GetDataTable("select Top 1 TenSP, SLDaBan from SanPham ORDER BY SLDaBan DESC");
            dt1.Columns["TenSP"].ColumnName = "Tên sản phẩm";
            dt1.Columns["SLDaBan"].ColumnName = "Số lượng đã bán";
            dgSPBanChay.DataSource = dt1;
            dgSPBanChay.AutoResizeColumns();
            DataTable dt2 = cl.GetDataTable("select Top 1 TenSP, SLDaBan from SanPham ORDER BY SLDaBan ASC");
            dt2.Columns["TenSP"].ColumnName = "Tên sản phẩm";
            dt2.Columns["SLDaBan"].ColumnName = "Số lượng đã bán";
            dgSPBanE.DataSource = dt2;
            dgSPBanE.AutoResizeColumns();
            DataTable dt3 = cl.GetDataTable("Select MaSP,TenSP,GiaBan*SLDaBan as Doanhthu from SanPham ");
            dt3.Columns["MaSP"].ColumnName = "Mã sản phẩm";
            dt3.Columns["TenSP"].ColumnName = "Tên sản phẩm";
            dt3.Columns["Doanhthu"].ColumnName = "Doanh thu";
            dgDoanhThu.DataSource = dt3;
            dgDoanhThu.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgDoanhThu.AutoResizeColumns();
            DataTable dt4 = cl.GetDataTable("Select MaSP,TenSP,(GiaBan-GiaNhap)*SLDaBan as LoiNhuan from SanPham ");
            dt4.Columns["MaSP"].ColumnName = "Mã sản phẩm";
            dt4.Columns["TenSP"].ColumnName = "Tên sản phẩm";
            dt4.Columns["LoiNhuan"].ColumnName = "Lợi nhuận";
            dgLoiNhuan.DataSource = dt4;
            dgLoiNhuan.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgLoiNhuan.AutoResizeColumns();
        }
        public void frmQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            loadThongKe();
            // TODO: This line of code loads data into the 'qLQUANAODataSet.HoaDon' table. You can move, or remove it, as needed.
            loadHD();
            //
            loadCTHD();
            
            tabHD.ImageIndex = 0;
            tabCTHD.ImageIndex = 1;
            tabThongKe.ImageIndex = 2;
        }
        private void btThem_Click(object sender, EventArgs e)
        {

        }
        private void btBackHD_Click(object sender, EventArgs e)
        {
            if (dgHD.Rows.Count - 1 == cl.sbg("select count (*) from HoaDon")) { this.Close(); }
            else
            {
                loadHD();

            }
        }
        private void bttimKiemct_Click(object sender, EventArgs e)
        {

        }
        private void btBackCTHD_Click(object sender, EventArgs e)
        {
            if (dgCTHD.Rows.Count - 1 == cl.sbg("select count (*) from ChiTietHoaDon")) { this.Close(); }
            else
            {
                loadHD();

            }
        }
        private void dgDoanhThu_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgDoanhThu.Rows)
            {
                if (row.Cells[2].Value != DBNull.Value && row.Cells[2].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells[2].Value);
                }
            }
            dgDoanhThu.Rows[dgDoanhThu.Rows.Count - 1].Cells[2].Value = total;
        }

        private void dgLoiNhuan_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgLoiNhuan.Rows)
            {
                if (row.Cells[2].Value != DBNull.Value && row.Cells[2].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells[2].Value);
                }
            }
            dgLoiNhuan.Rows[dgLoiNhuan.Rows.Count - 1].Cells[2].Value = total;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabCTHD_Click(object sender, EventArgs e)
        {

        }

        private void btXuatHD_Click(object sender, EventArgs e)
        {
            if (dgHD.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn hóa đơn!");
                return;
            }

            string maHD = dgHD.CurrentRow.Cells[0].Value.ToString();

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt";
            sfd.FileName = "HoaDon_" + maHD + ".txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8);

                sw.WriteLine("========= HÓA ĐƠN =========");
                sw.WriteLine("Mã hóa đơn: " + dgHD.CurrentRow.Cells[0].Value);
                sw.WriteLine("Mã khách hàng: " + dgHD.CurrentRow.Cells[1].Value);
                sw.WriteLine("Mã nhân viên: " + dgHD.CurrentRow.Cells[2].Value);
                sw.WriteLine("Ngày mua: " + dgHD.CurrentRow.Cells[3].Value);

                sw.WriteLine();
                sw.WriteLine("===== CHI TIẾT HÓA ĐƠN =====");

                DataTable dt = cl.GetDataTable(
                    "SELECT * FROM ChiTietHoaDon WHERE MaHD = '" + maHD + "'");

                foreach (DataRow r in dt.Rows)
                {
                    sw.WriteLine(
                        "Mã SP: " + r["MaSP"] +
                        " | SL: " + r["SL"] +
                        " | Thành tiền: " + r["ThanhTien"]);
                }

                sw.WriteLine();
                sw.WriteLine("======= Cảm ơn quý khách =======");

                sw.Close();

                MessageBox.Show("Xuất hóa đơn thành công!");
            }

        }

        private void tabNhapHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
