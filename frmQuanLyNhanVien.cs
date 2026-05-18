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
    public partial class frmQuanLyNhanVien : Form
    {
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }
        KetNoiCSDL cl = new KetNoiCSDL();
        void LoadNhanVien()
        {
            DataTable dt = cl.GetDataTable("SELECT * FROM NhanVien");
            dgNV.DataSource = dt;

            dgNV.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dgNV.Columns["TenNV"].HeaderText = "Tên nhân viên";
            dgNV.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgNV.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgNV.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgNV.Columns["tkNV"].HeaderText = "Tài khoản";
            dgNV.Columns["mkNV"].HeaderText = "Mật khẩu";
            dgNV.Columns["SDT"].HeaderText = "Số điện thoại";
            dgNV.Columns["Role"].HeaderText = "Chức vụ";
            dgNV.AutoResizeColumns();
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string checkMa = $"SELECT COUNT(*) FROM NhanVien WHERE MaNV='{txtMa.Text.Trim()}'";
            if (cl.sbg(checkMa) > 0)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại");
                return;
            }

            string checkTK = $"SELECT COUNT(*) FROM NhanVien WHERE tkNV='{txtTKNV.Text.Trim()}'";
            if (cl.sbg(checkTK) > 0)
            {
                MessageBox.Show("Tài khoản đã tồn tại");
                return;
            }

            string sql = $"INSERT INTO NhanVien VALUES ('{txtMa.Text.Trim()}', N'{txtTen.Text.Trim()}', '{dateTimePicker1.Value:yyyy-MM-dd}', N'{cbGT.Text}', N'{txtDiaChi.Text}', '{txtTKNV.Text}', '{txtMKNV.Text}', '{txtSDT.Text}', N'{comboBox1.Text}' )";

            cl.ThucThiPKN(sql);
            LoadNhanVien();
            btMoi_Click(sender, e);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            string checkTK = $"SELECT COUNT(*) FROM NhanVien WHERE tkNV='{txtTKNV.Text.Trim()}' AND MaNV <> '{txtMa.Text.Trim()}'";

            if (cl.sbg(checkTK) > 0)
            {
                MessageBox.Show("Tài khoản đã thuộc nhân viên khác");
                return;
            }

            string sql = $"UPDATE NhanVien SET TenNV = N'{txtTen.Text}', NgaySinh = '{dateTimePicker1.Value:yyyy-MM-dd}', GioiTinh = N'{cbGT.Text}', DiaChi = N'{txtDiaChi.Text}', SDT = '{txtSDT.Text}', tkNV = '{txtTKNV.Text}', mkNV = '{txtMKNV.Text}', Role = N'{comboBox1.Text}'  WHERE MaNV = '{txtMa.Text}';";

            cl.ThucThiPKN(sql);
            LoadNhanVien();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa nhân viên này?", "Xác nhận",
               MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            string sql = $"DELETE FROM NhanVien WHERE MaNV='{txtMa.Text}'";
            cl.ThucThiPKN(sql);

            LoadNhanVien();
            btMoi_Click(sender, e);
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            if (dgNV.Rows.Count - 1 == cl.sbg("select count (*) from NhanVien")) { this.Close(); }
            else
            {
                frmQuanLyNhanVien_Load(sender, e);
            }
        }
        private void dgNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow r = dgNV.Rows[e.RowIndex];

            txtMa.Text = r.Cells["MaNV"].Value.ToString();
            txtTen.Text = r.Cells["TenNV"].Value.ToString();

            // KIỂM TRA NULL CHO NGÀY SINH TẠI ĐÂY
            if (r.Cells["NgaySinh"].Value != DBNull.Value && r.Cells["NgaySinh"].Value != null)
            {
                dateTimePicker1.Value = Convert.ToDateTime(r.Cells["NgaySinh"].Value);
            }
            else
            {
                dateTimePicker1.Value = DateTime.Now; // Nếu NULL thì để ngày hiện tại hoặc ngày mặc định
            }
            comboBox1.Text = r.Cells["Role"].Value.ToString();
            cbGT.Text = r.Cells["GioiTinh"].Value.ToString();
            txtDiaChi.Text = r.Cells["DiaChi"].Value.ToString();
            txtSDT.Text = r.Cells["SDT"].Value.ToString();
            txtTKNV.Text = r.Cells["tkNV"].Value.ToString();
            txtMKNV.Text = r.Cells["mkNV"].Value.ToString();
        }
        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

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
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeNV tk = new frmThongKeNV();
            tk.ShowDialog(); 
        }

        private void txtMa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtTen.Focus();
        }

        private void cbGT_SelectedIndexChanged(object sender, EventArgs e)
        {
                txtSDT.Focus();
        }

        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtDiaChi.Focus();
        }

        private void txtDiaChi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtTKNV.Focus();
        }

        private void txtTKNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtMKNV.Focus();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
            {
                btSua.Enabled = false;
                btXoa.Enabled = false;
            }
            else
            {
                btSua.Enabled = true;
                btXoa.Enabled = true;
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            frmQuanLyNhanVien_Load(sender, e);
            for (int i = dgNV.Rows.Count - 2; i >= 0; i--)
            {
                if (!dgNV[1, i].Value.ToString().Trim().ToUpper().Contains(txtTim.Text.Trim().ToUpper()))
                {
                    dgNV.Rows.RemoveAt(i);
                }
            }
        }
    }
}
