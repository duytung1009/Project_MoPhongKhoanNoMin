using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace WindowsForms_MoPhongKhoanNoMin.CustomControls
{
    public partial class Loading : Form
    {
        private int i = 1;

        public Loading()
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.ButtonColor;
            timer1.Tick += new System.EventHandler(OnTimerEvent);
        }

        private void Loading_Shown(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void OnTimerEvent(object sender, EventArgs e)
        {
            switch(i)
            {
                case 1:
                    label1.Text = "LOADING.";
                    i = 2;
                    break;
                case 2:
                    label1.Text = "LOADING..";
                    i = 3;
                    break;
                case 3:
                    label1.Text = "LOADING...";
                    i = 1;
                    break;
            }                      
        }
    }
}
