namespace BtlWF
{
    partial class frmDangNhapNV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhapNV));
            label5 = new Label();
            lblThongBao = new Label();
            label4 = new Label();
            label3 = new Label();
            txtMatKhau = new TextBox();
            txtTaiKhoan = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnTroVe = new Button();
            btnDangNhap = new Button();
            pic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Coral;
            label5.Location = new Point(428, 69);
            label5.Name = "label5";
            label5.Size = new Size(330, 33);
            label5.TabIndex = 1;
            label5.Text = "ĐĂNG NHẬP NHÂN VIÊN";
            // 
            // lblThongBao
            // 
            lblThongBao.AutoSize = true;
            lblThongBao.BackColor = Color.Transparent;
            lblThongBao.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblThongBao.ForeColor = Color.Red;
            lblThongBao.Location = new Point(508, 226);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(0, 17);
            lblThongBao.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(619, 265);
            label4.Name = "label4";
            label4.Size = new Size(0, 22);
            label4.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Script", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 54);
            label3.Name = "label3";
            label3.Size = new Size(0, 71);
            label3.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(511, 193);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(247, 30);
            txtMatKhau.TabIndex = 5;
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhau.TextChanged += txtMatKhau_TextChanged;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(511, 151);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(247, 30);
            txtTaiKhoan.TabIndex = 4;
            txtTaiKhoan.TextChanged += txtTaiKhoan_TextChanged;
            txtTaiKhoan.KeyDown += txtTaiKhoan_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(401, 196);
            label2.Name = "label2";
            label2.Size = new Size(82, 22);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(401, 154);
            label1.Name = "label1";
            label1.Size = new Size(88, 22);
            label1.TabIndex = 2;
            label1.Text = "Tài khoản";
            // 
            // btnTroVe
            // 
            btnTroVe.BackColor = Color.LightSeaGreen;
            btnTroVe.ForeColor = SystemColors.HighlightText;
            btnTroVe.Location = new Point(711, 364);
            btnTroVe.Name = "btnTroVe";
            btnTroVe.Size = new Size(101, 31);
            btnTroVe.TabIndex = 9;
            btnTroVe.Text = "Trở về";
            btnTroVe.UseVisualStyleBackColor = false;
            btnTroVe.Click += btnTroVe_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.Coral;
            btnDangNhap.ForeColor = SystemColors.HighlightText;
            btnDangNhap.Location = new Point(573, 257);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(130, 30);
            btnDangNhap.TabIndex = 7;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // pic
            // 
            pic.BackColor = Color.Moccasin;
            pic.BackgroundImage = (Image)resources.GetObject("pic.BackgroundImage");
            pic.BackgroundImageLayout = ImageLayout.Stretch;
            pic.Location = new Point(52, 36);
            pic.Name = "pic";
            pic.Size = new Size(306, 285);
            pic.TabIndex = 10;
            pic.TabStop = false;
            // 
            // frmDangNhapNV
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(810, 393);
            Controls.Add(label5);
            Controls.Add(lblThongBao);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTroVe);
            Controls.Add(btnDangNhap);
            Controls.Add(pic);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmDangNhapNV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ứng dụng quản lý của hàng sách";
            Load += frmDangNhapNV_Load;
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.PictureBox pic;
    }
}