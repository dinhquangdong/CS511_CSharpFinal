namespace Final
{
    partial class UserControlNganh
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
            this.labelTenNganh = new System.Windows.Forms.Label();
            this.labelMaNganh = new System.Windows.Forms.Label();
            this.pbAnhNganh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhNganh)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTenNganh
            // 
            this.labelTenNganh.BackColor = System.Drawing.Color.White;
            this.labelTenNganh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTenNganh.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenNganh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.labelTenNganh.Location = new System.Drawing.Point(134, 10);
            this.labelTenNganh.Name = "labelTenNganh";
            this.labelTenNganh.Size = new System.Drawing.Size(317, 52);
            this.labelTenNganh.TabIndex = 0;
            this.labelTenNganh.Text = "Khoa học máy tính";
            this.labelTenNganh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTenNganh.Click += new System.EventHandler(this.labelTenNganh_Click);
            // 
            // labelMaNganh
            // 
            this.labelMaNganh.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaNganh.Location = new System.Drawing.Point(138, 72);
            this.labelMaNganh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaNganh.Name = "labelMaNganh";
            this.labelMaNganh.Size = new System.Drawing.Size(247, 30);
            this.labelMaNganh.TabIndex = 1;
            this.labelMaNganh.Text = "Mã ngành: 7480101";
            this.labelMaNganh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelMaNganh.Click += new System.EventHandler(this.labelTenNganh_Click);
            // 
            // pbAnhNganh
            // 
            this.pbAnhNganh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAnhNganh.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbAnhNganh.Location = new System.Drawing.Point(0, 0);
            this.pbAnhNganh.Name = "pbAnhNganh";
            this.pbAnhNganh.Size = new System.Drawing.Size(128, 128);
            this.pbAnhNganh.TabIndex = 2;
            this.pbAnhNganh.TabStop = false;
            this.pbAnhNganh.Click += new System.EventHandler(this.labelTenNganh_Click);
            // 
            // UserControlNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pbAnhNganh);
            this.Controls.Add(this.labelMaNganh);
            this.Controls.Add(this.labelTenNganh);
            this.Name = "UserControlNganh";
            this.Size = new System.Drawing.Size(488, 128);
            this.Load += new System.EventHandler(this.UserControlNganh_Load);
            this.Click += new System.EventHandler(this.labelTenNganh_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhNganh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTenNganh;
        private System.Windows.Forms.Label labelMaNganh;
        private System.Windows.Forms.PictureBox pbAnhNganh;
    }
}
