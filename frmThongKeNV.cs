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
    public partial class frmThongKeNV : Form
    {
        public frmThongKeNV()
        {
            InitializeComponent();
        }
        KetNoiCSDL cl = new KetNoiCSDL();
        private void frmThongKeNV_Load(object sender, EventArgs e)
        {
            DataTable dt1 = cl.GetDataTable("select Top 1 NV.MaNV,TenNV,SDT,DoanhSo from NhanVien NV inner join Luong L on NV.MaNV = L.MaNV order by DoanhSo DESC");
            dt1.Columns["MaNV"].ColumnName = "Mã nhân viên";
            dt1.Columns["TenNV"].ColumnName = "Tên nhân viên";
            dt1.Columns["SDT"].ColumnName = "SĐT";
            dt1.Columns["DoanhSo"].ColumnName = "Doanh số";
            dgNVDS.DataSource = dt1;
            dgNVDS.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgNVDS.AutoResizeColumns();
            DataTable dt2 = cl.GetDataTable("select Top 1 NV.MaNV,TenNV,SDT,ThucLinh from NhanVien NV inner join Luong L on NV.MaNV = L.MaNV order by ThucLinh DESC");
            dt2.Columns["MaNV"].ColumnName = "Mã nhân viên";
            dt2.Columns["TenNV"].ColumnName = "Tên nhân viên";
            dt2.Columns["SDT"].ColumnName = "SĐT";
            dt2.Columns["ThucLinh"].ColumnName = "Lương";
            dgNVLuong.DataSource = dt2;
            dgNVLuong.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgNVLuong.AutoResizeColumns();
        }
    }
}
