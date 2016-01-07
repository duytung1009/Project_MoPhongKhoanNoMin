namespace WindowsForms_MoPhongKhoanNoMin.GUILayer
{
    partial class FormQuanLyPhuKienNo
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
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonReload = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.textBoxGiaThanh = new System.Windows.Forms.TextBox();
            this.textBoxDonViTinh = new System.Windows.Forms.TextBox();
            this.textBoxMaPhuKien = new System.Windows.Forms.TextBox();
            this.textBoxTenPhuKien = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelBorder = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonShowInsert = new System.Windows.Forms.Button();
            this.panelInsert = new System.Windows.Forms.Panel();
            this.textBoxGiaThanh2 = new System.Windows.Forms.TextBox();
            this.textBoxDonViTinh2 = new System.Windows.Forms.TextBox();
            this.textBoxMaPhuKien2 = new System.Windows.Forms.TextBox();
            this.textBoxTenPhuKien2 = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.labelBorder2 = new System.Windows.Forms.Label();
            this.buttonBack2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            this.panelUpdate.SuspendLayout();
            this.panelInsert.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlMain
            // 
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlMain.Location = new System.Drawing.Point(0, 111);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.Size = new System.Drawing.Size(784, 300);
            this.gridControlMain.TabIndex = 60;
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
            this.buttonExport.TabIndex = 70;
            this.buttonExport.Text = "EXCEL";
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
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
            this.buttonPrint.TabIndex = 69;
            this.buttonPrint.Text = "IN";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
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
            this.buttonReload.TabIndex = 68;
            this.buttonReload.Text = "TẢI LẠI";
            this.buttonReload.UseVisualStyleBackColor = false;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
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
            this.labelTitle.TabIndex = 67;
            this.labelTitle.Text = "Thao tác";
            // 
            // panelUpdate
            // 
            this.panelUpdate.AutoScroll = true;
            this.panelUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelUpdate.Controls.Add(this.textBoxGiaThanh);
            this.panelUpdate.Controls.Add(this.textBoxDonViTinh);
            this.panelUpdate.Controls.Add(this.textBoxMaPhuKien);
            this.panelUpdate.Controls.Add(this.textBoxTenPhuKien);
            this.panelUpdate.Controls.Add(this.buttonUpdate);
            this.panelUpdate.Controls.Add(this.labelBorder);
            this.panelUpdate.Controls.Add(this.buttonBack);
            this.panelUpdate.Controls.Add(this.label5);
            this.panelUpdate.Controls.Add(this.label4);
            this.panelUpdate.Controls.Add(this.label3);
            this.panelUpdate.Controls.Add(this.label2);
            this.panelUpdate.Controls.Add(this.label1);
            this.panelUpdate.Location = new System.Drawing.Point(0, 111);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(784, 300);
            this.panelUpdate.TabIndex = 74;
            // 
            // textBoxGiaThanh
            // 
            this.textBoxGiaThanh.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGiaThanh.Location = new System.Drawing.Point(400, 156);
            this.textBoxGiaThanh.Name = "textBoxGiaThanh";
            this.textBoxGiaThanh.Size = new System.Drawing.Size(150, 22);
            this.textBoxGiaThanh.TabIndex = 78;
            // 
            // textBoxDonViTinh
            // 
            this.textBoxDonViTinh.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDonViTinh.Location = new System.Drawing.Point(400, 96);
            this.textBoxDonViTinh.Name = "textBoxDonViTinh";
            this.textBoxDonViTinh.Size = new System.Drawing.Size(150, 22);
            this.textBoxDonViTinh.TabIndex = 77;
            // 
            // textBoxMaPhuKien
            // 
            this.textBoxMaPhuKien.Enabled = false;
            this.textBoxMaPhuKien.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaPhuKien.Location = new System.Drawing.Point(70, 96);
            this.textBoxMaPhuKien.Name = "textBoxMaPhuKien";
            this.textBoxMaPhuKien.Size = new System.Drawing.Size(150, 22);
            this.textBoxMaPhuKien.TabIndex = 76;
            // 
            // textBoxTenPhuKien
            // 
            this.textBoxTenPhuKien.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenPhuKien.Location = new System.Drawing.Point(70, 156);
            this.textBoxTenPhuKien.Name = "textBoxTenPhuKien";
            this.textBoxTenPhuKien.Size = new System.Drawing.Size(150, 22);
            this.textBoxTenPhuKien.TabIndex = 75;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(400, 130);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3);
            this.label5.Size = new System.Drawing.Size(69, 23);
            this.label5.TabIndex = 71;
            this.label5.Text = "Giá thành";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(400, 70);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3);
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 69;
            this.label4.Text = "Đơn vị tính";
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
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 68;
            this.label3.Text = "Tên phụ kiện";
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
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 67;
            this.label2.Text = "Mã phụ kiện";
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
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(354, 60);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(70, 33);
            this.buttonDelete.TabIndex = 75;
            this.buttonDelete.Text = "XÓA";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonShowInsert
            // 
            this.buttonShowInsert.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonShowInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowInsert.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowInsert.ForeColor = System.Drawing.Color.White;
            this.buttonShowInsert.Location = new System.Drawing.Point(278, 60);
            this.buttonShowInsert.Name = "buttonShowInsert";
            this.buttonShowInsert.Size = new System.Drawing.Size(70, 33);
            this.buttonShowInsert.TabIndex = 76;
            this.buttonShowInsert.Text = "THÊM";
            this.buttonShowInsert.UseVisualStyleBackColor = false;
            this.buttonShowInsert.Click += new System.EventHandler(this.buttonShowInsert_Click);
            // 
            // panelInsert
            // 
            this.panelInsert.AutoScroll = true;
            this.panelInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelInsert.Controls.Add(this.textBoxGiaThanh2);
            this.panelInsert.Controls.Add(this.textBoxDonViTinh2);
            this.panelInsert.Controls.Add(this.textBoxMaPhuKien2);
            this.panelInsert.Controls.Add(this.textBoxTenPhuKien2);
            this.panelInsert.Controls.Add(this.buttonInsert);
            this.panelInsert.Controls.Add(this.labelBorder2);
            this.panelInsert.Controls.Add(this.buttonBack2);
            this.panelInsert.Controls.Add(this.label7);
            this.panelInsert.Controls.Add(this.label8);
            this.panelInsert.Controls.Add(this.label9);
            this.panelInsert.Controls.Add(this.label10);
            this.panelInsert.Controls.Add(this.label11);
            this.panelInsert.Location = new System.Drawing.Point(0, 111);
            this.panelInsert.Name = "panelInsert";
            this.panelInsert.Size = new System.Drawing.Size(784, 300);
            this.panelInsert.TabIndex = 77;
            // 
            // textBoxGiaThanh2
            // 
            this.textBoxGiaThanh2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGiaThanh2.Location = new System.Drawing.Point(400, 156);
            this.textBoxGiaThanh2.Name = "textBoxGiaThanh2";
            this.textBoxGiaThanh2.Size = new System.Drawing.Size(150, 22);
            this.textBoxGiaThanh2.TabIndex = 78;
            // 
            // textBoxDonViTinh2
            // 
            this.textBoxDonViTinh2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDonViTinh2.Location = new System.Drawing.Point(400, 96);
            this.textBoxDonViTinh2.Name = "textBoxDonViTinh2";
            this.textBoxDonViTinh2.Size = new System.Drawing.Size(150, 22);
            this.textBoxDonViTinh2.TabIndex = 77;
            // 
            // textBoxMaPhuKien2
            // 
            this.textBoxMaPhuKien2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaPhuKien2.Location = new System.Drawing.Point(70, 96);
            this.textBoxMaPhuKien2.Name = "textBoxMaPhuKien2";
            this.textBoxMaPhuKien2.Size = new System.Drawing.Size(150, 22);
            this.textBoxMaPhuKien2.TabIndex = 76;
            // 
            // textBoxTenPhuKien2
            // 
            this.textBoxTenPhuKien2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenPhuKien2.Location = new System.Drawing.Point(70, 156);
            this.textBoxTenPhuKien2.Name = "textBoxTenPhuKien2";
            this.textBoxTenPhuKien2.Size = new System.Drawing.Size(150, 22);
            this.textBoxTenPhuKien2.TabIndex = 75;
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsert.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.ForeColor = System.Drawing.Color.White;
            this.buttonInsert.Location = new System.Drawing.Point(672, 255);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(100, 33);
            this.buttonInsert.TabIndex = 65;
            this.buttonInsert.Text = "THÊM MỚI";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // labelBorder2
            // 
            this.labelBorder2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelBorder2.Location = new System.Drawing.Point(0, 0);
            this.labelBorder2.Name = "labelBorder2";
            this.labelBorder2.Size = new System.Drawing.Size(784, 2);
            this.labelBorder2.TabIndex = 73;
            // 
            // buttonBack2
            // 
            this.buttonBack2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonBack2.BackgroundImage = global::WindowsForms_MoPhongKhoanNoMin.Properties.Resources.left_arrow_white;
            this.buttonBack2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBack2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack2.ForeColor = System.Drawing.Color.White;
            this.buttonBack2.Location = new System.Drawing.Point(633, 255);
            this.buttonBack2.Name = "buttonBack2";
            this.buttonBack2.Size = new System.Drawing.Size(33, 33);
            this.buttonBack2.TabIndex = 65;
            this.buttonBack2.UseVisualStyleBackColor = false;
            this.buttonBack2.Click += new System.EventHandler(this.buttonBack2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(400, 130);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(3);
            this.label7.Size = new System.Drawing.Size(69, 23);
            this.label7.TabIndex = 71;
            this.label7.Text = "Giá thành";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(400, 70);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(3);
            this.label8.Size = new System.Drawing.Size(76, 23);
            this.label8.TabIndex = 69;
            this.label8.Text = "Đơn vị tính";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(70, 130);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(3);
            this.label9.Size = new System.Drawing.Size(87, 23);
            this.label9.TabIndex = 68;
            this.label9.Text = "Tên phụ kiện";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(70, 70);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(3);
            this.label10.Size = new System.Drawing.Size(86, 23);
            this.label10.TabIndex = 67;
            this.label10.Text = "Mã phụ kiện";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(50, 30);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(3);
            this.label11.Size = new System.Drawing.Size(86, 27);
            this.label11.TabIndex = 60;
            this.label11.Text = "Thông tin";
            // 
            // FormQuanLyPhuKienNo
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.buttonShowInsert);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelInsert);
            this.Controls.Add(this.panelUpdate);
            this.Controls.Add(this.gridControlMain);
            this.Name = "FormQuanLyPhuKienNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phụ kiện nổ";
            this.Load += new System.EventHandler(this.FormQuanLyPhuKienNo_Load);
            this.Shown += new System.EventHandler(this.FormQuanLyPhuKienNo_Shown);
            this.SizeChanged += new System.EventHandler(this.FormQuanLyPhuKienNo_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            this.panelInsert.ResumeLayout(false);
            this.panelInsert.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.TextBox textBoxGiaThanh;
        private System.Windows.Forms.TextBox textBoxDonViTinh;
        private System.Windows.Forms.TextBox textBoxMaPhuKien;
        private System.Windows.Forms.TextBox textBoxTenPhuKien;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelBorder;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonShowInsert;
        private System.Windows.Forms.Panel panelInsert;
        private System.Windows.Forms.TextBox textBoxGiaThanh2;
        private System.Windows.Forms.TextBox textBoxDonViTinh2;
        private System.Windows.Forms.TextBox textBoxMaPhuKien2;
        private System.Windows.Forms.TextBox textBoxTenPhuKien2;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label labelBorder2;
        private System.Windows.Forms.Button buttonBack2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}