using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_MoPhongKhoanNoMin.BusinessLayer
{
    public class DatDa
    {
        private String maDatDa;
        private String tenDatDa;
        private double hS_KienCo_TB;
        private double heSoDatDa;
        private String tinhChat;
        private double dungTrong;
        private double kCTB_KhoiNut;
        private double kT_HAT_MAX;

        public String MaDatDa { get { return maDatDa; } set { maDatDa = value; } }
        public String TenDatDa { get { return tenDatDa; } set { tenDatDa = value; } }
        public double HS_KienCo_TB { get { return hS_KienCo_TB; } set { hS_KienCo_TB = value; } }
        public double HeSoDatDa { get { return heSoDatDa; } set { heSoDatDa = value; } }
        public String TinhChat { get { return tinhChat; } set { tinhChat = value; } }
        public double DungTrong { get { return dungTrong; } set { dungTrong = value; } }
        public double KCTB_KhoiNut { get { return kCTB_KhoiNut; } set { kCTB_KhoiNut = value; } }
        public double KT_HAT_MAX { get { return kT_HAT_MAX; } set { kT_HAT_MAX = value; } }

        public DatDa()
        {
            this.maDatDa = null;
            this.tenDatDa = null;
            this.hS_KienCo_TB = -1;
            this.heSoDatDa = -1;
            this.tinhChat = null;
            this.dungTrong = -1;
            this.kCTB_KhoiNut = -1;
            this.kT_HAT_MAX = -1;
        }

        public DatDa(String _maDatDa, String _tenDatDa, double _hS_KienCo_TB, double _heSoDatDa, String _tinhChat, double _dungTrong, double _kCTB_KhoiNut, double _kT_HAT_MAX)
        {
            this.maDatDa = _maDatDa;
            this.tenDatDa = _tenDatDa;
            this.hS_KienCo_TB = _hS_KienCo_TB;
            this.heSoDatDa = _heSoDatDa;
            this.tinhChat = _tinhChat;
            this.dungTrong = _dungTrong;
            this.kCTB_KhoiNut = _kCTB_KhoiNut;
            this.kT_HAT_MAX = _kT_HAT_MAX;
        }
    }
}
