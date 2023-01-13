namespace Final
{
    partial class UserControlNganhGoiY
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTenTruong = new System.Windows.Forms.Label();
            this.labelTenNganh = new System.Windows.Forms.Label();
            this.labelMaNganh = new System.Windows.Forms.Label();
            this.labelDiemChuan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTenTruong
            // 
            this.labelTenTruong.AutoSize = true;
            this.labelTenTruong.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenTruong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.labelTenTruong.Location = new System.Drawing.Point(35, 16);
            this.labelTenTruong.Name = "labelTenTruong";
            this.labelTenTruong.Size = new System.Drawing.Size(332, 33);
            this.labelTenTruong.TabIndex = 0;
            this.labelTenTruong.Text = "Trường Đại học Bách Khoa";
            // 
            // labelTenNganh
            // 
            this.labelTenNganh.AutoSize = true;
            this.labelTenNganh.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenNganh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.labelTenNganh.Location = new System.Drawing.Point(37, 63);
            this.labelTenNganh.Name = "labelTenNganh";
            this.labelTenNganh.Size = new System.Drawing.Size(237, 24);
            this.labelTenNganh.TabIndex = 1;
            this.labelTenNganh.Text = "Ngành khoa học máy tính";
            // 
            // labelMaNganh
            // 
            this.labelMaNganh.AutoSize = true;
            this.labelMaNganh.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaNganh.Location = new System.Drawing.Point(37, 101);
            this.labelMaNganh.Name = "labelMaNganh";
            this.labelMaNganh.Size = new System.Drawing.Size(138, 23);
            this.labelMaNganh.TabIndex = 2;
            this.labelMaNganh.Text = "Mã ngành: 106";
            // 
            // labelDiemChuan
            // 
            this.labelDiemChuan.AutoSize = true;
            this.labelDiemChuan.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiemChuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.labelDiemChuan.Location = new System.Drawing.Point(808, 63);
            this.labelDiemChuan.Name = "labelDiemChuan";
            this.labelDiemChuan.Size = new System.Drawing.Size(201, 24);
            this.labelDiemChuan.TabIndex = 3;
            this.labelDiemChuan.Text = "Điểm chuẩn: 20.50";
            // 
            // UserControlNganhGoiY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelDiemChuan);
            this.Controls.Add(this.labelMaNganh);
            this.Controls.Add(this.labelTenNganh);
            this.Controls.Add(this.labelTenTruong);
            this.Name = "UserControlNganhGoiY";
            this.Size = new System.Drawing.Size(1039, 143);
            this.Load += new System.EventHandler(this.UserControlNganhGoiY_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTenTruong;
        private System.Windows.Forms.Label labelTenNganh;
        private System.Windows.Forms.Label labelMaNganh;
        private System.Windows.Forms.Label labelDiemChuan;
    }
}
