using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_MoPhongKhoanNoMin.CustomControls
{
    public partial class UserControl_BanVe : UserControl
    {
        //private String tenBanVe;
        //private String ngayChinhSua;
        //public String TenBanVe { get { return this.tenBanVe; } set { this.tenBanVe = value; } }
        //public String NgayChinhSua { get { return this.ngayChinhSua; } set { this.ngayChinhSua = value; } }
        public LinkLabel LinkLabelBanVe { get { return this.linkLabel; } set { this.linkLabel = value; } }
        public Label LabelNgayChinhSua { get { return this.label; } set { this.label = value; } }

        public UserControl_BanVe()
        {
            InitializeComponent();
        }

        public UserControl_BanVe(String _tenBanVe, String _ngayChinhSua, int stt)
        {
            InitializeComponent();
            //this.tenBanVe = _tenBanVe;
            //this.ngayChinhSua = _ngayChinhSua;
            this.linkLabel.Text = _tenBanVe;
            this.label.Text = _ngayChinhSua;
            if(stt%2 == 0)
            {
                this.BackColor = Properties.Settings.Default.PrimaryColor;
            }
            else
            {
                this.BackColor = Properties.Settings.Default.ButtonColor;
            }
        }
    }
}
