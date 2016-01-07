using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WindowsForms_MoPhongKhoanNoMin.DataAccessLayer;

namespace WindowsForms_MoPhongKhoanNoMin.BusinessLayer
{
    class BS_PhuongPhapNo
    {
        /// <summary>
        /// Hàm lấy thông tin phương pháp nổ
        /// </summary>
        /// <param name="id">mã phương pháp nổ</param>
        /// <returns>PhuongPhapNo</returns>
        public static PhuongPhapNo PhuongPhapNo(String id)
        {
            PhuongPhapNo phuongPhapNo = new PhuongPhapNo();
            Connection conn = new Connection();
            string sql = "SELECT * FROM PhuongPhapNo WHERE MaPPNo = '" + id + "'";
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                phuongPhapNo = new PhuongPhapNo(dr["MaPPNo"].ToString(), dr["TenPPNo"].ToString(), dr["MaCongTruong"].ToString(), dr.GetDouble(3), dr.GetDouble(4));
            }
            return phuongPhapNo;
        }

        /// <summary>
        /// Hàm trả về danh sách phương pháp nổ
        /// </summary>
        /// <returns>List<PhuongPhapNo></returns>
        public static List<PhuongPhapNo> DanhSachPPNo()
        {
            List<PhuongPhapNo> danhSachPPNo = new List<PhuongPhapNo>();
            Connection conn = new Connection();
            string sql = "SELECT * FROM PhuongPhapNo";
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                danhSachPPNo.Add(new PhuongPhapNo(dr["MaPPNo"].ToString(), dr["TenPPNo"].ToString(), dr["MaCongTruong"].ToString(), dr.GetDouble(3), dr.GetDouble(4)));
            }
            return danhSachPPNo;
        }

        /// <summary>
        /// Hàm thêm phương pháp nổ
        /// </summary>
        /// <param name="value">phương pháp nổ cần thêm</param>
        /// <returns>bool</returns>
        public static bool ThemPhuongPhapNo(PhuongPhapNo value)
        {
            String sql = "INSERT INTO PhuongPhapNo(MaPPNo, TenPPNo, MaCongTruong, Hs_KienCo, HeSoPPNo) VALUES('" + value.MaPPNo + "', '" + value.TenPPNo + "', '" + value.MaCongTruong + "', '" + value.HeSoKienCo + "', '" + value.HeSoPPNo + "')";
            Connection conn = new Connection();
            return conn.SetData(sql);
        }

        /// <summary>
        /// Hàm cập nhật phương pháp nổ
        /// </summary>
        /// <param name="value">phương pháp nổ cần cập nhật</param>
        /// <returns>bool</returns>
        public static bool CapNhatPhuongPhapNo(PhuongPhapNo value)
        {
            String sql = "UPDATE PhuongPhapNo SET TenPPNo = '" + value.TenPPNo + "', MaCongTruong = '" + value.MaCongTruong + "', Hs_KienCo = '" + value.HeSoKienCo + "', HeSoPPNo = '" + value.HeSoPPNo + "' WHERE MaPPNo = '" + value.MaPPNo + "'";
            Connection conn = new Connection();
            return conn.SetData(sql);
        }

        /// <summary>
        /// Hàm xóa danh sách phương pháp nổ
        /// </summary>
        /// <param name="dsXoa">Danh sách phương pháp nổ cần xóa</param>
        /// <returns>bool</returns>
        public static bool XoaPhuongPhapNo(List<PhuongPhapNo> dsXoa)
        {
            if (dsXoa.Count == 0)
            {
                return true;
            }
            Connection conn = new Connection();
            String sql = "";
            foreach (PhuongPhapNo value in dsXoa)
            {
                sql = "DELETE FROM PhuongPhapNo WHERE MaPPNo = '" + value.MaPPNo + "'";
                conn.SetData(sql);
            }
            return true;
        }
    }
}
