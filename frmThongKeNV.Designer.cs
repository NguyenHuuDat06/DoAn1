namespace BtlWF
{
    partial class frmThongKeNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeNV));
            this.dgNVDS = new System.Windows.Forms.DataGridView();
            this.dgNVLuong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgNVDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNVLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgNVDS
            // 
            this.dgNVDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgNVDS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgNVDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNVDS.Location = new System.Drawing.Point(1, 24);
            this.dgNVDS.Name = "dgNVDS";
            this.dgNVDS.RowHeadersWidth = 51;
            this.dgNVDS.RowTemplate.Height = 24;
            this.dgNVDS.Size = new System.Drawing.Size(682, 165);
            this.dgNVDS.TabIndex = 0;
            // 
            // dgNVLuong
            // 
            this.dgNVLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgNVLuong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgNVLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNVLuong.Location = new System.Drawing.Point(1, 235);
            this.dgNVLuong.Name = "dgNVLuong";
            this.dgNVLuong.RowHeadersWidth = 51;
            this.dgNVLuong.RowTemplate.Height = 24;
            this.dgNVLuong.Size = new System.Drawing.Size(682, 170);
            this.dgNVLuong.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(1, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhân viên có doanh số cao nhất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(1, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhân viên có lương cao nhất";
            // 
            // frmThongKeNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           
            this.ClientSize = new System.Drawing.Size(683, 403);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgNVLuong);
            this.Controls.Add(this.dgNVDS);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThongKeNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Thống kê";
            this.Load += new System.EventHandler(this.frmThongKeNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNVDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNVLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgNVDS;
        private System.Windows.Forms.DataGridView dgNVLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}