using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using WindowsForms_MoPhongKhoanNoMin.DataAccessLayer;

namespace WindowsForms_MoPhongKhoanNoMin.BusinessLayer
{
    class BS_BanVe
    {
        /// <summary>
        /// Hàm lấy bản vẽ từ ID tương ứng
        /// </summary>
        /// <param name="ID">ID bản vẽ</param>
        /// <returns>BanVe</returns>
        public static BanVe BanVe(String ID)
        {
            BanVe danhSachBanVe = new BanVe();
            String sql = "SELECT * FROM BanVe WHERE ID = '" + ID + "'";
            Connection conn = new Connection();
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                danhSachBanVe = new BanVe(dr["ID"].ToString(), dr["Template"].ToString(), dr["TenBanVe"].ToString(), dr.GetString(3), dr.GetDouble(4), dr.GetDouble(5), dr["NguoiDung"].ToString(), (dr.GetInt32(7) == 1)? true:false);
            }
            return danhSachBanVe;           
        }

        /// <summary>
        /// Hàm cập nhật bản vẽ
        /// </summary>
        /// <param name="bv">Bản vẽ cần cập nhật</param>
        /// <returns>bool</returns>
        public static bool CapNhatBanVe(BanVe value)
        {
            String sql = "UPDATE BanVe SET Template = '" + value.Template + "', TenBanVe = '" + value.TenBanVe + "', NgayChinhSua = '" + value.NgayChinhSua + "', DeltaX = '" + value.DeltaX + "', DeltaY = '" + value.DeltaY + "', NguoiDung = '" + value.NguoiDung + "', HienKhoangCach = '" + ((value.HienKhoangCach)?1:0) + "' WHERE ID = '" + value.ID + "'";
            Connection conn = new Connection();
            return conn.SetData(sql);
        }

        /// <summary>
        /// Hàm xóa danh sách bản vẽ
        /// </summary>
        /// <param name="dsXoa">Danh sách bản vẽ cần xóa</param>
        /// <returns>bool</returns>
        public static bool XoaBanVe(List<BanVe> dsXoa)
        {
            if (dsXoa.Count == 0)
            {
                return true;
            }
            Connection conn = new Connection();
            String sql = "";
            foreach (BanVe value in dsXoa)
            {
                ////xóa lỗ khoan
                //sql = "DELETE FROM LoKhoan WHERE MaBanVe = '" + value.ID + "'";
                //conn.SetData(sql);
                ////xóa hộ chiếu
                //sql = "DELETE FROM HoChieu WHERE MaHoChieu = '" + value.MaHoChieu + "'";
                //conn.SetData(sql);
                //xóa bản vẽ
                sql = "DELETE FROM BanVe WHERE ID = '" + value.ID + "'";
                conn.SetData(sql);
            }
            return true;
        }

        /// <summary>
        /// Hàm tìm kiếm bản vẽ tương ứng với tên bản vẽ
        /// </summary>
        /// <param name="tenBanVe">Tên bản vẽ</param>
        /// <returns>List<BanVe></returns>
        public static List<BanVe> TimKiemBanVe(String tenBanVe)
        {
            List<BanVe> danhSachBanVe = new List<BanVe>();
            String sql = "SELECT * FROM BanVe WHERE TenBanVe LIKE '%" + tenBanVe + "%'";
            Connection conn = new Connection();
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                danhSachBanVe.Add(new BanVe(dr["ID"].ToString(), dr["Template"].ToString(), dr["TenBanVe"].ToString(), dr.GetString(3), dr.GetDouble(4), dr.GetDouble(5), dr["NguoiDung"].ToString(), (dr.GetInt32(7) == 1) ? true : false));
            }
            return danhSachBanVe;
        }

        /// <summary>
        /// Hàm trả về danh sách bản vẽ
        /// </summary>
        /// <returns>List<BanVe></returns>
        public static List<BanVe> DanhSachBanVe()
        {
            List<BanVe> danhSachBanVe = new List<BanVe>();
            String sql = "SELECT * FROM BanVe";
            Connection conn = new Connection();
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                danhSachBanVe.Add(new BanVe(dr["ID"].ToString(), dr["Template"].ToString(), dr["TenBanVe"].ToString(), dr.GetString(3), dr.GetDouble(4), dr.GetDouble(5), dr["NguoiDung"].ToString(), (dr.GetInt32(7) == 1) ? true : false));
            }
            return danhSachBanVe;
        }

        /// <summary>
        /// Hàm trả về danh sách bản vẽ sử dụng gần đây nhất
        /// </summary>
        /// <returns>List<BanVe></returns>
        public static List<BanVe> DanhSachBanVeGanNhat()
        {
            List<BanVe> danhSachBanVe = new List<BanVe>();
            String sql = "SELECT * FROM BanVe ORDER BY NgayChinhSua";
            Connection conn = new Connection();
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                danhSachBanVe.Add(new BanVe(dr["ID"].ToString(), dr["Template"].ToString(), dr["TenBanVe"].ToString(), dr.GetString(3), dr.GetDouble(4), dr.GetDouble(5), dr["NguoiDung"].ToString(), (dr.GetInt32(7) == 1) ? true : false));
            }
            return danhSachBanVe;
        }

        /// <summary>
        /// Hàm trả về danh sách bản vẽ sử dụng gần đây nhất (có giới hạn)
        /// </summary>
        /// <param name="number">số bản vẽ trả về</param>
        /// <returns>List<BanVe></returns>
        public static List<BanVe> DanhSachBanVeGanNhat(int number)
        {
            List<BanVe> danhSachBanVe = new List<BanVe>();
            String sql = "SELECT * FROM BanVe ORDER BY NgayChinhSua DESC LIMIT " + number;
            Connection conn = new Connection();
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                danhSachBanVe.Add(new BanVe(dr["ID"].ToString(), dr["Template"].ToString(), dr["TenBanVe"].ToString(), dr.GetString(3), dr.GetDouble(4), dr.GetDouble(5), dr["NguoiDung"].ToString(), (dr.GetInt32(7) == 1) ? true : false));
            }
            return danhSachBanVe;
        }

        /// <summary>
        /// Hàm tạo bản vẽ
        /// </summary>
        /// <param name="idTemplate">ID Template</param>
        /// <param name="tenBanVe">Tên bản vẽ</param>
        /// <returns>ID bản vẽ vừa tạo</returns>
        public static String TaoBanVe(String idTemplate, String tenBanVe)
        {            
            Connection conn = new Connection();            
            SQLiteDataReader dr;
            BanVe banVeVuaTao = new BanVe();
            bool flag = true;
            //kiểm tra tên bản vẽ có trùng ko
            List<BanVe> danhSachBanVe = BS_BanVe.DanhSachBanVe();
            foreach(BanVe value in danhSachBanVe)
            {
                if(value.TenBanVe == tenBanVe)
                {
                    flag = false; break;
                }
            }
            //nếu ko trùng => tạo bản vẽ mới, trả về id bản vẽ vừa tạo
            if (flag)
            {
                String sql = "INSERT INTO BanVe (Template, TenBanVe, NgayChinhSua) VALUES ('" + idTemplate + "','" + tenBanVe + "','" + DateTime.Now + "')";
                conn.SetData(sql);
                sql = "SELECT * FROM BanVe WHERE TenBanVe = '" + tenBanVe + "'";
                dr = conn.GetData(sql);
                while (dr.Read())
                {
                    banVeVuaTao = new BanVe(dr["ID"].ToString(), dr["Template"].ToString(), dr["TenBanVe"].ToString(), dr.GetString(3), dr.GetDouble(4), dr.GetDouble(5), dr["NguoiDung"].ToString(), (dr.GetInt32(7) == 1) ? true : false);
                }
                return banVeVuaTao.ID;            
            }
            //nếu trùng => trả về null
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Hàm tạo bản vẽ (không có template)
        /// </summary>
        /// <param name="tenBanVe">Tên bản vẽ</param>
        /// <returns>ID bản vẽ vừa tạo</returns>
        public static String TaoBanVe(String tenBanVe)
        {
            Connection conn = new Connection();
            SQLiteDataReader dr;
            BanVe banVeVuaTao = new BanVe();
            bool flag = true;
            //kiểm tra tên bản vẽ có trùng ko
            List<BanVe> danhSachBanVe = BS_BanVe.DanhSachBanVe();
            foreach (BanVe value in danhSachBanVe)
            {
                if (value.TenBanVe == tenBanVe)
                {
                    flag = false; break;
                }
            }
            //nếu ko trùng => tạo bản vẽ mới, trả về id bản vẽ vừa tạo
            if (flag)
            {
                String sql = "INSERT INTO BanVe (TenBanVe, NgayChinhSua) VALUES ('" + tenBanVe + "','" + DateTime.Now + "')";
                conn.SetData(sql);
                sql = "SELECT * FROM BanVe WHERE TenBanVe = '" + tenBanVe + "'";
                dr = conn.GetData(sql);
                while (dr.Read())
                {
                    banVeVuaTao = new BanVe(dr["ID"].ToString(), dr["Template"].ToString(), dr["TenBanVe"].ToString(), dr.GetString(3), dr.GetDouble(4), dr.GetDouble(5), dr["NguoiDung"].ToString(), (dr.GetInt32(7) == 1) ? true : false);
                }
                return banVeVuaTao.ID;
            }
            //nếu trùng => trả về null
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Hàm lưu bản vẽ (ko dùng nữa)
        /// </summary>
        /// <param name="list">Danh sách lỗ khoan cần lưu</param>
        /// <param name="_id">ID bản vẽ</param>
        /// <param name="idTemplate">ID Template(để "" nếu không thay đổi)</param>
        /// <returns>bool</returns>
        public static bool LuuBanVe(List<LoKhoan> list, String _id, String idTemplate)
        {
            if(list.Count == 0)
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
                    sql = "INSERT INTO LoKhoan (MaHoChieu, MaBanVe, MaMayKhoan, MaLK, BanKinhLK, ChieuSauLK, HuongKhoan, ToaDoX, ToaDoY) VALUES ('" + newValue.MaHoChieu + "','" + newValue.MaBanVe + "','" + newValue.MaMayKhoan + "','" + newValue.MaLoKhoan + "','" + newValue.BanKinh + "','" + newValue.ChieuSau + "','" + newValue.HuongKhoan + "','" + newValue.ToaDoX + "','" + newValue.ToaDoY + "')";
                    conn.SetData(sql);
                }
            }
            else
            {
                sql = "DELETE FROM LoKhoan WHERE MaBanVe = '" + _id + "'";
                conn.SetData(sql);
                foreach (LoKhoan newValue in list)
                {
                    sql = "INSERT INTO LoKhoan (MaHoChieu, MaBanVe, MaMayKhoan, MaLK, BanKinhLK, ChieuSauLK, HuongKhoan, ToaDoX, ToaDoY) VALUES ('" + newValue.MaHoChieu + "','" + newValue.MaBanVe + "','" + newValue.MaMayKhoan + "','" + newValue.MaLoKhoan + "','" + newValue.BanKinh + "','" + newValue.ChieuSau + "','" + newValue.HuongKhoan + "','" + newValue.ToaDoX + "','" + newValue.ToaDoY + "')";
                    conn.SetData(sql);
                }
            }
            //cập nhật template
            if (idTemplate.Equals(String.Empty))
            {
                return true;
            }
            else
            {
                sql = "UPDATE BanVe SET Template = '" + idTemplate + "' WHERE ID = '" + _id + "'";
                conn.SetData(sql);
            }
            return true;
        }
    }
}
