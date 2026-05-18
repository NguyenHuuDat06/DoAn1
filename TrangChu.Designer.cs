namespace BtlWF
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            btNhanVien = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btNhanVien
            // 
            btNhanVien.BackgroundImage = (Image)resources.GetObject("btNhanVien.BackgroundImage");
            btNhanVien.BackgroundImageLayout = ImageLayout.Stretch;
            btNhanVien.Location = new Point(385, 203);
            btNhanVien.Margin = new Padding(4);
            btNhanVien.Name = "btNhanVien";
            btNhanVien.Size = new Size(375, 305);
            btNhanVien.TabIndex = 0;
            btNhanVien.UseVisualStyleBackColor = true;
            btNhanVien.Click += btNhanVien_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(-1, 202);
            button1.Name = "button1";
            button1.Size = new Size(379, 305);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-16, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "ảnh nền.jpg");
            imageList1.Images.SetKeyName(1, "ảnhnhanvien.jpg");
            imageList1.Images.SetKeyName(2, "ảnhadmin.jpg");
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(758, 523);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(btNhanVien);
            Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "TrangChu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ứng dụng quản lý cửa hàng sách ";
            FormClosing += TrangChu_FormClosing;
            Load += TrangChu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btNhanVien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ImageList imageList1;
    }
}