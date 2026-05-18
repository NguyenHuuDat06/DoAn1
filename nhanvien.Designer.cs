namespace BtlWF
{
    partial class nhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nhanvien));
            pictureBox1 = new PictureBox();
            btnQLSP = new Button();
            btnQLHD = new Button();
            btnQLKH = new Button();
            imageList1 = new ImageList(components);
            btCaNhan = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.BlanchedAlmond;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(683, 141);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnQLSP
            // 
            btnQLSP.BackColor = Color.Transparent;
            btnQLSP.BackgroundImage = (Image)resources.GetObject("btnQLSP.BackgroundImage");
            btnQLSP.BackgroundImageLayout = ImageLayout.Stretch;
            btnQLSP.Location = new Point(3, 416);
            btnQLSP.Name = "btnQLSP";
            btnQLSP.Size = new Size(338, 263);
            btnQLSP.TabIndex = 9;
            btnQLSP.UseVisualStyleBackColor = false;
            btnQLSP.Click += btnQLSP_Click;
            // 
            // btnQLHD
            // 
            btnQLHD.BackColor = Color.Transparent;
            btnQLHD.BackgroundImage = (Image)resources.GetObject("btnQLHD.BackgroundImage");
            btnQLHD.BackgroundImageLayout = ImageLayout.Stretch;
            btnQLHD.Location = new Point(347, 148);
            btnQLHD.Name = "btnQLHD";
            btnQLHD.Size = new Size(338, 262);
            btnQLHD.TabIndex = 7;
            btnQLHD.UseVisualStyleBackColor = false;
            btnQLHD.Click += btnQLHD_Click;
            // 
            // btnQLKH
            // 
            btnQLKH.BackColor = Color.Transparent;
            btnQLKH.BackgroundImage = (Image)resources.GetObject("btnQLKH.BackgroundImage");
            btnQLKH.BackgroundImageLayout = ImageLayout.Stretch;
            btnQLKH.ImageList = imageList1;
            btnQLKH.Location = new Point(2, 148);
            btnQLKH.Name = "btnQLKH";
            btnQLKH.Size = new Size(339, 262);
            btnQLKH.TabIndex = 6;
            btnQLKH.UseVisualStyleBackColor = false;
            btnQLKH.Click += btnQLKH_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // btCaNhan
            // 
            btCaNhan.BackgroundImage = (Image)resources.GetObject("btCaNhan.BackgroundImage");
            btCaNhan.BackgroundImageLayout = ImageLayout.Stretch;
            btCaNhan.Location = new Point(348, 416);
            btCaNhan.Name = "btCaNhan";
            btCaNhan.Size = new Size(337, 263);
            btCaNhan.TabIndex = 12;
            btCaNhan.UseVisualStyleBackColor = true;
            // 
            // nhanvien
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(684, 684);
            Controls.Add(btCaNhan);
            Controls.Add(pictureBox1);
            Controls.Add(btnQLSP);
            Controls.Add(btnQLHD);
            Controls.Add(btnQLKH);
            Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DarkGreen;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "nhanvien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhân viên";
            Load += nhanvien_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnQLSP;
        private System.Windows.Forms.Button btnQLHD;
        private System.Windows.Forms.Button btnQLKH;
        private System.Windows.Forms.Button btCaNhan;
        private ImageList imageList1;
    }
}