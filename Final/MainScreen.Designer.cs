namespace Final
{
    partial class MainScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.buttonMapSearch = new System.Windows.Forms.Button();
            this.buttonTimChu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.wbMap = new System.Windows.Forms.WebBrowser();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.comboBoxFilter);
            this.panel1.Controls.Add(this.buttonMapSearch);
            this.panel1.Controls.Add(this.buttonTimChu);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(308, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 711);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboBoxFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxFilter.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFilter.ForeColor = System.Drawing.Color.Gray;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.ItemHeight = 23;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "Điểm chuẩn",
            "Ngành",
            "Tổ hợp môn",
            "Trường"});
            this.comboBoxFilter.Location = new System.Drawing.Point(37, 19);
            this.comboBoxFilter.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(138, 31);
            this.comboBoxFilter.TabIndex = 5;
            this.comboBoxFilter.Text = "Trường";
            this.comboBoxFilter.TextChanged += new System.EventHandler(this.comboBoxFilter_TextChanged);
            // 
            // buttonMapSearch
            // 
            this.buttonMapSearch.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonMapSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMapSearch.FlatAppearance.BorderSize = 0;
            this.buttonMapSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMapSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMapSearch.Location = new System.Drawing.Point(936, 19);
            this.buttonMapSearch.Name = "buttonMapSearch";
            this.buttonMapSearch.Size = new System.Drawing.Size(29, 28);
            this.buttonMapSearch.TabIndex = 4;
            this.buttonMapSearch.UseVisualStyleBackColor = false;
            this.buttonMapSearch.Click += new System.EventHandler(this.buttonMapSearch_Click);
            // 
            // buttonTimChu
            // 
            this.buttonTimChu.BackColor = System.Drawing.Color.Gray;
            this.buttonTimChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTimChu.FlatAppearance.BorderSize = 0;
            this.buttonTimChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimChu.Location = new System.Drawing.Point(901, 19);
            this.buttonTimChu.Name = "buttonTimChu";
            this.buttonTimChu.Size = new System.Drawing.Size(29, 28);
            this.buttonTimChu.TabIndex = 3;
            this.buttonTimChu.UseVisualStyleBackColor = false;
            this.buttonTimChu.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Controls.Add(this.wbMap);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1076, 638);
            this.panel3.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1076, 638);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // wbMap
            // 
            this.wbMap.Location = new System.Drawing.Point(0, 0);
            this.wbMap.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMap.Name = "wbMap";
            this.wbMap.ScriptErrorsSuppressed = true;
            this.wbMap.Size = new System.Drawing.Size(1076, 638);
            this.wbMap.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(198, 19);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(687, 28);
            this.textBoxSearch.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pblogo);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 711);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tìm Trường Đại Học";
            // 
            // pblogo
            // 
            this.pblogo.BackColor = System.Drawing.Color.Transparent;
            this.pblogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pblogo.Location = new System.Drawing.Point(19, 45);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(267, 194);
            this.pblogo.TabIndex = 8;
            this.pblogo.TabStop = false;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button8.Location = new System.Drawing.Point(0, 511);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(308, 68);
            this.button8.TabIndex = 7;
            this.button8.Text = "Tính điểm";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button7.Location = new System.Drawing.Point(0, 641);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(308, 68);
            this.button7.TabIndex = 6;
            this.button7.Text = "Admin";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Location = new System.Drawing.Point(0, 447);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(308, 68);
            this.button5.TabIndex = 4;
            this.button5.Text = "Tất cả các trường";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(0, 576);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(308, 68);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thông tin bản thân";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1384, 711);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm trường đại học";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.WebBrowser wbMap;
        private System.Windows.Forms.Button buttonMapSearch;
        private System.Windows.Forms.Button buttonTimChu;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.ComboBox comboBoxFilter;
    }
}

