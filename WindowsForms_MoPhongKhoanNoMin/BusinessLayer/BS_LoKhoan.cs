using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using WindowsForms_MoPhongKhoanNoMin.DataAccessLayer;

namespace WindowsForms_MoPhongKhoanNoMin.BusinessLayer
{
    class BS_LoKhoan
    {
        /// <summary>
        /// Hàm lấy danh sách lỗ khoan
        /// </summary>
        /// <returns>List<LoKhoan></returns>
        public static List<LoKhoan> DanhSachLoKhoan()
        {
            List<LoKhoan> danhSachLoKhoan = new List<LoKhoan>();
            Connection conn = new Connection();
            string sql = "SELECT * FROM LoKhoan";
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                danhSachLoKhoan.Add(new LoKhoan(dr["ID"].ToString(), dr["MaHoChieu"].ToString(), dr["MaBanVe"].ToString(), dr["MaMayKhoan"].ToString(), dr["MaLK"].ToString(), dr.GetDouble(5), dr.GetDouble(6), dr["HuongKhoan"].ToString(), dr.GetDouble(8), dr.GetDouble(9), dr.GetDouble(10), dr.GetDouble(11), dr.GetDouble(12), dr.GetDouble(13)));
            }
            return danhSachLoKhoan;
        }

        /// <summary>
        /// Hàm lấy danh sách lỗ khoan của một bản vẽ
        /// </summary>
        /// <param name="_id">ID hộ chiếu</param>
        /// <returns>List<LoKhoan></returns>
        public static List<LoKhoan> DanhSachLoKhoan(String _id)
        {
            List<LoKhoan> danhSachLoKhoan = new List<LoKhoan>();
            Connection conn = new Connection();
            string sql = "SELECT * FROM LoKhoan WHERE MaHoChieu = '" + _id + "'";
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                danhSachLoKhoan.Add(new LoKhoan(dr["ID"].ToString(), dr["MaHoChieu"].ToString(), dr["MaBanVe"].ToString(), dr["MaMayKhoan"].ToString(), dr["MaLK"].ToString(), dr.GetDouble(5), dr.GetDouble(6), dr["HuongKhoan"].ToString(), dr.GetDouble(8), dr.GetDouble(9), dr.GetDouble(10), dr.GetDouble(11), dr.GetDouble(12), dr.GetDouble(13)));
            }
            if (dr != null)
            {
                return danhSachLoKhoan;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Hàm lấy thông tin một lỗ khoan của một bản vẽ
        /// </summary>
        /// <param name="_idHoChieu">ID hộ chiếu</param>
        /// <param name="_idLoKhoan">ID lỗ khoan</param>
        /// <returns>LoKhoan</returns>
        public static LoKhoan ThongTinLoKhoan(String _idHoChieu, String _idLoKhoan)
        {
            LoKhoan loKhoan = new LoKhoan();
            Connection conn = new Connection();
            string sql = "SELECT * FROM LoKhoan WHERE MaHoChieu = '" + _idHoChieu + "' AND MaLK = '" + _idLoKhoan + "'";
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                loKhoan = new LoKhoan(dr["ID"].ToString(), dr["MaHoChieu"].ToString(), dr["MaBanVe"].ToString(), dr["MaMayKhoan"].ToString(), dr["MaLK"].ToString(), dr.GetDouble(5), dr.GetDouble(6), dr["HuongKhoan"].ToString(), dr.GetDouble(8), dr.GetDouble(9), dr.GetDouble(10), dr.GetDouble(11), dr.GetDouble(12), dr.GetDouble(13));
            }
            return loKhoan;
        }

        /// <summary>
        /// Hàm cập nhật thông tin lỗ khoan
        /// </summary>
        /// <param name="value">lỗ khoan cần cập nhật</param>
        /// <returns>bool</returns>
        public static bool CapNhatLoKhoan(LoKhoan value)
        {
            String sql = "UPDATE LoKhoan SET MaHoChieu = '" + value.MaHoChieu + "', MaMayKhoan = '" + value.MaMayKhoan + "', BanKinhLK = '" + value.BanKinh + "', ChieuSauLK = '" + value.ChieuSau + "', HuongKhoan = '" + value.HuongKhoan + "', ToaDoX = '" + Math.Round(value.ToaDoX, 2) + "', ToaDoY = '" + Math.Round(value.ToaDoY, 2) + "', Lt = '" + value.Lt + "', Lkk = '" + value.Lkk + "', L0 = '" + value.L0 + "', Lbua = '" + value.Lbua + "' WHERE MaBanVe = '" + value.MaBanVe + "' AND MaLK = '" + value.MaLoKhoan + "'";
            Connection conn = new Connection();
            return conn.SetData(sql);
        }

        /// <summary>
        /// Hàm cập nhật thông tin danh sách lỗ khoan
        /// </summary>
        /// <param name="dsLoKhoan">danh sách lỗ khoan cần cập nhật</param>
        /// <returns>bool</returns>
        public static bool CapNhatLoKhoan(List<LoKhoan> dsLoKhoan)
        {
            foreach(LoKhoan value in dsLoKhoan)
            {
                String sql = "UPDATE LoKhoan SET MaHoChieu = '" + value.MaHoChieu + "', MaMayKhoan = '" + value.MaMayKhoan + "', BanKinhLK = '" + value.BanKinh + "', ChieuSauLK = '" + value.ChieuSau + "', HuongKhoan = '" + value.HuongKhoan + "', ToaDoX = '" + Math.Round(value.ToaDoX, 2) + "', ToaDoY = '" + Math.Round(value.ToaDoY, 2) + "', Lt = '" + value.Lt + "', Lkk = '" + value.Lkk + "', L0 = '" + value.L0 + "', Lbua = '" + value.Lbua + "' WHERE MaBanVe = '" + value.MaBanVe + "' AND MaLK = '" + value.MaLoKhoan + "'";
                Connection conn = new Connection();
                conn.SetData(sql);
            }
            return true;
        }
    }
}
