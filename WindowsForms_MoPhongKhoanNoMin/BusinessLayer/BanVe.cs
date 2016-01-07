using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_MoPhongKhoanNoMin.BusinessLayer
{
    class BanVe
    {
        private String iD;
        private String template;
        private String tenbanve;
        private String ngayChinhSua;
        private double deltaX;
        private double deltaY;
        private String nguoiDung;
        private bool hienKhoangCach;

        public String ID { get { return iD; } set { iD = value; } }
        public String Template { get { return template; } set { template = value; } }
        public String TenBanVe { get { return tenbanve; } set { tenbanve = value; } }
        public String NgayChinhSua { get { return ngayChinhSua; } set { ngayChinhSua = value; } }
        public double DeltaX { get { return deltaX; } set { deltaX = value; } }
        public double DeltaY { get { return deltaY; } set { deltaY = value; } }
        public String NguoiDung { get { return nguoiDung; } set { nguoiDung = value; } }
        public bool HienKhoangCach { get { return hienKhoangCach; } set { hienKhoangCach = value; } }

        public BanVe()
        {
            this.iD = null;
            this.template = "1";
            this.tenbanve = null;
            this.ngayChinhSua = null;
            this.deltaX = -1;
            this.deltaY = -1;
            this.nguoiDung = null;
            this.hienKhoangCach = false;
        }

        public BanVe(String _ID, String _Template, String _TenBanVe, String _NgayChinhSua, double _deltaX, double _deltaY, String _NguoiDung, bool _HienKhoangCach)
        {
            this.iD = _ID;
            this.template = _Template;
            this.tenbanve = _TenBanVe;
            this.ngayChinhSua = _NgayChinhSua;
            this.deltaX = _deltaX;
            this.deltaY = _deltaY;
            this.nguoiDung = _NguoiDung;
            this.hienKhoangCach = _HienKhoangCach;
        }
    }
}
