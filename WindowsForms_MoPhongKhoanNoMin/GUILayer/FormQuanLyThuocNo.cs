using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using System.Threading;
using WindowsForms_MoPhongKhoanNoMin.BusinessLayer;

namespace WindowsForms_MoPhongKhoanNoMin.GUILayer
{
    public partial class FormQuanLyThuocNo : DevExpress.XtraEditors.XtraForm
    {
        List<Button> buttonGroup = new List<Button>();
        List<Label> labelGroup = new List<Label>();
        Thread t = new Thread(new ThreadStart(BS_Main.LoadingScreen));

        public FormQuanLyThuocNo()
        {
            InitializeComponent();
            //UI
            this.BackColor = Properties.Settings.Default.FormBackgroundColor;
            panelUpdate.BackColor = Properties.Settings.Default.FormBackgroundColor;
            panelInsert.BackColor = Properties.Settings.Default.FormBackgroundColor;
            labelBorder.BackColor = Properties.Settings.Default.PrimaryColor;
            labelBorder2.BackColor = Properties.Settings.Default.PrimaryColor;
            this.panelInsert.Dock = DockStyle.Bottom;
            this.panelUpdate.Dock = DockStyle.Bottom;
            buttonGroup.Add(buttonReload);
            buttonGroup.Add(buttonPrint);
            buttonGroup.Add(buttonExport);
            buttonGroup.Add(buttonDelete);
            buttonGroup.Add(buttonBack);
            buttonGroup.Add(buttonUpdate);
            buttonGroup.Add(buttonShowInsert);
            buttonGroup.Add(buttonBack2);
            buttonGroup.Add(buttonInsert);
            labelGroup.Add(labelTitle);
            labelGroup.Add(label1);
            labelGroup.Add(label2);
            labelGroup.Add(label3);
            labelGroup.Add(label4);
            labelGroup.Add(label5);
            labelGroup.Add(label6);
            labelGroup.Add(label7);
            labelGroup.Add(label8);
            labelGroup.Add(label9);
            labelGroup.Add(label10);
            labelGroup.Add(label11);
            labelGroup.Add(label12);
            labelGroup.Add(label13);
            labelGroup.Add(label14);
            labelGroup.Add(label15);
            labelGroup.Add(label17);
            labelGroup.Add(label18);
            labelGroup.Add(label19);
            labelGroup.Add(label21);
            labelGroup.Add(label21);
            foreach (Button b in buttonGroup)
            {
                b.BackColor = Properties.Settings.Default.ButtonColor;
                b.FlatAppearance.BorderSize = 0;
            }
            foreach (Label l in labelGroup)
            {
                l.ForeColor = Properties.Settings.Default.TextColor;
            }
        }

        private void FormQuanLyThuocNo_Load(object sender, EventArgs e)
        {
            t.Start();
            ShowPanel(1);
            HienThiDuLieu_ThuocNo();
        }
        private void FormQuanLyThuocNo_Shown(object sender, EventArgs e)
        {
            t.Abort();
            this.Focus();
        }

        private void HienThiDuLieu_ThuocNo()
        {
            List<ThuocNo> dsThuocNo = BS_ThuocNo.DanhSachThuocNo();
            gridControlMain.DataSource = dsThuocNo;
        }

        private void FormQuanLyThuocNo_SizeChanged(object sender, EventArgs e)
        {
            gridControlMain.Height = this.Height - 150;
            PanelMainReload();
        }

        private void PanelMainReload()
        {
            //panel insert
            this.panelInsert.Height = this.Height - 150;
            this.labelBorder2.Width = panelInsert.Width;
            this.buttonBack2.Location = new Point(this.panelInsert.Width - 151, this.panelInsert.Height - 45);
            this.buttonInsert.Location = new Point(this.panelInsert.Width - 112, this.panelInsert.Height - 45);
            //panel update
            this.panelUpdate.Height = this.Height - 150;
            this.labelBorder.Width = panelUpdate.Width;
            this.buttonBack.Location = new Point(this.panelUpdate.Width - 151, this.panelUpdate.Height - 45);
            this.buttonUpdate.Location = new Point(this.panelUpdate.Width - 112, this.panelUpdate.Height - 45);
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            HienThiDuLieu_ThuocNo();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            List<ThuocNo> dsXoa = new List<ThuocNo>();
            foreach (int value in gridViewMain.GetSelectedRows())
            {
                dsXoa.Add(gridViewMain.GetRow(value) as ThuocNo);
            }
            try
            {
                BS_ThuocNo.XoaThuocNo(dsXoa);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Lỗi - " + exc.Message);
            }
            HienThiDuLieu_ThuocNo();
        }

        private void gridViewMain_DoubleClick(object sender, EventArgs e)
        {
            ShowPanel(3);
            ThuocNo focusedRow = gridViewMain.GetFocusedRow() as ThuocNo;
            textBoxMaThuocNo.Text = focusedRow.MaThuocNo;
            textBoxTenThuocNo.Text = focusedRow.TenThuocNo;
            textBoxTocDoNo.Text = focusedRow.TocDoNo.ToString();
            textBoxKhaNangSinhCong.Text = focusedRow.KhaNangSinhCong.ToString();
            textBoxMatDoNapThuoc.Text = focusedRow.MatDoNapThuoc.ToString();
            textBoxChiuNuoc.Text = focusedRow.ChiuNuoc;
            textBoxHeSoChuyenDoi.Text = focusedRow.HS_ChuyenDoi.ToString();
            textBoxDonViTinh.Text = focusedRow.DonViTinh_TN.ToString();
            textBoxGiaThanh.Text = focusedRow.GiaThanh_TN.ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ShowPanel(1);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            ThuocNo updated = gridViewMain.GetFocusedRow() as ThuocNo;
            updated.TenThuocNo = textBoxTenThuocNo.Text;
            if (textBoxTocDoNo.Text != String.Empty) { updated.TocDoNo = double.Parse(textBoxTocDoNo.Text); }
            if (textBoxKhaNangSinhCong.Text != String.Empty) { updated.KhaNangSinhCong = double.Parse(textBoxKhaNangSinhCong.Text); }
            if (textBoxMatDoNapThuoc.Text != String.Empty) { updated.MatDoNapThuoc = double.Parse(textBoxMatDoNapThuoc.Text); }
            updated.ChiuNuoc = textBoxChiuNuoc.Text;
            if (textBoxHeSoChuyenDoi.Text != String.Empty) { updated.HS_ChuyenDoi = double.Parse(textBoxHeSoChuyenDoi.Text); }
            if (textBoxDonViTinh.Text != String.Empty) { updated.DonViTinh_TN = double.Parse(textBoxDonViTinh.Text); }
            if (textBoxGiaThanh.Text != String.Empty) { updated.GiaThanh_TN = double.Parse(textBoxGiaThanh.Text); }
            try
            {
                BS_ThuocNo.CapNhatThuocNo(updated);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Lỗi - " + exc.Message);
            }
            ShowPanel(1);
            HienThiDuLieu_ThuocNo();
        }

        private void buttonShowInsert_Click(object sender, EventArgs e)
        {
            ShowPanel(2);
        }

        private void buttonBack2_Click(object sender, EventArgs e)
        {
            ShowPanel(1);
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            ThuocNo inserted = gridViewMain.GetFocusedRow() as ThuocNo;
            inserted.TenThuocNo = textBoxTenThuocNo2.Text;
            if (textBoxTocDoNo2.Text != String.Empty) { inserted.TocDoNo = double.Parse(textBoxTocDoNo2.Text); }
            if (textBoxKhaNangSinhCong2.Text != String.Empty) { inserted.KhaNangSinhCong = double.Parse(textBoxKhaNangSinhCong2.Text); }
            if (textBoxMatDoNapThuoc2.Text != String.Empty) { inserted.MatDoNapThuoc = double.Parse(textBoxMatDoNapThuoc2.Text); }
            inserted.ChiuNuoc = textBoxChiuNuoc2.Text;
            if (textBoxHeSoChuyenDoi2.Text != String.Empty) { inserted.HS_ChuyenDoi = double.Parse(textBoxHeSoChuyenDoi2.Text); }
            if (textBoxDonViTinh2.Text != String.Empty) { inserted.DonViTinh_TN = double.Parse(textBoxDonViTinh2.Text); }
            if (textBoxGiaThanh2.Text != String.Empty) { inserted.GiaThanh_TN = double.Parse(textBoxGiaThanh2.Text); }
            try
            {
                BS_ThuocNo.ThemThuocNo(inserted);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Lỗi - " + exc.Message);
            }
            ShowPanel(1);
            HienThiDuLieu_ThuocNo();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            BS_Main.PrintData<ThuocNo>(BS_ThuocNo.DanhSachThuocNo());
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            BS_Main.ExcelExport<ThuocNo>(BS_ThuocNo.DanhSachThuocNo());
        }

        /// <summary>
        /// Hàm quản lý panel
        /// </summary>
        /// <param name="flag">1: hiện datagrid, 2: hiện panel insert, 3: hiện panel update</param>
        private void ShowPanel(int flag)
        {
            switch (flag)
            {
                case 1:
                    gridControlMain.Visible = true;
                    panelInsert.Visible = false;
                    panelUpdate.Visible = false;
                    break;
                case 2:
                    gridControlMain.Visible = false;
                    panelInsert.Visible = true;
                    panelUpdate.Visible = false;
                    break;
                case 3:
                    gridControlMain.Visible = false;
                    panelInsert.Visible = false;
                    panelUpdate.Visible = true;
                    break;
                default:
                    gridControlMain.Visible = false;
                    panelInsert.Visible = false;
                    panelUpdate.Visible = false;
                    break;
            }
            PanelMainReload();
        }
    }
}