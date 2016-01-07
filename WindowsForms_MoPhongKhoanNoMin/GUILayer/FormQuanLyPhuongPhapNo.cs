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
    public partial class FormQuanLyPhuongPhapNo : DevExpress.XtraEditors.XtraForm
    {
        List<Button> buttonGroup = new List<Button>();
        List<Label> labelGroup = new List<Label>();
        Thread t = new Thread(new ThreadStart(BS_Main.LoadingScreen));

        public FormQuanLyPhuongPhapNo()
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
            labelGroup.Add(label9);
            labelGroup.Add(label10);
            labelGroup.Add(label11);
            labelGroup.Add(label12);
            labelGroup.Add(label13);
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

        private void FormQuanLyPhuongPhapNo_Load(object sender, EventArgs e)
        {
            t.Start();
            ShowPanel(1);
            HienThiDuLieu_PhuongPhapNo();
        }
        private void FormQuanLyPhuongPhapNo_Shown(object sender, EventArgs e)
        {
            t.Abort();
            this.Focus();
        }

        private void HienThiDuLieu_PhuongPhapNo()
        {
            List<PhuongPhapNo> dsPhuongPhapNo = BS_PhuongPhapNo.DanhSachPPNo();
            gridControlMain.DataSource = dsPhuongPhapNo;
        }

        private void FormQuanLyPhuongPhapNo_SizeChanged(object sender, EventArgs e)
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
            HienThiDuLieu_PhuongPhapNo();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            List<PhuongPhapNo> dsXoa = new List<PhuongPhapNo>();
            foreach (int value in gridViewMain.GetSelectedRows())
            {
                dsXoa.Add(gridViewMain.GetRow(value) as PhuongPhapNo);
            }
            try
            {
                BS_PhuongPhapNo.XoaPhuongPhapNo(dsXoa);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Lỗi - " + exc.Message);
            }           
            HienThiDuLieu_PhuongPhapNo();
        }

        private void gridViewMain_DoubleClick(object sender, EventArgs e)
        {
            ShowPanel(3);
            PhuongPhapNo focusedRow = gridViewMain.GetFocusedRow() as PhuongPhapNo;
            textBoxMaPPNo.Text = focusedRow.MaPPNo;
            textBoxTenPPNo.Text = focusedRow.TenPPNo;
            textBoxMaCongTruong.Text = focusedRow.MaCongTruong;
            textBoxHeSoKienCo.Text = focusedRow.HeSoKienCo.ToString();
            textBoxHeSoPPNo.Text = focusedRow.HeSoPPNo.ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ShowPanel(1);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            PhuongPhapNo updated = gridViewMain.GetFocusedRow() as PhuongPhapNo;
            updated.TenPPNo = textBoxTenPPNo.Text;
            updated.MaCongTruong = textBoxMaCongTruong.Text;
            if (textBoxHeSoKienCo.Text != String.Empty) { updated.HeSoKienCo = double.Parse(textBoxHeSoKienCo.Text); }
            if (textBoxHeSoPPNo.Text != String.Empty) { updated.HeSoPPNo = double.Parse(textBoxHeSoPPNo.Text); }        
            try
            {
                BS_PhuongPhapNo.CapNhatPhuongPhapNo(updated);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Lỗi - " + exc.Message);
            }
            ShowPanel(1);
            HienThiDuLieu_PhuongPhapNo();
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
            PhuongPhapNo inserted = new PhuongPhapNo();
            inserted.MaPPNo = textBoxMaPPNo2.Text;
            inserted.TenPPNo = textBoxTenPPNo2.Text;
            inserted.MaCongTruong = textBoxMaCongTruong2.Text;
            if (textBoxHeSoKienCo2.Text != String.Empty) { inserted.HeSoKienCo = double.Parse(textBoxHeSoKienCo2.Text); }
            if (textBoxHeSoPPNo2.Text != String.Empty) { inserted.HeSoPPNo = double.Parse(textBoxHeSoPPNo2.Text); }
            try
            {
                BS_PhuongPhapNo.ThemPhuongPhapNo(inserted);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Lỗi - " + exc.Message);
            }
            ShowPanel(1);
            HienThiDuLieu_PhuongPhapNo();
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
            BS_Main.ExcelExport<PhuongPhapNo>(BS_PhuongPhapNo.DanhSachPPNo());
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            BS_Main.PrintData<PhuongPhapNo>(BS_PhuongPhapNo.DanhSachPPNo());
        }
    }
}