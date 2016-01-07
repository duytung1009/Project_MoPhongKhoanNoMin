using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_MoPhongKhoanNoMin.BusinessLayer
{
    public class MayKhoan
    {
        private String maMayKhoan;
        private String tenMayKhoan;
        private double duongKinhLoKhoan;
        private String huongKhoan;
        private double chieuSau;

        public String MaMayKhoan { get { return maMayKhoan; } set { maMayKhoan = value; } }
        public String TenMayKhoan { get { return tenMayKhoan; } set { tenMayKhoan = value; } }
        public double DuongKinhLoKhoan { get { return duongKinhLoKhoan; } set { duongKinhLoKhoan = value; } }
        public String HuongKhoan { get { return huongKhoan; } set { huongKhoan = value; } }
        public double ChieuSau { get { return chieuSau; } set { chieuSau = value; } }

        public MayKhoan()
        {
            this.maMayKhoan = null;
            this.tenMayKhoan = null;
            this.duongKinhLoKhoan = 0;
            this.huongKhoan = null;
            this.chieuSau = 0;
        }

        public MayKhoan(String _maMayKhoan, String _tenMayKhoan, double _duongKinhLoKhoan, String _huongKhoan, double _chieuSau)
        {
            this.maMayKhoan = _maMayKhoan;
            this.tenMayKhoan = _tenMayKhoan;
            this.duongKinhLoKhoan = _duongKinhLoKhoan;
            this.huongKhoan = _huongKhoan;
            this.chieuSau = _chieuSau;
        }
    }
}
