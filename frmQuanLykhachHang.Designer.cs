namespace BtlWF
{
    partial class frmQuanLyKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyKhachHang));
            dgKH = new DataGridView();
            btSua = new Button();
            imageList1 = new ImageList(components);
            btXoa = new Button();
            btBack = new Button();
            groupBox1 = new GroupBox();
            btMoi = new Button();
            txtEmail = new TextBox();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtTen = new TextBox();
            txtMa = new TextBox();
            lbTB = new Label();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            txtTim = new TextBox();
            label7 = new Label();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgKH).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgKH
            // 
            dgKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgKH.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgKH.Location = new Point(12, 28);
            dgKH.Margin = new Padding(4);
            dgKH.Name = "dgKH";
            dgKH.RowHeadersWidth = 51;
            dgKH.RowTemplate.Height = 24;
            dgKH.Size = new Size(896, 515);
            dgKH.TabIndex = 4;
            dgKH.CellClick += dgKH_CellClick;
            dgKH.CellContentClick += dgKH_CellContentClick;
            // 
            // btSua
            // 
            btSua.BackColor = Color.LightCyan;
            btSua.ImageAlign = ContentAlignment.MiddleLeft;
            btSua.ImageIndex = 2;
            btSua.ImageList = imageList1;
            btSua.Location = new Point(769, 0);
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
            imageList1.Images.SetKeyName(0, "icons8-back-100 (1).png");
            imageList1.Images.SetKeyName(1, "icons8-update-64 (1).png");
            imageList1.Images.SetKeyName(2, "icons8-password-481.png");
            imageList1.Images.SetKeyName(3, "icons8-delete-50 (1).png");
            imageList1.Images.SetKeyName(4, "icons8-insert-60 (2).png");
            imageList1.Images.SetKeyName(5, "edit.png");
            // 
            // btXoa
            // 
            btXoa.BackColor = Color.LightCyan;
            btXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btXoa.ImageIndex = 4;
            btXoa.ImageList = imageList1;
            btXoa.Location = new Point(769, 93);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(148, 58);
            btXoa.TabIndex = 23;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = false;
            btXoa.Click += btXoa_Click;
            // 
            // btBack
            // 
            btBack.BackColor = Color.NavajoWhite;
            btBack.ImageAlign = ContentAlignment.MiddleLeft;
            btBack.ImageIndex = 0;
            btBack.ImageList = imageList1;
            btBack.Location = new Point(1114, 666);
            btBack.Name = "btBack";
            btBack.Size = new Size(133, 45);
            btBack.TabIndex = 22;
            btBack.Text = "Trở về";
            btBack.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PapayaWhip;
            groupBox1.Controls.Add(btMoi);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(txtMa);
            groupBox1.Controls.Add(lbTB);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(921, 150);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 412);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // btMoi
            // 
            btMoi.BackColor = Color.LightSalmon;
            btMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btMoi.ImageIndex = 5;
            btMoi.ImageList = imageList1;
            btMoi.Location = new Point(149, 333);
            btMoi.Name = "btMoi";
            btMoi.Size = new Size(177, 52);
            btMoi.TabIndex = 32;
            btMoi.Text = "Nhập mới";
            btMoi.UseVisualStyleBackColor = false;
            btMoi.Click += btMoi_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(149, 268);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(177, 28);
            txtEmail.TabIndex = 27;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(149, 157);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(177, 28);
            txtDiaChi.TabIndex = 28;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(149, 214);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(177, 28);
            txtSDT.TabIndex = 29;
            txtSDT.KeyPress += txtSDT_KeyPress;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(149, 97);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(177, 28);
            txtTen.TabIndex = 30;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(149, 48);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(177, 28);
            txtMa.TabIndex = 31;
            // 
            // lbTB
            // 
            lbTB.AutoSize = true;
            lbTB.BackColor = Color.Transparent;
            lbTB.ForeColor = Color.Red;
            lbTB.Location = new Point(145, 299);
            lbTB.Margin = new Padding(4, 0, 4, 0);
            lbTB.Name = "lbTB";
            lbTB.Size = new Size(0, 22);
            lbTB.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(14, 271);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 22);
            label4.TabIndex = 25;
            label4.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(14, 160);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(65, 22);
            label6.TabIndex = 26;
            label6.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(14, 217);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(47, 22);
            label3.TabIndex = 23;
            label3.Text = "SĐT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(10, 103);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 22);
            label2.TabIndex = 22;
            label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(10, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 22);
            label1.TabIndex = 24;
            label1.Text = "Mã khách hàng";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.BlanchedAlmond;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(763, 151);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Mistral", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Salmon;
            label5.Location = new Point(884, 28);
            label5.Name = "label5";
            label5.Size = new Size(375, 87);
            label5.TabIndex = 26;
            label5.Text = "QUẢN LÝ KHÁCH HÀNG";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTim
            // 
            txtTim.Location = new Point(929, 605);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(170, 28);
            txtTim.TabIndex = 25;
            txtTim.TextChanged += txtTim_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(925, 580);
            label7.Name = "label7";
            label7.Size = new Size(88, 22);
            label7.TabIndex = 27;
            label7.Text = "Nhập tên:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(dgKH);
            groupBox2.Location = new Point(0, 157);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(915, 554);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khách hàng";
            // 
            // frmQuanLyKhachHang
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(1259, 713);
            Controls.Add(groupBox2);
            Controls.Add(label7);
            Controls.Add(btBack);
            Controls.Add(btSua);
            Controls.Add(btXoa);
            Controls.Add(txtTim);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmQuanLyKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý khách hàng";
            Load += frmQuanLyKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgKH).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgKH;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btMoi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private ImageList imageList1;
    }
}