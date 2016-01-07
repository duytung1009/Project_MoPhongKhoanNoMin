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
    public partial class FormQuanLyBanVe : DevExpress.XtraEditors.XtraForm
    {
        List<Button> buttonGroup = new List<Button>();
        List<Label> labelGroup = new List<Label>();
        Thread t = new Thread(new ThreadStart(BS_Main.LoadingScreen));

        public FormQuanLyBanVe()
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.FormBackgroundColor;
            panelUpdate.BackColor = Properties.Settings.Default.FormBackgroundColor;
            //panelInsert.BackColor = Properties.Settings.Default.FormBackgroundColor;
            labelBorder.BackColor = Properties.Settings.Default.PrimaryColor;
            //labelBorder2.BackColor = Properties.Settings.Default.PrimaryColor;
            //this.panelInsert.Dock = DockStyle.Bottom;
            this.panelUpdate.Dock = DockStyle.Bottom;
            buttonGroup.Add(buttonReload);
            buttonGroup.Add(buttonPrint);
            buttonGroup.Add(buttonExport);
            buttonGroup.Add(buttonDelete);
            buttonGroup.Add(buttonBack);
            buttonGroup.Add(buttonUpdate);
            labelGroup.Add(labelTitle);
            labelGroup.Add(label1);
            labelGroup.Add(label2);
            labelGroup.Add(label3);
            labelGroup.Add(label4);
            labelGroup.Add(label5);
            labelGroup.Add(label6);
            labelGroup.Add(label7);
            labelGroup.Add(label8);
            foreach (Button b in buttonGroup)
            {
                b.BackColor = Properties.Settings.Default.ButtonColor;
                b.FlatAppearance.BorderSize = 0;
            }
            foreach(Label l in labelGroup)
            {
                l.ForeColor = Properties.Settings.Default.TextColor;
            }
        }

        private void FormQuanLyBanVe_Load(object sender, EventArgs e)
        {            
            t.Start();
            ShowPanel(1);
            HienThiDuLieu_BanVe();
            
        }
        private void FormQuanLyBanVe_Shown(object sender, EventArgs e)
        {
            t.Abort();
            this.Focus();
        }

        private void HienThiDuLieu_BanVe()
        {
            List<BanVe> dsBanVe = BS_BanVe.DanhSachBanVe();
            gridControlMain.DataSource = dsBanVe;
        }

        private void FormQuanLyBanVe_SizeChanged(object sender, EventArgs e)
        {
            gridControlMain.Height = this.Height - 150;
            PanelMainReload();
        }

        private void PanelMainReload()
        {
            //panel insert
            //this.panelInsert.Height = this.Height - 150;
            //this.labelBorder2.Width = panelInsert.Width;
            //this.buttonBack2.Location = new Point(this.panelInsert.Width - 151, this.panelInsert.Height - 45);
            //this.buttonInsert.Location = new Point(this.panelInsert.Width - 112, this.panelInsert.Height - 45);
            //panel update
            this.panelUpdate.Height = this.Height - 150;
            this.labelBorder.Width = panelUpdate.Width;
            this.buttonBack.Location = new Point(this.panelUpdate.Width - 151, this.panelUpdate.Height - 45);
            this.buttonUpdate.Location = new Point(this.panelUpdate.Width - 112, this.panelUpdate.Height - 45);
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            HienThiDuLieu_BanVe();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            List<BanVe> dsXoa = new List<BanVe>();
            foreach (int value in gridViewMain.GetSelectedRows())
            {
                dsXoa.Add(gridViewMain.GetRow(value) as BanVe);
            }
            try
            {
                BS_BanVe.XoaBanVe(dsXoa);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Lỗi - " + exc.Message);
            }           
            HienThiDuLieu_BanVe();
        }

        private void gridViewMain_DoubleClick(object sender, EventArgs e)
        {
            ShowPanel(3);
            BanVe focusedRow = gridViewMain.GetFocusedRow() as BanVe;
            textBoxID.Text = focusedRow.ID;
            textBoxIDTemplate.Text = focusedRow.Template;
            textBoxTenBanVe.Text = focusedRow.TenBanVe;
            textBoxNgayChinhSua.Text = focusedRow.NgayChinhSua;
            textBoxDeltaX.Text = focusedRow.DeltaX.ToString();
            textBoxDeltaY.Text = focusedRow.DeltaY.ToString();
            textBoxNguoiDung.Text = focusedRow.NguoiDung;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ShowPanel(1);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            BanVe updated = gridViewMain.GetFocusedRow() as BanVe;
            updated.Template = textBoxIDTemplate.Text;
            updated.TenBanVe = textBoxTenBanVe.Text;
            updated.NgayChinhSua = textBoxNgayChinhSua.Text;
            updated.DeltaX = double.Parse(textBoxDeltaX.Text);
            updated.DeltaY = double.Parse(textBoxDeltaY.Text);
            updated.NguoiDung = textBoxNguoiDung.Text;
            try
            {
                BS_BanVe.CapNhatBanVe(updated);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Lỗi - " + exc.Message);
            }
            ShowPanel(1);
            HienThiDuLieu_BanVe();
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
                    //panelInsert.Visible = false;
                    panelUpdate.Visible = false;
                    break;
                case 2:
                    gridControlMain.Visible = false;
                    //panelInsert.Visible = true;
                    panelUpdate.Visible = false;
                    break;
                case 3:
                    gridControlMain.Visible = false;
                    //panelInsert.Visible = false;
                    panelUpdate.Visible = true;
                    break;
                default:
                    gridControlMain.Visible = false;
                    //panelInsert.Visible = false;
                    panelUpdate.Visible = false;
                    break;
            }
            PanelMainReload();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            BS_Main.ExcelExport<BanVe>(BS_BanVe.DanhSachBanVe());
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            BS_Main.PrintData<BanVe>(BS_BanVe.DanhSachBanVe());
        }
    }
}