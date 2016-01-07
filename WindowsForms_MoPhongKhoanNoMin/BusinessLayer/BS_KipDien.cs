using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_MoPhongKhoanNoMin.BusinessLayer
{
    class BS_KipDien
    {
        /// <summary>
        /// Hàm thêm hoặc cập nhật kíp điện
        /// </summary>
        /// <param name="danhSachKipDien">danh sách kíp điện</param>
        /// <param name="kipDienThemVao">kíp điện cần thêm vào</param>
        /// <returns>List<KipDien></returns>
        public static List<KipDien> ThemKipDien(List<KipDien> danhSachKipDien, KipDien kipDienThemVao)
        {
            foreach (KipDien value in danhSachKipDien)
            {
                if(value.IDLoKhoan == kipDienThemVao.IDLoKhoan)
                {
                    value.ThoiGian += kipDienThemVao.ThoiGian;
                    return danhSachKipDien;
                }
            }
            //nếu chạy đến đây => kíp chưa có trong danh sách
            danhSachKipDien.Add(kipDienThemVao);
            return danhSachKipDien;
        }
    }
}
