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
    public partial class FormQuanLyHoChieu : DevExpress.XtraEditors.XtraForm
    {
        List<Button> buttonGroup = new List<Button>();
        List<Label> labelGroup = new List<Label>();
        Thread t = new Thread(new ThreadStart(BS_Main.LoadingScreen));

        public FormQuanLyHoChieu()
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
            labelGroup.Add(label14);
            labelGroup.Add(label15);
            labelGroup.Add(label16);
            labelGroup.Add(label17);
            labelGroup.Add(label18);
            labelGroup.Add(label19);
            labelGroup.Add(label20);
            labelGroup.Add(label21);
            labelGroup.Add(label22);
            labelGroup.Add(label23);
            labelGroup.Add(label24);
            labelGroup.Add(label25);
            labelGroup.Add(label26);
            labelGroup.Add(label27);
            labelGroup.Add(label28);
            labelGroup.Add(label29);
            labelGroup.Add(label30);
            labelGroup.Add(label31);
            labelGroup.Add(label32);
            labelGroup.Add(label33);
            labelGroup.Add(label34);
            labelGroup.Add(label35);
            labelGroup.Add(label36);
            labelGroup.Add(label37);          
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

        private void FormQuanLyHoChieu_Load(object sender, EventArgs e)
        {
            t.Start();
            ShowPanel(1);
            HienThiDuLieu_HoChieu();
        }
        private void FormQuanLyHoChieu_Shown(object sender, EventArgs e)
        {
            t.Abort();
            this.Focus();
        }

        private void HienThiDuLieu_HoChieu()
        {
            List<HoChieu> dsHoChieu = BS_HoChieu.DanhSachHoChieu();
            gridControlMain.DataSource = dsHoChieu;
            //panel insert + update
            comboBox_CongTruong.DataSource = comboBox_CongTruong2.DataSource = BS_CongTruong.DanhSachCongTruong();
            comboBox_CongTruong.DisplayMember = comboBox_CongTruong2.DisplayMember = "TenCongTruong";
            comboBox_DatDa.DataSource = comboBox_DatDa2.DataSource = BS_DatDa.DanhSachDatDa();
            comboBox_DatDa.DisplayMember = comboBox_DatDa2.DisplayMember = "TenDatDa";
            comboBox_MayKhoan.DataSource = comboBox_MayKhoan2.DataSource = BS_MayKhoan.DanhSachMayKhoan();
            comboBox_MayKhoan.DisplayMember = comboBox_MayKhoan2.DisplayMember = "TenMayKhoan";
            comboBox_KipNo.DataSource = comboBox_KipNo2.DataSource = BS_KipNo.DanhSachKipNo();
            comboBox_KipNo.DisplayMember = comboBox_KipNo2.DisplayMember = "TenKipNo";
            comboBox_ThuocNo.DataSource = comboBox_ThuocNo2.DataSource = BS_ThuocNo.DanhSachThuocNo();
            comboBox_ThuocNo.DisplayMember = comboBox_ThuocNo2.DisplayMember = "TenThuocNo";
            comboBox_PhuongPhapNo.DataSource = comboBox_PhuongPhapNo2.DataSource = BS_PhuongPhapNo.DanhSachPPNo();
            comboBox_PhuongPhapNo.DisplayMember = comboBox_PhuongPhapNo2.DisplayMember = "TenPPNo";
            comboBox_PhuKien.DataSource = comboBox_PhuKien2.DataSource = BS_PhuKienNo.DanhSachPhuKienNo();
            comboBox_PhuKien.DisplayMember = comboBox_PhuKien2.DisplayMember = "TenPhuKien";
            comboBox_CapDo.DataSource = comboBox_CapDo2.DataSource = BS_CapDoNo.DanhSachCapDoNo();
            comboBox_CapDo.DisplayMember = comboBox_CapDo2.DisplayMember = "TenCapDo";
            textBoxNgayLap2.Text = DateTime.Now.ToString();
        }

        private void FormQuanLyHoChieu_SizeChanged(object sender, EventArgs e)
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
            HienThiDuLieu_HoChieu();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            List<HoChieu> dsXoa = new List<HoChieu>();
            foreach (int value in gridViewMain.GetSelectedRows())
            {
                dsXoa.Add(gridViewMain.GetRow(value) as HoChieu);
            }
            try
            {
                BS_HoChieu.XoaHoChieu(dsXoa);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Lỗi - " + exc.Message);
            }
            HienThiDuLieu_HoChieu();
        }

        private void gridViewMain_DoubleClick(object sender, EventArgs e)
        {
            ShowPanel(3);
            HoChieu focusedRow = gridViewMain.GetFocusedRow() as HoChieu;
            textBoxMaBanVe.Text = focusedRow.MaBanVe;
            textBoxMaHoChieu.Text = focusedRow.MaHoChieu;
            textBoxTenHoChieu.Text = focusedRow.TenHoChieu;
            textBoxNgayLap.Text = focusedRow.NgayLap;
            comboBox_CongTruong.Text = BS_CongTruong.CongTruong(focusedRow.MaCongTruong).TenCongTruong;
            comboBox_DatDa.Text = BS_DatDa.DatDa(focusedRow.MaDatDa).TenDatDa;
            comboBox_MayKhoan.Text = BS_MayKhoan.MayKhoan(focusedRow.MaMayKhoan).TenMayKhoan;
            comboBox_KipNo.Text = BS_KipNo.KipNo(focusedRow.MaMayKhoan).TenKipNo;
            comboBox_ThuocNo.Text = BS_ThuocNo.ThuocNo(focusedRow.MaThuocNo).TenThuocNo;
            comboBox_PhuongPhapNo.Text = BS_PhuongPhapNo.PhuongPhapNo(focusedRow.MaPPNo).TenPPNo;
            comboBox_PhuKien.Text = BS_PhuKienNo.PhuKienNo(focusedRow.MaPhuKien).TenPhuKien;
            comboBox_CapDo.Text = BS_CapDoNo.CapDoNo(focusedRow.MaCapDo).TenCapDo;
            textBoxHeSoKC.Text = focusedRow.HeSoKC.ToString();
            textBoxChieuCaoTang.Text = focusedRow.ChieuCaoTang.ToString();
            textBoxQuyMoDotNo.Text = focusedRow.QuyMoDotNo.ToString();
            textBoxKichThuoc_X.Text = focusedRow.KichThuoc_X.ToString();
            textBoxKichThuoc_Y.Text = focusedRow.KichThuoc_Y.ToString();
            //textBoxThoiDiemNo.Text = ...;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ShowPanel(1);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            HoChieu updated = gridViewMain.GetFocusedRow() as HoChieu;
            if (textBoxTenHoChieu.Text != String.Empty) { updated.TenHoChieu = textBoxTenHoChieu.Text; }
            if (comboBox_CongTruong.Text != String.Empty) { updated.MaCongTruong = (comboBox_CongTruong.SelectedItem as CongTruong).MaCongTruong; }
            if (comboBox_DatDa.Text != String.Empty) { updated.MaDatDa = (comboBox_DatDa.SelectedItem as DatDa).MaDatDa; }
            if (comboBox_MayKhoan.Text != String.Empty) { updated.MaMayKhoan = (comboBox_MayKhoan.SelectedItem as MayKhoan).MaMayKhoan; }
            if (comboBox_KipNo.Text != String.Empty) { updated.MaKipNo = (comboBox_KipNo.SelectedItem as KipNo).MaKipNo; }
            if (comboBox_ThuocNo.Text != String.Empty) { updated.MaThuocNo = (comboBox_ThuocNo.SelectedItem as ThuocNo).MaThuocNo; }
            if (comboBox_PhuongPhapNo.Text != String.Empty) { updated.MaPPNo = (comboBox_PhuongPhapNo.SelectedItem as PhuongPhapNo).MaPPNo; }
            if (comboBox_PhuKien.Text != String.Empty) { updated.MaPhuKien = (comboBox_PhuKien.SelectedItem as PhuKienNo).MaPhuKien; }
            if (comboBox_CapDo.Text != String.Empty) { updated.MaCapDo = (comboBox_CapDo.SelectedItem as CapDoNo).MaCapDo; }
            updated.HeSoKC = double.Parse(textBoxHeSoKC.Text);
            updated.ChieuCaoTang = double.Parse(textBoxChieuCaoTang.Text);
            updated.QuyMoDotNo = double.Parse(textBoxQuyMoDotNo.Text);
            updated.KichThuoc_X = double.Parse(textBoxKichThuoc_X.Text);
            updated.KichThuoc_Y = double.Parse(textBoxKichThuoc_Y.Text);
            try
            {
                BS_HoChieu.CapNhatHoChieu(updated);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Lỗi - " + exc.Message);
            }
            ShowPanel(1);
            HienThiDuLieu_HoChieu();
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
            HoChieu inserted = new HoChieu();
            if (textBoxMaHoChieu2.Text != String.Empty) { inserted.MaHoChieu = textBoxMaHoChieu2.Text; }
            if (textBoxTenHoChieu2.Text != String.Empty) { inserted.TenHoChieu = textBoxTenHoChieu2.Text; }
            inserted.NgayLap = DateTime.Now.ToString();
            if (comboBox_CongTruong2.Text != String.Empty) { inserted.MaCongTruong = (comboBox_CongTruong2.SelectedItem as CongTruong).MaCongTruong; }
            if (comboBox_DatDa2.Text != String.Empty) { inserted.MaDatDa = (comboBox_DatDa2.SelectedItem as DatDa).MaDatDa; }
            if (comboBox_MayKhoan2.Text != String.Empty) { inserted.MaMayKhoan = (comboBox_MayKhoan2.SelectedItem as MayKhoan).MaMayKhoan; }
            if (comboBox_KipNo2.Text != String.Empty) { inserted.MaKipNo = (comboBox_KipNo2.SelectedItem as KipNo).MaKipNo; }
            if (comboBox_ThuocNo2.Text != String.Empty) { inserted.MaThuocNo = (comboBox_ThuocNo2.SelectedItem as ThuocNo).MaThuocNo; }
            if (comboBox_PhuongPhapNo2.Text != String.Empty) { inserted.MaPPNo = (comboBox_PhuongPhapNo2.SelectedItem as PhuongPhapNo).MaPPNo; }
            if (comboBox_PhuKien2.Text != String.Empty) { inserted.MaPhuKien = (comboBox_PhuKien2.SelectedItem as PhuKienNo).MaPhuKien; }
            if (comboBox_CapDo2.Text != String.Empty) { inserted.MaCapDo = (comboBox_CapDo2.SelectedItem as CapDoNo).MaCapDo; }
            inserted.HeSoKC = double.Parse(textBoxHeSoKC2.Text);
            inserted.ChieuCaoTang = double.Parse(textBoxChieuCaoTang2.Text);
            inserted.QuyMoDotNo = double.Parse(textBoxQuyMoDotNo2.Text);
            inserted.KichThuoc_X = double.Parse(textBoxKichThuoc_X2.Text);
            inserted.KichThuoc_Y = double.Parse(textBoxKichThuoc_Y2.Text);
            try
            {
                BS_HoChieu.ThemHoChieu(inserted);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Lỗi - " + exc.Message);
            }
            ShowPanel(1);
            HienThiDuLieu_HoChieu();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            BS_Main.PrintData<HoChieu>(BS_HoChieu.DanhSachHoChieu());
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            BS_Main.ExcelExport<HoChieu>(BS_HoChieu.DanhSachHoChieu());
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