namespace WindowsForms_MoPhongKhoanNoMin.GUILayer
{
    partial class FormBaoCaoThongKe
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
            this.buttonTaoMoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.labelText2 = new System.Windows.Forms.Label();
            this.comboBox_MaHoChieu = new System.Windows.Forms.ComboBox();
            this.labelValue_TenBanVe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonTaoMoi
            // 
            this.buttonTaoMoi.AutoSize = true;
            this.buttonTaoMoi.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonTaoMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTaoMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTaoMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTaoMoi.ForeColor = System.Drawing.Color.White;
            this.buttonTaoMoi.Location = new System.Drawing.Point(65, 320);
            this.buttonTaoMoi.Name = "buttonTaoMoi";
            this.buttonTaoMoi.Size = new System.Drawing.Size(115, 33);
            this.buttonTaoMoi.TabIndex = 39;
            this.buttonTaoMoi.Text = "XUẤT BÁO CÁO";
            this.buttonTaoMoi.UseVisualStyleBackColor = false;
            this.buttonTaoMoi.Click += new System.EventHandler(this.buttonTaoMoi_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(249, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 380);
            this.label1.TabIndex = 40;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.BackColor = System.Drawing.Color.Transparent;
            this.labelText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelText.Location = new System.Drawing.Point(30, 40);
            this.labelText.Name = "labelText";
            this.labelText.Padding = new System.Windows.Forms.Padding(3);
            this.labelText.Size = new System.Drawing.Size(81, 27);
            this.labelText.TabIndex = 61;
            this.labelText.Text = "Hộ chiếu";
            // 
            // labelText2
            // 
            this.labelText2.AutoSize = true;
            this.labelText2.BackColor = System.Drawing.Color.Transparent;
            this.labelText2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelText2.Location = new System.Drawing.Point(30, 140);
            this.labelText2.Name = "labelText2";
            this.labelText2.Padding = new System.Windows.Forms.Padding(3);
            this.labelText2.Size = new System.Drawing.Size(64, 27);
            this.labelText2.TabIndex = 62;
            this.labelText2.Text = "Bản vẽ";
            // 
            // comboBox_MaHoChieu
            // 
            this.comboBox_MaHoChieu.FormattingEnabled = true;
            this.comboBox_MaHoChieu.Items.AddRange(new object[] {
            "Trên",
            "Dưới",
            "Phải",
            "Trái"});
            this.comboBox_MaHoChieu.Location = new System.Drawing.Point(25, 80);
            this.comboBox_MaHoChieu.Name = "comboBox_MaHoChieu";
            this.comboBox_MaHoChieu.Size = new System.Drawing.Size(200, 21);
            this.comboBox_MaHoChieu.TabIndex = 91;
            this.comboBox_MaHoChieu.SelectedIndexChanged += new System.EventHandler(this.comboBox_MaHoChieu_SelectedIndexChanged);
            // 
            // labelValue_TenBanVe
            // 
            this.labelValue_TenBanVe.BackColor = System.Drawing.Color.Transparent;
            this.labelValue_TenBanVe.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValue_TenBanVe.ForeColor = System.Drawing.Color.Black;
            this.labelValue_TenBanVe.Location = new System.Drawing.Point(25, 180);
            this.labelValue_TenBanVe.Name = "labelValue_TenBanVe";
            this.labelValue_TenBanVe.Padding = new System.Windows.Forms.Padding(3);
            this.labelValue_TenBanVe.Size = new System.Drawing.Size(200, 23);
            this.labelValue_TenBanVe.TabIndex = 92;
            this.labelValue_TenBanVe.Text = "value";
            // 
            // FormBaoCaoThongKe
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.labelValue_TenBanVe);
            this.Controls.Add(this.comboBox_MaHoChieu);
            this.Controls.Add(this.labelText2);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTaoMoi);
            this.Name = "FormBaoCaoThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo - thống kê";
            this.Shown += new System.EventHandler(this.FormBaoCaoThongKe_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTaoMoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelText2;
        private System.Windows.Forms.ComboBox comboBox_MaHoChieu;
        private System.Windows.Forms.Label labelValue_TenBanVe;
    }
}