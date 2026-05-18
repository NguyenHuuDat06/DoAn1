namespace BtlWF
{
    partial class frmQuanLyHoaDon
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyHoaDon));
            imageList1 = new ImageList(components);
            tabNhapHoaDon = new TabPage();
            tabThongKe = new TabPage();
            dgSPBanChay = new DataGridView();
            dgLoiNhuan = new DataGridView();
            dgSPBanE = new DataGridView();
            dgDoanhThu = new DataGridView();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            tabCTHD = new TabPage();
            pictureBox2 = new PictureBox();
            label13 = new Label();
            dgCTHD = new DataGridView();
            btBackCTHD = new Button();
            btXuatHD = new Button();
            tabHD = new TabPage();
            groupBox1 = new GroupBox();
            dgHD = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btTimKiem = new Button();
            btBackHD = new Button();
            tab = new TabControl();
            dataGridView1 = new DataGridView();
            clTenSp = new DataGridViewTextBoxColumn();
            clSL = new DataGridViewTextBoxColumn();
            clDonGia1 = new DataGridViewTextBoxColumn();
            txtSDT = new TextBox();
            txtTraLai = new TextBox();
            txtKHTT = new TextBox();
            txtThanhTien = new TextBox();
            txtDiaChi = new TextBox();
            txtTenKH = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label7 = new Label();
            label2 = new Label();
            label6 = new Label();
            label4 = new Label();
            label8 = new Label();
            tabNhapHoaDon.SuspendLayout();
            tabThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgSPBanChay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgLoiNhuan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgSPBanE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgDoanhThu).BeginInit();
            tabCTHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgCTHD).BeginInit();
            tabHD.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgHD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-bill-64 (2) (1).png");
            imageList1.Images.SetKeyName(1, "icons8-detail-80 (1).png");
            imageList1.Images.SetKeyName(2, "icons8-analytics-48.ico");
            imageList1.Images.SetKeyName(3, "edit.png");
            imageList1.Images.SetKeyName(4, "icons8-back-100 (1).png");
            imageList1.Images.SetKeyName(5, "icons8-search-64 (1).png");
            // 
            // tabNhapHoaDon
            // 
            tabNhapHoaDon.Controls.Add(dataGridView1);
            tabNhapHoaDon.Controls.Add(txtSDT);
            tabNhapHoaDon.Controls.Add(txtTraLai);
            tabNhapHoaDon.Controls.Add(txtKHTT);
            tabNhapHoaDon.Controls.Add(txtThanhTien);
            tabNhapHoaDon.Controls.Add(txtDiaChi);
            tabNhapHoaDon.Controls.Add(txtTenKH);
            tabNhapHoaDon.Controls.Add(label5);
            tabNhapHoaDon.Controls.Add(label3);
            tabNhapHoaDon.Controls.Add(label7);
            tabNhapHoaDon.Controls.Add(label2);
            tabNhapHoaDon.Controls.Add(label6);
            tabNhapHoaDon.Controls.Add(label4);
            tabNhapHoaDon.Controls.Add(label8);
            tabNhapHoaDon.Location = new Point(4, 31);
            tabNhapHoaDon.Name = "tabNhapHoaDon";
            tabNhapHoaDon.Padding = new Padding(3);
            tabNhapHoaDon.Size = new Size(916, 536);
            tabNhapHoaDon.TabIndex = 3;
            tabNhapHoaDon.Text = "Nhập Hóa Đơn ";
            tabNhapHoaDon.UseVisualStyleBackColor = true;
            tabNhapHoaDon.Click += tabNhapHoaDon_Click;
            // 
            // tabThongKe
            // 
            tabThongKe.Controls.Add(label12);
            tabThongKe.Controls.Add(label11);
            tabThongKe.Controls.Add(label10);
            tabThongKe.Controls.Add(label9);
            tabThongKe.Controls.Add(dgDoanhThu);
            tabThongKe.Controls.Add(dgSPBanE);
            tabThongKe.Controls.Add(dgLoiNhuan);
            tabThongKe.Controls.Add(dgSPBanChay);
            tabThongKe.Location = new Point(4, 31);
            tabThongKe.Name = "tabThongKe";
            tabThongKe.Padding = new Padding(3);
            tabThongKe.Size = new Size(916, 536);
            tabThongKe.TabIndex = 2;
            tabThongKe.Text = "Thống kê";
            tabThongKe.UseVisualStyleBackColor = true;
            // 
            // dgSPBanChay
            // 
            dgSPBanChay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgSPBanChay.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgSPBanChay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSPBanChay.Location = new Point(3, 61);
            dgSPBanChay.Name = "dgSPBanChay";
            dgSPBanChay.RowHeadersWidth = 51;
            dgSPBanChay.RowTemplate.Height = 24;
            dgSPBanChay.Size = new Size(444, 143);
            dgSPBanChay.TabIndex = 0;
            // 
            // dgLoiNhuan
            // 
            dgLoiNhuan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgLoiNhuan.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgLoiNhuan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLoiNhuan.Location = new Point(484, 265);
            dgLoiNhuan.Name = "dgLoiNhuan";
            dgLoiNhuan.RowHeadersWidth = 51;
            dgLoiNhuan.RowTemplate.Height = 24;
            dgLoiNhuan.Size = new Size(428, 270);
            dgLoiNhuan.TabIndex = 0;
            dgLoiNhuan.DataBindingComplete += dgLoiNhuan_DataBindingComplete;
            // 
            // dgSPBanE
            // 
            dgSPBanE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgSPBanE.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgSPBanE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSPBanE.Location = new Point(484, 61);
            dgSPBanE.Name = "dgSPBanE";
            dgSPBanE.RowHeadersWidth = 51;
            dgSPBanE.RowTemplate.Height = 24;
            dgSPBanE.Size = new Size(428, 143);
            dgSPBanE.TabIndex = 0;
            // 
            // dgDoanhThu
            // 
            dgDoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgDoanhThu.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgDoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDoanhThu.Location = new Point(3, 265);
            dgDoanhThu.Name = "dgDoanhThu";
            dgDoanhThu.RowHeadersWidth = 51;
            dgDoanhThu.RowTemplate.Height = 24;
            dgDoanhThu.Size = new Size(444, 270);
            dgDoanhThu.TabIndex = 0;
            dgDoanhThu.DataBindingComplete += dgDoanhThu_DataBindingComplete;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 36);
            label9.Name = "label9";
            label9.Size = new Size(209, 22);
            label9.TabIndex = 1;
            label9.Text = "Sản phẩm bán chạy nhất";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(480, 36);
            label10.Name = "label10";
            label10.Size = new Size(141, 22);
            label10.TabIndex = 1;
            label10.Text = "Sản phẩm bán ế";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(-1, 240);
            label11.Name = "label11";
            label11.Size = new Size(98, 22);
            label11.TabIndex = 1;
            label11.Text = "Doanh thu ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(480, 240);
            label12.Name = "label12";
            label12.Size = new Size(89, 22);
            label12.TabIndex = 1;
            label12.Text = "Lợi nhuận";
            // 
            // tabCTHD
            // 
            tabCTHD.Controls.Add(btXuatHD);
            tabCTHD.Controls.Add(btBackCTHD);
            tabCTHD.Controls.Add(dgCTHD);
            tabCTHD.Controls.Add(label13);
            tabCTHD.Controls.Add(pictureBox2);
            tabCTHD.Location = new Point(4, 31);
            tabCTHD.Margin = new Padding(4);
            tabCTHD.Name = "tabCTHD";
            tabCTHD.Padding = new Padding(4);
            tabCTHD.Size = new Size(916, 536);
            tabCTHD.TabIndex = 1;
            tabCTHD.Text = "Chi tiết hóa đơn";
            tabCTHD.UseVisualStyleBackColor = true;
            tabCTHD.Click += tabCTHD_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(669, 135);
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Monotype Corsiva", 19.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DarkRed;
            label13.Location = new Point(599, 4);
            label13.Name = "label13";
            label13.Size = new Size(309, 40);
            label13.TabIndex = 36;
            label13.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // dgCTHD
            // 
            dgCTHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgCTHD.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgCTHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCTHD.Location = new Point(0, 141);
            dgCTHD.Name = "dgCTHD";
            dgCTHD.RowHeadersWidth = 51;
            dgCTHD.RowTemplate.Height = 24;
            dgCTHD.Size = new Size(752, 392);
            dgCTHD.TabIndex = 0;
            // 
            // btBackCTHD
            // 
            btBackCTHD.BackColor = Color.FromArgb(192, 255, 255);
            btBackCTHD.ForeColor = SystemColors.ControlText;
            btBackCTHD.ImageAlign = ContentAlignment.MiddleLeft;
            btBackCTHD.Location = new Point(758, 471);
            btBackCTHD.Name = "btBackCTHD";
            btBackCTHD.Size = new Size(158, 58);
            btBackCTHD.TabIndex = 27;
            btBackCTHD.Text = "Trở về";
            btBackCTHD.UseVisualStyleBackColor = false;
            btBackCTHD.Click += btBackCTHD_Click;
            // 
            // btXuatHD
            // 
            btXuatHD.BackColor = Color.Aqua;
            btXuatHD.Location = new Point(763, 396);
            btXuatHD.Name = "btXuatHD";
            btXuatHD.Size = new Size(150, 55);
            btXuatHD.TabIndex = 37;
            btXuatHD.Text = "Xuất Hóa Đơn ";
            btXuatHD.UseVisualStyleBackColor = false;
            btXuatHD.Click += btXuatHD_Click;
            // 
            // tabHD
            // 
            tabHD.BackColor = Color.BlanchedAlmond;
            tabHD.Controls.Add(btBackHD);
            tabHD.Controls.Add(btTimKiem);
            tabHD.Controls.Add(label1);
            tabHD.Controls.Add(pictureBox1);
            tabHD.Controls.Add(groupBox1);
            tabHD.Location = new Point(4, 31);
            tabHD.Margin = new Padding(4);
            tabHD.Name = "tabHD";
            tabHD.Padding = new Padding(4);
            tabHD.Size = new Size(916, 536);
            tabHD.TabIndex = 0;
            tabHD.Text = "Hóa đơn";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgHD);
            groupBox1.Location = new Point(3, 148);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(910, 385);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách hóa đơn";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dgHD
            // 
            dgHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgHD.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgHD.Location = new Point(8, 30);
            dgHD.Margin = new Padding(5, 6, 5, 6);
            dgHD.Name = "dgHD";
            dgHD.RowHeadersWidth = 51;
            dgHD.RowTemplate.Height = 24;
            dgHD.Size = new Size(894, 346);
            dgHD.TabIndex = 1;
            dgHD.CellContentClick += dgHD_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.BlanchedAlmond;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(735, 142);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(946, -11);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 22);
            label1.TabIndex = 0;
            // 
            // btTimKiem
            // 
            btTimKiem.BackColor = Color.FromArgb(192, 255, 255);
            btTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btTimKiem.ImageIndex = 5;
            btTimKiem.ImageList = imageList1;
            btTimKiem.Location = new Point(742, 8);
            btTimKiem.Margin = new Padding(4);
            btTimKiem.Name = "btTimKiem";
            btTimKiem.Size = new Size(170, 50);
            btTimKiem.TabIndex = 6;
            btTimKiem.Text = "Tìm kiếm";
            btTimKiem.UseVisualStyleBackColor = false;
            // 
            // btBackHD
            // 
            btBackHD.BackColor = Color.FromArgb(192, 255, 255);
            btBackHD.ImageAlign = ContentAlignment.MiddleLeft;
            btBackHD.ImageIndex = 4;
            btBackHD.ImageList = imageList1;
            btBackHD.Location = new Point(742, 91);
            btBackHD.Name = "btBackHD";
            btBackHD.Size = new Size(167, 51);
            btBackHD.TabIndex = 1;
            btBackHD.Text = "Trở về";
            btBackHD.UseVisualStyleBackColor = false;
            btBackHD.Click += btBackHD_Click;
            // 
            // tab
            // 
            tab.Controls.Add(tabHD);
            tab.Controls.Add(tabCTHD);
            tab.Controls.Add(tabThongKe);
            tab.Controls.Add(tabNhapHoaDon);
            tab.Dock = DockStyle.Fill;
            tab.Location = new Point(0, 0);
            tab.Margin = new Padding(4);
            tab.Name = "tab";
            tab.SelectedIndex = 0;
            tab.Size = new Size(924, 571);
            tab.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clTenSp, clSL, clDonGia1 });
            dataGridView1.Location = new Point(108, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(653, 200);
            dataGridView1.TabIndex = 16;
            
            // 
            // clTenSp
            // 
            clTenSp.HeaderText = "Sản phẩm";
            clTenSp.MinimumWidth = 6;
            clTenSp.Name = "clTenSp";
            // 
            // clSL
            // 
            clSL.HeaderText = "Số lượng";
            clSL.MinimumWidth = 6;
            clSL.Name = "clSL";
            clSL.ReadOnly = true;
            // 
            // clDonGia1
            // 
            clDonGia1.HeaderText = "Đơn giá";
            clDonGia1.MinimumWidth = 6;
            clDonGia1.Name = "clDonGia1";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(579, 75);
            txtSDT.Name = "txtSDT";
            txtSDT.ReadOnly = true;
            txtSDT.Size = new Size(183, 28);
            txtSDT.TabIndex = 10;
            txtSDT.TextChanged += txtSDT_TextChanged;
            // 
            // txtTraLai
            // 
            txtTraLai.Location = new Point(286, 463);
            txtTraLai.Name = "txtTraLai";
            txtTraLai.ReadOnly = true;
            txtTraLai.Size = new Size(322, 28);
            txtTraLai.TabIndex = 11;
            txtTraLai.TextAlign = HorizontalAlignment.Right;
            
            // 
            // txtKHTT
            // 
            txtKHTT.Location = new Point(286, 428);
            txtKHTT.Name = "txtKHTT";
            txtKHTT.ReadOnly = true;
            txtKHTT.Size = new Size(322, 28);
            txtKHTT.TabIndex = 12;
            txtKHTT.TextAlign = HorizontalAlignment.Right;
            
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(286, 393);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(322, 28);
            txtThanhTien.TabIndex = 13;
            txtThanhTien.TextAlign = HorizontalAlignment.Right;
            
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(191, 114);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.ReadOnly = true;
            txtDiaChi.Size = new Size(269, 28);
            txtDiaChi.TabIndex = 14;
            
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(247, 73);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.ReadOnly = true;
            txtTenKH.Size = new Size(213, 28);
            txtTenKH.TabIndex = 15;
            
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(104, 466);
            label5.Name = "label5";
            label5.Size = new Size(105, 22);
            label5.TabIndex = 3;
            label5.Text = "Tiền trả lại: ";
            
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(104, 431);
            label3.Name = "label3";
            label3.Size = new Size(206, 22);
            label3.TabIndex = 4;
            label3.Text = "Khách hàng thanh toán: ";
            
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(104, 396);
            label7.Name = "label7";
            label7.Size = new Size(106, 22);
            label7.TabIndex = 5;
            label7.Text = "Thành tiền: ";
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(104, 117);
            label2.Name = "label2";
            label2.Size = new Size(75, 22);
            label2.TabIndex = 6;
            label2.Text = "Địa chỉ: ";
            
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(466, 76);
            label6.Name = "label6";
            label6.Size = new Size(125, 22);
            label6.TabIndex = 7;
            label6.Text = "Số điện thoại: ";
            
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Kristen ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(910, 51);
            label4.TabIndex = 8;
            label4.Text = "HÓA ĐƠN";
            label4.TextAlign = ContentAlignment.MiddleCenter;

            //
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(104, 78);
            label8.Name = "label8";
            label8.Size = new Size(150, 22);
            label8.TabIndex = 9;
            label8.Text = "Tên khách hàng: ";
            
            // 
            // frmQuanLyHoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 571);
            Controls.Add(tab);
            Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmQuanLyHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý hóa đơn";
            Load += frmQuanLyHoaDon_Load;
            tabNhapHoaDon.ResumeLayout(false);
            tabNhapHoaDon.PerformLayout();
            tabThongKe.ResumeLayout(false);
            tabThongKe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgSPBanChay).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgLoiNhuan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgSPBanE).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgDoanhThu).EndInit();
            tabCTHD.ResumeLayout(false);
            tabCTHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgCTHD).EndInit();
            tabHD.ResumeLayout(false);
            tabHD.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgHD).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private TabPage tabNhapHoaDon;
        private TabPage tabThongKe;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private DataGridView dgDoanhThu;
        private DataGridView dgSPBanE;
        private DataGridView dgLoiNhuan;
        private DataGridView dgSPBanChay;
        private TabPage tabCTHD;
        private Button btXuatHD;
        private Button btBackCTHD;
        private DataGridView dgCTHD;
        private Label label13;
        private PictureBox pictureBox2;
        private TabPage tabHD;
        private Button btBackHD;
        private Button btTimKiem;
        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private DataGridView dgHD;
        private TabControl tab;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clTenSp;
        private DataGridViewTextBoxColumn clSL;
        private DataGridViewTextBoxColumn clDonGia1;
        private TextBox txtSDT;
        private TextBox txtTraLai;
        private TextBox txtKHTT;
        private TextBox txtThanhTien;
        private TextBox txtDiaChi;
        private TextBox txtTenKH;
        private Label label5;
        private Label label3;
        private Label label7;
        private Label label2;
        private Label label6;
        private Label label4;
        private Label label8;
    }
}