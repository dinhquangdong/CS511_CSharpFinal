namespace Final
{
    partial class UserControlAddBinhLuan
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
            this.txbBinhLuan = new System.Windows.Forms.TextBox();
            this.btnBinhLuan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.rd4 = new System.Windows.Forms.RadioButton();
            this.rd5 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txbBinhLuan
            // 
            this.txbBinhLuan.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txbBinhLuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbBinhLuan.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBinhLuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txbBinhLuan.Location = new System.Drawing.Point(3, 40);
            this.txbBinhLuan.Multiline = true;
            this.txbBinhLuan.Name = "txbBinhLuan";
            this.txbBinhLuan.Size = new System.Drawing.Size(718, 36);
            this.txbBinhLuan.TabIndex = 0;
            // 
            // btnBinhLuan
            // 
            this.btnBinhLuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.btnBinhLuan.FlatAppearance.BorderSize = 0;
            this.btnBinhLuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBinhLuan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinhLuan.ForeColor = System.Drawing.Color.White;
            this.btnBinhLuan.Location = new System.Drawing.Point(727, 40);
            this.btnBinhLuan.Name = "btnBinhLuan";
            this.btnBinhLuan.Size = new System.Drawing.Size(107, 36);
            this.btnBinhLuan.TabIndex = 1;
            this.btnBinhLuan.Text = "Bình luận";
            this.btnBinhLuan.UseVisualStyleBackColor = false;
            this.btnBinhLuan.Click += new System.EventHandler(this.btnBinhLuan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sao đánh giá:";
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.Checked = true;
            this.rd1.Location = new System.Drawing.Point(151, 16);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(51, 17);
            this.rd1.TabIndex = 3;
            this.rd1.TabStop = true;
            this.rd1.Tag = "1";
            this.rd1.Text = "1 sao";
            this.rd1.UseVisualStyleBackColor = true;
            this.rd1.CheckedChanged += new System.EventHandler(this.rd1_CheckedChanged);
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.Location = new System.Drawing.Point(208, 16);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(51, 17);
            this.rd2.TabIndex = 4;
            this.rd2.Tag = "2";
            this.rd2.Text = "2 sao";
            this.rd2.UseVisualStyleBackColor = true;
            this.rd2.CheckedChanged += new System.EventHandler(this.rd1_CheckedChanged);
            // 
            // rd3
            // 
            this.rd3.AutoSize = true;
            this.rd3.Location = new System.Drawing.Point(265, 16);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(51, 17);
            this.rd3.TabIndex = 5;
            this.rd3.Tag = "3";
            this.rd3.Text = "3 sao";
            this.rd3.UseVisualStyleBackColor = true;
            this.rd3.CheckedChanged += new System.EventHandler(this.rd1_CheckedChanged);
            // 
            // rd4
            // 
            this.rd4.AutoSize = true;
            this.rd4.Location = new System.Drawing.Point(322, 16);
            this.rd4.Name = "rd4";
            this.rd4.Size = new System.Drawing.Size(51, 17);
            this.rd4.TabIndex = 6;
            this.rd4.Tag = "4";
            this.rd4.Text = "4 sao";
            this.rd4.UseVisualStyleBackColor = true;
            this.rd4.CheckedChanged += new System.EventHandler(this.rd1_CheckedChanged);
            // 
            // rd5
            // 
            this.rd5.AutoSize = true;
            this.rd5.Location = new System.Drawing.Point(379, 17);
            this.rd5.Name = "rd5";
            this.rd5.Size = new System.Drawing.Size(51, 17);
            this.rd5.TabIndex = 7;
            this.rd5.Tag = "5";
            this.rd5.Text = "5 sao";
            this.rd5.UseVisualStyleBackColor = true;
            this.rd5.CheckedChanged += new System.EventHandler(this.rd1_CheckedChanged);
            // 
            // UserControlAddBinhLuan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.rd5);
            this.Controls.Add(this.rd4);
            this.Controls.Add(this.rd3);
            this.Controls.Add(this.rd2);
            this.Controls.Add(this.rd1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBinhLuan);
            this.Controls.Add(this.txbBinhLuan);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlAddBinhLuan";
            this.Size = new System.Drawing.Size(837, 79);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbBinhLuan;
        private System.Windows.Forms.Button btnBinhLuan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.RadioButton rd3;
        private System.Windows.Forms.RadioButton rd4;
        private System.Windows.Forms.RadioButton rd5;
    }
}
