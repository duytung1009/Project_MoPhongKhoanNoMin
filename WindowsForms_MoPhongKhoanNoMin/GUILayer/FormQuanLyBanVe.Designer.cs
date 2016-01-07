namespace WindowsForms_MoPhongKhoanNoMin.GUILayer
{
    partial class FormQuanLyBanVe
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
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonReload = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.textBoxNguoiDung = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDeltaX = new System.Windows.Forms.TextBox();
            this.textBoxDeltaY = new System.Windows.Forms.TextBox();
            this.textBoxNgayChinhSua = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxIDTemplate = new System.Windows.Forms.TextBox();
            this.textBoxTenBanVe = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelBorder = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            this.panelUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlMain
            // 
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlMain.Location = new System.Drawing.Point(0, 111);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.Size = new System.Drawing.Size(784, 300);
            this.gridControlMain.TabIndex = 58;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // gridViewMain
            // 
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsBehavior.Editable = false;
            this.gridViewMain.OptionsSelection.MultiSelect = true;
            this.gridViewMain.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMain.OptionsView.ShowGroupPanel = false;
            this.gridViewMain.DoubleClick += new System.EventHandler(this.gridViewMain_DoubleClick);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelTitle.Location = new System.Drawing.Point(50, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new System.Windows.Forms.Padding(3);
            this.labelTitle.Size = new System.Drawing.Size(78, 27);
            this.labelTitle.TabIndex = 59;
            this.labelTitle.Text = "Thao tác";
            // 
            // buttonReload
            // 
            this.buttonReload.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReload.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReload.ForeColor = System.Drawing.Color.White;
            this.buttonReload.Location = new System.Drawing.Point(50, 60);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(70, 33);
            this.buttonReload.TabIndex = 60;
            this.buttonReload.Text = "TẢI LẠI";
            this.buttonReload.UseVisualStyleBackColor = false;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.ForeColor = System.Drawing.Color.White;
            this.buttonPrint.Location = new System.Drawing.Point(126, 60);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(70, 33);
            this.buttonPrint.TabIndex = 61;
            this.buttonPrint.Text = "IN";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport.ForeColor = System.Drawing.Color.White;
            this.buttonExport.Location = new System.Drawing.Point(202, 60);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(70, 33);
            this.buttonExport.TabIndex = 62;
            this.buttonExport.Text = "EXCEL";
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(278, 60);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(70, 33);
            this.buttonDelete.TabIndex = 63;
            this.buttonDelete.Text = "XÓA";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // panelUpdate
            // 
            this.panelUpdate.AutoScroll = true;
            this.panelUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelUpdate.Controls.Add(this.textBoxNguoiDung);
            this.panelUpdate.Controls.Add(this.label8);
            this.panelUpdate.Controls.Add(this.textBoxDeltaX);
            this.panelUpdate.Controls.Add(this.textBoxDeltaY);
            this.panelUpdate.Controls.Add(this.textBoxNgayChinhSua);
            this.panelUpdate.Controls.Add(this.textBoxID);
            this.panelUpdate.Controls.Add(this.textBoxIDTemplate);
            this.panelUpdate.Controls.Add(this.textBoxTenBanVe);
            this.panelUpdate.Controls.Add(this.buttonUpdate);
            this.panelUpdate.Controls.Add(this.labelBorder);
            this.panelUpdate.Controls.Add(this.buttonBack);
            this.panelUpdate.Controls.Add(this.label7);
            this.panelUpdate.Controls.Add(this.label6);
            this.panelUpdate.Controls.Add(this.label5);
            this.panelUpdate.Controls.Add(this.label4);
            this.panelUpdate.Controls.Add(this.label3);
            this.panelUpdate.Controls.Add(this.label2);
            this.panelUpdate.Controls.Add(this.label1);
            this.panelUpdate.Location = new System.Drawing.Point(0, 111);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(784, 300);
            this.panelUpdate.TabIndex = 64;
            // 
            // textBoxNguoiDung
            // 
            this.textBoxNguoiDung.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNguoiDung.Location = new System.Drawing.Point(530, 96);
            this.textBoxNguoiDung.Name = "textBoxNguoiDung";
            this.textBoxNguoiDung.Size = new System.Drawing.Size(150, 22);
            this.textBoxNguoiDung.TabIndex = 81;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(530, 70);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(3);
            this.label8.Size = new System.Drawing.Size(85, 23);
            this.label8.TabIndex = 80;
            this.label8.Text = "Người dùng";
            // 
            // textBoxDeltaX
            // 
            this.textBoxDeltaX.Enabled = false;
            this.textBoxDeltaX.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDeltaX.Location = new System.Drawing.Point(300, 216);
            this.textBoxDeltaX.Name = "textBoxDeltaX";
            this.textBoxDeltaX.Size = new System.Drawing.Size(150, 22);
            this.textBoxDeltaX.TabIndex = 79;
            // 
            // textBoxDeltaY
            // 
            this.textBoxDeltaY.Enabled = false;
            this.textBoxDeltaY.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDeltaY.Location = new System.Drawing.Point(300, 156);
            this.textBoxDeltaY.Name = "textBoxDeltaY";
            this.textBoxDeltaY.Size = new System.Drawing.Size(150, 22);
            this.textBoxDeltaY.TabIndex = 78;
            // 
            // textBoxNgayChinhSua
            // 
            this.textBoxNgayChinhSua.Enabled = false;
            this.textBoxNgayChinhSua.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNgayChinhSua.Location = new System.Drawing.Point(300, 96);
            this.textBoxNgayChinhSua.Name = "textBoxNgayChinhSua";
            this.textBoxNgayChinhSua.Size = new System.Drawing.Size(150, 22);
            this.textBoxNgayChinhSua.TabIndex = 77;
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(70, 96);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(150, 22);
            this.textBoxID.TabIndex = 76;
            // 
            // textBoxIDTemplate
            // 
            this.textBoxIDTemplate.Enabled = false;
            this.textBoxIDTemplate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIDTemplate.Location = new System.Drawing.Point(70, 156);
            this.textBoxIDTemplate.Name = "textBoxIDTemplate";
            this.textBoxIDTemplate.Size = new System.Drawing.Size(150, 22);
            this.textBoxIDTemplate.TabIndex = 75;
            // 
            // textBoxTenBanVe
            // 
            this.textBoxTenBanVe.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenBanVe.Location = new System.Drawing.Point(70, 216);
            this.textBoxTenBanVe.Name = "textBoxTenBanVe";
            this.textBoxTenBanVe.Size = new System.Drawing.Size(150, 22);
            this.textBoxTenBanVe.TabIndex = 74;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(672, 255);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 33);
            this.buttonUpdate.TabIndex = 65;
            this.buttonUpdate.Text = "CẬP NHẬT";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelBorder
            // 
            this.labelBorder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelBorder.Location = new System.Drawing.Point(0, 0);
            this.labelBorder.Name = "labelBorder";
            this.labelBorder.Size = new System.Drawing.Size(784, 2);
            this.labelBorder.TabIndex = 73;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonBack.BackgroundImage = global::WindowsForms_MoPhongKhoanNoMin.Properties.Resources.left_arrow_white;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(633, 255);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(33, 33);
            this.buttonBack.TabIndex = 65;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(300, 190);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(3);
            this.label7.Size = new System.Drawing.Size(111, 23);
            this.label7.TabIndex = 72;
            this.label7.Text = "Khoảng cách cột";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(300, 130);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3);
            this.label6.Size = new System.Drawing.Size(122, 23);
            this.label6.TabIndex = 71;
            this.label6.Text = "Khoảng cách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(300, 70);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3);
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 70;
            this.label5.Text = "Ngày chỉnh sửa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(70, 190);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3);
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 69;
            this.label4.Text = "Tên bản vẽ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(70, 130);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3);
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 68;
            this.label3.Text = "ID Template";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(70, 70);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 67;
            this.label2.Text = "ID bản vẽ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(86, 27);
            this.label1.TabIndex = 60;
            this.label1.Text = "Thông tin";
            // 
            // FormQuanLyBanVe
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelUpdate);
            this.Controls.Add(this.gridControlMain);
            this.Name = "FormQuanLyBanVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bản vẽ";
            this.Load += new System.EventHandler(this.FormQuanLyBanVe_Load);
            this.Shown += new System.EventHandler(this.FormQuanLyBanVe_Shown);
            this.SizeChanged += new System.EventHandler(this.FormQuanLyBanVe_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelBorder;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxIDTemplate;
        private System.Windows.Forms.TextBox textBoxTenBanVe;
        private System.Windows.Forms.TextBox textBoxDeltaX;
        private System.Windows.Forms.TextBox textBoxDeltaY;
        private System.Windows.Forms.TextBox textBoxNgayChinhSua;
        private System.Windows.Forms.TextBox textBoxNguoiDung;
        private System.Windows.Forms.Label label8;
    }
}