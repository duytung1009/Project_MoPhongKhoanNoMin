using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_MoPhongKhoanNoMin.BusinessLayer
{
    public class HoChieu
    {
        private String maHoChieu;
        private String maBanVe;
        private String tenHoChieu;
        private double chieuCaoTang;
        private double quyMoDotNo;
        private String maCongTruong;
        private String maDatDa;
        private String maMayKhoan;
        private String maKipNo;
        private String maThuocNo;
        private String maPPNo;
        private String maPhuKien;
        private String maCapDo;
        private String ngayLap;
        private double heSoKC;
        private double kichThuoc_X;
        private double kichThuoc_Y;

        public String MaHoChieu { get { return maHoChieu; } set { maHoChieu = value; } }
        public String MaBanVe { get { return maBanVe; } set { maBanVe = value; } }
        public String TenHoChieu { get { return tenHoChieu; } set { tenHoChieu = value; } }
        public double ChieuCaoTang { get { return chieuCaoTang; } set { chieuCaoTang = value; } }
        public double QuyMoDotNo { get { return quyMoDotNo; } set { quyMoDotNo = value; } }
        public String MaCongTruong { get { return maCongTruong; } set { maCongTruong = value; } }
        public String MaDatDa { get { return maDatDa; } set { maDatDa = value; } }
        public String MaMayKhoan { get { return maMayKhoan; } set { maMayKhoan = value; } }
        public String MaKipNo { get { return maKipNo; } set { maKipNo = value; } }
        public String MaThuocNo { get { return maThuocNo; } set { maThuocNo = value; } }
        public String MaPPNo { get { return maPPNo; } set { maPPNo = value; } }
        public String MaPhuKien { get { return maPhuKien; } set { maPhuKien = value; } }
        public String MaCapDo { get { return maCapDo; } set { maCapDo = value; } }
        public String NgayLap { get { return ngayLap; } set { ngayLap = value; } }
        public double HeSoKC { get { return heSoKC; } set { heSoKC = value; } }
        public double KichThuoc_X { get { return kichThuoc_X; } set { kichThuoc_X = value; } }
        public double KichThuoc_Y { get { return kichThuoc_Y; } set { kichThuoc_Y = value; } }

        public HoChieu()
        {
            this.maHoChieu = null;
            this.maBanVe = null;
            this.tenHoChieu = null;
            this.chieuCaoTang = -1;
            this.quyMoDotNo = -1;
            this.maCongTruong = null;
            this.maDatDa = null;
            this.maMayKhoan = null;
            this.maKipNo = null;
            this.maThuocNo = null;
            this.maPPNo = null;
            this.maPhuKien = null;
            this.maCapDo = null;
            this.ngayLap = null;
            this.heSoKC = -1;
            this.kichThuoc_X = -1;
            this.kichThuoc_Y = -1;
        }

        public HoChieu(String _maHoChieu, String _maBanVe, String _tenHoChieu, double _chieuCaoTang, double _quyMoDotNo, String _maCongTruong, String _maDatDa, String _maMayKhoan, String _maKipNo, String _maThuocNo, String _maPPNo, String _maPhuKien, String _maCapDo, String _ngayLap, double _heSoKC, double _kichThuoc_X, double _kichThuoc_Y)
        {
            this.maHoChieu = _maHoChieu;
            this.maBanVe = _maBanVe;
            this.tenHoChieu = _tenHoChieu;
            this.chieuCaoTang = _chieuCaoTang;
            this.quyMoDotNo = _quyMoDotNo;
            this.maCongTruong = _maCongTruong;
            this.maDatDa = _maDatDa;
            this.maMayKhoan = _maMayKhoan;
            this.maKipNo = _maKipNo;
            this.maThuocNo = _maThuocNo;
            this.maPPNo = _maPPNo;
            this.maPhuKien = _maPhuKien;
            this.maCapDo = _maCapDo;
            this.ngayLap = _ngayLap;
            this.heSoKC = _heSoKC;
            this.kichThuoc_X = _kichThuoc_X;
            this.kichThuoc_Y = _kichThuoc_Y;
        }

        public HoChieu(String _maHoChieu, String _maBanVe, String _tenHoChieu)
        {
            this.maHoChieu = _maHoChieu;
            this.maBanVe = _maBanVe;
            this.tenHoChieu = _tenHoChieu;
            this.chieuCaoTang = -1;
            this.quyMoDotNo = -1;
            this.maCongTruong = null;
            this.maDatDa = null;
            this.maMayKhoan = null;
            this.maKipNo = null;
            this.maThuocNo = null;
            this.maPPNo = null;
            this.maPhuKien = null;
            this.maCapDo = null;
            this.ngayLap = null;
            this.heSoKC = -1;
            this.kichThuoc_X = -1;
            this.kichThuoc_Y = -1;
        }
    }
}
