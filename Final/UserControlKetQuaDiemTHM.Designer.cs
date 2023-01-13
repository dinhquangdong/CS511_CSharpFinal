namespace Final
{
    partial class UserControlKetQuaDiemTHM
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
            this.lbMaTHM = new System.Windows.Forms.Label();
            this.lbTenTHM = new System.Windows.Forms.Label();
            this.lbDiemTHM = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMaTHM
            // 
            this.lbMaTHM.AutoSize = true;
            this.lbMaTHM.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaTHM.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbMaTHM.Location = new System.Drawing.Point(12, 10);
            this.lbMaTHM.Name = "lbMaTHM";
            this.lbMaTHM.Size = new System.Drawing.Size(67, 33);
            this.lbMaTHM.TabIndex = 0;
            this.lbMaTHM.Text = "A00";
            // 
            // lbTenTHM
            // 
            this.lbTenTHM.AutoSize = true;
            this.lbTenTHM.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTHM.Location = new System.Drawing.Point(15, 53);
            this.lbTenTHM.Name = "lbTenTHM";
            this.lbTenTHM.Size = new System.Drawing.Size(135, 24);
            this.lbTenTHM.TabIndex = 1;
            this.lbTenTHM.Text = "Toán, Lý, Hóa";
            // 
            // lbDiemTHM
            // 
            this.lbDiemTHM.AutoSize = true;
            this.lbDiemTHM.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiemTHM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.lbDiemTHM.Location = new System.Drawing.Point(204, 31);
            this.lbDiemTHM.Name = "lbDiemTHM";
            this.lbDiemTHM.Size = new System.Drawing.Size(32, 24);
            this.lbDiemTHM.TabIndex = 2;
            this.lbDiemTHM.Text = "24";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "điểm";
            // 
            // UserControlKetQuaDiemTHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbDiemTHM);
            this.Controls.Add(this.lbTenTHM);
            this.Controls.Add(this.lbMaTHM);
            this.Name = "UserControlKetQuaDiemTHM";
            this.Size = new System.Drawing.Size(303, 94);
            this.Load += new System.EventHandler(this.UserControlKetQuaDiemTHM_Load);
            this.Click += new System.EventHandler(this.UserControlKetQuaDiemTHM_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaTHM;
        private System.Windows.Forms.Label lbTenTHM;
        private System.Windows.Forms.Label lbDiemTHM;
        private System.Windows.Forms.Label label4;
    }
}
