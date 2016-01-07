using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WindowsForms_MoPhongKhoanNoMin.DataAccessLayer;

namespace WindowsForms_MoPhongKhoanNoMin.BusinessLayer
{
    class BS_DatDa
    {
        /// <summary>
        /// Hàm lấy thông tin đất đá
        /// </summary>
        /// <param name="id">mã đất đá</param>
        /// <returns>DatDa</returns>
        public static DatDa DatDa(String id)
        {
            DatDa datDa = new DatDa();
            Connection conn = new Connection();
            string sql = "SELECT * FROM DatDa WHERE MaDatDa = '" + id + "'";
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                datDa = new DatDa(dr["MaDatDa"].ToString(), dr["TenDatDa"].ToString(), dr.GetDouble(2), dr.GetDouble(3), dr["TinhChat"].ToString(), dr.GetDouble(5), dr.GetDouble(6), dr.GetDouble(7));
            }
            return datDa;
        }

        /// <summary>
        /// Hàm trả về danh sách đất đá
        /// </summary>
        /// <returns>List<DatDa></returns>
        public static List<DatDa> DanhSachDatDa()
        {
            List<DatDa> danhSachDatDa = new List<DatDa>();
            Connection conn = new Connection();
            string sql = "SELECT * FROM DatDa";
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                danhSachDatDa.Add(new DatDa(dr["MaDatDa"].ToString(), dr["TenDatDa"].ToString(), dr.GetDouble(2), dr.GetDouble(3), dr["TinhChat"].ToString(), dr.GetDouble(5), dr.GetDouble(6), dr.GetDouble(7)));
            }
            return danhSachDatDa;
        }

        /// <summary>
        /// Hàm thêm đất đá
        /// </summary>
        /// <param name="value">đất đá cần thêm</param>
        /// <returns>bool</returns>
        public static bool ThemDatDa(DatDa value)
        {
            String sql = "INSERT INTO DatDa (MaDatDa, TenDatDa, HS_KienCo_TB, HeSoDatDa, TinhChat, DungTrong, KCTB_KhoiNut, KT_HAT_MAX) VALUES ('" + value.MaDatDa + "', '" + value.TenDatDa + "', '" + value.HS_KienCo_TB + "', '" + value.HeSoDatDa + "', '" + value.TinhChat + "', '" + value.DungTrong + "', '" + value.KCTB_KhoiNut + "', '" + value.KT_HAT_MAX + "')";
            Connection conn = new Connection();
            return conn.SetData(sql);
        }

        /// <summary>
        /// Hàm cập nhật đất đá
        /// </summary>
        /// <param name="value">đất đá cần cập nhật</param>
        /// <returns>bool</returns>
        public static bool CapNhatDatDa(DatDa value)
        {
            String sql = "UPDATE DatDa SET TenDatDa = '" + value.TenDatDa + "', HS_KienCo_TB = '" + value.HS_KienCo_TB + "', HeSoDatDa = '" + value.HeSoDatDa + "', TinhChat = '" + value.TinhChat + "', DungTrong = '" + value.DungTrong + "', KCTB_KhoiNut = '" + value.KCTB_KhoiNut + "', KT_HAT_MAX = '" + value.KT_HAT_MAX + "' WHERE MaDatDa = '" + value.MaDatDa + "'";
            Connection conn = new Connection();
            return conn.SetData(sql);
        }

        /// <summary>
        /// Hàm xóa danh sách đất đá
        /// </summary>
        /// <param name="dsXoa">Danh sách đất đá cần xóa</param>
        /// <returns>bool</returns>
        public static bool XoaDatDa(List<DatDa> dsXoa)
        {
            if (dsXoa.Count == 0)
            {
                return true;
            }
            Connection conn = new Connection();
            String sql = "";
            foreach (DatDa value in dsXoa)
            {
                sql = "DELETE FROM DatDa WHERE MaDatDa = '" + value.MaDatDa + "'";
                conn.SetData(sql);
            }
            return true;
        }
    }
}
