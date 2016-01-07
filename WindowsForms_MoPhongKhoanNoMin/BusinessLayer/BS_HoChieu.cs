using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WindowsForms_MoPhongKhoanNoMin.DataAccessLayer;

namespace WindowsForms_MoPhongKhoanNoMin.BusinessLayer
{
    class BS_HoChieu
    {
        /// <summary>
        /// Hàm lấy thông tin hộ chiếu nổ mìn
        /// </summary>
        /// <param name="id">mã hộ chiếu</param>
        /// <returns>HoChieu</returns>
        public static HoChieu HoChieu(String id)
        {
            HoChieu hoChieu = new HoChieu();
            Connection conn = new Connection();
            string sql = "SELECT * FROM HoChieu WHERE MaHoChieu = '" + id + "'";
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                hoChieu = new HoChieu(dr["MaHoChieu"].ToString(), dr["MaBanVe"].ToString(), dr["TenHoChieu"].ToString(), ((dr["ChieuCaoTang"].ToString() == String.Empty) ? -1 : Convert.ToDouble(dr["ChieuCaoTang"])), ((dr["QuyMoDotNo"].ToString() == String.Empty) ? -1 : Convert.ToDouble(dr["QuyMoDotNo"])), dr["MaCongTruong"].ToString(), dr["MaDatDa"].ToString(), dr["MaMayKhoan"].ToString(), dr["MaKipNo"].ToString(), dr["MaThuocNo"].ToString(), dr["MaPPNo"].ToString(), dr["MaPhuKien"].ToString(), dr["MaCapDo"].ToString(), dr["NgayLap"].ToString(), ((dr["HeSoKC"].ToString() == String.Empty) ? -1 : Convert.ToDouble(dr["HeSoKC"])), ((dr["KichThuoc_X"].ToString() == String.Empty) ? -1 : Convert.ToDouble(dr["KichThuoc_X"])), ((dr["KichThuoc_Y"].ToString() == String.Empty) ? -1 : Convert.ToDouble(dr["KichThuoc_Y"])));
            }
            return hoChieu;
        }

        /// <summary>
        /// Hàm trả về danh sách hộ chiếu nổ mìn
        /// </summary>
        /// <returns>List<HoChieu></returns>
        public static List<HoChieu> DanhSachHoChieu()
        {
            List<HoChieu> danhSachHoChieu = new List<HoChieu>();
            Connection conn = new Connection();
            string sql = "SELECT * FROM HoChieu";
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                danhSachHoChieu.Add(new HoChieu(dr["MaHoChieu"].ToString(), dr["MaBanVe"].ToString(), dr["TenHoChieu"].ToString(), ((dr["ChieuCaoTang"].ToString() == String.Empty) ? -1 : Convert.ToDouble(dr["ChieuCaoTang"])), ((dr["QuyMoDotNo"].ToString() == String.Empty) ? -1 : Convert.ToDouble(dr["QuyMoDotNo"])), dr["MaCongTruong"].ToString(), dr["MaDatDa"].ToString(), dr["MaMayKhoan"].ToString(), dr["MaKipNo"].ToString(), dr["MaThuocNo"].ToString(), dr["MaPPNo"].ToString(), dr["MaPhuKien"].ToString(), dr["MaCapDo"].ToString(), dr["NgayLap"].ToString(), ((dr["HeSoKC"].ToString() == String.Empty) ? -1 : Convert.ToDouble(dr["HeSoKC"])), ((dr["KichThuoc_X"].ToString() == String.Empty) ? -1 : Convert.ToDouble(dr["KichThuoc_X"])), ((dr["KichThuoc_Y"].ToString() == String.Empty) ? -1 : Convert.ToDouble(dr["KichThuoc_Y"]))));
            }
            return danhSachHoChieu;
        }

        /// <summary>
        /// Hàm trả về danh sách hộ chiếu sử dụng gần đây nhất
        /// </summary>
        /// <returns>List<HoChieu></returns>
        public static List<HoChieu> DanhSachHoChieuGanNhat()
        {
            List<HoChieu> danhSachHoChieu = new List<HoChieu>();
            String sql = "SELECT * FROM HoChieu a ORDER BY (SELECT NgayChinhSua FROM BanVe WHERE ID = a.MaBanVe)";
            Connection conn = new Connection();
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                danhSachHoChieu.Add(new HoChieu(dr["MaHoChieu"].ToString(), dr["MaBanVe"].ToString(), dr["TenHoChieu"].ToString(), ((dr["ChieuCaoTang"].ToString() == String.Empty) ? -1 : Convert.ToDouble(dr["ChieuCaoTang"])), ((dr["QuyMoDotNo"].ToString() == String.Empty) ? -1 : Convert.ToDouble(dr["QuyMoDotNo"])), dr["MaCongTruong"].ToString(), dr["MaDatDa"].ToString(), dr["MaMayKhoan"].ToString(), dr["MaKipNo"].ToString(), dr["MaThuocNo"].ToString(), dr["MaPPNo"].ToString(), dr["MaPhuKien"].ToString(), dr["MaCapDo"].ToString(), dr["NgayLap"].ToString(), ((dr["HeSoKC"].ToString() == String.Empty) ? -1 : Convert.ToDouble(dr["HeSoKC"])), ((dr["KichThuoc_X"].ToString() == String.Empty) ? -1 : Convert.ToDouble(dr["KichThuoc_X"])), ((dr["KichThuoc_Y"].ToString() == String.Empty) ? -1 : Convert.ToDouble(dr["KichThuoc_Y"]))));
            }
            return danhSachHoChieu;
        }

        /// <summary>
        /// Hàm trả về danh sách hộ chiếu sử dụng gần đây nhất (có giới hạn)
        /// </summary>
        /// <param name="number">số hộ chiếu trả về</param>
        /// <returns>List<HoChieu></returns>
        public static List<HoChieu> DanhSachHoChieuGanNhat(int number)
        {
            List<HoChieu> danhSachHoChieu = new List<HoChieu>();
            String sql = "SELECT * FROM HoChieu a ORDER BY (SELECT NgayChinhSua FROM BanVe WHERE ID = a.MaBanVe) DESC LIMIT " + number;
            Connection conn = new Connection();
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                //danhSachHoChieu.Add(new HoChieu(dr["MaHoChieu"].ToString(), dr["MaBanVe"].ToString(), dr["TenHoChieu"].ToString(), ((dr["ChieuCaoTang"].ToString() == String.Empty) ? -1 : dr.GetDouble(2)), ((dr["QuyMoDotNo"].ToString() == String.Empty) ? -1 : dr.GetDouble(3)), dr["MaCongTruong"].ToString(), dr["MaDatDa"].ToString(), dr["MaMayKhoan"].ToString(), dr["MaKipNo"].ToString(), dr["MaThuocNo"].ToString(), dr["MaPPNo"].ToString(), dr["MaPhuKien"].ToString(), dr["MaCapDo"].ToString(), dr["NgayLap"].ToString(), ((dr["HeSoKC"].ToString() == String.Empty) ? -1 : dr.GetDouble(13)), ((dr["KichThuoc_X"].ToString() == String.Empty) ? -1 : dr.GetDouble(14)), ((dr["KichThuoc_Y"].ToString() == String.Empty) ? -1 : dr.GetDouble(15))));
                danhSachHoChieu.Add(new HoChieu(dr["MaHoChieu"].ToString(), dr["MaBanVe"].ToString(), dr["TenHoChieu"].ToString(), ((dr["ChieuCaoTang"].ToString() == String.Empty) ? -1 : Convert.ToDouble(dr["ChieuCaoTang"])), ((dr["QuyMoDotNo"].ToString() == String.Empty) ? -1 : Convert.ToDouble(dr["QuyMoDotNo"])), dr["MaCongTruong"].ToString(), dr["MaDatDa"].ToString(), dr["MaMayKhoan"].ToString(), dr["MaKipNo"].ToString(), dr["MaThuocNo"].ToString(), dr["MaPPNo"].ToString(), dr["MaPhuKien"].ToString(), dr["MaCapDo"].ToString(), dr["NgayLap"].ToString(), ((dr["HeSoKC"].ToString() == String.Empty) ? -1 : Convert.ToDouble(dr["HeSoKC"])), ((dr["KichThuoc_X"].ToString() == String.Empty) ? -1 : Convert.ToDouble(dr["KichThuoc_X"])), ((dr["KichThuoc_Y"].ToString() == String.Empty) ? -1 : Convert.ToDouble(dr["KichThuoc_Y"]))));
            }
            return danhSachHoChieu;
        }

        /// <summary>
        /// Hàm thêm hộ chiếu
        /// </summary>
        /// <param name="value">hộ chiếu cần thêm</param>
        /// <returns>bool</returns>
        public static bool ThemHoChieu(HoChieu value)
        {
            String sql = "INSERT INTO HoChieu (MaBanVe, TenHoChieu, ChieuCaoTang, QuyMoDotNo, MaCongTruong, MaDatDa, MaMayKhoan, MaKipNo, MaThuocNo, MaPPNo, MaPhuKien, MaCapDo, NgayLap, HeSoKC, KichThuoc_X, KichThuoc_Y) VALUES ('" + value.MaBanVe + "', '" + value.TenHoChieu + "', '" + value.ChieuCaoTang + "', '" + value.QuyMoDotNo + "', '" + value.MaCongTruong + "', '" + value.MaDatDa + "', '" + value.MaMayKhoan + "', '" + value.MaKipNo + "', '" + value.MaThuocNo + "', '" + value.MaPPNo + "', '" + value.MaPhuKien + "', '" + value.MaCapDo + "', '" + value.NgayLap + "', '" + value.HeSoKC + "', '" + value.KichThuoc_X + "', '" + value.KichThuoc_Y + "')";
            Connection conn = new Connection();
            return conn.SetData(sql);
        }

        /// <summary>
        /// Hàm cập nhật hộ chiếu
        /// </summary>
        /// <param name="value">hộ chiếu cần cập nhật</param>
        /// <returns>bool</returns>
        public static bool CapNhatHoChieu(HoChieu value)
        {
            String sql = "UPDATE HoChieu SET TenHoChieu = '" + value.TenHoChieu + "', ChieuCaoTang = '" + value.ChieuCaoTang + "', QuyMoDotNo ='" + value.QuyMoDotNo + "', MaCongTruong = '" + value.MaCongTruong + "', MaDatDa = '" + value.MaDatDa + "', MaMayKhoan = '" + value.MaMayKhoan + "', MaKipNo = '" + value.MaKipNo + "', MaThuocNo = '" + value.MaThuocNo + "', MaPPNo = '" + value.MaPPNo + "', MaPhuKien = '" + value.MaPhuKien + "', MaCapDo = '" + value.MaCapDo + "', NgayLap = '" + value.NgayLap + "', HeSoKC = '" + value.HeSoKC + "', KichThuoc_X = '" + value.KichThuoc_X + "', KichThuoc_Y = '" + value.KichThuoc_Y + "' WHERE MaHoChieu = '" + value.MaHoChieu + "'";
            Connection conn = new Connection();
            return conn.SetData(sql);
        }

        /// <summary>
        /// Hàm xóa danh sách hộ chiếu
        /// </summary>
        /// <param name="dsXoa">Danh sách hộ chiếu cần xóa</param>
        /// <returns>bool</returns>
        public static bool XoaHoChieu(List<HoChieu> dsXoa)
        {
            if (dsXoa.Count == 0)
            {
                return true;
            }
            Connection conn = new Connection();
            String sql = "";
            foreach (HoChieu value in dsXoa)
            {
                sql = "DELETE FROM LoKhoan WHERE MaHoChieu = '" + value.MaHoChieu + "'";
                conn.SetData(sql);
                sql = "DELETE FROM BanVe WHERE ID = '" + value.MaBanVe + "'";
                conn.SetData(sql);
                sql = "DELETE FROM HoChieu WHERE MaHoChieu = '" + value.MaHoChieu + "'";
                conn.SetData(sql);
            }
            return true;
        }

        /// <summary>
        /// Hàm tạo hộ chiếu
        /// </summary>
        /// <param name="tenHoChieu">Tên hộ chiếu</param>
        /// <returns>ID hộ chiếu vừa tạo</returns>
        public static String TaoHoChieu(String idTemplate, String tenHoChieu)
        {
            Connection conn = new Connection();
            SQLiteDataReader dr;
            HoChieu hoChieuVuaTao = new HoChieu();
            bool flag = true;
            //kiểm tra tên hộ chiếu có trùng ko
            List<HoChieu> danhSachHoChieu = BS_HoChieu.DanhSachHoChieu();
            foreach (HoChieu value in danhSachHoChieu)
            {
                if (value.TenHoChieu == tenHoChieu)
                {
                    flag = false; break;
                }
            }
            //nếu ko trùng => tạo hộ chiếu mới, trả về id hộ chiếu vừa tạo
            if (flag)
            {
                //tạo bản vẽ mới cho hộ chiếu
                String idBanVe = BS_BanVe.TaoBanVe(idTemplate, tenHoChieu);
                if (idBanVe == null)
                {
                    return null;
                }
                else
                {
                    String sql = "INSERT INTO HoChieu (MaBanVe, TenHoChieu, NgayLap) VALUES ('" + idBanVe + "', '" + tenHoChieu + "', '" + DateTime.Now.ToString() + "')";
                    conn.SetData(sql);
                    sql = "SELECT * FROM HoChieu WHERE TenHoChieu = '" + tenHoChieu + "'";
                    dr = conn.GetData(sql);
                    while (dr.Read())
                    {
                        hoChieuVuaTao = new HoChieu(dr["MaHoChieu"].ToString(), dr["MaBanVe"].ToString(), dr["TenHoChieu"].ToString(), ((dr["ChieuCaoTang"].ToString() == String.Empty) ? -1 : Convert.ToDouble(dr["ChieuCaoTang"])), ((dr["QuyMoDotNo"].ToString() == String.Empty) ? -1 : Convert.ToDouble(dr["QuyMoDotNo"])), dr["MaCongTruong"].ToString(), dr["MaDatDa"].ToString(), dr["MaMayKhoan"].ToString(), dr["MaKipNo"].ToString(), dr["MaThuocNo"].ToString(), dr["MaPPNo"].ToString(), dr["MaPhuKien"].ToString(), dr["MaCapDo"].ToString(), dr["NgayLap"].ToString(), ((dr["HeSoKC"].ToString() == String.Empty) ? -1 : Convert.ToDouble(dr["HeSoKC"])), ((dr["KichThuoc_X"].ToString() == String.Empty) ? -1 : Convert.ToDouble(dr["KichThuoc_X"])), ((dr["KichThuoc_Y"].ToString() == String.Empty) ? -1 : Convert.ToDouble(dr["KichThuoc_Y"])));
                    }
                    return hoChieuVuaTao.MaHoChieu;
                }               
            }
            //nếu trùng => trả về null
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Hàm tạo hộ chiếu (không có template)
        /// </summary>
        /// <param name="tenHoChieu">Tên hộ chiếu</param>
        /// <returns>ID hộ chiếu vừa tạo</returns>
        public static String TaoHoChieu(String tenHoChieu)
        {
            //Connection conn = new Connection();
            //SQLiteDataReader dr;
            //BanVe banVeVuaTao = new BanVe();
            //bool flag = true;
            ////kiểm tra tên hộ chiếu có trùng ko
            //List<HoChieu> danhSachHoChieu = BS_HoChieu.DanhSachHoChieu();
            //foreach (HoChieu value in danhSachHoChieu)
            //{
            //    if (value.TenHoChieu == tenHoChieu)
            //    {
            //        flag = false; break;
            //    }
            //}
            ////nếu ko trùng => tạo hộ chiếu mới, trả về id hộ chiếu vừa tạo
            //if (flag)
            //{
            //    //tạo bản vẽ mới cho hộ chiếu
            //    String idBanVe = BS_BanVe.TaoBanVe(tenHoChieu);
            //    if (idBanVe == null)
            //    {
            //        return null;
            //    }
            //    else
            //    {
            //        String sql = "INSERT INTO HoChieu (MaBanVe, TenHoChieu, NgayLap) VALUES ('" + idBanVe + "', '" + tenHoChieu + "', '" + DateTime.Now.ToString() + "')";
            //        conn.SetData(sql);
            //        sql = "SELECT * FROM HoChieu WHERE TenHoChieu = '" + tenHoChieu + "'";
            //        dr = conn.GetData(sql);
            //        while (dr.Read())
            //        {
            //            hoChieuVuaTao = new HoChieu(dr["MaHoChieu"].ToString(), dr["MaBanVe"].ToString(), dr["TenHoChieu"].ToString(), ((dr["ChieuCaoTang"].ToString() == String.Empty) ? -1 : dr.GetDouble(2)), ((dr["QuyMoDotNo"].ToString() == String.Empty) ? -1 : dr.GetDouble(3)), dr["MaCongTruong"].ToString(), dr["MaDatDa"].ToString(), dr["MaMayKhoan"].ToString(), dr["MaKipNo"].ToString(), dr["MaThuocNo"].ToString(), dr["MaPPNo"].ToString(), dr["MaPhuKien"].ToString(), dr["MaCapDo"].ToString(), dr["NgayLap"].ToString(), ((dr["HeSoKC"].ToString() == String.Empty) ? -1 : dr.GetDouble(13)), ((dr["KichThuoc_X"].ToString() == String.Empty) ? -1 : dr.GetDouble(14)), ((dr["KichThuoc_Y"].ToString() == String.Empty) ? -1 : dr.GetDouble(15)));
            //        }
            //        return hoChieuVuaTao.MaHoChieu;
            //    }
            //}
            ////nếu trùng => trả về null
            //else
            //{
                return null;
            //}
        }

        /// <summary>
        /// Hàm lưu hộ chiếu
        /// </summary>
        /// <param name="list">Danh sách lỗ khoan cần lưu</param>
        /// <param name="_id">ID hộ chiếu</param>
        /// <returns>bool</returns>
        public static bool LuuBanVe(List<LoKhoan> list, String _id)
        {
            if (list.Count == 0)
            {
                return true;
            }
            Connection conn = new Connection();
            List<LoKhoan> lk = BS_LoKhoan.DanhSachLoKhoan(_id);
            String sql = "";
            if (lk.Count == 0)
            {
                foreach (LoKhoan newValue in list)
                {
                    sql = "INSERT INTO LoKhoan (MaHoChieu, MaBanVe, MaMayKhoan, MaLK, BanKinhLK, ChieuSauLK, HuongKhoan, ToaDoX, ToaDoY) VALUES ('" + newValue.MaHoChieu + "','" + newValue.MaBanVe + "','" + newValue.MaMayKhoan + "','" + newValue.MaLoKhoan + "','" + newValue.BanKinh + "','" + newValue.ChieuSau + "','" + newValue.HuongKhoan + "','" + Math.Round(newValue.ToaDoX, 2) + "','" + Math.Round(newValue.ToaDoY, 2) + "')";
                    conn.SetData(sql);
                }
            }
            else
            {
                sql = "DELETE FROM LoKhoan WHERE MaHoChieu = '" + _id + "'";
                conn.SetData(sql);
                foreach (LoKhoan newValue in list)
                {
                    sql = "INSERT INTO LoKhoan (MaHoChieu, MaBanVe, MaMayKhoan, MaLK, BanKinhLK, ChieuSauLK, HuongKhoan, ToaDoX, ToaDoY) VALUES ('" + newValue.MaHoChieu + "','" + newValue.MaBanVe + "','" + newValue.MaMayKhoan + "','" + newValue.MaLoKhoan + "','" + newValue.BanKinh + "','" + newValue.ChieuSau + "','" + newValue.HuongKhoan + "','" + Math.Round(newValue.ToaDoX, 2) + "','" + Math.Round(newValue.ToaDoY, 2) + "')";
                    conn.SetData(sql);
                }
            }
            return true;
        }
    }
}
