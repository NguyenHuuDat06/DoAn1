namespace BtlWF
{
    partial class frmadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadmin));
            btnQLKH = new Button();
            btnQLHD = new Button();
            btnQLSP = new Button();
            btnQLNV = new Button();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            bảoMậtToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnQLKH
            // 
            btnQLKH.BackColor = Color.Transparent;
            btnQLKH.BackgroundImage = (Image)resources.GetObject("btnQLKH.BackgroundImage");
            btnQLKH.BackgroundImageLayout = ImageLayout.Stretch;
            btnQLKH.Location = new Point(-1, 154);
            btnQLKH.Name = "btnQLKH";
            btnQLKH.Size = new Size(339, 263);
            btnQLKH.TabIndex = 1;
            btnQLKH.UseVisualStyleBackColor = false;
            btnQLKH.Click += btnQLKH_Click;
            // 
            // btnQLHD
            // 
            btnQLHD.BackgroundImage = (Image)resources.GetObject("btnQLHD.BackgroundImage");
            btnQLHD.BackgroundImageLayout = ImageLayout.Stretch;
            btnQLHD.Location = new Point(344, 154);
            btnQLHD.Name = "btnQLHD";
            btnQLHD.Size = new Size(338, 263);
            btnQLHD.TabIndex = 2;
            btnQLHD.UseVisualStyleBackColor = false;
            btnQLHD.Click += btnQLHD_Click;
            // 
            // btnQLSP
            // 
            btnQLSP.BackColor = Color.Transparent;
            btnQLSP.BackgroundImage = (Image)resources.GetObject("btnQLSP.BackgroundImage");
            btnQLSP.BackgroundImageLayout = ImageLayout.Stretch;
            btnQLSP.Location = new Point(344, 423);
            btnQLSP.Name = "btnQLSP";
            btnQLSP.Size = new Size(338, 260);
            btnQLSP.TabIndex = 4;
            btnQLSP.UseVisualStyleBackColor = false;
            btnQLSP.Click += btnQLSP_Click;
            // 
            // btnQLNV
            // 
            btnQLNV.BackColor = Color.Transparent;
            btnQLNV.BackgroundImage = (Image)resources.GetObject("btnQLNV.BackgroundImage");
            btnQLNV.BackgroundImageLayout = ImageLayout.Stretch;
            btnQLNV.Location = new Point(-1, 423);
            btnQLNV.Name = "btnQLNV";
            btnQLNV.Size = new Size(339, 260);
            btnQLNV.TabIndex = 3;
            btnQLNV.UseVisualStyleBackColor = false;
            btnQLNV.Click += btnQLNV_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(681, 117);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { bảoMậtToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(681, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // bảoMậtToolStripMenuItem
            // 
            bảoMậtToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đổiMậtKhẩuToolStripMenuItem });
            bảoMậtToolStripMenuItem.Name = "bảoMậtToolStripMenuItem";
            bảoMậtToolStripMenuItem.Size = new Size(79, 24);
            bảoMậtToolStripMenuItem.Text = "Bảo mật";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(181, 26);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            đổiMậtKhẩuToolStripMenuItem.Click += đổiMậtKhẩuToolStripMenuItem_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // frmadmin
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(681, 682);
            Controls.Add(btnQLNV);
            Controls.Add(btnQLSP);
            Controls.Add(btnQLHD);
            Controls.Add(btnQLKH);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmadmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADMIN";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnQLKH;
        private System.Windows.Forms.Button btnQLHD;
        private System.Windows.Forms.Button btnQLSP;
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bảoMậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ImageList imageList1;
    }
}