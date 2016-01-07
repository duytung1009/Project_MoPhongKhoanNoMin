using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WindowsForms_MoPhongKhoanNoMin.CustomControls
{
    /// <summary>
    /// Interaction logic for DataViewer.xaml
    /// </summary>
    public partial class DataViewer : UserControl
    {
        private bool hidden;

        public DataViewer()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            //HideNotify();
        }

        public void AddData<T>(List<T> list)
        {
            dataGrid.ItemsSource = list;
        }

        public void ShowNotify()
        {
            Storyboard sb1 = this.FindResource("ShowOptionGrid") as Storyboard;
            Storyboard sb2 = this.FindResource("ShowOptionBar") as Storyboard;
            Storyboard sb3 = this.FindResource("ShowOptionButton") as Storyboard;
            Storyboard.SetTarget(sb1, this.dataGrid);
            Storyboard.SetTarget(sb2, this.optionBar);
            Storyboard.SetTarget(sb3, this.buttonShow);
            sb1.Begin(); sb2.Begin(); sb3.Begin();
            hidden = false;
        }

        public void HideNotify()
        {
            Storyboard sb1 = this.FindResource("HideOptionGrid") as Storyboard;
            Storyboard sb2 = this.FindResource("HideOptionBar") as Storyboard;
            Storyboard sb3 = this.FindResource("HideOptionButton") as Storyboard;
            Storyboard.SetTarget(sb1, this.dataGrid);
            Storyboard.SetTarget(sb2, this.optionBar);
            Storyboard.SetTarget(sb3, this.buttonShow);
            sb1.Begin(); sb2.Begin(); sb3.Begin();
            hidden = true;
        }

        private void buttonShow_Click(object sender, RoutedEventArgs e)
        {
            if (hidden)
            {
                ShowNotify();
            }
            else
            {
                HideNotify();
            }
        }
    }
}
