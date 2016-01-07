using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_MoPhongKhoanNoMin.BusinessLayer
{
    class CapDoNo
    {
        private String maCapDo;
        private String tenCapDo;
        private double chiTieuThuocNo;
        private String doCungDatDa;

        public String MaCapDo { get { return maCapDo; } set { maCapDo = value; } }
        public String TenCapDo { get { return tenCapDo; } set { tenCapDo = value; } }
        public double ChiTieuThuocNo { get { return chiTieuThuocNo; } set { chiTieuThuocNo = value; } }
        public String DoCungDatDa { get { return doCungDatDa; } set { doCungDatDa = value; } }

        public CapDoNo()
        {
            this.maCapDo = null;
            this.tenCapDo = null;
            this.chiTieuThuocNo = -1;
            this.doCungDatDa = null;
        }

        public CapDoNo(String _MaCapDo, String _TenCapDo, double _ChiTieuThuocNo, String _DoCungDatDa)
        {
            this.maCapDo = _MaCapDo;
            this.tenCapDo = _TenCapDo;
            this.chiTieuThuocNo = _ChiTieuThuocNo;
            this.doCungDatDa = _DoCungDatDa;
        }
    }
}
