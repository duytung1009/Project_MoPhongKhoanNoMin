using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WindowsForms_MoPhongKhoanNoMin.DataAccessLayer;

namespace WindowsForms_MoPhongKhoanNoMin.BusinessLayer
{
    class BS_MayKhoan
    {
        /// <summary>
        /// Hàm lấy thông tin máy khoan
        /// </summary>
        /// <param name="id">mã máy khoan</param>
        /// <returns>MayKhoan</returns>
        public static MayKhoan MayKhoan(String id)
        {
            MayKhoan mayKhoan = new MayKhoan();
            Connection conn = new Connection();
            string sql = "SELECT * FROM MayKhoan WHERE MaMayKhoan = '" + id + "'";
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                mayKhoan = new MayKhoan(dr["MaMayKhoan"].ToString(), dr["TenMayKhoan"].ToString(), dr.GetDouble(2), dr["HuongKhoan"].ToString(), dr.GetDouble(4));
            }
            return mayKhoan;
        }

        /// <summary>
        /// Hàm lấy danh sách máy khoan
        /// </summary>
        /// <returns>List<MayKhoan></returns>
        static public List<MayKhoan> DanhSachMayKhoan()
        {
            List<MayKhoan> danhSachMayKhoan = new List<MayKhoan>();
            Connection conn = new Connection();
            string sql = "SELECT * FROM MayKhoan";
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                danhSachMayKhoan.Add(new MayKhoan(dr["MaMayKhoan"].ToString(), dr["TenMayKhoan"].ToString(), dr.GetDouble(2), dr["HuongKhoan"].ToString(), dr.GetDouble(4)));
            }
            return danhSachMayKhoan;
        }

        /// <summary>
        /// Hàm thêm máy khoan
        /// </summary>
        /// <param name="value">máy khoan cần thêm</param>
        /// <returns>bool</returns>
        public static bool ThemMayKhoan(MayKhoan value)
        {
            String sql = "INSERT INTO MayKhoan(MaMayKhoan, TenMayKhoan, DuongKinhLK, HuongKhoan, ChieuSau) VALUES('" + value.MaMayKhoan + "', '" + value.TenMayKhoan + "', '" + value.DuongKinhLoKhoan + "', '" + value.HuongKhoan + "', '" + value.ChieuSau + "')";
            Connection conn = new Connection();
            return conn.SetData(sql);
        }

        /// <summary>
        /// Hàm cập nhật máy khoan
        /// </summary>
        /// <param name="value">máy khoan cần cập nhật</param>
        /// <returns>bool</returns>
        public static bool CapNhatMayKhoan(MayKhoan value)
        {
            String sql = "UPDATE MayKhoan SET TenMayKhoan = '" + value.TenMayKhoan + "', DuongKinhLK = '" + value.DuongKinhLoKhoan + "', HuongKhoan = '" + value.HuongKhoan + "', ChieuSau = '" + value.ChieuSau + "' WHERE MaMayKhoan = '" + value.MaMayKhoan + "'";
            Connection conn = new Connection();
            return conn.SetData(sql);
        }

        /// <summary>
        /// Hàm xóa danh sách máy khoan
        /// </summary>
        /// <param name="dsXoa">Danh sách máy khoan cần xóa</param>
        /// <returns>bool</returns>
        public static bool XoaMayKhoan(List<MayKhoan> dsXoa)
        {
            if (dsXoa.Count == 0)
            {
                return true;
            }
            Connection conn = new Connection();
            String sql = "";
            foreach (MayKhoan value in dsXoa)
            {
                sql = "DELETE FROM MayKhoan WHERE MaMayKhoan = '" + value.MaMayKhoan + "'";
                conn.SetData(sql);
            }
            return true;
        }
    }
}
