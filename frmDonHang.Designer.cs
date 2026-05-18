namespace BtlWF
{
    partial class frmDonHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonHang));
            groupBox2 = new GroupBox();
            btThemSP = new Button();
            txtSL = new TextBox();
            cbTenSP = new ComboBox();
            cbMaSP = new ComboBox();
            label9 = new Label();
            label7 = new Label();
            label10 = new Label();
            label8 = new Label();
            txtGia = new TextBox();
            dtNgayMua = new DateTimePicker();
            label6 = new Label();
            groupBox1 = new GroupBox();
            txtMaKH = new TextBox();
            txtTenKH = new TextBox();
            label1 = new Label();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtDiaChi = new TextBox();
            label2 = new Label();
            lbTB = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lbTBHD = new Label();
            txtThanhTien = new TextBox();
            label11 = new Label();
            txtMaHD = new TextBox();
            label12 = new Label();
            btMoi = new Button();
            btLenDon = new Button();
            label13 = new Label();
            txtKHTT = new TextBox();
            lwSP = new ListView();
            masp = new ColumnHeader();
            tensp = new ColumnHeader();
            soluong = new ColumnHeader();
            dongia = new ColumnHeader();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btThemSP);
            groupBox2.Controls.Add(txtSL);
            groupBox2.Controls.Add(cbTenSP);
            groupBox2.Controls.Add(cbMaSP);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtGia);
            groupBox2.Location = new Point(439, 67);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(363, 274);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sản phẩm";
            // 
            // btThemSP
            // 
            btThemSP.Location = new Point(207, 227);
            btThemSP.Name = "btThemSP";
            btThemSP.Size = new Size(150, 37);
            btThemSP.TabIndex = 8;
            btThemSP.Text = "Thêm sản phẩm";
            btThemSP.UseVisualStyleBackColor = true;
            btThemSP.Click += btThemSP_Click;
            // 
            // txtSL
            // 
            txtSL.Location = new Point(119, 121);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(238, 28);
            txtSL.TabIndex = 6;
            txtSL.TextChanged += txtSL_TextChanged;
            txtSL.KeyPress += txtSL_KeyPress;
            // 
            // cbTenSP
            // 
            cbTenSP.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTenSP.FormattingEnabled = true;
            cbTenSP.Location = new Point(119, 81);
            cbTenSP.Name = "cbTenSP";
            cbTenSP.Size = new Size(238, 30);
            cbTenSP.TabIndex = 5;
            cbTenSP.SelectedIndexChanged += cbTenSP_SelectedIndexChanged;
            // 
            // cbMaSP
            // 
            cbMaSP.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaSP.FormattingEnabled = true;
            cbMaSP.Location = new Point(119, 40);
            cbMaSP.Name = "cbMaSP";
            cbMaSP.Size = new Size(238, 30);
            cbMaSP.TabIndex = 4;
            cbMaSP.SelectedIndexChanged += cbMaSP_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 46);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(63, 22);
            label9.TabIndex = 0;
            label9.Text = "Mã SP";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(16, 162);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(38, 22);
            label7.TabIndex = 3;
            label7.Text = "Giá";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 87);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(71, 22);
            label10.TabIndex = 1;
            label10.Text = "Tên SP";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 124);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(32, 22);
            label8.TabIndex = 2;
            label8.Text = "SL";
            // 
            // txtGia
            // 
            txtGia.Location = new Point(119, 159);
            txtGia.Name = "txtGia";
            txtGia.ReadOnly = true;
            txtGia.Size = new Size(238, 28);
            txtGia.TabIndex = 7;
            txtGia.Text = "0";
            txtGia.TextAlign = HorizontalAlignment.Right;
            // 
            // dtNgayMua
            // 
            dtNgayMua.Format = DateTimePickerFormat.Custom;
            dtNgayMua.Location = new Point(147, 389);
            dtNgayMua.Name = "dtNgayMua";
            dtNgayMua.Size = new Size(239, 28);
            dtNgayMua.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(34, 389);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(91, 22);
            label6.TabIndex = 6;
            label6.Text = "Ngày mua";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtMaKH);
            groupBox1.Controls.Add(txtTenKH);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lbTB);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(39, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(355, 274);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Khách hàng";
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(109, 40);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(238, 28);
            txtMaKH.TabIndex = 5;
            txtMaKH.KeyDown += txtMaKH_KeyDown;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(109, 81);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(238, 28);
            txtTenKH.TabIndex = 6;
            txtTenKH.KeyDown += txtTenKH_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 22);
            label1.TabIndex = 0;
            label1.Text = "Mã KH";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(109, 196);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(238, 28);
            txtEmail.TabIndex = 9;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(109, 159);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(238, 28);
            txtSDT.TabIndex = 8;
            txtSDT.KeyDown += txtSDT_KeyDown;
            txtSDT.KeyPress += txtSDT_KeyPress;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(109, 121);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(238, 28);
            txtDiaChi.TabIndex = 7;
            txtDiaChi.KeyDown += txtDiaChi_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 84);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 22);
            label2.TabIndex = 1;
            label2.Text = "Tên KH";
            // 
            // lbTB
            // 
            lbTB.AutoSize = true;
            lbTB.BackColor = Color.Transparent;
            lbTB.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbTB.ForeColor = Color.Red;
            lbTB.Location = new Point(105, 227);
            lbTB.Margin = new Padding(4, 0, 4, 0);
            lbTB.Name = "lbTB";
            lbTB.Size = new Size(0, 18);
            lbTB.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 199);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 22);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 162);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 22);
            label4.TabIndex = 2;
            label4.Text = "SĐT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 124);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 22);
            label3.TabIndex = 3;
            label3.Text = "Địa chỉ";
            // 
            // lbTBHD
            // 
            lbTBHD.AutoSize = true;
            lbTBHD.BackColor = Color.Transparent;
            lbTBHD.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbTBHD.ForeColor = Color.Red;
            lbTBHD.Location = new Point(245, 344);
            lbTBHD.Margin = new Padding(4, 0, 4, 0);
            lbTBHD.Name = "lbTBHD";
            lbTBHD.Size = new Size(0, 20);
            lbTBHD.TabIndex = 5;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(147, 429);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(239, 28);
            txtThanhTien.TabIndex = 10;
            txtThanhTien.Text = "0";
            txtThanhTien.TextAlign = HorizontalAlignment.Right;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Location = new Point(35, 432);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(96, 22);
            label11.TabIndex = 7;
            label11.Text = "Thành tiền";
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(161, 25);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(238, 28);
            txtMaHD.TabIndex = 1;
            txtMaHD.KeyDown += txtMaHD_KeyDown;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Location = new Point(28, 25);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(107, 22);
            label12.TabIndex = 0;
            label12.Text = "Mã Hóa đơn";
            // 
            // btMoi
            // 
            btMoi.BackColor = Color.FromArgb(192, 255, 255);
            btMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btMoi.Location = new Point(206, 524);
            btMoi.Name = "btMoi";
            btMoi.Size = new Size(160, 54);
            btMoi.TabIndex = 0;
            btMoi.Text = "Hóa đơn mới";
            btMoi.TextAlign = ContentAlignment.MiddleRight;
            btMoi.UseVisualStyleBackColor = false;
            btMoi.Click += btMoi_Click;
            // 
            // btLenDon
            // 
            btLenDon.BackColor = Color.FromArgb(192, 255, 255);
            btLenDon.ImageAlign = ContentAlignment.MiddleLeft;
            btLenDon.Location = new Point(483, 524);
            btLenDon.Name = "btLenDon";
            btLenDon.Size = new Size(151, 54);
            btLenDon.TabIndex = 13;
            btLenDon.Text = "Lên đơn";
            btLenDon.TextAlign = ContentAlignment.MiddleRight;
            btLenDon.UseVisualStyleBackColor = false;
            btLenDon.Click += btLenDon_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Location = new Point(35, 470);
            label13.Name = "label13";
            label13.Size = new Size(196, 22);
            label13.TabIndex = 8;
            label13.Text = "Khách hàng thanh toán";
            // 
            // txtKHTT
            // 
            txtKHTT.ImeMode = ImeMode.Off;
            txtKHTT.Location = new Point(237, 467);
            txtKHTT.Name = "txtKHTT";
            txtKHTT.Size = new Size(148, 28);
            txtKHTT.TabIndex = 11;
            txtKHTT.KeyPress += txtKHTT_KeyPress;
            // 
            // lwSP
            // 
            lwSP.Columns.AddRange(new ColumnHeader[] { masp, tensp, soluong, dongia });
            lwSP.Location = new Point(439, 373);
            lwSP.Name = "lwSP";
            lwSP.Size = new Size(363, 122);
            lwSP.TabIndex = 14;
            lwSP.UseCompatibleStateImageBehavior = false;
            lwSP.View = View.Details;
            // 
            // masp
            // 
            masp.Text = "Mã SP";
            masp.Width = 70;
            // 
            // tensp
            // 
            tensp.Text = "Tên SP";
            tensp.Width = 120;
            // 
            // soluong
            // 
            soluong.Text = "Số lượng";
            soluong.Width = 84;
            // 
            // dongia
            // 
            dongia.Text = "Đơn giá";
            dongia.Width = 113;
            // 
            // frmDonHang
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(837, 614);
            Controls.Add(lwSP);
            Controls.Add(txtKHTT);
            Controls.Add(label13);
            Controls.Add(btLenDon);
            Controls.Add(btMoi);
            Controls.Add(dtNgayMua);
            Controls.Add(txtMaHD);
            Controls.Add(label6);
            Controls.Add(label12);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lbTBHD);
            Controls.Add(label11);
            Controls.Add(txtThanhTien);
            Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmDonHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đơn hàng";
            Load += frmDonHang_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtNgayMua;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTenSP;
        private System.Windows.Forms.ComboBox cbMaSP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTBHD;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Button btThemSP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btMoi;
        private System.Windows.Forms.Button btLenDon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtKHTT;
        private System.Windows.Forms.ListView lwSP;
        private System.Windows.Forms.ColumnHeader masp;
        private System.Windows.Forms.ColumnHeader tensp;
        private System.Windows.Forms.ColumnHeader soluong;
        private System.Windows.Forms.ColumnHeader dongia;
    }
}