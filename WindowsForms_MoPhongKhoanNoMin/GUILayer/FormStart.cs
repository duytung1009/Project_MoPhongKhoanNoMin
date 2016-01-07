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
    public partial class FormStart : DevExpress.XtraEditors.XtraForm
    {
        private String idTemplate, pathTemplate;
        List<HoChieu> danhSachHoChieu = new List<HoChieu>();
        List<HyperlinkLabelControl> duongDanHoChieu = new List<HyperlinkLabelControl>();
        List<Label> ngayBanVe = new List<Label>();
        List<Label> textLabel = new List<Label>();
        List<RadioButton> radioButtonTemplate = new List<RadioButton>();

        // khai báo 1 hàm delegate
        public delegate void GetData(String idHoChieu);
        // khai báo 1 kiểu hàm delegate
        public GetData MyGetData;

        public FormStart()
        {
            InitializeComponent();
            //set title
            labelFormTitle.Text = this.Text;
            //nhóm các controls
            duongDanHoChieu.Add(banVe1);
            duongDanHoChieu.Add(banVe2);
            duongDanHoChieu.Add(banVe3);
            duongDanHoChieu.Add(banVe4);
            duongDanHoChieu.Add(banVe5);
            ngayBanVe.Add(labelNgay1);
            ngayBanVe.Add(labelNgay2);
            ngayBanVe.Add(labelNgay3);
            ngayBanVe.Add(labelNgay4);
            ngayBanVe.Add(labelNgay5);
            textLabel.Add(labelText1);
            textLabel.Add(labelText2);
            textLabel.Add(labelText3);
            //UI
            this.BackColor = Properties.Settings.Default.FormBackgroundColor;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.BackColor = ColorTranslator.FromHtml("#e74c3c");
            buttonTaoMoi.FlatAppearance.BorderSize = 0;
            buttonTaoMoi.BackColor = Properties.Settings.Default.ButtonColor;            
            foreach (RadioButton rb in radioButtonTemplate)
            {
                rb.FlatAppearance.BorderSize = 5;
                rb.CheckedChanged += new System.EventHandler(radioButtonTempGroups_CheckedChanged);
            }
            foreach(Label value in textLabel)
            {
                value.ForeColor = Properties.Settings.Default.TextColor;
            }
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            List<Template> danhSachTemplate = BS_Template.DanhSachTemplate();
            int i = 1, x = 10, y = 10;
            foreach (Template value in danhSachTemplate)
            {
                RadioButton rbt = new RadioButton();
                rbt.Name = value.ID;
                rbt.Location = new Point(x, y);
                rbt.Appearance = System.Windows.Forms.Appearance.Button;
                rbt.Size = new Size(160, 90);
                rbt.FlatStyle = FlatStyle.Flat;
                rbt.FlatAppearance.BorderSize = 3;
                rbt.BackgroundImageLayout = ImageLayout.Stretch;
                rbt.Text = value.TenTemplate;
                rbt.ForeColor = Properties.Settings.Default.FormBackgroundColor;
                rbt.TextAlign = ContentAlignment.TopLeft;
                rbt.Cursor = Cursors.Hand;
                if (!value.AnhMau.Equals(""))
                { rbt.BackgroundImage = Image.FromFile(value.AnhMau); }
                radioButtonTemplate.Add(rbt);
                panelMain.Controls.Add(rbt);
                if (i % 2 == 0)
                { x = 10; y = y + 100; }
                else
                { x = x + 170; }
                i++;
            }
            foreach (RadioButton rb in radioButtonTemplate)
            {
                rb.FlatAppearance.BorderSize = 2;
                rb.CheckedChanged += new System.EventHandler(radioButtonTempGroups_CheckedChanged);
            }

            danhSachHoChieu = BS_HoChieu.DanhSachHoChieuGanNhat(5);
            i = 0;
            foreach (HyperlinkLabelControl value in duongDanHoChieu)
            {
                if (danhSachHoChieu.Count > i)
                {
                    value.Text = danhSachHoChieu[i].TenHoChieu;
                    value.Click += new System.EventHandler(link_Click);
                    i++;
                }
            }
            i = 0;
            foreach (Label value in ngayBanVe)
            {
                if (danhSachHoChieu.Count > i)
                {
                    value.Text = BS_BanVe.BanVe(danhSachHoChieu[i].MaBanVe).NgayChinhSua;
                    i++;
                }
                this.Refresh();
            }
        }

        private void FormStart_Shown(object sender, EventArgs e)
        {
            if (radioButtonTemplate.IsValidIndex(0))
            {
                radioButtonTemplate[0].Checked = true;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void link_Click(object sender, EventArgs e)
        {
            HyperlinkLabelControl linkBanVe = sender as HyperlinkLabelControl;
            switch (linkBanVe.Name)
            {
                case "banVe1":
                    MyGetData(danhSachHoChieu[0].MaHoChieu.ToString());
                    break;
                case "banVe2":
                    MyGetData(danhSachHoChieu[1].MaHoChieu.ToString());
                    break;
                case "banVe3":
                    MyGetData(danhSachHoChieu[2].MaHoChieu.ToString());
                    break;
                case "banVe4":
                    MyGetData(danhSachHoChieu[3].MaHoChieu.ToString());
                    break;
                case "banVe5":
                    MyGetData(danhSachHoChieu[4].MaHoChieu.ToString());
                    break;
                default:
                    break;
            }
            this.Close();
        }

        private void radioButtonTempGroups_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                rb.ForeColor = Properties.Settings.Default.PrimaryColor;                
            }
            else
            {
                rb.ForeColor = Properties.Settings.Default.FormBackgroundColor;
            }
        }
    }
}