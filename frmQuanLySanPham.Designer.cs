namespace BtlWF
{
    partial class frmQuanLySanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLySanPham));
            contextMenuStrip1 = new ContextMenuStrip(components);
            tab = new TabControl();
            tabSP = new TabPage();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            btSua = new Button();
            imageList1 = new ImageList(components);
            btXoa = new Button();
            btThem = new Button();
            groupBox3 = new GroupBox();
            txtMa = new TextBox();
            btHA = new Button();
            btMoi = new Button();
            txtSLDaBan = new TextBox();
            txtSL = new TextBox();
            txtGiaBan = new TextBox();
            txtNCC = new TextBox();
            txtGianhap = new TextBox();
            txtTen = new TextBox();
            lbTBSP = new Label();
            txtLinkPic = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgSP = new DataGridView();
            btBack = new Button();
            menuStrip1 = new MenuStrip();
            sảnPhẩmĐãHếtToolStripMenuItem = new ToolStripMenuItem();
            btTimKiem = new Button();
            groupBox1 = new GroupBox();
            tabNCC = new TabPage();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btTimKiemNCC = new Button();
            btSuaNCC = new Button();
            btXoaNCC = new Button();
            btThemNCC = new Button();
            btBackNCC = new Button();
            dgNCC = new DataGridView();
            groupBox2 = new GroupBox();
            btMoiNCC = new Button();
            txtDiaChiNCC = new TextBox();
            txtSDTNCC = new TextBox();
            txtTenNCC = new TextBox();
            txtMaNCC = new TextBox();
            label10 = new Label();
            lbTBNCC = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            tab.SuspendLayout();
            tabSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgSP).BeginInit();
            menuStrip1.SuspendLayout();
            tabNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgNCC).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
          
            // 
            // tab
            // 
            tab.Controls.Add(tabSP);
            tab.Controls.Add(tabNCC);
            tab.Dock = DockStyle.Fill;
            tab.Location = new Point(0, 0);
            tab.Name = "tab";
            tab.SelectedIndex = 0;
            tab.Size = new Size(1301, 766);
            tab.TabIndex = 4;
            tab.Tag = "Sản phẩm";
            // 
            // tabSP
            // 
            tabSP.BackColor = Color.BlanchedAlmond;
            tabSP.Controls.Add(pictureBox2);
            tabSP.Controls.Add(panel3);
            tabSP.Controls.Add(groupBox3);
            tabSP.Controls.Add(dgSP);
            tabSP.Controls.Add(btBack);
            tabSP.Controls.Add(menuStrip1);
            tabSP.Controls.Add(btTimKiem);
            tabSP.Controls.Add(groupBox1);
            tabSP.Location = new Point(4, 31);
            tabSP.Name = "tabSP";
            tabSP.Padding = new Padding(3);
            tabSP.Size = new Size(1293, 731);
            tabSP.TabIndex = 0;
            tabSP.Text = " Sản phẩm";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(8, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(118, 111);
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btSua);
            panel3.Controls.Add(btXoa);
            panel3.Controls.Add(btThem);
            panel3.Location = new Point(132, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(696, 111);
            panel3.TabIndex = 22;
            // 
            // btSua
            // 
            btSua.BackColor = Color.LightCyan;
            btSua.ImageAlign = ContentAlignment.MiddleLeft;
            btSua.ImageIndex = 4;
            btSua.ImageList = imageList1;
            btSua.Location = new Point(283, 24);
            btSua.Name = "btSua";
            btSua.Size = new Size(148, 57);
            btSua.TabIndex = 22;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = false;
            btSua.Click += btSua_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "edit.png");
            imageList1.Images.SetKeyName(1, "icons8-detail-80.png");
            imageList1.Images.SetKeyName(2, "z4793595578786_0f411e3028611da59c2b0444d9b3163b.jpg");
            imageList1.Images.SetKeyName(3, "icons8-search-64 (1).png");
            imageList1.Images.SetKeyName(4, "icons8-password-481.png");
            imageList1.Images.SetKeyName(5, "icons8-order-80.png");
            imageList1.Images.SetKeyName(6, "icons8-new-document-50 (1).png");
            imageList1.Images.SetKeyName(7, "icons8-insert-60 (2).png");
            imageList1.Images.SetKeyName(8, "icons8-coin-64 (1).png");
            imageList1.Images.SetKeyName(9, "icons8-delete-50 (1).png");
            imageList1.Images.SetKeyName(10, "icons8-update-64 (1).png");
            imageList1.Images.SetKeyName(11, "icons8-security-shield-green-48.png");
            imageList1.Images.SetKeyName(12, "icons8-image-48.png");
            imageList1.Images.SetKeyName(13, "icons8-back-100 (1).png");
            // 
            // btXoa
            // 
            btXoa.BackColor = Color.LightCyan;
            btXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btXoa.ImageIndex = 9;
            btXoa.ImageList = imageList1;
            btXoa.Location = new Point(520, 23);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(156, 58);
            btXoa.TabIndex = 23;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = false;
            btXoa.Click += btXoa_Click;
            // 
            // btThem
            // 
            btThem.BackColor = Color.LightCyan;
            btThem.ImageAlign = ContentAlignment.MiddleLeft;
            btThem.ImageIndex = 7;
            btThem.ImageList = imageList1;
            btThem.Location = new Point(49, 23);
            btThem.Name = "btThem";
            btThem.Size = new Size(157, 57);
            btThem.TabIndex = 21;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = false;
            btThem.Click += btThem_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtMa);
            groupBox3.Controls.Add(btHA);
            groupBox3.Controls.Add(btMoi);
            groupBox3.Controls.Add(txtSLDaBan);
            groupBox3.Controls.Add(txtSL);
            groupBox3.Controls.Add(txtGiaBan);
            groupBox3.Controls.Add(txtNCC);
            groupBox3.Controls.Add(txtGianhap);
            groupBox3.Controls.Add(txtTen);
            groupBox3.Controls.Add(lbTBSP);
            groupBox3.Controls.Add(txtLinkPic);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(831, 116);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(454, 619);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin sản phẩm";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(181, 107);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(246, 28);
            txtMa.TabIndex = 36;
          
            // 
            // btHA
            // 
            btHA.BackColor = Color.Gainsboro;
            btHA.ImageAlign = ContentAlignment.MiddleLeft;
            btHA.ImageIndex = 12;
            btHA.ImageList = imageList1;
            btHA.Location = new Point(24, 557);
            btHA.Name = "btHA";
            btHA.Size = new Size(174, 52);
            btHA.TabIndex = 35;
            btHA.Text = "Thêm Hình ảnh";
            btHA.TextAlign = ContentAlignment.MiddleRight;
            btHA.UseVisualStyleBackColor = false;
           
            // 
            // btMoi
            // 
            btMoi.BackColor = Color.LightSalmon;
            btMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btMoi.Location = new Point(285, 557);
            btMoi.Name = "btMoi";
            btMoi.Size = new Size(177, 56);
            btMoi.TabIndex = 33;
            btMoi.Text = "Nhập mới";
            btMoi.UseVisualStyleBackColor = false;
       
            // 
            // txtSLDaBan
            // 
            txtSLDaBan.Location = new Point(181, 466);
            txtSLDaBan.Name = "txtSLDaBan";
            txtSLDaBan.Size = new Size(246, 28);
            txtSLDaBan.TabIndex = 27;
            
            // 
            // txtSL
            // 
            txtSL.Location = new Point(181, 404);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(246, 28);
            txtSL.TabIndex = 27;
           
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(181, 336);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(246, 28);
            txtGiaBan.TabIndex = 28;
            
            // 
            // txtNCC
            // 
            txtNCC.Location = new Point(181, 216);
            txtNCC.Name = "txtNCC";
            txtNCC.Size = new Size(246, 28);
            txtNCC.TabIndex = 29;
            
            // 
            // txtGianhap
            // 
            txtGianhap.Location = new Point(181, 275);
            txtGianhap.Name = "txtGianhap";
            txtGianhap.Size = new Size(246, 28);
            txtGianhap.TabIndex = 30;
          
            // 
            // txtTen
            // 
            txtTen.Location = new Point(181, 160);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(246, 28);
            txtTen.TabIndex = 31;
           
            // 
            // lbTBSP
            // 
            lbTBSP.AutoSize = true;
            lbTBSP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTBSP.ForeColor = Color.Red;
            lbTBSP.Location = new Point(181, 545);
            lbTBSP.Margin = new Padding(4, 0, 4, 0);
            lbTBSP.Name = "lbTBSP";
            lbTBSP.Size = new Size(0, 18);
            lbTBSP.TabIndex = 24;
            // 
            // txtLinkPic
            // 
            txtLinkPic.Location = new Point(45, 47);
            txtLinkPic.Name = "txtLinkPic";
            txtLinkPic.Size = new Size(385, 28);
            txtLinkPic.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(45, 466);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(92, 22);
            label8.TabIndex = 25;
            label8.Text = "SL đã bán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 407);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(32, 22);
            label5.TabIndex = 25;
            label5.Text = "SL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 336);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 22);
            label4.TabIndex = 25;
            label4.Text = "Giá bán";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 216);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(121, 22);
            label6.TabIndex = 26;
            label6.Text = "Nhà cung cấp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 275);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 22);
            label3.TabIndex = 22;
            label3.Text = "Giá nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 160);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 22);
            label2.TabIndex = 21;
            label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 107);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 22);
            label1.TabIndex = 23;
            label1.Text = "Mã sản phẩm";
            // 
            // dgSP
            // 
            dgSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgSP.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSP.Location = new Point(25, 163);
            dgSP.Margin = new Padding(4);
            dgSP.Name = "dgSP";
            dgSP.RowHeadersWidth = 51;
            dgSP.RowTemplate.Height = 24;
            dgSP.Size = new Size(785, 545);
            dgSP.TabIndex = 4;
            dgSP.CellClick += dgSP_CellClick;
            // 
            // btBack
            // 
            btBack.BackColor = Color.NavajoWhite;
            btBack.ImageAlign = ContentAlignment.MiddleLeft;
            btBack.ImageIndex = 13;
            btBack.ImageList = imageList1;
            btBack.Location = new Point(1130, 54);
            btBack.Name = "btBack";
            btBack.Size = new Size(143, 56);
            btBack.TabIndex = 20;
            btBack.Text = "Trở về";
            btBack.UseVisualStyleBackColor = false;
           
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sảnPhẩmĐãHếtToolStripMenuItem });
            menuStrip1.Location = new Point(1130, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(143, 28);
            menuStrip1.TabIndex = 25;
            menuStrip1.Text = "menuStrip1";
            // 
            // sảnPhẩmĐãHếtToolStripMenuItem
            // 
            sảnPhẩmĐãHếtToolStripMenuItem.Name = "sảnPhẩmĐãHếtToolStripMenuItem";
            sảnPhẩmĐãHếtToolStripMenuItem.Size = new Size(135, 24);
            sảnPhẩmĐãHếtToolStripMenuItem.Text = "Sản phẩm đã hết";
            // 
            // btTimKiem
            // 
            btTimKiem.BackColor = Color.NavajoWhite;
            btTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btTimKiem.ImageIndex = 3;
            btTimKiem.ImageList = imageList1;
            btTimKiem.Location = new Point(834, 3);
            btTimKiem.Name = "btTimKiem";
            btTimKiem.Size = new Size(172, 56);
            btTimKiem.TabIndex = 24;
            btTimKiem.Text = "Tìm kiếm";
            btTimKiem.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(8, 135);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(820, 596);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sản phẩm";
            // 
            // tabNCC
            // 
            tabNCC.Controls.Add(label7);
            tabNCC.Controls.Add(pictureBox1);
            tabNCC.Controls.Add(panel2);
            tabNCC.Controls.Add(btBackNCC);
            tabNCC.Controls.Add(dgNCC);
            tabNCC.Controls.Add(groupBox2);
            tabNCC.Location = new Point(4, 29);
            tabNCC.Name = "tabNCC";
            tabNCC.Padding = new Padding(3);
            tabNCC.Size = new Size(1293, 733);
            tabNCC.TabIndex = 2;
            tabNCC.Text = "Nhà cung cấp";
            tabNCC.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe Script", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Firebrick;
            label7.Location = new Point(817, 3);
            label7.Name = "label7";
            label7.Size = new Size(473, 160);
            label7.TabIndex = 43;
            label7.Text = "NHÀ CUNG CẤP";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(810, 163);
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btTimKiemNCC);
            panel2.Controls.Add(btSuaNCC);
            panel2.Controls.Add(btXoaNCC);
            panel2.Controls.Add(btThemNCC);
            panel2.Location = new Point(3, 588);
            panel2.Name = "panel2";
            panel2.Size = new Size(807, 143);
            panel2.TabIndex = 40;
            // 
            // btTimKiemNCC
            // 
            btTimKiemNCC.BackColor = Color.LightCyan;
            btTimKiemNCC.ImageAlign = ContentAlignment.MiddleLeft;
            btTimKiemNCC.Location = new Point(598, 39);
            btTimKiemNCC.Name = "btTimKiemNCC";
            btTimKiemNCC.Size = new Size(172, 58);
            btTimKiemNCC.TabIndex = 41;
            btTimKiemNCC.Text = "Tìm kiếm";
            btTimKiemNCC.UseVisualStyleBackColor = false;
            // 
            // btSuaNCC
            // 
            btSuaNCC.BackColor = Color.LightCyan;
            btSuaNCC.ImageAlign = ContentAlignment.MiddleLeft;
            btSuaNCC.Location = new Point(229, 39);
            btSuaNCC.Name = "btSuaNCC";
            btSuaNCC.Size = new Size(148, 58);
            btSuaNCC.TabIndex = 39;
            btSuaNCC.Text = "Sửa";
            btSuaNCC.UseVisualStyleBackColor = false;
       
            // 
            // btXoaNCC
            // 
            btXoaNCC.BackColor = Color.LightCyan;
            btXoaNCC.ImageAlign = ContentAlignment.MiddleLeft;
            btXoaNCC.Location = new Point(408, 39);
            btXoaNCC.Name = "btXoaNCC";
            btXoaNCC.Size = new Size(156, 58);
            btXoaNCC.TabIndex = 40;
            btXoaNCC.Text = "Xóa";
            btXoaNCC.UseVisualStyleBackColor = false;
            btXoaNCC.Click += btXoaNCC_Click;
            // 
            // btThemNCC
            // 
            btThemNCC.BackColor = Color.LightCyan;
            btThemNCC.ImageAlign = ContentAlignment.MiddleLeft;
            btThemNCC.Location = new Point(20, 39);
            btThemNCC.Name = "btThemNCC";
            btThemNCC.Size = new Size(180, 58);
            btThemNCC.TabIndex = 38;
            btThemNCC.Text = "Thêm";
            btThemNCC.UseVisualStyleBackColor = false;
            btThemNCC.Click += btThemNCC_Click;
            // 
            // btBackNCC
            // 
            btBackNCC.BackColor = Color.NavajoWhite;
            btBackNCC.ImageAlign = ContentAlignment.MiddleLeft;
            btBackNCC.Location = new Point(1135, 683);
            btBackNCC.Name = "btBackNCC";
            btBackNCC.Size = new Size(158, 45);
            btBackNCC.TabIndex = 39;
            btBackNCC.Text = "Trở về";
            btBackNCC.UseVisualStyleBackColor = false;
            
            // 
            // dgNCC
            // 
            dgNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgNCC.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgNCC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgNCC.Location = new Point(0, 165);
            dgNCC.Margin = new Padding(4);
            dgNCC.Name = "dgNCC";
            dgNCC.RowHeadersWidth = 51;
            dgNCC.RowTemplate.Height = 24;
            dgNCC.Size = new Size(810, 416);
            dgNCC.TabIndex = 23;
          
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btMoiNCC);
            groupBox2.Controls.Add(txtDiaChiNCC);
            groupBox2.Controls.Add(txtSDTNCC);
            groupBox2.Controls.Add(txtTenNCC);
            groupBox2.Controls.Add(txtMaNCC);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(lbTBNCC);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Location = new Point(817, 165);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(470, 416);
            groupBox2.TabIndex = 41;
            groupBox2.TabStop = false;
            // 
            // btMoiNCC
            // 
            btMoiNCC.BackColor = Color.LightSalmon;
            btMoiNCC.ImageAlign = ContentAlignment.MiddleLeft;
            btMoiNCC.Location = new Point(274, 339);
            btMoiNCC.Name = "btMoiNCC";
            btMoiNCC.Size = new Size(177, 52);
            btMoiNCC.TabIndex = 47;
            btMoiNCC.Text = "Nhập mới";
            btMoiNCC.UseVisualStyleBackColor = false;
            
            // 
            // txtDiaChiNCC
            // 
            txtDiaChiNCC.Location = new Point(135, 149);
            txtDiaChiNCC.Name = "txtDiaChiNCC";
            txtDiaChiNCC.Size = new Size(262, 28);
            txtDiaChiNCC.TabIndex = 43;
            // 
            // txtSDTNCC
            // 
            txtSDTNCC.Location = new Point(135, 206);
            txtSDTNCC.Name = "txtSDTNCC";
            txtSDTNCC.Size = new Size(262, 28);
            txtSDTNCC.TabIndex = 44;
            // 
            // txtTenNCC
            // 
            txtTenNCC.Location = new Point(135, 90);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(262, 28);
            txtTenNCC.TabIndex = 45;
            // 
            // txtMaNCC
            // 
            txtMaNCC.Location = new Point(135, 36);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(262, 28);
            txtMaNCC.TabIndex = 46;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(63, 149);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(65, 22);
            label10.TabIndex = 42;
            label10.Text = "Địa chỉ";
            // 
            // lbTBNCC
            // 
            lbTBNCC.AutoSize = true;
            lbTBNCC.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTBNCC.ForeColor = Color.Red;
            lbTBNCC.Location = new Point(132, 238);
            lbTBNCC.Margin = new Padding(4, 0, 4, 0);
            lbTBNCC.Name = "lbTBNCC";
            lbTBNCC.Size = new Size(0, 18);
            lbTBNCC.TabIndex = 40;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(63, 206);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(47, 22);
            label11.TabIndex = 40;
            label11.Text = "SĐT";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(63, 93);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(47, 22);
            label12.TabIndex = 39;
            label12.Text = "Tên ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(63, 39);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(39, 22);
            label13.TabIndex = 41;
            label13.Text = "Mã ";
            // 
            // frmQuanLySanPham
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 766);
            Controls.Add(tab);
            Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "frmQuanLySanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sản phẩm";
            Load += frmQuanLySanPham_Load;
            tab.ResumeLayout(false);
            tabSP.ResumeLayout(false);
            tabSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgSP).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabNCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgNCC).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabPage tabNCC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btTimKiemNCC;
        private System.Windows.Forms.Button btSuaNCC;
        private System.Windows.Forms.Button btXoaNCC;
        private System.Windows.Forms.Button btThemNCC;
        private System.Windows.Forms.Button btBackNCC;
        private System.Windows.Forms.DataGridView dgNCC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btMoiNCC;
        private System.Windows.Forms.TextBox txtDiaChiNCC;
        private System.Windows.Forms.TextBox txtSDTNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbTBNCC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabSP;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btHA;
        private System.Windows.Forms.Button btMoi;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.TextBox txtGianhap;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lbTBSP;
        private System.Windows.Forms.TextBox txtLinkPic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgSP;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtSLDaBan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmĐãHếtToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private ImageList imageList1;
    }
}