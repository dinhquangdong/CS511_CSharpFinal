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
            this.SuspendLayout();
            // 
            // labelTenNganh
            // 
            this.labelTenNganh.BackColor = System.Drawing.Color.LightBlue;
            this.labelTenNganh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTenNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenNganh.Location = new System.Drawing.Point(4, 15);
            this.labelTenNganh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTenNganh.Name = "labelTenNganh";
            this.labelTenNganh.Size = new System.Drawing.Size(265, 145);
            this.labelTenNganh.TabIndex = 0;
            this.labelTenNganh.Text = "Khoa học máy tính";
            this.labelTenNganh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTenNganh.Click += new System.EventHandler(this.labelTenNganh_Click);
            // 
            // labelMaNganh
            // 
            this.labelMaNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaNganh.Location = new System.Drawing.Point(0, 15);
            this.labelMaNganh.Name = "labelMaNganh";
            this.labelMaNganh.Size = new System.Drawing.Size(270, 37);
            this.labelMaNganh.TabIndex = 1;
            this.labelMaNganh.Text = "Mã ngành: 7480101";
            this.labelMaNganh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.labelMaNganh);
            this.Controls.Add(this.labelTenNganh);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControlNganh";
            this.Size = new System.Drawing.Size(273, 160);
            this.Load += new System.EventHandler(this.UserControlNganh_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTenNganh;
        private System.Windows.Forms.Label labelMaNganh;
    }
}
