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
            this.SuspendLayout();
            // 
            // labelTenNganh
            // 
            this.labelTenNganh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTenNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenNganh.Location = new System.Drawing.Point(9, 11);
            this.labelTenNganh.Name = "labelTenNganh";
            this.labelTenNganh.Size = new System.Drawing.Size(184, 104);
            this.labelTenNganh.TabIndex = 0;
            this.labelTenNganh.Text = "Khoa học máy tính";
            this.labelTenNganh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.labelTenNganh);
            this.Name = "UserControlNganh";
            this.Size = new System.Drawing.Size(205, 130);
            this.Load += new System.EventHandler(this.UserControlNganh_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTenNganh;
    }
}
