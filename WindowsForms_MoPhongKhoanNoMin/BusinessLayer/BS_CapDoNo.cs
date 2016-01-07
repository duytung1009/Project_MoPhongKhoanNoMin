using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WindowsForms_MoPhongKhoanNoMin.DataAccessLayer;

namespace WindowsForms_MoPhongKhoanNoMin.BusinessLayer
{
    class BS_CapDoNo
    {
        /// <summary>
        /// Hàm lấy thông tin cấp độ nổ
        /// </summary>
        /// <param name="id">mã cấp độ nổ</param>
        /// <returns>CapDoNo</returns>
        public static CapDoNo CapDoNo(String id)
        {
            CapDoNo capDoNo = new CapDoNo();
            Connection conn = new Connection();
            string sql = "SELECT * FROM CapDoNo WHERE MaCapDo = '" + id + "'";
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                capDoNo = new CapDoNo(dr["MaCapDo"].ToString(), dr["TenCapDo"].ToString(), dr.GetDouble(2), dr["DoCungDatDa"].ToString());
            }
            return capDoNo;
        }

        /// <summary>
        /// Hàm trả về danh sách cấp độ nổ
        /// </summary>
        /// <returns>List<CapDoNo></returns>
        public static List<CapDoNo> DanhSachCapDoNo()
        {
            List<CapDoNo> danhSachCapDoNo = new List<CapDoNo>();
            Connection conn = new Connection();
            string sql = "SELECT * FROM CapDoNo";
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                danhSachCapDoNo.Add(new CapDoNo(dr["MaCapDo"].ToString(), dr["TenCapDo"].ToString(), dr.GetDouble(2), dr["DoCungDatDa"].ToString()));
            }
            return danhSachCapDoNo;
        }

        /// <summary>
        /// Hàm thêm cấp độ nổ
        /// </summary>
        /// <param name="value">cấp độ nổ cần thêm mới</param>
        /// <returns>bool</returns>
        public static bool ThemCapDoNo(CapDoNo value)
        {
            String sql = "INSERT INTO CapDoNo (MaCapDo, TenCapDo, ChiTieuThuocNo, DoCungDatDa) VALUES ('" + value.MaCapDo + "','" + value.TenCapDo + "','" + value.ChiTieuThuocNo + "','" + value.DoCungDatDa + "')";
            Connection conn = new Connection();
            return conn.SetData(sql);
        }

        /// <summary>
        /// Hàm cập nhật cấp độ nổ
        /// </summary>
        /// <param name="value">cấp độ nổ cần cập nhật</param>
        /// <returns>bool</returns>
        public static bool CapNhatCapDoNo(CapDoNo value)
        {
            String sql = "UPDATE CapDoNo SET TenCapDo = '" + value.TenCapDo + "', ChiTieuThuocNo = '" + value.ChiTieuThuocNo + "', DoCungDatDa = '" + value.DoCungDatDa + "' WHERE MaCapDo = '" + value.MaCapDo + "'";
            Connection conn = new Connection();
            return conn.SetData(sql);
        }

        /// <summary>
        /// Hàm xóa danh sách cấp độ nổ
        /// </summary>
        /// <param name="dsXoa">danh sách cấp độ nổ cần xóa</param>
        /// <returns>bool</returns>
        public static bool XoaCapDoNo(List<CapDoNo> dsXoa)
        {
            if (dsXoa.Count == 0)
            {
                return true;
            }
            Connection conn = new Connection();
            String sql = "";
            foreach (CapDoNo value in dsXoa)
            {
                sql = "DELETE FROM CapDoNo WHERE MaCapDo = '" + value.MaCapDo + "'";
                conn.SetData(sql);
            }
            return true;
        }
    }
}
