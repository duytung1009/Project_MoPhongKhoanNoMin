using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WindowsForms_MoPhongKhoanNoMin.DataAccessLayer;

namespace WindowsForms_MoPhongKhoanNoMin.BusinessLayer
{
    class BS_ThuocNo
    {
        /// <summary>
        /// Hàm lấy thông tin thuốc nổ
        /// </summary>
        /// <param name="id">mã thuốc nổ</param>
        /// <returns>ThuocNo</returns>
        public static ThuocNo ThuocNo(String id)
        {
            ThuocNo thuocNo = new ThuocNo();
            Connection conn = new Connection();
            string sql = "SELECT * FROM ThuocNo WHERE MaThuocNo = '" + id + "'";
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                thuocNo = new ThuocNo(dr["MaThuocNo"].ToString(), dr["TenThuocNo"].ToString(), dr.GetDouble(2), dr.GetDouble(3), dr.GetDouble(4), dr["ChiuNuoc"].ToString(), dr.GetDouble(6), dr.GetDouble(7), dr.GetDouble(8));
            }
            return thuocNo;
        }

        /// <summary>
        /// Hàm trả về danh sách thuốc nổ
        /// </summary>
        /// <returns>List<ThuocNo></returns>
        public static List<ThuocNo> DanhSachThuocNo()
        {
            List<ThuocNo> danhSachThuocNo = new List<ThuocNo>();
            Connection conn = new Connection();
            string sql = "SELECT * FROM ThuocNo";
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                danhSachThuocNo.Add(new ThuocNo(dr["MaThuocNo"].ToString(), dr["TenThuocNo"].ToString(), dr.GetDouble(2), dr.GetDouble(3), dr.GetDouble(4), dr["ChiuNuoc"].ToString(), dr.GetDouble(6), dr.GetDouble(7), dr.GetDouble(8)));
            }
            return danhSachThuocNo;
        }

        /// <summary>
        /// Hàm thêm thuốc nổ
        /// </summary>
        /// <param name="value">thuốc nổ cần thêm</param>
        /// <returns>bool</returns>
        public static bool ThemThuocNo(ThuocNo value)
        {
            String sql = "INSERT INTO ThuocNo(MaThuocNo, TenThuocNo, TocDoNo, KhaNangSinhCong, MatDoNapThuoc, ChiuNuoc, HS_ChuyenDoi, DonViTinh_TN, GiaThanh_TN) VALUES('" + value.MaThuocNo + "', '" + value.TenThuocNo + "', '" + value.TocDoNo + "', '" + value.KhaNangSinhCong + "', '" + value.MatDoNapThuoc + "' ,'" + value.ChiuNuoc + "', '" + value.HS_ChuyenDoi + "', '" + value.DonViTinh_TN + "', '" + value.GiaThanh_TN + "')";
            Connection conn = new Connection();
            return conn.SetData(sql);
        }

        /// <summary>
        /// Hàm cập nhật thuốc nổ
        /// </summary>
        /// <param name="value">thuốc nổ cần cập nhật</param>
        /// <returns>bool</returns>
        public static bool CapNhatThuocNo(ThuocNo value)
        {
            String sql = "UPDATE ThuocNo SET TenThuocNo = '" + value.TenThuocNo + "', TocDoNo = '" + value.TocDoNo + "', KhaNangSinhCong = '" + value.KhaNangSinhCong + "', MatDoNapThuoc = '" + value.MatDoNapThuoc + "', ChiuNuoc = '" + value.ChiuNuoc + "', HS_ChuyenDoi = '" + value.HS_ChuyenDoi + "', DonViTinh_TN = '" + value.DonViTinh_TN + "', GiaThanh_TN = '" + value.GiaThanh_TN + "' WHERE MaThuocNo = '" + value.MaThuocNo + "'";
            Connection conn = new Connection();
            return conn.SetData(sql);
        }

        /// <summary>
        /// Hàm xóa danh sách thuốc nổ
        /// </summary>
        /// <param name="dsXoa">Danh sách thuốc nổ cần xóa</param>
        /// <returns>bool</returns>
        public static bool XoaThuocNo(List<ThuocNo> dsXoa)
        {
            if (dsXoa.Count == 0)
            {
                return true;
            }
            Connection conn = new Connection();
            String sql = "";
            foreach (ThuocNo value in dsXoa)
            {
                sql = "DELETE FROM ThuocNo WHERE MaThuocNo = '" + value.MaThuocNo + "'";
                conn.SetData(sql);
            }
            return true;
        }
    }
}
