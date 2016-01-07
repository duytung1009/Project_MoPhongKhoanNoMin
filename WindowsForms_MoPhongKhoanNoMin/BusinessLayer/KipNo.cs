using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_MoPhongKhoanNoMin.BusinessLayer
{
    public class KipNo
    {
        private String maKipNo;
        private String tenKipNo;
        private String thoiGianViSai;
        private double donViTinh_KN;
        private double giaThanh_KN;

        public String MaKipNo { get { return maKipNo; } set { maKipNo = value; } }
        public String TenKipNo { get { return tenKipNo; } set { tenKipNo = value; } }
        public String ThoiGianViSai { get { return thoiGianViSai; } set { thoiGianViSai = value; } }
        public double DonViTinh_KN { get { return donViTinh_KN; } set { donViTinh_KN = value; } }
        public double GiaThanh_KN { get { return giaThanh_KN; } set { giaThanh_KN = value; } }

        public KipNo()
        {
            this.maKipNo = null;
            this.tenKipNo = null;
            this.thoiGianViSai = null;
            this.donViTinh_KN = -1;
            this.giaThanh_KN = -1;
        }

        public KipNo(String _maKipNo, String _tenKipNo, String _thoiGianViSai, double _donViTinh_KN, double _giaThanh_KN)
        {
            this.maKipNo = _maKipNo;
            this.tenKipNo = _tenKipNo;
            this.thoiGianViSai = _thoiGianViSai;
            this.donViTinh_KN = _donViTinh_KN;
            this.giaThanh_KN = _giaThanh_KN;
        }
    }
}
