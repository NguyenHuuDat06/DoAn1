namespace BtlWF
{
    partial class hoadonnv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hoadonnv));
            dgHD = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btThanhToan = new Button();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgHD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgHD
            // 
            dgHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgHD.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgHD.Location = new Point(7, 32);
            dgHD.Margin = new Padding(4);
            dgHD.Name = "dgHD";
            dgHD.RowHeadersWidth = 51;
            dgHD.RowTemplate.Height = 24;
            dgHD.Size = new Size(554, 332);
            dgHD.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(575, 169);
            dateTimePicker1.MaxDate = new DateTime(2023, 10, 21, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 34);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.Value = new DateTime(2023, 10, 21, 0, 0, 0, 0);
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(568, 135);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Ink Free", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(576, 0);
            label2.Name = "label2";
            label2.Size = new Size(205, 131);
            label2.TabIndex = 5;
            label2.Text = "HÓA ĐƠN";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btThanhToan
            // 
            btThanhToan.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btThanhToan.ImageAlign = ContentAlignment.MiddleLeft;
            btThanhToan.Location = new Point(608, 435);
            btThanhToan.Name = "btThanhToan";
            btThanhToan.Size = new Size(158, 60);
            btThanhToan.TabIndex = 6;
            btThanhToan.Text = "Lên đơn";
            btThanhToan.UseVisualStyleBackColor = true;
            btThanhToan.Click += btThanhToan_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Microsoft Sans Serif", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(575, 259);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 32);
            dateTimePicker2.TabIndex = 7;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(572, 234);
            label1.Name = "label1";
            label1.Size = new Size(48, 22);
            label1.TabIndex = 8;
            label1.Text = "Đến:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(572, 144);
            label3.Name = "label3";
            label3.Size = new Size(37, 22);
            label3.TabIndex = 8;
            label3.Text = "Từ:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(dgHD);
            groupBox1.Location = new Point(1, 137);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(568, 371);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách hóa đơn";
            // 
            // hoadonnv
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(787, 507);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(btThanhToan);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(dateTimePicker1);
            Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "hoadonnv";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn";
            Load += hoadonnv_Load;
            ((System.ComponentModel.ISupportInitialize)dgHD).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgHD;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThanhToan;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}