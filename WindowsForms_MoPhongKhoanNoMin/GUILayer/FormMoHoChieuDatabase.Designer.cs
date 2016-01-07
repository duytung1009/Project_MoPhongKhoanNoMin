namespace WindowsForms_MoPhongKhoanNoMin.GUILayer
{
    partial class FormMoHoChieuDatabase
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelTitle2 = new System.Windows.Forms.Label();
            this.textBoxTenBanVe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.labelTitle.Size = new System.Drawing.Size(155, 27);
            this.labelTitle.TabIndex = 53;
            this.labelTitle.Text = "Danh sách hộ chiếu";
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Location = new System.Drawing.Point(0, 40);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(550, 220);
            this.panelMain.TabIndex = 55;
            this.panelMain.SizeChanged += new System.EventHandler(this.panelMain_SizeChanged);
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
            this.labelTitle2.Size = new System.Drawing.Size(148, 27);
            this.labelTitle2.TabIndex = 56;
            this.labelTitle2.Text = "Tìm kiếm hộ chiếu";
            // 
            // textBoxTenBanVe
            // 
            this.textBoxTenBanVe.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenBanVe.Location = new System.Drawing.Point(166, 284);
            this.textBoxTenBanVe.Name = "textBoxTenBanVe";
            this.textBoxTenBanVe.Size = new System.Drawing.Size(200, 22);
            this.textBoxTenBanVe.TabIndex = 57;
            this.textBoxTenBanVe.TextChanged += new System.EventHandler(this.textBoxTenBanVe_TextChanged);
            // 
            // FormMoHoChieuDatabase
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 321);
            this.Controls.Add(this.textBoxTenBanVe);
            this.Controls.Add(this.labelTitle2);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormMoHoChieuDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mở hộ chiếu từ cơ sở dữ liệu";
            this.Load += new System.EventHandler(this.FormMoBanVeDatabase_Load);
            this.Shown += new System.EventHandler(this.FormMoBanVeDatabase_Shown);
            this.SizeChanged += new System.EventHandler(this.FormMoBanVeDatabase_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelTitle2;
        private System.Windows.Forms.TextBox textBoxTenBanVe;
    }
}