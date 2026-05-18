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
    public partial class frmHoaDon : Form
    {
        string tienKH, tenkh, tensp, sl, Gia, sdt, diachi, ThanhTien;



        private void dghd_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dghd.Rows)
            {
                if (!row.IsNewRow)
                {
                    total += Convert.ToDecimal(row.Cells[2].Value);
                }
            }

            // Hiển thị tổng bên dưới cột
            dghd.Rows[dghd.Rows.Count - 1].Cells[2].Value = total;
            dghd.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        public frmHoaDon(string sp, string soluong, string gia, string tenKH, string SDT, string Diachi, string TienKh, string thanhtien)
        {
            InitializeComponent();
            tensp = sp;
            sl = soluong;
            Gia = gia;
            tenkh = tenKH;
            sdt = SDT;
            diachi = Diachi;
            tienKH = TienKh;
            ThanhTien = thanhtien;
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            string[] a = tensp.Split(',');
            string[] b = sl.Split(',');
            string[] c = Gia.Split(',');
            for (int i = 0; i < a.Length; i++)
            {
                dghd.Rows.Add(a[i], b[i], c[i]);
            }
            txtTenKH.Text = tenkh;
            txtSDT.Text = sdt;
            txtDiaChi.Text = diachi;
            txtKHTT.Text = tienKH;
            txtThanhTien.Text = ThanhTien;
            string ok = ThanhTien.ToString();
            float x = float.Parse(ok);
            string ko = tienKH.ToString();
            float y = float.Parse(ko);
            float r = y - x;
            txtTraLai.Text = r.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
