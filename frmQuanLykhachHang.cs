using System;
using System.Data;
using System.Windows.Forms;

namespace BtlWF
{
    public partial class frmQuanLyKhachHang : Form
    {
        KetNoiCSDL cl = new KetNoiCSDL();

        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }

        // ================= LOAD DATA =================
        void LoadKhachHang()
        {
            DataTable dt = cl.GetDataTable("SELECT * FROM KhachHang");
            dgKH.DataSource = dt;

            if (dgKH.Columns.Contains("MaKH")) dgKH.Columns["MaKH"].HeaderText = "Mã KH";
            if (dgKH.Columns.Contains("TenKH")) dgKH.Columns["TenKH"].HeaderText = "Tên KH";
            if (dgKH.Columns.Contains("DiaChi")) dgKH.Columns["DiaChi"].HeaderText = "Địa chỉ";
            if (dgKH.Columns.Contains("SDT")) dgKH.Columns["SDT"].HeaderText = "SĐT";
            if (dgKH.Columns.Contains("Email")) dgKH.Columns["Email"].HeaderText = "Email";

            dgKH.AutoResizeColumns();
        }

        // ================= FORM LOAD =================
        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }

        // ================= CLICK GRID =================
        private void dgKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow r = dgKH.Rows[e.RowIndex];

            txtMa.Text = r.Cells["MaKH"].Value?.ToString();
            txtTen.Text = r.Cells["TenKH"].Value?.ToString();
            txtDiaChi.Text = r.Cells["DiaChi"].Value?.ToString();
            txtSDT.Text = r.Cells["SDT"].Value?.ToString();
            txtEmail.Text = r.Cells["Email"].Value?.ToString();

            txtMa.ReadOnly = true;
            btSua.Enabled = true;
            btXoa.Enabled = true;
        }

        // ================= FIX LỖI DESIGNER =================
        private void dgKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // gọi lại CellClick để tránh lỗi Designer
            dgKH_CellClick(sender, e);
        }

        // ================= MỚI =================
        private void btMoi_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtTen.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtEmail.Clear();

            txtMa.ReadOnly = false;
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }

        // ================= SỬA =================
        private void btSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMa.Text)) return;

            if (MessageBox.Show("Bạn có chắc muốn sửa?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            string sql = $@"
                UPDATE KhachHang SET
                    TenKH = N'{txtTen.Text.Trim().Replace("'", "''")}',
                    DiaChi = N'{txtDiaChi.Text.Trim().Replace("'", "''")}',
                    SDT = '{txtSDT.Text.Trim().Replace("'", "''")}',
                    Email = '{txtEmail.Text.Trim().Replace("'", "''")}'
                WHERE MaKH = '{txtMa.Text.Trim().Replace("'", "''")}'";

            cl.ThucThiPKN(sql);

            LoadKhachHang();
            btMoi_Click(sender, e);

            MessageBox.Show("Cập nhật thành công!");
        }

        // ================= XÓA =================
        private void btXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text.Trim();
            if (string.IsNullOrEmpty(ma)) return;

            DataTable dt = cl.GetDataTable($"SELECT * FROM HoaDon WHERE MaKH = '{ma}'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Không thể xóa vì đã có hóa đơn!");
                return;
            }

            if (MessageBox.Show("Xóa khách hàng?", "Cảnh báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cl.ThucThiPKN($"DELETE FROM KhachHang WHERE MaKH = '{ma}'");

                LoadKhachHang();
                btMoi_Click(sender, e);

                MessageBox.Show("Đã xóa!");
            }
        }

        // ================= TÌM KIẾM =================
        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            if (dgKH.DataSource is DataTable dt)
            {
                dt.DefaultView.RowFilter =
                    $"TenKH LIKE '%{txtTim.Text.Trim().Replace("'", "''")}%'";
            }
        }

        // ================= CHỈ NHẬP SỐ =================
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}