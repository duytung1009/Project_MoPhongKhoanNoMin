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
    public partial class FormThongTinBanVe : DevExpress.XtraEditors.XtraForm
    {
        private String idHoChieu;
        List<Label> textLabel = new List<Label>();
        List<Label> valueLabel = new List<Label>();

        public FormThongTinBanVe()
        {
            InitializeComponent();
        }

        public FormThongTinBanVe(String _idHoChieu)
        {
            InitializeComponent();
            //lấy id bản vẽ
            idHoChieu = _idHoChieu;
            //add text control
            textLabel.Add(labelTitle1);
            textLabel.Add(labelTitle2);
            textLabel.Add(label_TenBanVe);
            textLabel.Add(label_Template);
            textLabel.Add(label_NgayChinhSua);
            textLabel.Add(label_SoLoKhoan);
            //UI
            this.BackColor = Properties.Settings.Default.FormBackgroundColor;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            foreach (Label l in textLabel)
            {
                l.ForeColor = Properties.Settings.Default.TextColor;
            }
        }

        private void FormThongTinBanVe_Load(object sender, EventArgs e)
        {
            if(idHoChieu == null)
            {
                MessageBox.Show("Thông tin hộ chiếu chưa được lưu trong CSDL");
                this.Close();
                return;
            }
            BanVe value = BS_BanVe.BanVe(BS_HoChieu.HoChieu(idHoChieu).MaBanVe);
            labelValue_TenBanVe.Text = value.TenBanVe;
            labelValue_Template.Text = BS_Template.ChonTemplate(value.Template).TenTemplate;
            labelValue_NgayChinhSua.Text = value.NgayChinhSua;
            labelValue_SoLoKhoan.Text = BS_LoKhoan.DanhSachLoKhoan(idHoChieu).Count.ToString();
        }
    }
}