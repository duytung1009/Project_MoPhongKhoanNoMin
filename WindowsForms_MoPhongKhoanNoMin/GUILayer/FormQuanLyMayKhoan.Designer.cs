namespace WindowsForms_MoPhongKhoanNoMin.GUILayer
{
    partial class FormQuanLyMayKhoan
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
            this.textBoxChieuSau = new System.Windows.Forms.TextBox();
            this.textBoxDuongKinhLK = new System.Windows.Forms.TextBox();
            this.textBoxMaMayKhoan = new System.Windows.Forms.TextBox();
            this.textBoxTenMayKhoan = new System.Windows.Forms.TextBox();
            this.textBoxHuongKhoan = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelBorder = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonShowInsert = new System.Windows.Forms.Button();
            this.panelInsert = new System.Windows.Forms.Panel();
            this.textBoxChieuSau2 = new System.Windows.Forms.TextBox();
            this.textBoxDuongKinhLK2 = new System.Windows.Forms.TextBox();
            this.textBoxMaMayKhoan2 = new System.Windows.Forms.TextBox();
            this.textBoxTenMayKhoan2 = new System.Windows.Forms.TextBox();
            this.textBoxHuongKhoan2 = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.labelBorder2 = new System.Windows.Forms.Label();
            this.buttonBack2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
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
            this.buttonExport.TabIndex = 59;
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
            this.buttonPrint.TabIndex = 60;
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
            this.buttonReload.TabIndex = 61;
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
            this.labelTitle.TabIndex = 62;
            this.labelTitle.Text = "Thao tác";
            // 
            // panelUpdate
            // 
            this.panelUpdate.AutoScroll = true;
            this.panelUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelUpdate.Controls.Add(this.textBoxChieuSau);
            this.panelUpdate.Controls.Add(this.textBoxDuongKinhLK);
            this.panelUpdate.Controls.Add(this.textBoxMaMayKhoan);
            this.panelUpdate.Controls.Add(this.textBoxTenMayKhoan);
            this.panelUpdate.Controls.Add(this.textBoxHuongKhoan);
            this.panelUpdate.Controls.Add(this.buttonUpdate);
            this.panelUpdate.Controls.Add(this.labelBorder);
            this.panelUpdate.Controls.Add(this.buttonBack);
            this.panelUpdate.Controls.Add(this.label6);
            this.panelUpdate.Controls.Add(this.label5);
            this.panelUpdate.Controls.Add(this.label4);
            this.panelUpdate.Controls.Add(this.label3);
            this.panelUpdate.Controls.Add(this.label2);
            this.panelUpdate.Controls.Add(this.label1);
            this.panelUpdate.Location = new System.Drawing.Point(0, 111);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(784, 300);
            this.panelUpdate.TabIndex = 73;
            // 
            // textBoxChieuSau
            // 
            this.textBoxChieuSau.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChieuSau.Location = new System.Drawing.Point(400, 156);
            this.textBoxChieuSau.Name = "textBoxChieuSau";
            this.textBoxChieuSau.Size = new System.Drawing.Size(150, 22);
            this.textBoxChieuSau.TabIndex = 78;
            // 
            // textBoxDuongKinhLK
            // 
            this.textBoxDuongKinhLK.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDuongKinhLK.Location = new System.Drawing.Point(70, 216);
            this.textBoxDuongKinhLK.Name = "textBoxDuongKinhLK";
            this.textBoxDuongKinhLK.Size = new System.Drawing.Size(150, 22);
            this.textBoxDuongKinhLK.TabIndex = 77;
            // 
            // textBoxMaMayKhoan
            // 
            this.textBoxMaMayKhoan.Enabled = false;
            this.textBoxMaMayKhoan.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaMayKhoan.Location = new System.Drawing.Point(70, 96);
            this.textBoxMaMayKhoan.Name = "textBoxMaMayKhoan";
            this.textBoxMaMayKhoan.Size = new System.Drawing.Size(150, 22);
            this.textBoxMaMayKhoan.TabIndex = 76;
            // 
            // textBoxTenMayKhoan
            // 
            this.textBoxTenMayKhoan.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenMayKhoan.Location = new System.Drawing.Point(70, 156);
            this.textBoxTenMayKhoan.Name = "textBoxTenMayKhoan";
            this.textBoxTenMayKhoan.Size = new System.Drawing.Size(150, 22);
            this.textBoxTenMayKhoan.TabIndex = 75;
            // 
            // textBoxHuongKhoan
            // 
            this.textBoxHuongKhoan.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHuongKhoan.Location = new System.Drawing.Point(400, 96);
            this.textBoxHuongKhoan.Name = "textBoxHuongKhoan";
            this.textBoxHuongKhoan.Size = new System.Drawing.Size(150, 22);
            this.textBoxHuongKhoan.TabIndex = 74;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(400, 130);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3);
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 71;
            this.label6.Text = "Chiều sâu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(400, 70);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3);
            this.label5.Size = new System.Drawing.Size(93, 23);
            this.label5.TabIndex = 70;
            this.label5.Text = "Hướng khoan";
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
            this.label4.Size = new System.Drawing.Size(135, 23);
            this.label4.TabIndex = 69;
            this.label4.Text = "Đường kính lỗ khoan";
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
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 68;
            this.label3.Text = "Tên máy khoan";
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
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 67;
            this.label2.Text = "Mã máy khoan";
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
            this.buttonDelete.TabIndex = 74;
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
            this.buttonShowInsert.TabIndex = 75;
            this.buttonShowInsert.Text = "THÊM";
            this.buttonShowInsert.UseVisualStyleBackColor = false;
            this.buttonShowInsert.Click += new System.EventHandler(this.buttonShowInsert_Click);
            // 
            // panelInsert
            // 
            this.panelInsert.AutoScroll = true;
            this.panelInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelInsert.Controls.Add(this.textBoxChieuSau2);
            this.panelInsert.Controls.Add(this.textBoxDuongKinhLK2);
            this.panelInsert.Controls.Add(this.textBoxMaMayKhoan2);
            this.panelInsert.Controls.Add(this.textBoxTenMayKhoan2);
            this.panelInsert.Controls.Add(this.textBoxHuongKhoan2);
            this.panelInsert.Controls.Add(this.buttonInsert);
            this.panelInsert.Controls.Add(this.labelBorder2);
            this.panelInsert.Controls.Add(this.buttonBack2);
            this.panelInsert.Controls.Add(this.label8);
            this.panelInsert.Controls.Add(this.label9);
            this.panelInsert.Controls.Add(this.label10);
            this.panelInsert.Controls.Add(this.label11);
            this.panelInsert.Controls.Add(this.label12);
            this.panelInsert.Controls.Add(this.label13);
            this.panelInsert.Location = new System.Drawing.Point(0, 111);
            this.panelInsert.Name = "panelInsert";
            this.panelInsert.Size = new System.Drawing.Size(784, 300);
            this.panelInsert.TabIndex = 76;
            // 
            // textBoxChieuSau2
            // 
            this.textBoxChieuSau2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChieuSau2.Location = new System.Drawing.Point(400, 156);
            this.textBoxChieuSau2.Name = "textBoxChieuSau2";
            this.textBoxChieuSau2.Size = new System.Drawing.Size(150, 22);
            this.textBoxChieuSau2.TabIndex = 78;
            // 
            // textBoxDuongKinhLK2
            // 
            this.textBoxDuongKinhLK2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDuongKinhLK2.Location = new System.Drawing.Point(70, 216);
            this.textBoxDuongKinhLK2.Name = "textBoxDuongKinhLK2";
            this.textBoxDuongKinhLK2.Size = new System.Drawing.Size(150, 22);
            this.textBoxDuongKinhLK2.TabIndex = 77;
            // 
            // textBoxMaMayKhoan2
            // 
            this.textBoxMaMayKhoan2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaMayKhoan2.Location = new System.Drawing.Point(70, 96);
            this.textBoxMaMayKhoan2.Name = "textBoxMaMayKhoan2";
            this.textBoxMaMayKhoan2.Size = new System.Drawing.Size(150, 22);
            this.textBoxMaMayKhoan2.TabIndex = 76;
            // 
            // textBoxTenMayKhoan2
            // 
            this.textBoxTenMayKhoan2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenMayKhoan2.Location = new System.Drawing.Point(70, 156);
            this.textBoxTenMayKhoan2.Name = "textBoxTenMayKhoan2";
            this.textBoxTenMayKhoan2.Size = new System.Drawing.Size(150, 22);
            this.textBoxTenMayKhoan2.TabIndex = 75;
            // 
            // textBoxHuongKhoan2
            // 
            this.textBoxHuongKhoan2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHuongKhoan2.Location = new System.Drawing.Point(400, 96);
            this.textBoxHuongKhoan2.Name = "textBoxHuongKhoan2";
            this.textBoxHuongKhoan2.Size = new System.Drawing.Size(150, 22);
            this.textBoxHuongKhoan2.TabIndex = 74;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(400, 130);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(3);
            this.label8.Size = new System.Drawing.Size(70, 23);
            this.label8.TabIndex = 71;
            this.label8.Text = "Chiều sâu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(400, 70);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(3);
            this.label9.Size = new System.Drawing.Size(93, 23);
            this.label9.TabIndex = 70;
            this.label9.Text = "Hướng khoan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(70, 190);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(3);
            this.label10.Size = new System.Drawing.Size(135, 23);
            this.label10.TabIndex = 69;
            this.label10.Text = "Đường kính lỗ khoan";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(70, 130);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(3);
            this.label11.Size = new System.Drawing.Size(101, 23);
            this.label11.TabIndex = 68;
            this.label11.Text = "Tên máy khoan";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(70, 70);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(3);
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 67;
            this.label12.Text = "Mã máy khoan";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(50, 30);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(3);
            this.label13.Size = new System.Drawing.Size(86, 27);
            this.label13.TabIndex = 60;
            this.label13.Text = "Thông tin";
            // 
            // FormQuanLyMayKhoan
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
            this.Name = "FormQuanLyMayKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý máy khoan";
            this.Load += new System.EventHandler(this.FormQuanLyMayKhoan_Load);
            this.Shown += new System.EventHandler(this.FormQuanLyMayKhoan_Shown);
            this.SizeChanged += new System.EventHandler(this.FormQuanLyMayKhoan_SizeChanged);
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
        private System.Windows.Forms.TextBox textBoxChieuSau;
        private System.Windows.Forms.TextBox textBoxDuongKinhLK;
        private System.Windows.Forms.TextBox textBoxMaMayKhoan;
        private System.Windows.Forms.TextBox textBoxTenMayKhoan;
        private System.Windows.Forms.TextBox textBoxHuongKhoan;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelBorder;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonShowInsert;
        private System.Windows.Forms.Panel panelInsert;
        private System.Windows.Forms.TextBox textBoxChieuSau2;
        private System.Windows.Forms.TextBox textBoxDuongKinhLK2;
        private System.Windows.Forms.TextBox textBoxMaMayKhoan2;
        private System.Windows.Forms.TextBox textBoxTenMayKhoan2;
        private System.Windows.Forms.TextBox textBoxHuongKhoan2;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label labelBorder2;
        private System.Windows.Forms.Button buttonBack2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}