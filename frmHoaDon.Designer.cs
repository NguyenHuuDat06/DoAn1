namespace BtlWF
{
    partial class frmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtTenKH = new TextBox();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            dghd = new DataGridView();
            clTenSp = new DataGridViewTextBoxColumn();
            clSL = new DataGridViewTextBoxColumn();
            clDonGia1 = new DataGridViewTextBoxColumn();
            txtThanhTien = new TextBox();
            label3 = new Label();
            label5 = new Label();
            txtKHTT = new TextBox();
            txtTraLai = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dghd).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(27, 82);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên khách hàng: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(27, 121);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 0;
            label2.Text = "Địa chỉ: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(389, 80);
            label6.Name = "label6";
            label6.Size = new Size(116, 20);
            label6.TabIndex = 0;
            label6.Text = "Số điện thoại: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(27, 400);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 0;
            label7.Text = "Thành tiền: ";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(170, 77);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.ReadOnly = true;
            txtTenKH.Size = new Size(213, 27);
            txtTenKH.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(114, 118);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.ReadOnly = true;
            txtDiaChi.Size = new Size(269, 27);
            txtDiaChi.TabIndex = 1;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(502, 79);
            txtSDT.Name = "txtSDT";
            txtSDT.ReadOnly = true;
            txtSDT.Size = new Size(183, 27);
            txtSDT.TabIndex = 1;
            // 
            // dghd
            // 
            dghd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dghd.BackgroundColor = Color.FromArgb(255, 224, 192);
            dghd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dghd.Columns.AddRange(new DataGridViewColumn[] { clTenSp, clSL, clDonGia1 });
            dghd.Location = new Point(31, 171);
            dghd.Name = "dghd";
            dghd.RowHeadersWidth = 51;
            dghd.RowTemplate.Height = 24;
            dghd.Size = new Size(653, 200);
            dghd.TabIndex = 2;
            dghd.CellFormatting += dghd_CellFormatting;
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
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(209, 397);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(322, 27);
            txtThanhTien.TabIndex = 1;
            txtThanhTien.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(27, 435);
            label3.Name = "label3";
            label3.Size = new Size(190, 20);
            label3.TabIndex = 0;
            label3.Text = "Khách hàng thanh toán: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(27, 470);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 0;
            label5.Text = "Tiền trả lại: ";
            // 
            // txtKHTT
            // 
            txtKHTT.Location = new Point(209, 432);
            txtKHTT.Name = "txtKHTT";
            txtKHTT.ReadOnly = true;
            txtKHTT.Size = new Size(322, 27);
            txtKHTT.TabIndex = 1;
            txtKHTT.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTraLai
            // 
            txtTraLai.Location = new Point(209, 467);
            txtTraLai.Name = "txtTraLai";
            txtTraLai.ReadOnly = true;
            txtTraLai.Size = new Size(322, 27);
            txtTraLai.TabIndex = 1;
            txtTraLai.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Kristen ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(714, 51);
            label4.TabIndex = 0;
            label4.Text = "HÓA ĐƠN";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(714, 533);
            Controls.Add(dghd);
            Controls.Add(txtSDT);
            Controls.Add(txtTraLai);
            Controls.Add(txtKHTT);
            Controls.Add(txtThanhTien);
            Controls.Add(txtDiaChi);
            Controls.Add(txtTenKH);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn";
            Load += frmHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dghd).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DataGridView dghd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonGia1;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKHTT;
        private System.Windows.Forms.TextBox txtTraLai;
        private System.Windows.Forms.Label label4;
    }
}