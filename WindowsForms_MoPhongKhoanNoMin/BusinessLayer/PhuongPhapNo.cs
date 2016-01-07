using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_MoPhongKhoanNoMin.BusinessLayer
{
    public class PhuongPhapNo
    {
        private String maPPNo;
        private String tenPPNo;
        private String maCongTruong;
        private double heSoKienCo;
        private double heSoPPNo;

        public String MaPPNo { get { return maPPNo; } set { maPPNo = value; } }
        public String TenPPNo { get { return tenPPNo; } set { tenPPNo = value; } }
        public String MaCongTruong { get { return maCongTruong; } set { maCongTruong = value; } }
        public double HeSoKienCo { get { return heSoKienCo; } set { heSoKienCo = value; } }
        public double HeSoPPNo { get { return heSoPPNo; } set { heSoPPNo = value; } }

        public PhuongPhapNo()
        {
            this.maPPNo = null;
            this.tenPPNo = null;
            this.maCongTruong = null;
            this.heSoKienCo = -1;
            this.heSoPPNo = -1;
        }

        public PhuongPhapNo(String _maPPNo, String _tenPPNo, String _maCongTruong, double _heSoKienCo, double _heSoPPNo)
        {
            this.maPPNo = _maPPNo;
            this.tenPPNo = _tenPPNo;
            this.maCongTruong = _maCongTruong;
            this.heSoKienCo = _heSoKienCo;
            this.heSoPPNo = _heSoPPNo;
        }
    }
}
