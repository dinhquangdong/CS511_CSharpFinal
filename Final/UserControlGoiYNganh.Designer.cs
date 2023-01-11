namespace Final
{
    partial class UserControlGoiYNganh
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
            this.btnBackTinhDiem = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelDiemCuaBan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBackTinhDiem
            // 
            this.btnBackTinhDiem.Location = new System.Drawing.Point(19, 7);
            this.btnBackTinhDiem.Name = "btnBackTinhDiem";
            this.btnBackTinhDiem.Size = new System.Drawing.Size(83, 56);
            this.btnBackTinhDiem.TabIndex = 0;
            this.btnBackTinhDiem.Text = "Trở về";
            this.btnBackTinhDiem.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 106);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1066, 522);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A00"});
            this.comboBox1.Location = new System.Drawing.Point(139, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 32);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "A00";
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // labelDiemCuaBan
            // 
            this.labelDiemCuaBan.AutoSize = true;
            this.labelDiemCuaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiemCuaBan.Location = new System.Drawing.Point(387, 46);
            this.labelDiemCuaBan.Name = "labelDiemCuaBan";
            this.labelDiemCuaBan.Size = new System.Drawing.Size(241, 31);
            this.labelDiemCuaBan.TabIndex = 3;
            this.labelDiemCuaBan.Text = "Điểm của bạn: 22";
            // 
            // UserControlGoiYNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelDiemCuaBan);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnBackTinhDiem);
            this.Name = "UserControlGoiYNganh";
            this.Size = new System.Drawing.Size(1066, 628);
            this.Load += new System.EventHandler(this.UserControlGoiYNganh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackTinhDiem;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelDiemCuaBan;
    }
}
