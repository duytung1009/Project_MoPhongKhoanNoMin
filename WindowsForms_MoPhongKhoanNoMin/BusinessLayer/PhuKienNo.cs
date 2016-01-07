using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_MoPhongKhoanNoMin.BusinessLayer
{
    class PhuKienNo
    {
        private String maPhuKien;
        private String tenPhuKien;
        private double donViTinh_PK;
        private double giaThanh_PK;

        public String MaPhuKien { get { return maPhuKien; } set { maPhuKien = value; } }
        public String TenPhuKien { get { return tenPhuKien; } set { tenPhuKien = value; } }
        public double DonViTinh_PK { get { return donViTinh_PK; } set { donViTinh_PK = value; } }
        public double GiaThanh_PK { get { return giaThanh_PK; } set { giaThanh_PK = value; } }

        public PhuKienNo()
        {
            this.maPhuKien = null;
            this.tenPhuKien = null;
            this.donViTinh_PK = -1;
            this.giaThanh_PK = -1;
        }

        public PhuKienNo(String _maPhuKien, String _tenPhuKien, double _donViTinh_PK, double _giaThanh_PK)
        {
            this.maPhuKien = _maPhuKien;
            this.tenPhuKien = _tenPhuKien;
            this.donViTinh_PK = _donViTinh_PK;
            this.giaThanh_PK = _giaThanh_PK;
        }
    }
}
