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
    public partial class FormQuanLyDatDa : DevExpress.XtraEditors.XtraForm
    {
        List<Button> buttonGroup = new List<Button>();
        List<Label> labelGroup = new List<Label>();
        Thread t = new Thread(new ThreadStart(BS_Main.LoadingScreen));

        public FormQuanLyDatDa()
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

        private void FormQuanLyDatDa_Load(object sender, EventArgs e)
        {
            t.Start();
            ShowPanel(1);
            HienThiDuLieu_DatDa();
        }
        private void FormQuanLyDatDa_Shown(object sender, EventArgs e)
        {
            t.Abort();
            this.Focus();
        }

        private void HienThiDuLieu_DatDa()
        {
            List<DatDa> dsDatDa = BS_DatDa.DanhSachDatDa();
            gridControlMain.DataSource = dsDatDa;
        }

        private void FormQuanLyDatDa_SizeChanged(object sender, EventArgs e)
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
            HienThiDuLieu_DatDa();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            List<DatDa> dsXoa = new List<DatDa>();
            foreach (int value in gridViewMain.GetSelectedRows())
            {
                dsXoa.Add(gridViewMain.GetRow(value) as DatDa);
            }
            try
            {
                BS_DatDa.XoaDatDa(dsXoa);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Lỗi - " + exc.Message);
            }
            HienThiDuLieu_DatDa();
        }

        private void gridViewMain_DoubleClick(object sender, EventArgs e)
        {
            ShowPanel(3);
            DatDa focusedRow = gridViewMain.GetFocusedRow() as DatDa;
            textBoxMaDatDa.Text = focusedRow.MaDatDa;
            textBoxTenDatDa.Text = focusedRow.TenDatDa;
            textBoxHeSoKienCo.Text = focusedRow.HS_KienCo_TB.ToString();
            textBoxHeSoDatDa.Text = focusedRow.HeSoDatDa.ToString();
            textBoxTinhChat.Text = focusedRow.TinhChat;
            textBoxDungTrong.Text = focusedRow.DungTrong.ToString();
            textBoxKCTB.Text = focusedRow.KCTB_KhoiNut.ToString();
            textBoxKT_HAT_MAX.Text = focusedRow.KT_HAT_MAX.ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ShowPanel(1);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            DatDa updated = gridViewMain.GetFocusedRow() as DatDa;
            updated.TenDatDa = textBoxTenDatDa.Text;
            updated.HS_KienCo_TB = double.Parse(textBoxHeSoKienCo.Text);
            updated.HeSoDatDa = double.Parse(textBoxHeSoDatDa.Text);
            updated.TinhChat = textBoxTinhChat.Text;
            updated.DungTrong = double.Parse(textBoxDungTrong.Text);
            updated.KCTB_KhoiNut = double.Parse(textBoxKCTB.Text);
            updated.KT_HAT_MAX = double.Parse(textBoxKT_HAT_MAX.Text);
            try
            {
                BS_DatDa.CapNhatDatDa(updated);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Lỗi - " + exc.Message);
            }
            ShowPanel(1);
            HienThiDuLieu_DatDa();
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
            DatDa inserted = new DatDa();
            inserted.MaDatDa = textBoxMaDatDa2.Text;
            inserted.TenDatDa = textBoxTenDatDa2.Text;
            if (textBoxHeSoKienCo2.Text != String.Empty) { inserted.HS_KienCo_TB = double.Parse(textBoxHeSoKienCo2.Text); }
            if (textBoxHeSoDatDa2.Text != String.Empty) { inserted.HeSoDatDa = double.Parse(textBoxHeSoDatDa2.Text); }
            inserted.TinhChat = textBoxTinhChat2.Text;
            if (textBoxDungTrong2.Text != String.Empty) { inserted.DungTrong = double.Parse(textBoxDungTrong2.Text); }
            if (textBoxKCTB2.Text != String.Empty) { inserted.KCTB_KhoiNut = double.Parse(textBoxKCTB2.Text); }
            if (textBoxKT_HAT_MAX2.Text != String.Empty) { inserted.KT_HAT_MAX = double.Parse(textBoxKT_HAT_MAX2.Text); }
            try
            {
                BS_DatDa.ThemDatDa(inserted);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Lỗi - " + exc.Message);
            }
            ShowPanel(1);
            HienThiDuLieu_DatDa();
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
            BS_Main.ExcelExport<DatDa>(BS_DatDa.DanhSachDatDa());
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            BS_Main.PrintData<DatDa>(BS_DatDa.DanhSachDatDa());
        }
    }
}