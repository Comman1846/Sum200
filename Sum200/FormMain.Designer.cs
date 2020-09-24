namespace Sum200
{
    partial class FrmMain
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
            this.BtnStart = new System.Windows.Forms.Button();
            this.LblHalfway = new System.Windows.Forms.Label();
            this.TxtHalfway = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(19, 15);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(185, 86);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // LblHalfway
            // 
            this.LblHalfway.AutoSize = true;
            this.LblHalfway.Location = new System.Drawing.Point(21, 153);
            this.LblHalfway.Name = "LblHalfway";
            this.LblHalfway.Size = new System.Drawing.Size(93, 17);
            this.LblHalfway.TabIndex = 1;
            this.LblHalfway.Text = "Halfway Total";
            // 
            // TxtHalfway
            // 
            this.TxtHalfway.Location = new System.Drawing.Point(22, 187);
            this.TxtHalfway.Name = "TxtHalfway";
            this.TxtHalfway.ReadOnly = true;
            this.TxtHalfway.Size = new System.Drawing.Size(91, 22);
            this.TxtHalfway.TabIndex = 2;
            this.TxtHalfway.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(26, 272);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(40, 17);
            this.LblTotal.TabIndex = 3;
            this.LblTotal.Text = "Total";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(24, 309);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(91, 22);
            this.TxtTotal.TabIndex = 4;
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 450);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.TxtHalfway);
            this.Controls.Add(this.LblHalfway);
            this.Controls.Add(this.BtnStart);
            this.Name = "FrmMain";
            this.Text = "Sum200";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label LblHalfway;
        private System.Windows.Forms.TextBox TxtHalfway;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.TextBox TxtTotal;
    }
}

