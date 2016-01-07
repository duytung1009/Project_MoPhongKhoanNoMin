using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_MoPhongKhoanNoMin.BusinessLayer
{
    public class KipDien
    {
        private String iDLoKhoan;
        private double thoiGian;

        public String IDLoKhoan { get { return iDLoKhoan; } set { iDLoKhoan = value; } }
        public double ThoiGian { get { return thoiGian; } set { thoiGian = value; } }

        public KipDien()
        {
            this.iDLoKhoan = null;
            this.thoiGian = 0;
        }

        public KipDien(String _iDLoKhoan, double _thoiGian)
        {
            this.iDLoKhoan = _iDLoKhoan;
            this.thoiGian = _thoiGian;
        }
    }
}
