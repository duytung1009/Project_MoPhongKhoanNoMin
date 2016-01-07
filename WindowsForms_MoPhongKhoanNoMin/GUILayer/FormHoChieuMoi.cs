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
using System.IO;

using WindowsForms_MoPhongKhoanNoMin.BusinessLayer;
using WindowsForms_MoPhongKhoanNoMin.CustomControls;

namespace WindowsForms_MoPhongKhoanNoMin.GUILayer
{
    public partial class FormHoChieuMoi : DevExpress.XtraEditors.XtraForm
    {
        private String idTemplate, pathTemplate;
        List<RadioButton> radioButtonTemplate = new List<RadioButton>();
        //List<UserControl_PreviewButton> previewButtonTemplate = new List<UserControl_PreviewButton>();

        // khai báo 1 hàm delegate
        public delegate void GetData(String idBanVe);
        // khai báo 1 kiểu hàm delegate
        public GetData MyGetData;

        public FormHoChieuMoi()
        {
            InitializeComponent();
            //UI
            this.BackColor = Properties.Settings.Default.FormBackgroundColor;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            labelScrollBar.BackColor = this.BackColor;
            buttonTaoMoi.FlatAppearance.BorderSize = 0;
            buttonTaoMoi.BackColor = Properties.Settings.Default.ButtonColor;          
            panelMain.BackColor = Properties.Settings.Default.SecondaryColor;
            labelTitle.ForeColor = Properties.Settings.Default.TextColor;
            labelTitle2.ForeColor = Properties.Settings.Default.TextColor;
        }

        private void FormBanVeMoi_Load(object sender, EventArgs e)
        {
            List<Template> danhSachTemplate = BS_Template.DanhSachTemplate();
            int i = 1, x = 10, y = 5;
            foreach (Template value in danhSachTemplate)
            {
                RadioButton rbt = new RadioButton();
                //rbt.Name = "radioButton" + i.ToString();
                rbt.Name = value.ID;
                rbt.Location = new Point(x, y);
                rbt.Appearance = System.Windows.Forms.Appearance.Button;
                rbt.Size = new Size(160, 90);
                rbt.FlatStyle = FlatStyle.Flat;
                rbt.FlatAppearance.BorderSize = 3;
                rbt.BackgroundImageLayout = ImageLayout.Stretch;
                rbt.Text = value.TenTemplate;
                rbt.ForeColor = Properties.Settings.Default.SecondaryColor;
                rbt.TextAlign = ContentAlignment.TopLeft;
                rbt.Cursor = Cursors.Hand;
                if (!value.AnhMau.Equals(""))
                    { rbt.BackgroundImage = Image.FromFile(value.AnhMau); }                          
                radioButtonTemplate.Add(rbt);
                panelMain.Controls.Add(rbt);
                //UserControl_PreviewButton previewButton = new UserControl_PreviewButton(value.TenTemplate, value.AnhMau, value.DuongDan);
                //previewButton.Name = "radioButton" + i.ToString();
                //previewButton.Location = new Point(x, y);
                //panel1.Controls.Add(previewButton);
                if (i % 2 == 0)
                    { x = x + 170; y = 5; }
                else
                    { y = y + 100; }                     
                i++;
            }
            foreach (RadioButton rb in radioButtonTemplate)
            {
                rb.FlatAppearance.BorderSize = 2;
                rb.CheckedChanged += new System.EventHandler(radioButtonTempGroups_CheckedChanged);
            }
        }

        private void FormBanVeMoi_Shown(object sender, EventArgs e)
        {
            if (radioButtonTemplate.IsValidIndex(0))
            {
                radioButtonTemplate[0].Checked = true;
            }
            textBoxTenBanVe.Focus();
        }

        private void buttonTaoMoi_Click(object sender, EventArgs e)
        {
            if (textBoxTenBanVe.Text.Equals(""))
            {
                MessageBox.Show("Chưa nhập tên hộ chiếu");
                return;
            }
            foreach (RadioButton value in radioButtonTemplate)
            {
                if (value.Checked)
                {
                    idTemplate = value.Name;
                    pathTemplate = BS_Template.ChonTemplate(idTemplate).DuongDan;
                }
            }
            //tạo id hộ chiếu, gán cho biến toàn cục
            String idHoChieu = BS_HoChieu.TaoHoChieu(idTemplate, textBoxTenBanVe.Text);        
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

        private void radioButtonTempGroups_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                //rb.ForeColor = ColorTranslator.FromHtml("#00E676"); //green code
                rb.ForeColor = Color.White;
            }
            else
            {
                //rb.ForeColor = ColorTranslator.FromHtml("#B0BEC5");
                rb.ForeColor = Properties.Settings.Default.SecondaryColor;
            }
        }
    }
}