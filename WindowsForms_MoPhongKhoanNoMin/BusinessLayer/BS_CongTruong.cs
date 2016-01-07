using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WindowsForms_MoPhongKhoanNoMin.DataAccessLayer;

namespace WindowsForms_MoPhongKhoanNoMin.BusinessLayer
{
    class BS_CongTruong
    {
        /// <summary>
        /// Hàm lấy thông tin công trường
        /// </summary>
        /// <param name="id">mã công trường</param>
        /// <returns>CongTruong</returns>
        public static CongTruong CongTruong(String id)
        {
            CongTruong congTruong = new CongTruong();
            Connection conn = new Connection();
            string sql = "SELECT * FROM CongTruong WHERE MaCongTruong = '" + id + "'";
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                congTruong = new CongTruong(dr["MaCongTruong"].ToString(), dr["TenCongTruong"].ToString(), dr["SoDienThoai"].ToString(), dr.GetDouble(3), dr["Tang"].ToString(), dr["KhuVuc"].ToString());
            }
            return congTruong;
        }

        /// <summary>
        /// Hàm trả về danh sách công trường
        /// </summary>
        /// <returns>List<CongTruong></returns>
        public static List<CongTruong> DanhSachCongTruong()
        {
            List<CongTruong> danhSachCongTruong = new List<CongTruong>();
            Connection conn = new Connection();
            string sql = "SELECT * FROM CongTruong";
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                danhSachCongTruong.Add(new CongTruong(dr["MaCongTruong"].ToString(), dr["TenCongTruong"].ToString(), dr["SoDienThoai"].ToString(), dr.GetDouble(3), dr["Tang"].ToString(), dr["KhuVuc"].ToString()));
            }
            return danhSachCongTruong;
        }

        /// <summary>
        /// Hàm thêm công trường
        /// </summary>
        /// <param name="value">công trường cần thêm mới</param>
        /// <returns>bool</returns>
        public static bool ThemCongTruong(CongTruong value)
        {
            String sql = "INSERT INTO CongTruong (MaCongTruong, TenCongTruong, SoDienThoai, CaoDiem, Tang, KhuVuc) VALUES ('" + value.MaCongTruong + "','" + value.TenCongTruong + "','" + value.SoDienThoai + "','" + value.CaoDiem + "','" + value.Tang + "','" + value.KhuVuc + "')";
            Connection conn = new Connection();
            return conn.SetData(sql);
        }

        /// <summary>
        /// Hàm cập nhật công trường
        /// </summary>
        /// <param name="value">công trường cần cập nhật</param>
        /// <returns>bool</returns>
        public static bool CapNhatCongTruong(CongTruong value)
        {
            String sql = "UPDATE CongTruong SET TenCongTruong = '" + value.TenCongTruong + "', SoDienThoai = '" + value.SoDienThoai + "', CaoDiem = '" + value.CaoDiem + "', Tang = '" + value.Tang + "', KhuVuc = '" + value.KhuVuc + "' WHERE MaCongTruong = '" + value.MaCongTruong + "'";
            Connection conn = new Connection();
            return conn.SetData(sql);
        }

        /// <summary>
        /// Hàm xóa danh sách công trường
        /// </summary>
        /// <param name="dsXoa">Danh sách công trường cần xóa</param>
        /// <returns>bool</returns>
        public static bool XoaCongTruong(List<CongTruong> dsXoa)
        {
            if (dsXoa.Count == 0)
            {
                return true;
            }
            Connection conn = new Connection();
            String sql = "";
            foreach (CongTruong value in dsXoa)
            {
                sql = "DELETE FROM CongTruong WHERE MaCongTruong = '" + value.MaCongTruong + "'";
                conn.SetData(sql);
            }
            return true;
        }
    }
}
