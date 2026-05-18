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
    public partial class frmDonHang : Form
    {
        private string txttk, txtmk;
        public frmDonHang(string tk, string mk)
        {
            InitializeComponent();
            txttk = tk;
            txtmk = mk;
        }



        private void btThemSP_Click(object sender, EventArgs e)
        {
            if (txtSL.Text.Trim() == "0")
            {
                lbTBHD.Text = "Vui lòng nhập số lượng!";return;
            }
            string value1 = cbMaSP.Text;
            string value2 = cbTenSP.Text;
            string value3 = txtSL.Text;
            string value4 = txtGia.Text;
            // Tạo ListViewItem và thêm vào ListView
            ListViewItem item = new ListViewItem(value1);
            item.SubItems.Add(value2);
            item.SubItems.Add(value3);
            item.SubItems.Add(value4);
            lwSP.Items.Add(item);
            string ma = cbMaSP.Text.Trim();
            string ten = cbTenSP.Text.Trim();
            float a = float.Parse( txtThanhTien.Text.Trim());
            float b = float.Parse(txtGia.Text.Trim());
            a += b;
            txtThanhTien.Text=a.ToString();
            //string listboxString = ma + "," + ten + "," + txtSL.Text.Trim() + "," + txtGia.Text.Trim();
            //lstSP.Items.Add(listboxString);
            int c = int.Parse(txtSL.Text);
            string strSua = $"update SanPham set SLDaBan = SLDaBan + {c} , SL = SL - {c} where MaSP = '" + cbMaSP.Text.Trim() + "'";
            cl.ThucThiPKN(strSua);
        }
        KetNoiCSDL cl = new KetNoiCSDL();
        private void frmDonHang_Load(object sender, EventArgs e)
        {
            DataTable dtMasp = cl.GetDataTable("select MaSP from SanPham");
            cbMaSP.DataSource = dtMasp;
            cbMaSP.DisplayMember = "MaSP";
            DataTable dtTensp = cl.GetDataTable("select TenSP from SanPham");
            cbTenSP.DataSource = dtTensp;
            cbTenSP.DisplayMember = "TenSP";
            btThemSP.Enabled = false;
        }
        private void cbMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xác định chỉ số của item được chọn trong comboBox1
            int selectedIndex = cbMaSP.SelectedIndex;

            // Kiểm tra xem chỉ số có hợp lệ hay không
            if (selectedIndex >= 0 && selectedIndex < cbTenSP.Items.Count)
            {
                // Chọn item tương ứng trong comboBox2 dựa trên chỉ số của item trong comboBox1
                cbTenSP.SelectedIndex = selectedIndex;
                txtSL.Focus();
            }
        }
        private void cbTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xác định chỉ số của item được chọn trong comboBox1
            int selectedIndex = cbTenSP.SelectedIndex;

            // Kiểm tra xem chỉ số có hợp lệ hay không
            if (selectedIndex >= 0 && selectedIndex < cbMaSP.Items.Count)
            {
                // Chọn item tương ứng trong comboBox2 dựa trên chỉ số của item trong comboBox1
                cbMaSP.SelectedIndex = selectedIndex;
            }
            txtSL.Text = "0";
            txtSL.Focus();
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            lbTBHD.Text = "";
            if (txtSL.Text == "") { txtGia.Text = ""; }
            else
            {
                DataTable dt = cl.GetDataTable("select * from SanPham where MaSP = '" + cbMaSP.Text.Trim() + "'");
                DataColumn dcl1, dcl2;
                dcl1 = dt.Columns["GiaBan"];
                dcl2 = dt.Columns["SL"];
                DataRow dr;
                dr = dt.Rows[0];
                object value = dr[dcl1];
                object value1 = dr[dcl2];
                float slton = float.Parse(value1.ToString());
                float a = float.Parse(value.ToString());
                float b = float.Parse(txtSL.Text);
                if (b > slton)
                {
                    btThemSP.Enabled = false;
                    lbTBHD.Text = "Số lượng vượt quá số lượng tồn kho";
                }
                else
                {
                    btThemSP.Enabled = true;
                    float thanhTien = a * b;
                    txtGia.Text = thanhTien.ToString();
                }
            }
        }
        private void btLenDon_Click(object sender, EventArgs e)
        {
            string result = "";
            string result1 = "";
            string result2 = "";
            foreach (ListViewItem item in lwSP.Items)
            {
                // Lấy giá trị của cột và ghép vào chuỗi
                string columnValue = item.SubItems[0].Text; 
                result += columnValue + ",";
                string columnValue1 = item.SubItems[2].Text; 
                result1 += columnValue1 + ",";
                string columnValue2 = item.SubItems[3].Text;
                result2 += columnValue2 + ",";
            }
            if (!string.IsNullOrEmpty(result))
            {
                result = result.TrimEnd(',');
            }
            if (!string.IsNullOrEmpty(result1))
            {
                result1 = result1.TrimEnd(',');
            }
            if (!string.IsNullOrEmpty(result1))
            {
                result2 = result2.TrimEnd(',');
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn tạo đơn hàng này không?", "Lên đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool kh = false;
                bool ok = false;
                DataTable dtcheck = cl.GetDataTable("select * from KhachHang where MaKh = '" + txtMaKH.Text.Trim() + "'");
                if (dtcheck.Rows.Count == 1)
                {
                    DataRow row = dtcheck.Rows[0];
                    string[] values = row.ItemArray.Select(x => x.ToString()).ToArray();
                    if (MessageBox.Show("Khách hàng cũ: \nMã khách hàng:" + values[0] + "\nTên khách hàng: " + values[1] + "\nĐịa chỉ: " + values[2] + "\nSĐT: " + values[3] + "\nEmail: " + values[4] + "", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ok = true;
                    }kh = false;
                }
                else kh = true;
                DataTable dtcheck1 = cl.GetDataTable("select * from HoaDon where MaHD = '" + txtMaHD.Text.Trim() + "'");
                if (dtcheck1.Rows.Count == 1)
                {
                    lbTBHD.Text = "Đã tồn tại mã mã hóa đơn: " + txtMaHD.Text.Trim(); ok = false; return;
                }
                else ok = true;
                DataTable dtcheckhd = cl.GetDataTable("select * from CTHoaDon where MaHD = '" + txtMaHD.Text.Trim() + "'");
                if (dtcheckhd.Rows.Count == 1)
                {
                    lbTBHD.Text = "Đã tồn tại mã mã hóa đơn: " + txtMaHD.Text.Trim(); ok = false; return;
                }
                else ok = true;
                DataTable dt = cl.GetDataTable("select * from NhanVien where tkNV = '" + txttk + "' and mkNV = '" + txtmk + "' ");
                DataColumn dcl1, dcl2;
                dcl1 = dt.Columns["MaNV"];
                DataRow dr;
                dr = dt.Rows[0];
                object value = dr[dcl1];
                DataTable dtcheckNV = cl.GetDataTable("select * from NhanVien where MaNV = '" + value.ToString().Trim() + "'");
                if (dtcheckNV.Rows.Count == 1)
                { ok = true; }
                else ok = false;
                frmQuanLyHoaDon qlhd = new frmQuanLyHoaDon();
                if (ok)
                {
                    if (kh)
                    {
                        string strThem = "insert into KhachHang values('" + txtMaKH.Text.Trim() + "',N'" + txtTenKH.Text.Trim() + "',N'" + txtDiaChi.Text.Trim() + "','" + txtSDT.Text.Trim() + "','" + txtEmail.Text.Trim() + "')";
                        cl.ThucThiPKN(strThem);
                        lbTB.Text = "";
                    }
                    string strThemHD = "insert into HoaDon values('" + txtMaHD.Text.Trim() + "','" + value.ToString().Trim() + "','" + txtMaKH.Text.Trim() + "','" + dtNgayMua.Text.Trim() + "')";
                    cl.ThucThiPKN(strThemHD);
                    lbTBHD.Text = "";

                    string strThemCTHD = "insert into CTHoaDon values('" + txtMaHD.Text.Trim() + "','" + result + "','" + result1 + "','" + txtThanhTien.Text.Trim() + "')";
                    cl.ThucThiPKN(strThemCTHD);
                    qlhd.frmQuanLyHoaDon_Load(sender, e);
                    lbTBHD.Text = "";
                    MessageBox.Show("Lên đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmHoaDon hd = new frmHoaDon(result, result1,result2,txtTenKH.Text.Trim(),txtSDT.Text.Trim(),txtDiaChi.Text.Trim(),txtKHTT.Text.Trim(),txtThanhTien.Text.Trim());
                    btMoi_Click(sender, e);
                    lwSP.Items.Clear();
                    hd.ShowDialog();
                }
            }
        }
        private void lstSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lwSP.Items.Count > 0)
            {
                btLenDon.Enabled = true;
            }
            else
            {
                btLenDon.Enabled = false;
            }
        }
        private void txtMaHD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtMaKH.Focus();
        }
        private void txtMaKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtTenKH.Focus();
        }
        private void txtTenKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtDiaChi.Focus();
        }
        private void txtDiaChi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtSDT.Focus();
        }
        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtEmail.Focus();
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtKHTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in groupBox1.Controls)
            {
                if (ctr is TextBox || ctr is ComboBox)
                {
                    ctr.Text = "";
                }
            }
            foreach (Control ctr in groupBox2.Controls)
            {
                if (ctr is TextBox || ctr is ComboBox)
                {
                    ctr.Text = "";
                }
            }
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox || ctr is ComboBox)
                {
                    ctr.Text = "";
                }
            }
        }
    }
}

