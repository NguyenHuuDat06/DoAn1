using BtlWF;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTlWF
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }
        KetNoiCSDL cl = new KetNoiCSDL();


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DataTable dtcheck = cl.GetDataTable(
        "SELECT Role FROM NhanVien WHERE tkNV = @tk AND mkNV = @mk",
        new SqlParameter("@tk", txtTenDangNhap.Text.Trim()),
        new SqlParameter("@mk", txtMatKhau.Text.Trim()) );

            if (dtcheck.Rows.Count == 1)
            {
                string role = dtcheck.Rows[0]["Role"].ToString();

                if (role == "Admin")
                {
                    new frmadmin().ShowDialog();
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền Admin!");
                }
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }

        private void llbDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangKyTaiKhoan dky = new frmDangKyTaiKhoan();
            dky.ShowDialog();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMatKhau.Focus();
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }

        private void frm1_Load(object sender, EventArgs e)
        {

        }
    }
}
