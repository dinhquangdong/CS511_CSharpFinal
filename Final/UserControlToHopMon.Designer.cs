namespace Final
{
    partial class UserControlToHopMon
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
            this.labelMon = new System.Windows.Forms.Label();
            this.labelMa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMon
            // 
            this.labelMon.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMon.Location = new System.Drawing.Point(220, 15);
            this.labelMon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMon.Name = "labelMon";
            this.labelMon.Size = new System.Drawing.Size(286, 47);
            this.labelMon.TabIndex = 1;
            this.labelMon.Text = "Toán, Lý, Hoá";
            this.labelMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelMon.Click += new System.EventHandler(this.UserControlToHopMon_Click);
            // 
            // labelMa
            // 
            this.labelMa.AutoSize = true;
            this.labelMa.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.labelMa.Location = new System.Drawing.Point(20, 19);
            this.labelMa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMa.Name = "labelMa";
            this.labelMa.Size = new System.Drawing.Size(67, 33);
            this.labelMa.TabIndex = 0;
            this.labelMa.Text = "A00";
            this.labelMa.Click += new System.EventHandler(this.UserControlToHopMon_Click);
            // 
            // UserControlToHopMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelMon);
            this.Controls.Add(this.labelMa);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControlToHopMon";
            this.Size = new System.Drawing.Size(521, 76);
            this.Load += new System.EventHandler(this.UserControlToHopMon_Load);
            this.Click += new System.EventHandler(this.UserControlToHopMon_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMon;
        private System.Windows.Forms.Label labelMa;
    }
}
