namespace WindowsForms_MoPhongKhoanNoMin.GUILayer
{
    partial class FormHoChieuMoi
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelScrollBar = new System.Windows.Forms.Label();
            this.textBoxTenBanVe = new System.Windows.Forms.TextBox();
            this.labelTitle2 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
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
            this.buttonTaoMoi.Location = new System.Drawing.Point(459, 276);
            this.buttonTaoMoi.Name = "buttonTaoMoi";
            this.buttonTaoMoi.Size = new System.Drawing.Size(79, 33);
            this.buttonTaoMoi.TabIndex = 51;
            this.buttonTaoMoi.Text = "TẠO MỚI";
            this.buttonTaoMoi.UseVisualStyleBackColor = false;
            this.buttonTaoMoi.Click += new System.EventHandler(this.buttonTaoMoi_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new System.Windows.Forms.Padding(3);
            this.labelTitle.Size = new System.Drawing.Size(48, 27);
            this.labelTitle.TabIndex = 52;
            this.labelTitle.Text = "Mẫu";
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.labelScrollBar);
            this.panelMain.Location = new System.Drawing.Point(0, 40);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(550, 220);
            this.panelMain.TabIndex = 54;
            // 
            // labelScrollBar
            // 
            this.labelScrollBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.labelScrollBar.Location = new System.Drawing.Point(0, 200);
            this.labelScrollBar.Name = "labelScrollBar";
            this.labelScrollBar.Size = new System.Drawing.Size(550, 20);
            this.labelScrollBar.TabIndex = 0;
            // 
            // textBoxTenBanVe
            // 
            this.textBoxTenBanVe.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenBanVe.Location = new System.Drawing.Point(125, 284);
            this.textBoxTenBanVe.Name = "textBoxTenBanVe";
            this.textBoxTenBanVe.Size = new System.Drawing.Size(200, 22);
            this.textBoxTenBanVe.TabIndex = 55;
            // 
            // labelTitle2
            // 
            this.labelTitle2.AutoSize = true;
            this.labelTitle2.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelTitle2.Location = new System.Drawing.Point(12, 281);
            this.labelTitle2.Name = "labelTitle2";
            this.labelTitle2.Padding = new System.Windows.Forms.Padding(3);
            this.labelTitle2.Size = new System.Drawing.Size(107, 27);
            this.labelTitle2.TabIndex = 56;
            this.labelTitle2.Text = "Tên hộ chiếu";
            // 
            // FormBanVeMoi
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 321);
            this.Controls.Add(this.labelTitle2);
            this.Controls.Add(this.textBoxTenBanVe);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonTaoMoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormBanVeMoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo hộ chiếu mới";
            this.Load += new System.EventHandler(this.FormBanVeMoi_Load);
            this.Shown += new System.EventHandler(this.FormBanVeMoi_Shown);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonTaoMoi;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelScrollBar;
        private System.Windows.Forms.TextBox textBoxTenBanVe;
        private System.Windows.Forms.Label labelTitle2;
    }
}