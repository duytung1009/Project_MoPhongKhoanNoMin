using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WindowsForms_MoPhongKhoanNoMin.DataAccessLayer;

namespace WindowsForms_MoPhongKhoanNoMin.BusinessLayer
{
    class BS_KipNo
    {
        /// <summary>
        /// Hàm lấy thông tin kíp nổ
        /// </summary>
        /// <param name="id">mã kíp nổ</param>
        /// <returns>KipNo</returns>
        public static KipNo KipNo(String id)
        {
            KipNo kipNo = new KipNo();
            Connection conn = new Connection();
            string sql = "SELECT * FROM KipNo WHERE MaKipNo = '" + id + "'";
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                kipNo = new KipNo(dr["MaKipNo"].ToString(), dr["TenKipNo"].ToString(), dr["ThoiGianViSai"].ToString(), dr.GetDouble(3), dr.GetDouble(4));
            }
            return kipNo;
        }

        /// <summary>
        /// Hàm trả về danh sách kíp nổ
        /// </summary>
        /// <returns>List<KipNo></returns>
        public static List<KipNo> DanhSachKipNo()
        {
            List<KipNo> danhSachKipNo = new List<KipNo>();
            Connection conn = new Connection();
            string sql = "SELECT * FROM KipNo";
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                danhSachKipNo.Add(new KipNo(dr["MaKipNo"].ToString(), dr["TenKipNo"].ToString(), dr["ThoiGianViSai"].ToString(), dr.GetDouble(3), dr.GetDouble(4)));
            }
            return danhSachKipNo;
        }

        /// <summary>
        /// Hàm thêm kíp nổ
        /// </summary>
        /// <param name="value">kíp nổ cần thêm</param>
        /// <returns>bool</returns>
        public static bool ThemKipNo(KipNo value)
        {
            String sql = "INSERT INTO KipNo (MaKipNo, TenKipNo, ThoiGianViSai, DonViTinh_KN, GiaThanh_KN) VALUES ('" + value.MaKipNo + "', '" + value.TenKipNo + "', '" + value.ThoiGianViSai + "', '" + value.DonViTinh_KN + "', '" + value.GiaThanh_KN + "')";
            Connection conn = new Connection();
            return conn.SetData(sql);
        }

        /// <summary>
        /// Hàm cập nhật kíp nổ
        /// </summary>
        /// <param name="value">kíp nổ cần cập nhật</param>
        /// <returns>bool</returns>
        public static bool CapNhatKipNo(KipNo value)
        {
            String sql = "UPDATE KipNo SET TenKipNo = '" + value.TenKipNo + "', ThoiGianViSai = '" + value.ThoiGianViSai + "', DonViTinh_KN = '" + value.DonViTinh_KN + "', GiaThanh_KN = '" + value.GiaThanh_KN + "' WHERE MaKipNo = '" + value.MaKipNo + "'";
            Connection conn = new Connection();
            return conn.SetData(sql);
        }

        /// <summary>
        /// Hàm xóa danh sách kíp nổ
        /// </summary>
        /// <param name="dsXoa">Danh sách kíp nổ cần xóa</param>
        /// <returns>bool</returns>
        public static bool XoaKipNo(List<KipNo> dsXoa)
        {
            if (dsXoa.Count == 0)
            {
                return true;
            }
            Connection conn = new Connection();
            String sql = "";
            foreach (KipNo value in dsXoa)
            {
                sql = "DELETE FROM KipNo WHERE MaKipNo = '" + value.MaKipNo + "'";
                conn.SetData(sql);
            }
            return true;
        }
    }
}
