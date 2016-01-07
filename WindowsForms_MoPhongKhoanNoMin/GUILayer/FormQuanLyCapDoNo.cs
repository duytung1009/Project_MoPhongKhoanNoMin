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
    public partial class FormQuanLyCapDoNo : DevExpress.XtraEditors.XtraForm
    {
        List<Button> buttonGroup = new List<Button>();
        List<Label> labelGroup = new List<Label>();
        Thread t = new Thread(new ThreadStart(BS_Main.LoadingScreen));

        public FormQuanLyCapDoNo()
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
            //...
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

        private void FormQuanLyCapDoNo_Load(object sender, EventArgs e)
        {
            t.Start();
            ShowPanel(1);
            HienThiDuLieu_CapDoNo();
        }
        private void FormQuanLyCapDoNo_Shown(object sender, EventArgs e)
        {
            t.Abort();
            this.Focus();
        }

        private void HienThiDuLieu_CapDoNo()
        {
            List<CapDoNo> dsCapDoNo = BS_CapDoNo.DanhSachCapDoNo();
            gridControlMain.DataSource = dsCapDoNo;
        }

        private void FormQuanLyCapDoNo_SizeChanged(object sender, EventArgs e)
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
            HienThiDuLieu_CapDoNo();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            List<CapDoNo> dsXoa = new List<CapDoNo>();
            foreach (int value in gridViewMain.GetSelectedRows())
            {
                dsXoa.Add(gridViewMain.GetRow(value) as CapDoNo);
            }
            try
            {
                BS_CapDoNo.XoaCapDoNo(dsXoa);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Lỗi - " + exc.Message);
            }
            HienThiDuLieu_CapDoNo();
        }

        private void gridViewMain_DoubleClick(object sender, EventArgs e)
        {
            ShowPanel(3);
            CapDoNo focusedRow = gridViewMain.GetFocusedRow() as CapDoNo;
            textBoxMaCapDo.Text = focusedRow.MaCapDo;
            textBoxTenCapDo.Text = focusedRow.TenCapDo;
            textBoxChiTieuThuocNo.Text = focusedRow.ChiTieuThuocNo.ToString();
            textBoxDoCungDatDa.Text = focusedRow.DoCungDatDa;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ShowPanel(1);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            CapDoNo updated = gridViewMain.GetFocusedRow() as CapDoNo;
            updated.TenCapDo = textBoxTenCapDo.Text;
            if (textBoxChiTieuThuocNo.Text != String.Empty) { updated.ChiTieuThuocNo = double.Parse(textBoxChiTieuThuocNo.Text); }
            updated.DoCungDatDa = textBoxDoCungDatDa.Text;
            try
            {
                BS_CapDoNo.CapNhatCapDoNo(updated);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Lỗi - " + exc.Message);
            }
            ShowPanel(1);
            HienThiDuLieu_CapDoNo();
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
            CapDoNo inserted = new CapDoNo();
            inserted.MaCapDo = textBoxMaCapDo2.Text;
            inserted.TenCapDo = textBoxTenCapDo2.Text;
            if (textBoxChiTieuThuocNo2.Text != String.Empty) { inserted.ChiTieuThuocNo = double.Parse(textBoxChiTieuThuocNo2.Text); }
            inserted.DoCungDatDa = textBoxDoCungDatDa2.Text;
            try
            {
                BS_CapDoNo.ThemCapDoNo(inserted);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Lỗi - " + exc.Message);
            }
            ShowPanel(1);
            HienThiDuLieu_CapDoNo();
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

        private void buttonExport_Click(object sender, EventArgs e)
        {
            BS_Main.ExcelExport<CapDoNo>(BS_CapDoNo.DanhSachCapDoNo());
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            BS_Main.PrintData<CapDoNo>(BS_CapDoNo.DanhSachCapDoNo());
        }
    }
}