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
    /// Interaction logic for UserControl_Notify.xaml
    /// </summary>
    public partial class UserControl_Notify : UserControl
    {
        public UserControl_Notify()
        {
            InitializeComponent();
            //this.Loaded += new RoutedEventHandler(ShowNotifyAutoHide);
        }

        public UserControl_Notify(String _notify)
        {
            InitializeComponent();
            labelNotify.Content = _notify;
            //this.Loaded += new RoutedEventHandler(ShowNotifyAutoHide);
        }

        public void ShowNotifyAutoHide()
        {
            Storyboard sb = this.FindResource("ShowNotifyAutoHide") as Storyboard;
            Storyboard.SetTarget(sb, this.content);
            sb.Begin();
        }

        public void ShowNotify()
        {
            Storyboard sb = this.FindResource("ShowNotify") as Storyboard;
            Storyboard.SetTarget(sb, this.content);
            sb.Begin();
        }

        public void HideNotify()
        {
            Storyboard sb = this.FindResource("HideNotify") as Storyboard;
            Storyboard.SetTarget(sb, this.content);
            sb.Begin();
        }
    }
}
