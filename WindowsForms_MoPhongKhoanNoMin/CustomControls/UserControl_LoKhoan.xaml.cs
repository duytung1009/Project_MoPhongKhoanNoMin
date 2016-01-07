using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for UserControl_LoKhoan.xaml
    /// </summary>
    public partial class UserControl_LoKhoan : UserControl, INotifyPropertyChanged
    {
        //http://stackoverflow.com/questions/13325617/i-cant-data-bind-to-a-local-variable-in-wpf-xaml post 3
        private int caoDo1, caoDo2, caoDo3, caoDo4, caoDoText1, caoDoText2, caoDoText3, caoDoText4;
        public int CaoDo1 { get { return this.caoDo1; } set { this.caoDo1 = value; OnPropertyChanged("CaoDo1"); } }
        public int CaoDo2 { get { return this.caoDo2; } set { this.caoDo2 = value; OnPropertyChanged("CaoDo2"); } }
        public int CaoDo3 { get { return this.caoDo3; } set { this.caoDo3 = value; OnPropertyChanged("CaoDo3"); } }
        public int CaoDo4 { get { return this.caoDo4; } set { this.caoDo4 = value; OnPropertyChanged("CaoDo4"); } }
        public int CaoDoText1 { get { return this.caoDoText1; } set { this.caoDoText1 = value; OnPropertyChanged("CaoDoText1"); } }
        public int CaoDoText2 { get { return this.caoDoText2; } set { this.caoDoText2 = value; OnPropertyChanged("CaoDoText2"); } }
        public int CaoDoText3 { get { return this.caoDoText3; } set { this.caoDoText3 = value; OnPropertyChanged("CaoDoText3"); } }
        public int CaoDoText4 { get { return this.caoDoText4; } set { this.caoDoText4 = value; OnPropertyChanged("CaoDoText4"); } }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public UserControl_LoKhoan()
        {
            InitializeComponent();
        }

        public UserControl_LoKhoan(int _caoDo1, int _caoDo2, int _caoDo3, int _caoDo4)
        {
            InitializeComponent();
            CaoDo1 = _caoDo1;
            CaoDo2 = _caoDo2;
            CaoDo3 = _caoDo3;
            CaoDo4 = _caoDo4;
            caoDoText1 = _caoDo1 + 20;
            caoDoText2 = _caoDo2 + 20;
            caoDoText3 = _caoDo3 + 20;
            caoDoText4 = _caoDo4 + 20;
        }

        public void HienLoKhoan()
        {
            Storyboard sb1 = this.FindResource("HienLoKhoanL1") as Storyboard;
            Storyboard.SetTarget(sb1, this.L1);
            Storyboard sb2 = this.FindResource("HienLoKhoanL2") as Storyboard;
            Storyboard.SetTarget(sb2, this.L2);
            Storyboard sb3 = this.FindResource("HienLoKhoanL3") as Storyboard;
            Storyboard.SetTarget(sb3, this.L3);
            Storyboard sb4 = this.FindResource("HienLoKhoanL4") as Storyboard;
            Storyboard.SetTarget(sb4, this.L4);
            Storyboard sbLabel1 = this.FindResource("HienLoKhoanLabel1") as Storyboard;
            Storyboard.SetTarget(sbLabel1, this.Label1);
            Storyboard sbLabel2 = this.FindResource("HienLoKhoanLabel2") as Storyboard;
            Storyboard.SetTarget(sbLabel2, this.Label2);
            Storyboard sbLabel3 = this.FindResource("HienLoKhoanLabel3") as Storyboard;
            Storyboard.SetTarget(sbLabel3, this.Label3);
            Storyboard sbLabel4 = this.FindResource("HienLoKhoanLabel4") as Storyboard;
            Storyboard.SetTarget(sbLabel4, this.Label4);
            sb1.Begin();
            sb2.Begin();
            sb3.Begin();
            sb4.Begin();
            sbLabel1.Begin();
            sbLabel2.Begin();
            sbLabel3.Begin();
            sbLabel4.Begin();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            //HienLoKhoan();
        }
    }
}
