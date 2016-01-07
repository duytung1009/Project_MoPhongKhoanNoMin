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
    public partial class FormQuanLyLoKhoan : DevExpress.XtraEditors.XtraForm
    {
        List<Button> buttonGroup = new List<Button>();
        List<Label> labelGroup = new List<Label>();
        Thread t = new Thread(new ThreadStart(BS_Main.LoadingScreen));

        public FormQuanLyLoKhoan()
        {
            InitializeComponent();
            //UI
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
            labelGroup.Add(label9);
            labelGroup.Add(label10);
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

        private void FormQuanLyLoKhoan_Load(object sender, EventArgs e)
        {
            t.Start();
            ShowPanel(1);
            HienThiDuLieu_LoKhoan();
        }
        private void FormQuanLyLoKhoan_Shown(object sender, EventArgs e)
        {
            t.Abort();
            this.Focus();
        }

        private void HienThiDuLieu_LoKhoan()
        {
            List<LoKhoan> dsLoKhoan = BS_LoKhoan.DanhSachLoKhoan();
            gridControlMain.DataSource = dsLoKhoan;
            comboBox_MayKhoan.DataSource = BS_MayKhoan.DanhSachMayKhoan();
            comboBox_MayKhoan.DisplayMember = "TenMayKhoan";
        }

        private void FormQuanLyLoKhoan_SizeChanged(object sender, EventArgs e)
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
            HienThiDuLieu_LoKhoan();
        }

        private void gridViewMain_DoubleClick(object sender, EventArgs e)
        {
            ShowPanel(3);
            LoKhoan focusedRow = gridViewMain.GetFocusedRow() as LoKhoan;
            textBoxMaHoChieu.Text = focusedRow.MaHoChieu;
            textBoxMaBanVe.Text = focusedRow.MaBanVe;
            textBoxMaLoKhoan.Text = focusedRow.MaLoKhoan;
            comboBox_MayKhoan.Text = BS_MayKhoan.MayKhoan(focusedRow.MaMayKhoan).TenMayKhoan;
            textBoxBanKinh.Text = focusedRow.BanKinh.ToString();
            textBoxChieuSau.Text = focusedRow.ChieuSau.ToString();
            comboBox_HuongKhoan.Text = focusedRow.HuongKhoan;
            textBoxToaDoX.Text = focusedRow.ToaDoX.ToString();
            textBoxToaDoY.Text = focusedRow.ToaDoY.ToString();
            textBoxLt.Text = focusedRow.Lt.ToString();
            textBoxLkk.Text = focusedRow.Lkk.ToString();
            textBoxL0.Text = focusedRow.L0.ToString();
            textBoxLbua.Text = focusedRow.Lbua.ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ShowPanel(1);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            LoKhoan updated = gridViewMain.GetFocusedRow() as LoKhoan;
            updated.BanKinh = double.Parse(textBoxBanKinh.Text);
            updated.ChieuSau = double.Parse(textBoxChieuSau.Text);
            updated.Lt = double.Parse(textBoxLt.Text);
            updated.Lkk = double.Parse(textBoxLkk.Text);
            updated.L0 = double.Parse(textBoxL0.Text);
            updated.Lbua = double.Parse(textBoxLbua.Text);
            if (comboBox_HuongKhoan.Text != String.Empty) { updated.HuongKhoan = comboBox_HuongKhoan.Text; }     
            if (comboBox_MayKhoan.Text != String.Empty) { updated.MaMayKhoan = (comboBox_MayKhoan.SelectedValue as MayKhoan).MaMayKhoan; }      
            try
            {
                BS_LoKhoan.CapNhatLoKhoan(updated);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Lỗi - " + exc.Message);
            }
            ShowPanel(1);
            HienThiDuLieu_LoKhoan();
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
            BS_Main.ExcelExport<LoKhoan>(BS_LoKhoan.DanhSachLoKhoan());
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            BS_Main.PrintData<LoKhoan>(BS_LoKhoan.DanhSachLoKhoan());
        }
    }
}