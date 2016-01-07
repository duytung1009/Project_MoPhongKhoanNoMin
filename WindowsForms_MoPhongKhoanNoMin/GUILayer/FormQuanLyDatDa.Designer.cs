namespace WindowsForms_MoPhongKhoanNoMin.GUILayer
{
    partial class FormQuanLyDatDa
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
            this.textBoxKT_HAT_MAX = new System.Windows.Forms.TextBox();
            this.textBoxKCTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxHeSoDatDa = new System.Windows.Forms.TextBox();
            this.textBoxHeSoKienCo = new System.Windows.Forms.TextBox();
            this.textBoxTinhChat = new System.Windows.Forms.TextBox();
            this.textBoxMaDatDa = new System.Windows.Forms.TextBox();
            this.textBoxTenDatDa = new System.Windows.Forms.TextBox();
            this.textBoxDungTrong = new System.Windows.Forms.TextBox();
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
            this.textBoxKT_HAT_MAX2 = new System.Windows.Forms.TextBox();
            this.textBoxKCTB2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxHeSoDatDa2 = new System.Windows.Forms.TextBox();
            this.textBoxHeSoKienCo2 = new System.Windows.Forms.TextBox();
            this.textBoxTinhChat2 = new System.Windows.Forms.TextBox();
            this.textBoxMaDatDa2 = new System.Windows.Forms.TextBox();
            this.textBoxTenDatDa2 = new System.Windows.Forms.TextBox();
            this.textBoxDungTrong2 = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.labelBorder2 = new System.Windows.Forms.Label();
            this.buttonBack2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
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
            this.panelUpdate.Controls.Add(this.textBoxKT_HAT_MAX);
            this.panelUpdate.Controls.Add(this.textBoxKCTB);
            this.panelUpdate.Controls.Add(this.label9);
            this.panelUpdate.Controls.Add(this.label8);
            this.panelUpdate.Controls.Add(this.label7);
            this.panelUpdate.Controls.Add(this.textBoxHeSoDatDa);
            this.panelUpdate.Controls.Add(this.textBoxHeSoKienCo);
            this.panelUpdate.Controls.Add(this.textBoxTinhChat);
            this.panelUpdate.Controls.Add(this.textBoxMaDatDa);
            this.panelUpdate.Controls.Add(this.textBoxTenDatDa);
            this.panelUpdate.Controls.Add(this.textBoxDungTrong);
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
            this.panelUpdate.TabIndex = 71;
            // 
            // textBoxKT_HAT_MAX
            // 
            this.textBoxKT_HAT_MAX.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKT_HAT_MAX.Location = new System.Drawing.Point(530, 156);
            this.textBoxKT_HAT_MAX.Name = "textBoxKT_HAT_MAX";
            this.textBoxKT_HAT_MAX.Size = new System.Drawing.Size(150, 22);
            this.textBoxKT_HAT_MAX.TabIndex = 84;
            // 
            // textBoxKCTB
            // 
            this.textBoxKCTB.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKCTB.Location = new System.Drawing.Point(530, 96);
            this.textBoxKCTB.Name = "textBoxKCTB";
            this.textBoxKCTB.Size = new System.Drawing.Size(150, 22);
            this.textBoxKCTB.TabIndex = 83;
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
            this.label9.Size = new System.Drawing.Size(88, 23);
            this.label9.TabIndex = 82;
            this.label9.Text = "KT HAT MAX";
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
            this.label8.Size = new System.Drawing.Size(47, 23);
            this.label8.TabIndex = 81;
            this.label8.Text = "KCTB ";
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
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 80;
            this.label7.Text = "Hệ số đất đá";
            // 
            // textBoxHeSoDatDa
            // 
            this.textBoxHeSoDatDa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHeSoDatDa.Location = new System.Drawing.Point(300, 216);
            this.textBoxHeSoDatDa.Name = "textBoxHeSoDatDa";
            this.textBoxHeSoDatDa.Size = new System.Drawing.Size(150, 22);
            this.textBoxHeSoDatDa.TabIndex = 79;
            // 
            // textBoxHeSoKienCo
            // 
            this.textBoxHeSoKienCo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHeSoKienCo.Location = new System.Drawing.Point(300, 156);
            this.textBoxHeSoKienCo.Name = "textBoxHeSoKienCo";
            this.textBoxHeSoKienCo.Size = new System.Drawing.Size(150, 22);
            this.textBoxHeSoKienCo.TabIndex = 78;
            // 
            // textBoxTinhChat
            // 
            this.textBoxTinhChat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTinhChat.Location = new System.Drawing.Point(70, 216);
            this.textBoxTinhChat.Name = "textBoxTinhChat";
            this.textBoxTinhChat.Size = new System.Drawing.Size(150, 22);
            this.textBoxTinhChat.TabIndex = 77;
            // 
            // textBoxMaDatDa
            // 
            this.textBoxMaDatDa.Enabled = false;
            this.textBoxMaDatDa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaDatDa.Location = new System.Drawing.Point(70, 96);
            this.textBoxMaDatDa.Name = "textBoxMaDatDa";
            this.textBoxMaDatDa.Size = new System.Drawing.Size(150, 22);
            this.textBoxMaDatDa.TabIndex = 76;
            // 
            // textBoxTenDatDa
            // 
            this.textBoxTenDatDa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenDatDa.Location = new System.Drawing.Point(70, 156);
            this.textBoxTenDatDa.Name = "textBoxTenDatDa";
            this.textBoxTenDatDa.Size = new System.Drawing.Size(150, 22);
            this.textBoxTenDatDa.TabIndex = 75;
            // 
            // textBoxDungTrong
            // 
            this.textBoxDungTrong.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDungTrong.Location = new System.Drawing.Point(300, 96);
            this.textBoxDungTrong.Name = "textBoxDungTrong";
            this.textBoxDungTrong.Size = new System.Drawing.Size(150, 22);
            this.textBoxDungTrong.TabIndex = 74;
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
            this.label6.Location = new System.Drawing.Point(300, 130);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3);
            this.label6.Size = new System.Drawing.Size(97, 23);
            this.label6.TabIndex = 71;
            this.label6.Text = "Hệ số kiên cố ";
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
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 70;
            this.label5.Text = "Dung trọng";
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
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 69;
            this.label4.Text = "Tính chất";
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
            this.label3.Text = "Tên đất đá";
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
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 67;
            this.label2.Text = "Mã đất đá";
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
            this.buttonDelete.TabIndex = 72;
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
            this.buttonShowInsert.TabIndex = 73;
            this.buttonShowInsert.Text = "THÊM";
            this.buttonShowInsert.UseVisualStyleBackColor = false;
            this.buttonShowInsert.Click += new System.EventHandler(this.buttonShowInsert_Click);
            // 
            // panelInsert
            // 
            this.panelInsert.AutoScroll = true;
            this.panelInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelInsert.Controls.Add(this.textBoxKT_HAT_MAX2);
            this.panelInsert.Controls.Add(this.textBoxKCTB2);
            this.panelInsert.Controls.Add(this.label10);
            this.panelInsert.Controls.Add(this.label11);
            this.panelInsert.Controls.Add(this.label12);
            this.panelInsert.Controls.Add(this.textBoxHeSoDatDa2);
            this.panelInsert.Controls.Add(this.textBoxHeSoKienCo2);
            this.panelInsert.Controls.Add(this.textBoxTinhChat2);
            this.panelInsert.Controls.Add(this.textBoxMaDatDa2);
            this.panelInsert.Controls.Add(this.textBoxTenDatDa2);
            this.panelInsert.Controls.Add(this.textBoxDungTrong2);
            this.panelInsert.Controls.Add(this.buttonInsert);
            this.panelInsert.Controls.Add(this.labelBorder2);
            this.panelInsert.Controls.Add(this.buttonBack2);
            this.panelInsert.Controls.Add(this.label14);
            this.panelInsert.Controls.Add(this.label15);
            this.panelInsert.Controls.Add(this.label16);
            this.panelInsert.Controls.Add(this.label17);
            this.panelInsert.Controls.Add(this.label18);
            this.panelInsert.Controls.Add(this.label19);
            this.panelInsert.Location = new System.Drawing.Point(0, 111);
            this.panelInsert.Name = "panelInsert";
            this.panelInsert.Size = new System.Drawing.Size(784, 300);
            this.panelInsert.TabIndex = 74;
            // 
            // textBoxKT_HAT_MAX2
            // 
            this.textBoxKT_HAT_MAX2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKT_HAT_MAX2.Location = new System.Drawing.Point(530, 156);
            this.textBoxKT_HAT_MAX2.Name = "textBoxKT_HAT_MAX2";
            this.textBoxKT_HAT_MAX2.Size = new System.Drawing.Size(150, 22);
            this.textBoxKT_HAT_MAX2.TabIndex = 84;
            // 
            // textBoxKCTB2
            // 
            this.textBoxKCTB2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKCTB2.Location = new System.Drawing.Point(530, 96);
            this.textBoxKCTB2.Name = "textBoxKCTB2";
            this.textBoxKCTB2.Size = new System.Drawing.Size(150, 22);
            this.textBoxKCTB2.TabIndex = 83;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(530, 130);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(3);
            this.label10.Size = new System.Drawing.Size(88, 23);
            this.label10.TabIndex = 82;
            this.label10.Text = "KT HAT MAX";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(530, 70);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(3);
            this.label11.Size = new System.Drawing.Size(47, 23);
            this.label11.TabIndex = 81;
            this.label11.Text = "KCTB ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(300, 190);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(3);
            this.label12.Size = new System.Drawing.Size(90, 23);
            this.label12.TabIndex = 80;
            this.label12.Text = "Hệ số đất đá";
            // 
            // textBoxHeSoDatDa2
            // 
            this.textBoxHeSoDatDa2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHeSoDatDa2.Location = new System.Drawing.Point(300, 216);
            this.textBoxHeSoDatDa2.Name = "textBoxHeSoDatDa2";
            this.textBoxHeSoDatDa2.Size = new System.Drawing.Size(150, 22);
            this.textBoxHeSoDatDa2.TabIndex = 79;
            // 
            // textBoxHeSoKienCo2
            // 
            this.textBoxHeSoKienCo2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHeSoKienCo2.Location = new System.Drawing.Point(300, 156);
            this.textBoxHeSoKienCo2.Name = "textBoxHeSoKienCo2";
            this.textBoxHeSoKienCo2.Size = new System.Drawing.Size(150, 22);
            this.textBoxHeSoKienCo2.TabIndex = 78;
            // 
            // textBoxTinhChat2
            // 
            this.textBoxTinhChat2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTinhChat2.Location = new System.Drawing.Point(70, 216);
            this.textBoxTinhChat2.Name = "textBoxTinhChat2";
            this.textBoxTinhChat2.Size = new System.Drawing.Size(150, 22);
            this.textBoxTinhChat2.TabIndex = 77;
            // 
            // textBoxMaDatDa2
            // 
            this.textBoxMaDatDa2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaDatDa2.Location = new System.Drawing.Point(70, 96);
            this.textBoxMaDatDa2.Name = "textBoxMaDatDa2";
            this.textBoxMaDatDa2.Size = new System.Drawing.Size(150, 22);
            this.textBoxMaDatDa2.TabIndex = 76;
            // 
            // textBoxTenDatDa2
            // 
            this.textBoxTenDatDa2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenDatDa2.Location = new System.Drawing.Point(70, 156);
            this.textBoxTenDatDa2.Name = "textBoxTenDatDa2";
            this.textBoxTenDatDa2.Size = new System.Drawing.Size(150, 22);
            this.textBoxTenDatDa2.TabIndex = 75;
            // 
            // textBoxDungTrong2
            // 
            this.textBoxDungTrong2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDungTrong2.Location = new System.Drawing.Point(300, 96);
            this.textBoxDungTrong2.Name = "textBoxDungTrong2";
            this.textBoxDungTrong2.Size = new System.Drawing.Size(150, 22);
            this.textBoxDungTrong2.TabIndex = 74;
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(300, 130);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(3);
            this.label14.Size = new System.Drawing.Size(97, 23);
            this.label14.TabIndex = 71;
            this.label14.Text = "Hệ số kiên cố ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(300, 70);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(3);
            this.label15.Size = new System.Drawing.Size(81, 23);
            this.label15.TabIndex = 70;
            this.label15.Text = "Dung trọng";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Location = new System.Drawing.Point(70, 190);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(3);
            this.label16.Size = new System.Drawing.Size(66, 23);
            this.label16.TabIndex = 69;
            this.label16.Text = "Tính chất";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label17.Location = new System.Drawing.Point(70, 130);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(3);
            this.label17.Size = new System.Drawing.Size(76, 23);
            this.label17.TabIndex = 68;
            this.label17.Text = "Tên đất đá";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label18.Location = new System.Drawing.Point(70, 70);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(3);
            this.label18.Size = new System.Drawing.Size(75, 23);
            this.label18.TabIndex = 67;
            this.label18.Text = "Mã đất đá";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label19.Location = new System.Drawing.Point(50, 30);
            this.label19.Name = "label19";
            this.label19.Padding = new System.Windows.Forms.Padding(3);
            this.label19.Size = new System.Drawing.Size(86, 27);
            this.label19.TabIndex = 60;
            this.label19.Text = "Thông tin";
            // 
            // FormQuanLyDatDa
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
            this.Name = "FormQuanLyDatDa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đất đá";
            this.Load += new System.EventHandler(this.FormQuanLyDatDa_Load);
            this.Shown += new System.EventHandler(this.FormQuanLyDatDa_Shown);
            this.SizeChanged += new System.EventHandler(this.FormQuanLyDatDa_SizeChanged);
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
        private System.Windows.Forms.TextBox textBoxKT_HAT_MAX;
        private System.Windows.Forms.TextBox textBoxKCTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxHeSoDatDa;
        private System.Windows.Forms.TextBox textBoxHeSoKienCo;
        private System.Windows.Forms.TextBox textBoxTinhChat;
        private System.Windows.Forms.TextBox textBoxMaDatDa;
        private System.Windows.Forms.TextBox textBoxTenDatDa;
        private System.Windows.Forms.TextBox textBoxDungTrong;
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
        private System.Windows.Forms.TextBox textBoxKT_HAT_MAX2;
        private System.Windows.Forms.TextBox textBoxKCTB2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxHeSoDatDa2;
        private System.Windows.Forms.TextBox textBoxHeSoKienCo2;
        private System.Windows.Forms.TextBox textBoxTinhChat2;
        private System.Windows.Forms.TextBox textBoxMaDatDa2;
        private System.Windows.Forms.TextBox textBoxTenDatDa2;
        private System.Windows.Forms.TextBox textBoxDungTrong2;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label labelBorder2;
        private System.Windows.Forms.Button buttonBack2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}