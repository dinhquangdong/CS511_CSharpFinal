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
            this.labelMa = new System.Windows.Forms.Label();
            this.labelMon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMa
            // 
            this.labelMa.AutoSize = true;
            this.labelMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMa.Location = new System.Drawing.Point(46, 27);
            this.labelMa.Name = "labelMa";
            this.labelMa.Size = new System.Drawing.Size(57, 29);
            this.labelMa.TabIndex = 0;
            this.labelMa.Text = "A00";
            // 
            // labelMon
            // 
            this.labelMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMon.Location = new System.Drawing.Point(3, 83);
            this.labelMon.Name = "labelMon";
            this.labelMon.Size = new System.Drawing.Size(150, 59);
            this.labelMon.TabIndex = 1;
            this.labelMon.Text = "Toán, Lý, Hoá";
            this.labelMon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlToHopMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelMon);
            this.Controls.Add(this.labelMa);
            this.Name = "UserControlToHopMon";
            this.Size = new System.Drawing.Size(154, 153);
            this.Load += new System.EventHandler(this.UserControlToHopMon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMa;
        private System.Windows.Forms.Label labelMon;
    }
}
