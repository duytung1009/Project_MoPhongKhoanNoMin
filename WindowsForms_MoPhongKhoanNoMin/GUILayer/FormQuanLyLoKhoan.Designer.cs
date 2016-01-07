namespace WindowsForms_MoPhongKhoanNoMin.GUILayer
{
    partial class FormQuanLyLoKhoan
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
            this.buttonReload = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.textBoxLbua = new System.Windows.Forms.TextBox();
            this.textBoxL0 = new System.Windows.Forms.TextBox();
            this.textBoxLkk = new System.Windows.Forms.TextBox();
            this.textBoxLt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_HuongKhoan = new System.Windows.Forms.ComboBox();
            this.comboBox_MayKhoan = new System.Windows.Forms.ComboBox();
            this.textBoxToaDoY = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxToaDoX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxChieuSau = new System.Windows.Forms.TextBox();
            this.textBoxBanKinh = new System.Windows.Forms.TextBox();
            this.textBoxMaLoKhoan = new System.Windows.Forms.TextBox();
            this.textBoxMaHoChieu = new System.Windows.Forms.TextBox();
            this.textBoxMaBanVe = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelBorder = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
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
            this.labelTitle.TabIndex = 38;
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
            this.buttonReload.TabIndex = 54;
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
            this.buttonPrint.TabIndex = 55;
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
            this.buttonExport.TabIndex = 56;
            this.buttonExport.Text = "EXCEL";
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // gridControlMain
            // 
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlMain.Location = new System.Drawing.Point(0, 111);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.Size = new System.Drawing.Size(1008, 426);
            this.gridControlMain.TabIndex = 57;
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
            // panelUpdate
            // 
            this.panelUpdate.AutoScroll = true;
            this.panelUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelUpdate.Controls.Add(this.textBoxLbua);
            this.panelUpdate.Controls.Add(this.textBoxL0);
            this.panelUpdate.Controls.Add(this.textBoxLkk);
            this.panelUpdate.Controls.Add(this.textBoxLt);
            this.panelUpdate.Controls.Add(this.label14);
            this.panelUpdate.Controls.Add(this.label13);
            this.panelUpdate.Controls.Add(this.label12);
            this.panelUpdate.Controls.Add(this.label11);
            this.panelUpdate.Controls.Add(this.comboBox_HuongKhoan);
            this.panelUpdate.Controls.Add(this.comboBox_MayKhoan);
            this.panelUpdate.Controls.Add(this.textBoxToaDoY);
            this.panelUpdate.Controls.Add(this.label10);
            this.panelUpdate.Controls.Add(this.textBoxToaDoX);
            this.panelUpdate.Controls.Add(this.label9);
            this.panelUpdate.Controls.Add(this.label8);
            this.panelUpdate.Controls.Add(this.label7);
            this.panelUpdate.Controls.Add(this.textBoxChieuSau);
            this.panelUpdate.Controls.Add(this.textBoxBanKinh);
            this.panelUpdate.Controls.Add(this.textBoxMaLoKhoan);
            this.panelUpdate.Controls.Add(this.textBoxMaHoChieu);
            this.panelUpdate.Controls.Add(this.textBoxMaBanVe);
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
            this.panelUpdate.Size = new System.Drawing.Size(1008, 426);
            this.panelUpdate.TabIndex = 72;
            // 
            // textBoxLbua
            // 
            this.textBoxLbua.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLbua.Location = new System.Drawing.Point(760, 276);
            this.textBoxLbua.Name = "textBoxLbua";
            this.textBoxLbua.Size = new System.Drawing.Size(150, 22);
            this.textBoxLbua.TabIndex = 104;
            // 
            // textBoxL0
            // 
            this.textBoxL0.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxL0.Location = new System.Drawing.Point(760, 216);
            this.textBoxL0.Name = "textBoxL0";
            this.textBoxL0.Size = new System.Drawing.Size(150, 22);
            this.textBoxL0.TabIndex = 103;
            // 
            // textBoxLkk
            // 
            this.textBoxLkk.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLkk.Location = new System.Drawing.Point(760, 156);
            this.textBoxLkk.Name = "textBoxLkk";
            this.textBoxLkk.Size = new System.Drawing.Size(150, 22);
            this.textBoxLkk.TabIndex = 102;
            // 
            // textBoxLt
            // 
            this.textBoxLt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLt.Location = new System.Drawing.Point(760, 96);
            this.textBoxLt.Name = "textBoxLt";
            this.textBoxLt.Size = new System.Drawing.Size(150, 22);
            this.textBoxLt.TabIndex = 101;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(760, 250);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(3);
            this.label14.Size = new System.Drawing.Size(42, 23);
            this.label14.TabIndex = 100;
            this.label14.Text = "Lbua";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(760, 190);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(3);
            this.label13.Size = new System.Drawing.Size(27, 23);
            this.label13.TabIndex = 99;
            this.label13.Text = "L0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(760, 130);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(3);
            this.label12.Size = new System.Drawing.Size(32, 23);
            this.label12.TabIndex = 98;
            this.label12.Text = "Lkk";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(760, 70);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(3);
            this.label11.Size = new System.Drawing.Size(24, 23);
            this.label11.TabIndex = 97;
            this.label11.Text = "Lt";
            // 
            // comboBox_HuongKhoan
            // 
            this.comboBox_HuongKhoan.FormattingEnabled = true;
            this.comboBox_HuongKhoan.Items.AddRange(new object[] {
            "Trên",
            "Dưới",
            "Phải",
            "Trái"});
            this.comboBox_HuongKhoan.Location = new System.Drawing.Point(530, 96);
            this.comboBox_HuongKhoan.Name = "comboBox_HuongKhoan";
            this.comboBox_HuongKhoan.Size = new System.Drawing.Size(150, 21);
            this.comboBox_HuongKhoan.TabIndex = 96;
            // 
            // comboBox_MayKhoan
            // 
            this.comboBox_MayKhoan.FormattingEnabled = true;
            this.comboBox_MayKhoan.Items.AddRange(new object[] {
            "Trên",
            "Dưới",
            "Phải",
            "Trái"});
            this.comboBox_MayKhoan.Location = new System.Drawing.Point(300, 96);
            this.comboBox_MayKhoan.Name = "comboBox_MayKhoan";
            this.comboBox_MayKhoan.Size = new System.Drawing.Size(150, 21);
            this.comboBox_MayKhoan.TabIndex = 91;
            // 
            // textBoxToaDoY
            // 
            this.textBoxToaDoY.Enabled = false;
            this.textBoxToaDoY.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxToaDoY.Location = new System.Drawing.Point(530, 216);
            this.textBoxToaDoY.Name = "textBoxToaDoY";
            this.textBoxToaDoY.Size = new System.Drawing.Size(150, 22);
            this.textBoxToaDoY.TabIndex = 86;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(530, 190);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(3);
            this.label10.Size = new System.Drawing.Size(67, 23);
            this.label10.TabIndex = 85;
            this.label10.Text = "Tọa độ Y";
            // 
            // textBoxToaDoX
            // 
            this.textBoxToaDoX.Enabled = false;
            this.textBoxToaDoX.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxToaDoX.Location = new System.Drawing.Point(530, 156);
            this.textBoxToaDoX.Name = "textBoxToaDoX";
            this.textBoxToaDoX.Size = new System.Drawing.Size(150, 22);
            this.textBoxToaDoX.TabIndex = 84;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(530, 130);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(3);
            this.label9.Size = new System.Drawing.Size(68, 23);
            this.label9.TabIndex = 82;
            this.label9.Text = "Tọa độ X";
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
            this.label8.Size = new System.Drawing.Size(93, 23);
            this.label8.TabIndex = 81;
            this.label8.Text = "Hướng khoan";
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
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 80;
            this.label7.Text = "Chiều sâu";
            // 
            // textBoxChieuSau
            // 
            this.textBoxChieuSau.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChieuSau.Location = new System.Drawing.Point(300, 216);
            this.textBoxChieuSau.Name = "textBoxChieuSau";
            this.textBoxChieuSau.Size = new System.Drawing.Size(150, 22);
            this.textBoxChieuSau.TabIndex = 79;
            // 
            // textBoxBanKinh
            // 
            this.textBoxBanKinh.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBanKinh.Location = new System.Drawing.Point(300, 156);
            this.textBoxBanKinh.Name = "textBoxBanKinh";
            this.textBoxBanKinh.Size = new System.Drawing.Size(150, 22);
            this.textBoxBanKinh.TabIndex = 78;
            // 
            // textBoxMaLoKhoan
            // 
            this.textBoxMaLoKhoan.Enabled = false;
            this.textBoxMaLoKhoan.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaLoKhoan.Location = new System.Drawing.Point(70, 216);
            this.textBoxMaLoKhoan.Name = "textBoxMaLoKhoan";
            this.textBoxMaLoKhoan.Size = new System.Drawing.Size(150, 22);
            this.textBoxMaLoKhoan.TabIndex = 77;
            // 
            // textBoxMaHoChieu
            // 
            this.textBoxMaHoChieu.Enabled = false;
            this.textBoxMaHoChieu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaHoChieu.Location = new System.Drawing.Point(70, 96);
            this.textBoxMaHoChieu.Name = "textBoxMaHoChieu";
            this.textBoxMaHoChieu.Size = new System.Drawing.Size(150, 22);
            this.textBoxMaHoChieu.TabIndex = 76;
            // 
            // textBoxMaBanVe
            // 
            this.textBoxMaBanVe.Enabled = false;
            this.textBoxMaBanVe.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaBanVe.Location = new System.Drawing.Point(70, 156);
            this.textBoxMaBanVe.Name = "textBoxMaBanVe";
            this.textBoxMaBanVe.Size = new System.Drawing.Size(150, 22);
            this.textBoxMaBanVe.TabIndex = 75;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(896, 381);
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
            this.labelBorder.Size = new System.Drawing.Size(1008, 2);
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
            this.buttonBack.Location = new System.Drawing.Point(857, 381);
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
            this.label6.Location = new System.Drawing.Point(300, 130);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3);
            this.label6.Size = new System.Drawing.Size(62, 23);
            this.label6.TabIndex = 71;
            this.label6.Text = "Bán kính";
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
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 70;
            this.label5.Text = "Máy khoan";
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
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 69;
            this.label4.Text = "Mã lỗ khoan";
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
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 68;
            this.label3.Text = "Mã bản vẽ";
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
            this.label2.Text = "Mã hộ chiếu";
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
            // FormQuanLyLoKhoan
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelUpdate);
            this.Controls.Add(this.gridControlMain);
            this.Name = "FormQuanLyLoKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý lỗ khoan";
            this.Load += new System.EventHandler(this.FormQuanLyLoKhoan_Load);
            this.Shown += new System.EventHandler(this.FormQuanLyLoKhoan_Shown);
            this.SizeChanged += new System.EventHandler(this.FormQuanLyLoKhoan_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonExport;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.TextBox textBoxToaDoY;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxToaDoX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxChieuSau;
        private System.Windows.Forms.TextBox textBoxBanKinh;
        private System.Windows.Forms.TextBox textBoxMaLoKhoan;
        private System.Windows.Forms.TextBox textBoxMaHoChieu;
        private System.Windows.Forms.TextBox textBoxMaBanVe;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelBorder;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_MayKhoan;
        private System.Windows.Forms.ComboBox comboBox_HuongKhoan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxLbua;
        private System.Windows.Forms.TextBox textBoxL0;
        private System.Windows.Forms.TextBox textBoxLkk;
        private System.Windows.Forms.TextBox textBoxLt;
    }
}