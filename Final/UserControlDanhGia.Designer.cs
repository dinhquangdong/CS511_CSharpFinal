namespace Final
{
    partial class UserControlDanhGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDanhGia));
            this.lbTenHienThiUser = new System.Windows.Forms.Label();
            this.lbSoSao = new System.Windows.Forms.Label();
            this.pbSao = new System.Windows.Forms.PictureBox();
            this.lbBinhLuan = new System.Windows.Forms.Label();
            this.lbThoiGian = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSao)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTenHienThiUser
            // 
            this.lbTenHienThiUser.AutoSize = true;
            this.lbTenHienThiUser.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenHienThiUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lbTenHienThiUser.Location = new System.Drawing.Point(19, 15);
            this.lbTenHienThiUser.Name = "lbTenHienThiUser";
            this.lbTenHienThiUser.Size = new System.Drawing.Size(192, 24);
            this.lbTenHienThiUser.TabIndex = 0;
            this.lbTenHienThiUser.Text = "Trương Văn Chinh";
            // 
            // lbSoSao
            // 
            this.lbSoSao.AutoSize = true;
            this.lbSoSao.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoSao.Location = new System.Drawing.Point(761, 15);
            this.lbSoSao.Name = "lbSoSao";
            this.lbSoSao.Size = new System.Drawing.Size(25, 25);
            this.lbSoSao.TabIndex = 2;
            this.lbSoSao.Text = "4";
            // 
            // pbSao
            // 
            this.pbSao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbSao.Location = new System.Drawing.Point(785, 16);
            this.pbSao.Name = "pbSao";
            this.pbSao.Size = new System.Drawing.Size(22, 24);
            this.pbSao.TabIndex = 3;
            this.pbSao.TabStop = false;
            // 
            // lbBinhLuan
            // 
            this.lbBinhLuan.AllowDrop = true;
            this.lbBinhLuan.AutoSize = true;
            this.lbBinhLuan.Location = new System.Drawing.Point(19, 51);
            this.lbBinhLuan.MaximumSize = new System.Drawing.Size(830, 0);
            this.lbBinhLuan.Name = "lbBinhLuan";
            this.lbBinhLuan.Size = new System.Drawing.Size(803, 72);
            this.lbBinhLuan.TabIndex = 4;
            this.lbBinhLuan.Text = resources.GetString("lbBinhLuan.Text");
            // 
            // lbThoiGian
            // 
            this.lbThoiGian.AutoSize = true;
            this.lbThoiGian.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiGian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lbThoiGian.Location = new System.Drawing.Point(217, 19);
            this.lbThoiGian.Name = "lbThoiGian";
            this.lbThoiGian.Size = new System.Drawing.Size(18, 19);
            this.lbThoiGian.TabIndex = 5;
            this.lbThoiGian.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(234, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "giờ trước";
            // 
            // UserControlDanhGia
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbThoiGian);
            this.Controls.Add(this.lbBinhLuan);
            this.Controls.Add(this.pbSao);
            this.Controls.Add(this.lbSoSao);
            this.Controls.Add(this.lbTenHienThiUser);
            this.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlDanhGia";
            this.Size = new System.Drawing.Size(835, 138);
            this.Load += new System.EventHandler(this.UserControlDanhGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTenHienThiUser;
        private System.Windows.Forms.Label lbSoSao;
        private System.Windows.Forms.PictureBox pbSao;
        private System.Windows.Forms.Label lbBinhLuan;
        private System.Windows.Forms.Label lbThoiGian;
        private System.Windows.Forms.Label label2;
    }
}
