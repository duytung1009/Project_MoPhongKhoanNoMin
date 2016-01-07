using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WindowsForms_MoPhongKhoanNoMin.DataAccessLayer;

namespace WindowsForms_MoPhongKhoanNoMin.BusinessLayer
{
    class BS_PhuKienNo
    {
        /// <summary>
        /// Hàm lấy thông tin phụ kiện nổ
        /// </summary>
        /// <param name="id">mã phụ kiện nổ</param>
        /// <returns>PhuKienNo</returns>
        public static PhuKienNo PhuKienNo(String id)
        {
            PhuKienNo phuKienNo = new PhuKienNo();
            Connection conn = new Connection();
            string sql = "SELECT * FROM PhuKienNo WHERE MaPhuKien = '" + id + "'";
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                phuKienNo = new PhuKienNo(dr["MaPhuKien"].ToString(), dr["TenPhuKien"].ToString(), dr.GetDouble(2), dr.GetDouble(3));
            }
            return phuKienNo;
        }

        /// <summary>
        /// Hàm trả về danh sách phụ kiện nổ
        /// </summary>
        /// <returns>List<PhuKienNo></returns>
        public static List<PhuKienNo> DanhSachPhuKienNo()
        {
            List<PhuKienNo> danhSachPhuKienNo = new List<PhuKienNo>();
            Connection conn = new Connection();
            string sql = "SELECT * FROM PhuKienNo";
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                danhSachPhuKienNo.Add(new PhuKienNo(dr["MaPhuKien"].ToString(), dr["TenPhuKien"].ToString(), dr.GetDouble(2), dr.GetDouble(3)));
            }
            return danhSachPhuKienNo;
        }

        /// <summary>
        /// Hàm thêm phụ kiện nổ
        /// </summary>
        /// <param name="value">phụ kiện nổ cần thêmt</param>
        /// <returns>bool</returns>
        public static bool ThemPhuKienNo(PhuKienNo value)
        {
            String sql = "INSERT INTO PhuKienNo(MaPhuKien, TenPhuKien, DonViTinh_PK, GiaThanh_PK) VALUES('" + value.MaPhuKien + "', '" + value.TenPhuKien + "', '" + value.DonViTinh_PK + "', '" + value.GiaThanh_PK + "')";
            Connection conn = new Connection();
            return conn.SetData(sql);
        }

        /// <summary>
        /// Hàm cập nhật phụ kiện nổ
        /// </summary>
        /// <param name="value">phụ kiện nổ cần cập nhật</param>
        /// <returns>bool</returns>
        public static bool CapNhatPhuKienNo(PhuKienNo value)
        {
            String sql = "UPDATE PhuKienNo SET TenPhuKien = '" + value.TenPhuKien + "', DonViTinh_PK = '" + value.DonViTinh_PK + "', GiaThanh_PK = '" + value.GiaThanh_PK + "' WHERE MaPhuKien = '" + value.MaPhuKien + "'";
            Connection conn = new Connection();
            return conn.SetData(sql);
        }

        /// <summary>
        /// Hàm xóa danh sách phụ kiện nổ
        /// </summary>
        /// <param name="dsXoa">Danh sách phụ kiện nổ cần xóa</param>
        /// <returns>bool</returns>
        public static bool XoaPhuKienNo(List<PhuKienNo> dsXoa)
        {
            if (dsXoa.Count == 0)
            {
                return true;
            }
            Connection conn = new Connection();
            String sql = "";
            foreach (PhuKienNo value in dsXoa)
            {
                sql = "DELETE FROM PhuKienNo WHERE MaPhuKien = '" + value.MaPhuKien + "'";
                conn.SetData(sql);
            }
            return true;
        }
    }
}
