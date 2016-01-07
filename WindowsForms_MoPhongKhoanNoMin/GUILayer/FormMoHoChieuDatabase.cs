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
using WindowsForms_MoPhongKhoanNoMin.CustomControls;

namespace WindowsForms_MoPhongKhoanNoMin.GUILayer
{
    public partial class FormMoHoChieuDatabase : DevExpress.XtraEditors.XtraForm
    {
        private List<UserControl_BanVe> controlDanhSachBanVe = new List<UserControl_BanVe>();
        Thread t = new Thread(new ThreadStart(BS_Main.LoadingScreen));

        // khai báo 1 hàm delegate
        public delegate void GetData(String idHoChieu);
        // khai báo 1 kiểu hàm delegate
        public GetData MyGetData;

        public FormMoHoChieuDatabase()
        {
            InitializeComponent();
            //UI
            this.BackColor = Properties.Settings.Default.FormBackgroundColor;
            panelMain.BackColor = Properties.Settings.Default.SecondaryColor;
            labelTitle.ForeColor = Properties.Settings.Default.TextColor;
            labelTitle2.ForeColor = Properties.Settings.Default.TextColor;
        }

        private void FormMoBanVeDatabase_Load(object sender, EventArgs e)
        {
            t.Start();
            List<HoChieu> danhSachHoChieu = BS_HoChieu.DanhSachHoChieu();
            int y = 0, i = 1;
            foreach(HoChieu value in danhSachHoChieu)
            {
                UserControl_BanVe controlBanVe = new UserControl_BanVe(value.TenHoChieu, BS_BanVe.BanVe(value.MaBanVe).NgayChinhSua, i);
                controlBanVe.Width = panelMain.Width;
                controlBanVe.Location = new Point(0, y);
                controlDanhSachBanVe.Add(controlBanVe);
                panelMain.Controls.Add(controlBanVe);
                y += 30; i++;
            }
            foreach (UserControl_BanVe value in controlDanhSachBanVe)
            {
                value.LinkLabelBanVe.Click += new System.EventHandler(controlDanhSachBanVe_Click);
            }
        }

        private void FormMoBanVeDatabase_Shown(object sender, EventArgs e)
        {
            t.Abort();
            this.Focus();
            textBoxTenBanVe.Focus();
        }

        private void controlDanhSachBanVe_Click(object sender, EventArgs e)
        {
            List<HoChieu> danhSachHoChieu = BS_HoChieu.DanhSachHoChieu();
            LinkLabel value = sender as LinkLabel;
            foreach(HoChieu a in danhSachHoChieu)
            {
                if (a.TenHoChieu.Equals(value.Text))
                {
                    MyGetData(a.MaHoChieu);
                    this.Close();
                }
            }
        }

        private void FormMoBanVeDatabase_SizeChanged(object sender, EventArgs e)
        {
            panelMain.Size = new Size(this.Width - 16, this.Height - 140);
            labelTitle2.Location = new Point(12, this.Height - 79);
            textBoxTenBanVe.Location = new Point(166, this.Height - 76);
        }

        private void panelMain_SizeChanged(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            List<BanVe> danhSachBanVe = BS_BanVe.DanhSachBanVe();
            int y = 0, i = 1;
            foreach (BanVe value in danhSachBanVe)
            {
                UserControl_BanVe controlBanVe = new UserControl_BanVe(value.TenBanVe, value.NgayChinhSua, i);
                controlBanVe.Width = panelMain.Width;
                controlBanVe.Location = new Point(0, y);
                controlDanhSachBanVe.Add(controlBanVe);
                panelMain.Controls.Add(controlBanVe);
                y += 30; i++;
            }
            foreach (UserControl_BanVe value in controlDanhSachBanVe)
            {
                value.LinkLabelBanVe.Click += new System.EventHandler(controlDanhSachBanVe_Click);
            }
        }

        private void textBoxTenBanVe_TextChanged(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            List<BanVe> danhSachBanVe = BS_BanVe.TimKiemBanVe(textBoxTenBanVe.Text);
            int y = 0, i = 1;
            foreach (BanVe value in danhSachBanVe)
            {
                UserControl_BanVe controlBanVe = new UserControl_BanVe(value.TenBanVe, value.NgayChinhSua, i);
                controlBanVe.Width = panelMain.Width;
                controlBanVe.Location = new Point(0, y);
                controlDanhSachBanVe.Add(controlBanVe);
                panelMain.Controls.Add(controlBanVe);
                y += 30; i++;
            }
            foreach (UserControl_BanVe value in controlDanhSachBanVe)
            {
                value.LinkLabelBanVe.Click += new System.EventHandler(controlDanhSachBanVe_Click);
            }
        }
    }
}