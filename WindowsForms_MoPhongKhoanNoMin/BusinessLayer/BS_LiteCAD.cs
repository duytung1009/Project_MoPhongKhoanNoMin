using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WindowsForms_MoPhongKhoanNoMin.DataAccessLayer;
using WindowsForms_MoPhongKhoanNoMin.CustomControls;
using System.Windows.Forms.Integration;

namespace WindowsForms_MoPhongKhoanNoMin.BusinessLayer
{
    class BS_LiteCAD
    {
        public static void ShowNotifyAutoHide(ElementHost elementHost1, String text)
        {
            UserControl_Notify note = new UserControl_Notify(text);
            elementHost1.Child = note;
            note.ShowNotifyAutoHide();
        }
    }
}
