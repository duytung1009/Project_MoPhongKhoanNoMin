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
using WindowsForms_MoPhongKhoanNoMin.CustomControls;

namespace WindowsForms_MoPhongKhoanNoMin.GUILayer
{
    public partial class FormTest : DevExpress.XtraEditors.XtraForm
    {
        DataViewer dv = new DataViewer();

        public FormTest()
        {
            InitializeComponent();
            //UI
            this.BackColor = Properties.Settings.Default.FormBackgroundColor;
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            HienThiLoKhoan();
        }

        private void HienThiLoKhoan()
        {
            List<MayKhoan> dsMayKhoan = BS_MayKhoan.DanhSachMayKhoan();
            elementHost1.Child = dv;
            dv.AddData<MayKhoan>(dsMayKhoan);
        }
    }
}