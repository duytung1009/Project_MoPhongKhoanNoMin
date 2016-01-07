using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_MoPhongKhoanNoMin.BusinessLayer
{
    class LoKhoan
    {
        private String iD;
        private String maHoChieu;
        private String maBanVe;
        private String maMayKhoan;
        private String maLoKhoan;    
        private double banKinh;
        private double chieuSau;
        private String huongKhoan;
        private double toaDoX;
        private double toaDoY;
        private double lt;
        private double lkk;
        private double l0;
        private double lbua;

        public String ID { get { return iD; } set { iD = value; } }
        public String MaHoChieu { get { return maHoChieu; } set { maHoChieu = value; } }
        public String MaBanVe { get { return maBanVe; } set { maBanVe = value; } }
        public String MaMayKhoan { get { return maMayKhoan; } set { maMayKhoan = value; } }
        public String MaLoKhoan { get { return maLoKhoan; } set { maLoKhoan = value; } }     
        public double BanKinh { get { return banKinh; } set { banKinh = value; } }
        public double ChieuSau { get { return chieuSau; } set { chieuSau = value; } }
        public String HuongKhoan { get { return huongKhoan; } set { huongKhoan = value; } }
        public double ToaDoX { get { return toaDoX; } set { toaDoX = value; } }
        public double ToaDoY { get { return toaDoY; } set { toaDoY = value; } }
        public double Lt { get { return lt; } set { lt = value; } }
        public double Lkk { get { return lkk; } set { lkk = value; } }
        public double L0 { get { return l0; } set { l0 = value; } }
        public double Lbua { get { return lbua; } set { lbua = value; } }

        public LoKhoan()
        {
            this.iD = null;
            this.maHoChieu = null;
            this.maBanVe = null;
            this.maMayKhoan = null;
            this.maLoKhoan = null;            
            this.banKinh = 0;
            this.chieuSau = 0;
            this.huongKhoan = null;
            this.toaDoX = 0;
            this.toaDoY = 0;
            this.lt = 0;
            this.lkk = 0;
            this.l0 = 0;
            this.lbua = 0;
        }

        public LoKhoan(String _iD, String _maHoChieu, String _maBanVe, String _maMayKhoan , String _maLoKhoan, double _banKinh, double _chieuSau, String _huongKhoan, double _toaDoX, double _toaDoY, double _lt, double _lkk, double _l0, double _lbua)
        {
            this.iD = _iD;
            this.maHoChieu = _maHoChieu;
            this.maBanVe = _maBanVe;
            this.maMayKhoan = _maMayKhoan;
            this.maLoKhoan = _maLoKhoan;           
            this.banKinh = _banKinh;
            this.chieuSau = _chieuSau;
            this.huongKhoan = _huongKhoan;
            this.toaDoX = _toaDoX;
            this.toaDoY = _toaDoY;
            this.lt = _lt;
            this.lkk = _lkk;
            this.l0 = _l0;
            this.lbua = _lbua;
        }

        public LoKhoan(String maHoChieu, Circle c)
        {
            this.iD = null;
            this.maHoChieu = maHoChieu;
            this.maBanVe = BS_HoChieu.HoChieu(maHoChieu).MaBanVe;
            this.maMayKhoan = null;
            this.maLoKhoan = c.GetID().ToString();
            this.banKinh = c.GetRadius();
            this.chieuSau = 0;
            this.huongKhoan = null;
            this.toaDoX = c.GetX();
            this.toaDoY = c.GetY();
            this.lt = 0;
            this.lkk = 0;
            this.l0 = 0;
            this.lbua = 0;
        }
    }
}
