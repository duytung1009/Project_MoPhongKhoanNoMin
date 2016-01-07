using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_MoPhongKhoanNoMin.BusinessLayer
{
    public class ThuocNo
    {
        private String maThuocNo;
        private String tenThuocNo;
        private double tocDoNo;
        private double khaNangSinhCong;
        private double matDoNapThuoc;
        private String chiuNuoc;
        private double hS_ChuyenDoi;
        private double donViTinh_TN;
        private double giaThanh_TN;

        public String MaThuocNo { get { return maThuocNo; } set { maThuocNo = value; } }
        public String TenThuocNo { get { return tenThuocNo; } set { tenThuocNo = value; } }
        public double TocDoNo { get { return tocDoNo; } set { tocDoNo = value; } }
        public double KhaNangSinhCong { get { return khaNangSinhCong; } set { khaNangSinhCong = value; } }
        public double MatDoNapThuoc { get { return matDoNapThuoc; } set { matDoNapThuoc = value; } }
        public String ChiuNuoc { get { return chiuNuoc; } set { chiuNuoc = value; } }
        public double HS_ChuyenDoi { get { return hS_ChuyenDoi; } set { hS_ChuyenDoi = value; } }
        public double DonViTinh_TN { get { return donViTinh_TN; } set { donViTinh_TN = value; } }
        public double GiaThanh_TN { get { return giaThanh_TN; } set { giaThanh_TN = value; } }

        public ThuocNo()
        {
            this.maThuocNo = null;
            this.tenThuocNo = null;
            this.tocDoNo = -1;
            this.khaNangSinhCong = -1;
            this.matDoNapThuoc = -1;
            this.chiuNuoc = null;
            this.hS_ChuyenDoi = -1;
            this.donViTinh_TN = -1;
            this.giaThanh_TN = -1;
        }

        public ThuocNo(String _maThuocNo, String _tenThuocNo, double _tocDoNo, double _khaNangSinhCong, double _matDoNapThuoc, String _chiuNuoc, double _hS_ChuyenDoi, double _donViTinh_TN, double _giaThanh_TN)
        {
            this.maThuocNo = _maThuocNo;
            this.tenThuocNo = _tenThuocNo;
            this.tocDoNo = _tocDoNo;
            this.khaNangSinhCong = _khaNangSinhCong;
            this.matDoNapThuoc = _matDoNapThuoc;
            this.chiuNuoc = _chiuNuoc;
            this.hS_ChuyenDoi = _hS_ChuyenDoi;
            this.donViTinh_TN = _donViTinh_TN;
            this.giaThanh_TN = _giaThanh_TN;
        }
    }
}
