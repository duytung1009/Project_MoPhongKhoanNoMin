using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_MoPhongKhoanNoMin.BusinessLayer
{
    public class CongTruong
    {
        private String maCongTruong;
        private String tenCongTruong;
        private String soDienThoai;
        private double caoDiem;
        private String tang;
        private String khuVuc;

        public String MaCongTruong { get { return maCongTruong; } set { maCongTruong = value; } }
        public String TenCongTruong { get { return tenCongTruong; } set { tenCongTruong = value; } }
        public String SoDienThoai { get { return soDienThoai; } set { soDienThoai = value; } }
        public double CaoDiem { get { return caoDiem; } set { caoDiem = value; } }
        public String Tang { get { return tang; } set { tang = value; } }
        public String KhuVuc { get { return khuVuc; } set { khuVuc = value; } }

        public CongTruong()
        {
            this.maCongTruong = null;
            this.tenCongTruong = null;
            this.soDienThoai = null;
            this.caoDiem = -1;
            this.tang = null;
            this.khuVuc = null;
        }

        public CongTruong(String _maCongTruong, String _tenCongTruong, String _soDienThoai, double _caoDiem, String _tang, String _khuVuc)
        {
            this.maCongTruong = _maCongTruong;
            this.tenCongTruong = _tenCongTruong;
            this.soDienThoai = _soDienThoai;
            this.caoDiem = _caoDiem;
            this.tang = _tang;
            this.khuVuc = _khuVuc;
        }
    }
}
