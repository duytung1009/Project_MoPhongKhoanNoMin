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
    public partial class UserControl_PreviewButton : UserControl
    {
        private String _Path;

        public String Path { get { return _Path; } set { _Path = value; } }
        public bool Check { get { return radioButtonTemp.Checked; } set { radioButtonTemp.Checked = value; } }

        public UserControl_PreviewButton()
        {
            InitializeComponent();
        }

        public UserControl_PreviewButton(String _name, String _image, String _path)
        {
            InitializeComponent();
            this.radioButtonTemp.Text = _name;
            if(!_image.Equals(""))
            {
                this.radioButtonTemp.BackgroundImage = Image.FromFile(_image);
            }           
            this._Path = _path;
            this.radioButtonTemp.FlatAppearance.BorderSize = 3;
        }

        private void radioButtonTemp_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTemp.Checked)
            {
                radioButtonTemp.ForeColor = ColorTranslator.FromHtml("#90A4AE");
            }
            else
            {
                radioButtonTemp.ForeColor = Color.WhiteSmoke;
            }
        }
    }
}
