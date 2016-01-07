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
    public partial class FormQuanLyKipNo : DevExpress.XtraEditors.XtraForm
    {
        List<Button> buttonGroup = new List<Button>();
        List<Label> labelGroup = new List<Label>();
        Thread t = new Thread(new ThreadStart(BS_Main.LoadingScreen));

        public FormQuanLyKipNo()
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
            labelGroup.Add(label8);
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

        private void FormQuanLyKipNo_Load(object sender, EventArgs e)
        {
            t.Start();
            ShowPanel(1);
            HienThiDuLieu_KipNo();
        }
        private void FormQuanLyKipNo_Shown(object sender, EventArgs e)
        {
            t.Abort();
            this.Focus();
        }

        private void HienThiDuLieu_KipNo()
        {
            List<KipNo> dsKipNo = BS_KipNo.DanhSachKipNo();
            gridControlMain.DataSource = dsKipNo;
        }

        private void FormQuanLyKipNo_SizeChanged(object sender, EventArgs e)
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
            HienThiDuLieu_KipNo();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            List<KipNo> dsXoa = new List<KipNo>();
            foreach (int value in gridViewMain.GetSelectedRows())
            {
                dsXoa.Add(gridViewMain.GetRow(value) as KipNo);
            }
            try
            {
                BS_KipNo.XoaKipNo(dsXoa);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Lỗi - " + exc.Message);
            }
            HienThiDuLieu_KipNo();
        }

        private void gridViewMain_DoubleClick(object sender, EventArgs e)
        {
            ShowPanel(3);
            KipNo focusedRow = gridViewMain.GetFocusedRow() as KipNo;
            textBoxMaKipNo.Text = focusedRow.MaKipNo;
            textBoxTenKipNo.Text = focusedRow.TenKipNo;
            textBoxThoiGianViSai.Text = focusedRow.ThoiGianViSai;
            textBoxDonViTinh.Text = focusedRow.DonViTinh_KN.ToString();
            textBoxGiaThanh.Text = focusedRow.GiaThanh_KN.ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ShowPanel(1);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            KipNo updated = gridViewMain.GetFocusedRow() as KipNo;
            updated.TenKipNo = textBoxTenKipNo.Text;
            updated.ThoiGianViSai = textBoxThoiGianViSai.Text;
            if (textBoxDonViTinh.Text != String.Empty) { updated.DonViTinh_KN = double.Parse(textBoxDonViTinh.Text); }
            if (textBoxGiaThanh.Text != String.Empty) { updated.GiaThanh_KN = double.Parse(textBoxGiaThanh.Text); }       
            try
            {
                BS_KipNo.CapNhatKipNo(updated);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Lỗi - " + exc.Message);
            }
            ShowPanel(1);
            HienThiDuLieu_KipNo();
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
            KipNo insert = new KipNo();
            insert.MaKipNo = textBoxMaKipNo2.Text;
            insert.TenKipNo = textBoxTenKipNo2.Text;
            insert.ThoiGianViSai = textBoxThoiGianViSai2.Text;
            if (textBoxDonViTinh2.Text != String.Empty) { insert.DonViTinh_KN = double.Parse(textBoxDonViTinh2.Text); }
            if (textBoxGiaThanh2.Text != String.Empty) { insert.GiaThanh_KN = double.Parse(textBoxGiaThanh2.Text); }
            try
            {
                BS_KipNo.ThemKipNo(insert);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Lỗi - " + exc.Message);
            }
            ShowPanel(1);
            HienThiDuLieu_KipNo();
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
            BS_Main.ExcelExport<KipNo>(BS_KipNo.DanhSachKipNo());
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            BS_Main.PrintData<KipNo>(BS_KipNo.DanhSachKipNo());
        }
    }
}