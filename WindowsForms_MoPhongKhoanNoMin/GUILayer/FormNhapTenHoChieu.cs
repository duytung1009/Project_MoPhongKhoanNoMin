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

using WindowsForms_MoPhongKhoanNoMin.BusinessLayer;

namespace WindowsForms_MoPhongKhoanNoMin.GUILayer
{
    public partial class FormNhapTenHoChieu : DevExpress.XtraEditors.XtraForm
    {
        // khai báo 1 hàm delegate
        public delegate void GetData(String tenBanVe);
        // khai báo 1 kiểu hàm delegate
        public GetData MyGetData;

        public FormNhapTenHoChieu()
        {
            InitializeComponent();
            //UI
            this.BackColor = Properties.Settings.Default.FormBackgroundColor;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            labelTitle2.ForeColor = Properties.Settings.Default.TextColor;
            buttonTaoMoi.BackColor = Properties.Settings.Default.ButtonColor;
            buttonTaoMoi.FlatAppearance.BorderSize = 0;
        }

        private void buttonTaoMoi_Click(object sender, EventArgs e)
        {
            if (textBoxTenBanVe.Text.Equals(""))
            {
                MessageBox.Show("Chưa nhập tên hộ chiếu");
                return;
            }
            String idHoChieu = BS_HoChieu.TaoHoChieu(textBoxTenBanVe.Text);
            if (idHoChieu == null)
            {
                MessageBox.Show("Hộ chiếu đã có");
                return;
            }
            else
            {
                MyGetData(idHoChieu);
                this.Close();
            }           
        }
    }
}