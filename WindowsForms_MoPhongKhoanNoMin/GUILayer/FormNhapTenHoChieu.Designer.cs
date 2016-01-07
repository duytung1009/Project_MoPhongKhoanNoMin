namespace WindowsForms_MoPhongKhoanNoMin.GUILayer
{
    partial class FormNhapTenHoChieu
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
            this.labelTitle2 = new System.Windows.Forms.Label();
            this.textBoxTenBanVe = new System.Windows.Forms.TextBox();
            this.buttonTaoMoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle2
            // 
            this.labelTitle2.AutoSize = true;
            this.labelTitle2.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelTitle2.Location = new System.Drawing.Point(12, 9);
            this.labelTitle2.Name = "labelTitle2";
            this.labelTitle2.Padding = new System.Windows.Forms.Padding(3);
            this.labelTitle2.Size = new System.Drawing.Size(93, 27);
            this.labelTitle2.TabIndex = 57;
            this.labelTitle2.Text = "Tên bản vẽ";
            // 
            // textBoxTenBanVe
            // 
            this.textBoxTenBanVe.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenBanVe.Location = new System.Drawing.Point(111, 12);
            this.textBoxTenBanVe.Name = "textBoxTenBanVe";
            this.textBoxTenBanVe.Size = new System.Drawing.Size(200, 22);
            this.textBoxTenBanVe.TabIndex = 58;
            // 
            // buttonTaoMoi
            // 
            this.buttonTaoMoi.AutoSize = true;
            this.buttonTaoMoi.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonTaoMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTaoMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTaoMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTaoMoi.ForeColor = System.Drawing.Color.White;
            this.buttonTaoMoi.Location = new System.Drawing.Point(243, 66);
            this.buttonTaoMoi.Name = "buttonTaoMoi";
            this.buttonTaoMoi.Size = new System.Drawing.Size(79, 33);
            this.buttonTaoMoi.TabIndex = 59;
            this.buttonTaoMoi.Text = "LƯU LẠI";
            this.buttonTaoMoi.UseVisualStyleBackColor = false;
            this.buttonTaoMoi.Click += new System.EventHandler(this.buttonTaoMoi_Click);
            // 
            // FormNhapTenBanVe
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 111);
            this.Controls.Add(this.buttonTaoMoi);
            this.Controls.Add(this.textBoxTenBanVe);
            this.Controls.Add(this.labelTitle2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormNhapTenBanVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập tên bản vẽ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle2;
        private System.Windows.Forms.TextBox textBoxTenBanVe;
        private System.Windows.Forms.Button buttonTaoMoi;
    }
}