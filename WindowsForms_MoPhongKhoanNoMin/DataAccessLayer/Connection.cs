using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace WindowsForms_MoPhongKhoanNoMin.DataAccessLayer
{
    class Connection
    {
        private static String chuoiKetNoi = "Data Source=..\\..\\Database\\KhoanNoMin.db;Version=3;New=True;Compress=True;";
        private SQLiteConnection conn;

        public SQLiteConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }

        public Connection()
        {
            conn = new SQLiteConnection(chuoiKetNoi);     //hoặc dùng file App.config
        }

        /// <summary>
        /// Hàm mở kết nối, nếu xảy ra lỗi sẽ ném ex lên
        /// </summary>
        public bool OpenConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                    conn.Open();
            }
            catch (Exception ex)
            {
                ex.Data["UserMessage"] += "\nKhông thể tạo kết nối đến CSDL";
                throw;  //ném lên layer business (dùng try catch để bắt lại)
            }
            return true;
        }

        /// <summary>
        /// Hàm đóng kết nối, nếu xảy ra lỗi sẽ ném ex lên
        /// </summary>
        public bool CloseConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                ex.Data["UserMessage"] += "\nKhông thể đóng kết nối đến CSDL";
                throw;
            }
            return true;
        }

        /// <summary>
        /// Hàm này trả về dữ liệu sau khi thực thi lệnh sql
        /// </summary>
        /// <param name="cmd">Câu lệnh sql</param>
        /// <returns>SQLiteDataReader</returns>
        public SQLiteDataReader GetData(string cmd)
        {
            SQLiteDataReader dr;
            try
            {
                this.OpenConnection();                          //đóng lại ở tầng business
                SQLiteCommand com = new SQLiteCommand(cmd, conn);
                dr = com.ExecuteReader();
            }
            catch (SQLiteException sqlException)
            {
                throw new Exception(sqlException.Message);
            }
            catch (Exception ex)
            {
                ex.Data["UserMessage"] += "\nKhông thể thực thi tác vụ lấy dữ liệu";
                throw ex;
            }
            return dr;
        }

        /// <summary>
        /// Hàm này thực thi lệnh sql tác động lên database
        /// </summary>
        /// <param name="cmd">Câu lệnh sql</param>
        /// /// <returns>bool</returns>
        public bool SetData(string cmd)
        {
            try
            {
                this.OpenConnection();
                SQLiteCommand com = new SQLiteCommand(cmd, conn);
                com.ExecuteNonQuery();
            }
            catch (SQLiteException sqlException)
            {
                sqlException.Data["UserMessage"] += "\nLỗi SQL - " + sqlException.Message;
                throw sqlException;
            }
            catch (Exception ex)
            {
                ex.Data["UserMessage"] += "\nKhông thể thực thi tác vụ thay đổi dữ liệu";
                throw ex;
            }
            return true;
        }
    }
}
