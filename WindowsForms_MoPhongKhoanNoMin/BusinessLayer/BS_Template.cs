using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WindowsForms_MoPhongKhoanNoMin.DataAccessLayer;

namespace WindowsForms_MoPhongKhoanNoMin.BusinessLayer
{
    class BS_Template
    {
        /// <summary>
        /// Hàm lấy danh sách Template
        /// </summary>
        /// <returns>List<Template></returns>
        static public List<Template> DanhSachTemplate()
        {
            List<Template> danhSachTemplate = new List<Template>();
            String sql = "SELECT * FROM Template";
            Connection conn = new Connection();
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                danhSachTemplate.Add(new Template(dr["ID"].ToString(), dr["TenTemplate"].ToString(), dr["DuongDan"].ToString(), dr["MoTa"].ToString(), dr["AnhMau"].ToString()));
            }
            return danhSachTemplate;
        }

        /// <summary>
        /// Hàm lấy Template theo id
        /// </summary>
        /// <param name="ID">ID Template</param>
        /// <returns>Template</returns>
        static public Template ChonTemplate(String ID)
        {
            if (ID == null)
            {
                return null;
            }
            Template danhSachTemplate = new Template();
            if (ID.Equals(String.Empty))
            {
                return danhSachTemplate;
            }          
            String sql = "SELECT * FROM Template WHERE ID = " + ID;
            Connection conn = new Connection();
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                danhSachTemplate = new Template(dr["ID"].ToString(), dr["TenTemplate"].ToString(), dr["DuongDan"].ToString(), dr["MoTa"].ToString(), dr["AnhMau"].ToString());
            }
            return danhSachTemplate;
        }
    }
}
