using System;
using System.Data;
using System.Windows.Forms;

namespace BtlWF
{
    public partial class frmQuanLySanPham : Form
    {
        public bool isAdmin = true;
        KetNoiCSDL cl = new KetNoiCSDL();

        public frmQuanLySanPham()
        {
            InitializeComponent();
        }

        // ================= LOAD =================

        void loadSP()
        {
            DataTable dtSP = cl.GetDataTable(
                "SELECT MaSP, TenSP, SL, GiaNhap, GiaBan, SLDaBan, MaNCC FROM SanPham");

            dgSP.DataSource = dtSP;
            dgSP.AutoResizeColumns();
        }

        void loadNCC()
        {
            DataTable dtNCC = cl.GetDataTable("SELECT * FROM NhaCungCap");
            dgNCC.DataSource = dtNCC;
            dgNCC.AutoResizeColumns();
        }

        // ================= FORM LOAD =================

        private void frmQuanLySanPham_Load(object sender, EventArgs e)
        {
            loadSP();
            loadNCC();

            if (isAdmin)
            {
                btThem.Enabled = true;
                btSua.Enabled = false;
                btXoa.Enabled = false;

                btThemNCC.Enabled = true;
                btSuaNCC.Enabled = true;
                btXoaNCC.Enabled = true;
            }
            else
            {
                btThem.Enabled = false;
                btSua.Enabled = false;
                btXoa.Enabled = false;

                btThemNCC.Enabled = false;
                btSuaNCC.Enabled = false;
                btXoaNCC.Enabled = false;
            }
        }

        // ================= CHECK INPUT SỐ =================
        bool IsNumber(string s)
        {
            return int.TryParse(s, out _);
        }

        // ================= NHÀ CUNG CẤP =================

        private void btThemNCC_Click(object sender, EventArgs e)
        {
            string ma = txtMaNCC.Text.Trim();

            DataTable dtcheck = cl.GetDataTable(
                "SELECT * FROM NhaCungCap WHERE MaNCC = '" + ma + "'");

            if (dtcheck.Rows.Count > 0)
            {
                lbTBNCC.Text = "Đã tồn tại NCC";
                return;
            }

            string sql = "INSERT INTO NhaCungCap VALUES(" +
                         "'" + ma + "',N'" + txtTenNCC.Text.Trim() + "',N'" +
                         txtDiaChiNCC.Text.Trim() + "','" + txtSDTNCC.Text.Trim() + "')";

            cl.ThucThiPKN(sql);
            loadNCC();
        }

        private void btXoaNCC_Click(object sender, EventArgs e)
        {
            string ma = txtMaNCC.Text.Trim();

            DataTable dtcheck = cl.GetDataTable(
                "SELECT * FROM NhaCungCap WHERE MaNCC = '" + ma + "'");

            if (dtcheck.Rows.Count == 0)
            {
                lbTBNCC.Text = "Không tìm thấy NCC";
                return;
            }

            if (MessageBox.Show("Xóa NCC sẽ ảnh hưởng sản phẩm. Xóa?",
                "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cl.ThucThiPKN(
                    "DELETE FROM NhaCungCap WHERE MaNCC = '" + ma + "'");
                loadNCC();
            }
        }

        // ================= SẢN PHẨM =================

        private void btThem_Click(object sender, EventArgs e)
        {
            string maSP = txtMa.Text.Trim();
            string maNCC = txtNCC.Text.Trim();

            if (!IsNumber(txtSL.Text) || !IsNumber(txtGianhap.Text) ||
                !IsNumber(txtGiaBan.Text) || !IsNumber(txtSLDaBan.Text))
            {
                MessageBox.Show("Các ô số phải là số!");
                return;
            }

            DataTable dtcheck = cl.GetDataTable(
                "SELECT * FROM SanPham WHERE MaSP = '" + maSP + "'");

            if (dtcheck.Rows.Count > 0)
            {
                lbTBSP.Text = "Đã tồn tại mã SP";
                return;
            }

            DataTable dtcheckNCC = cl.GetDataTable(
                "SELECT * FROM NhaCungCap WHERE MaNCC = '" + maNCC + "'");

            if (dtcheckNCC.Rows.Count == 0)
            {
                lbTBSP.Text = "Không tồn tại NCC";
                return;
            }

            string sql = "INSERT INTO SanPham(MaSP, TenSP, SL, GiaNhap, GiaBan, SLDaBan, MaNCC) VALUES(" +
                         "'" + maSP + "'," +
                         "N'" + txtTen.Text.Trim() + "'," +
                         txtSL.Text + "," +
                         txtGianhap.Text + "," +
                         txtGiaBan.Text + "," +
                         txtSLDaBan.Text + "," +
                         "'" + maNCC + "')";

            cl.ThucThiPKN(sql);
            loadSP();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string maSP = txtMa.Text.Trim();
            string maNCC = txtNCC.Text.Trim();

            if (!IsNumber(txtSL.Text) || !IsNumber(txtGianhap.Text) ||
                !IsNumber(txtGiaBan.Text) || !IsNumber(txtSLDaBan.Text))
            {
                MessageBox.Show("Các ô số phải là số!");
                return;
            }

            string sql = "UPDATE SanPham SET " +
                         "TenSP = N'" + txtTen.Text.Trim() + "'," +
                         "SL = " + txtSL.Text + "," +
                         "GiaNhap = " + txtGianhap.Text + "," +
                         "GiaBan = " + txtGiaBan.Text + "," +
                         "SLDaBan = " + txtSLDaBan.Text + "," +
                         "MaNCC = '" + maNCC + "'" +
                         " WHERE MaSP = '" + maSP + "'";

            cl.ThucThiPKN(sql);
            loadSP();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string maSP = txtMa.Text.Trim();

            cl.ThucThiPKN(
                "DELETE FROM SanPham WHERE MaSP = '" + maSP + "'");

            loadSP();
        }

        // ================= CLICK GRID =================

        private void dgSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow r = dgSP.Rows[e.RowIndex];

            txtMa.Text = r.Cells["MaSP"].Value.ToString();
            txtTen.Text = r.Cells["TenSP"].Value.ToString();
            txtNCC.Text = r.Cells["MaNCC"].Value.ToString();

            btSua.Enabled = true;
            btXoa.Enabled = true;
        }
    }
}