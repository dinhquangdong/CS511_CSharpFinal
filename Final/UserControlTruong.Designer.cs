﻿namespace Final
{
    partial class UserControlTruong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlTruong));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.lbMinMaxDiem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(33, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.UserControlTruong_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.UserControlTruong_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserControlTruong_MouseMove);
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.labelName.Location = new System.Drawing.Point(10, 147);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(188, 74);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Đại học Công nghệ thông tin";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelName.Click += new System.EventHandler(this.UserControlTruong_Click);
            this.labelName.MouseLeave += new System.EventHandler(this.UserControlTruong_MouseLeave);
            this.labelName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserControlTruong_MouseMove);
            // 
            // lbMinMaxDiem
            // 
            this.lbMinMaxDiem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinMaxDiem.Location = new System.Drawing.Point(0, 221);
            this.lbMinMaxDiem.Name = "lbMinMaxDiem";
            this.lbMinMaxDiem.Size = new System.Drawing.Size(207, 18);
            this.lbMinMaxDiem.TabIndex = 2;
            this.lbMinMaxDiem.Text = "label1";
            this.lbMinMaxDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbMinMaxDiem.MouseLeave += new System.EventHandler(this.UserControlTruong_MouseLeave);
            this.lbMinMaxDiem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserControlTruong_MouseMove);
            // 
            // UserControlTruong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.lbMinMaxDiem);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControlTruong";
            this.Size = new System.Drawing.Size(207, 255);
            this.Load += new System.EventHandler(this.UserControlTruong_Load);
            this.Click += new System.EventHandler(this.UserControlTruong_Click);
            this.MouseLeave += new System.EventHandler(this.UserControlTruong_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserControlTruong_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label lbMinMaxDiem;
    }
}
