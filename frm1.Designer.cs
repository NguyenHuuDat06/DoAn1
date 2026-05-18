namespace BTlWF
{
    partial class frm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1));
            label5 = new Label();
            llbDangKy = new LinkLabel();
            lblThongBao = new Label();
            label4 = new Label();
            label3 = new Label();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
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
            label5.Location = new Point(461, 74);
            label5.Name = "label5";
            label5.Size = new Size(270, 33);
            label5.TabIndex = 14;
            label5.Text = "ĐĂNG NHẬP ADMIN";
            // 
            // llbDangKy
            // 
            llbDangKy.AutoSize = true;
            llbDangKy.BackColor = Color.Transparent;
            llbDangKy.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llbDangKy.Location = new Point(548, 304);
            llbDangKy.Name = "llbDangKy";
            llbDangKy.Size = new Size(201, 17);
            llbDangKy.TabIndex = 22;
            llbDangKy.TabStop = true;
            llbDangKy.Text = "Bạn chưa có tài khoản? Đăng ký";
            llbDangKy.LinkClicked += llbDangKy_LinkClicked;
            // 
            // lblThongBao
            // 
            lblThongBao.AutoSize = true;
            lblThongBao.BackColor = Color.Transparent;
            lblThongBao.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblThongBao.ForeColor = Color.Red;
            lblThongBao.Location = new Point(515, 239);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(0, 17);
            lblThongBao.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(588, 282);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Script", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(66, 48);
            label3.Name = "label3";
            label3.Size = new Size(0, 71);
            label3.TabIndex = 13;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(517, 206);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(225, 27);
            txtMatKhau.TabIndex = 18;
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(518, 163);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(225, 27);
            txtTenDangNhap.TabIndex = 17;
            txtTenDangNhap.KeyDown += txtTenDangNhap_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(390, 209);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 16;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(390, 171);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 15;
            label1.Text = "Tên đăng nhập";
            // 
            // btnTroVe
            // 
            btnTroVe.BackColor = Color.LightSeaGreen;
            btnTroVe.ForeColor = SystemColors.HighlightText;
            btnTroVe.Location = new Point(672, 381);
            btnTroVe.Name = "btnTroVe";
            btnTroVe.Size = new Size(92, 31);
            btnTroVe.TabIndex = 23;
            btnTroVe.Text = "Trở về";
            btnTroVe.UseVisualStyleBackColor = false;
            btnTroVe.Click += btnTroVe_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.Coral;
            btnDangNhap.ForeColor = SystemColors.HighlightText;
            btnDangNhap.Location = new Point(567, 265);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(118, 30);
            btnDangNhap.TabIndex = 20;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // pic
            // 
            pic.BackgroundImage = (Image)resources.GetObject("pic.BackgroundImage");
            pic.BackgroundImageLayout = ImageLayout.Stretch;
            pic.Location = new Point(37, 38);
            pic.Name = "pic";
            pic.Size = new Size(309, 308);
            pic.TabIndex = 24;
            pic.TabStop = false;
            // 
            // frm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(767, 421);
            Controls.Add(label5);
            Controls.Add(llbDangKy);
            Controls.Add(lblThongBao);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTroVe);
            Controls.Add(btnDangNhap);
            Controls.Add(pic);
            Name = "frm1";
            Text = "frm1";
            Load += frm1_Load;
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private LinkLabel llbDangKy;
        private Label lblThongBao;
        private Label label4;
        private Label label3;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private Label label2;
        private Label label1;
        private Button btnTroVe;
        private Button btnDangNhap;
        private PictureBox pic;
    }
}