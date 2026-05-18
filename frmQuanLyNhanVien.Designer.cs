namespace BtlWF
{
    partial class frmQuanLyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyNhanVien));
            dgNV = new DataGridView();
            panel = new Panel();
            comboBox1 = new ComboBox();
            btBack = new Button();
            imageList1 = new ImageList(components);
            btSua = new Button();
            btXoa = new Button();
            btThem = new Button();
            txtTim = new TextBox();
            label9 = new Label();
            menuStrip1 = new MenuStrip();
            quảnLíLươngToolStripMenuItem = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            btMoi = new Button();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            cbGT = new ComboBox();
            txtMKNV = new TextBox();
            txtTKNV = new TextBox();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtTen = new TextBox();
            txtMa = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label3 = new Label();
            label10 = new Label();
            label4 = new Label();
            label6 = new Label();
            label2 = new Label();
            label7 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgNV).BeginInit();
            panel.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgNV
            // 
            dgNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgNV.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgNV.Location = new Point(7, 43);
            dgNV.Margin = new Padding(4);
            dgNV.Name = "dgNV";
            dgNV.RowHeadersWidth = 51;
            dgNV.RowTemplate.Height = 24;
            dgNV.Size = new Size(1059, 304);
            dgNV.TabIndex = 0;
            dgNV.CellClick += dgNV_CellClick;
            // 
            // panel
            // 
            panel.BackColor = Color.BlanchedAlmond;
            panel.Controls.Add(comboBox1);
            panel.Controls.Add(btBack);
            panel.Controls.Add(btSua);
            panel.Controls.Add(btXoa);
            panel.Controls.Add(btThem);
            panel.Controls.Add(txtTim);
            panel.Controls.Add(label9);
            panel.Location = new Point(1076, 0);
            panel.Name = "panel";
            panel.Size = new Size(235, 736);
            panel.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(37, 528);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 33);
            comboBox1.TabIndex = 13;
            // 
            // btBack
            // 
            btBack.BackColor = Color.NavajoWhite;
            btBack.ImageAlign = ContentAlignment.MiddleLeft;
            btBack.ImageIndex = 3;
            btBack.ImageList = imageList1;
            btBack.Location = new Point(66, 660);
            btBack.Name = "btBack";
            btBack.Size = new Size(109, 45);
            btBack.TabIndex = 4;
            btBack.Text = "Trở về";
            btBack.TextAlign = ContentAlignment.TopRight;
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-update-64 (1).png");
            imageList1.Images.SetKeyName(1, "icons8-security-shield-green-48.png");
            imageList1.Images.SetKeyName(2, "icons8-image-48.png");
            imageList1.Images.SetKeyName(3, "icons8-back-100 (1).png");
            imageList1.Images.SetKeyName(4, "icons8-detail-80.png");
            imageList1.Images.SetKeyName(5, "z4793595578786_0f411e3028611da59c2b0444d9b3163b.jpg");
            imageList1.Images.SetKeyName(6, "icons8-search-64 (1).png");
            imageList1.Images.SetKeyName(7, "icons8-password-481.png");
            imageList1.Images.SetKeyName(8, "icons8-new-document-50 (1).png");
            imageList1.Images.SetKeyName(9, "icons8-insert-60 (2).png");
            imageList1.Images.SetKeyName(10, "icons8-coin-64 (1).png");
            imageList1.Images.SetKeyName(11, "icons8-delete-50 (1).png");
            // 
            // btSua
            // 
            btSua.BackColor = Color.LightCyan;
            btSua.ImageAlign = ContentAlignment.MiddleLeft;
            btSua.ImageIndex = 7;
            btSua.ImageList = imageList1;
            btSua.Location = new Point(26, 192);
            btSua.Name = "btSua";
            btSua.Size = new Size(180, 57);
            btSua.TabIndex = 1;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = false;
            btSua.Click += btSua_Click;
            // 
            // btXoa
            // 
            btXoa.BackColor = Color.LightCyan;
            btXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btXoa.ImageIndex = 11;
            btXoa.ImageList = imageList1;
            btXoa.Location = new Point(26, 298);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(180, 58);
            btXoa.TabIndex = 2;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = false;
            btXoa.Click += btXoa_Click;
            // 
            // btThem
            // 
            btThem.BackColor = Color.LightCyan;
            btThem.ImageAlign = ContentAlignment.MiddleLeft;
            btThem.ImageIndex = 9;
            btThem.ImageList = imageList1;
            btThem.Location = new Point(26, 71);
            btThem.Name = "btThem";
            btThem.Size = new Size(180, 57);
            btThem.TabIndex = 0;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = false;
            btThem.Click += btThem_Click;
            // 
            // txtTim
            // 
            txtTim.Location = new Point(26, 452);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(177, 30);
            txtTim.TabIndex = 12;
            txtTim.TextChanged += txtTim_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 424);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(111, 25);
            label9.TabIndex = 1;
            label9.Text = "Nhân viên: ";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.BlanchedAlmond;
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLíLươngToolStripMenuItem, thốngKêToolStripMenuItem });
            menuStrip1.Location = new Point(0, 708);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1311, 28);
            menuStrip1.TabIndex = 26;
            menuStrip1.Text = "menuStrip1";
            // 
            // quảnLíLươngToolStripMenuItem
            // 
            quảnLíLươngToolStripMenuItem.BackColor = Color.Transparent;
            quảnLíLươngToolStripMenuItem.Name = "quảnLíLươngToolStripMenuItem";
            quảnLíLươngToolStripMenuItem.Size = new Size(113, 24);
            quảnLíLươngToolStripMenuItem.Text = "Quản lí lương";
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.BackColor = Color.Transparent;
            thốngKêToolStripMenuItem.ForeColor = Color.Black;
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(84, 24);
            thốngKêToolStripMenuItem.Text = "Thống kê";
            thốngKêToolStripMenuItem.Click += thốngKêToolStripMenuItem_Click;
            // 
            // btMoi
            // 
            btMoi.BackColor = Color.DarkSalmon;
            btMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btMoi.ImageIndex = 4;
            btMoi.ImageList = imageList1;
            btMoi.Location = new Point(919, 119);
            btMoi.Name = "btMoi";
            btMoi.Size = new Size(138, 64);
            btMoi.TabIndex = 16;
            btMoi.Text = "Nhập mới";
            btMoi.TextAlign = ContentAlignment.MiddleRight;
            btMoi.UseVisualStyleBackColor = false;
            btMoi.Click += btMoi_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.BlanchedAlmond;
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(btMoi);
            groupBox1.Controls.Add(cbGT);
            groupBox1.Controls.Add(txtMKNV);
            groupBox1.Controls.Add(txtTKNV);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(txtMa);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 528);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1067, 180);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(459, 77);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 30);
            dateTimePicker1.TabIndex = 18;
            // 
            // cbGT
            // 
            cbGT.FormattingEnabled = true;
            cbGT.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbGT.Location = new Point(711, 77);
            cbGT.Name = "cbGT";
            cbGT.Size = new Size(121, 33);
            cbGT.TabIndex = 11;
            cbGT.SelectedIndexChanged += cbGT_SelectedIndexChanged;
            // 
            // txtMKNV
            // 
            txtMKNV.Location = new Point(459, 143);
            txtMKNV.Name = "txtMKNV";
            txtMKNV.Size = new Size(177, 30);
            txtMKNV.TabIndex = 15;
            // 
            // txtTKNV
            // 
            txtTKNV.Location = new Point(227, 143);
            txtTKNV.Name = "txtTKNV";
            txtTKNV.Size = new Size(177, 30);
            txtTKNV.TabIndex = 14;
            txtTKNV.KeyDown += txtTKNV_KeyDown;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(6, 143);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(177, 30);
            txtDiaChi.TabIndex = 13;
            txtDiaChi.TextChanged += txtDiaChi_TextChanged;
            txtDiaChi.KeyDown += txtDiaChi_KeyDown;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(863, 77);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(177, 30);
            txtSDT.TabIndex = 12;
            txtSDT.KeyDown += txtSDT_KeyDown;
            txtSDT.KeyPress += txtSDT_KeyPress;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(227, 77);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(177, 30);
            txtTen.TabIndex = 9;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(6, 77);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(177, 30);
            txtMa.TabIndex = 8;
            txtMa.TextChanged += txtMa_TextChanged;
            txtMa.KeyDown += txtMa_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(454, 115);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(93, 25);
            label8.TabIndex = 7;
            label8.Text = "Mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(222, 115);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(99, 25);
            label5.TabIndex = 6;
            label5.Text = "Tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 115);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 17;
            label3.Text = "Địa chỉ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(858, 46);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(53, 25);
            label10.TabIndex = 5;
            label10.Text = "SĐT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 115);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 4;
            label4.Text = "Địa chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(454, 46);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(99, 25);
            label6.TabIndex = 2;
            label6.Text = "Ngày sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(706, 46);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 3;
            label2.Text = "Giới tính";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(222, 46);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(137, 25);
            label7.TabIndex = 1;
            label7.Text = "Tên nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 46);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1074, 168);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.BlanchedAlmond;
            groupBox2.Controls.Add(dgNV);
            groupBox2.Location = new Point(3, 174);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1073, 354);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // frmQuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 736);
            Controls.Add(groupBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmQuanLyNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhân viên";
            Load += frmQuanLyNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgNV).EndInit();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgNV;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbGT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btMoi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMKNV;
        private System.Windows.Forms.TextBox txtTKNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLíLươngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private ImageList imageList1;
        private ComboBox comboBox1;
    }
}