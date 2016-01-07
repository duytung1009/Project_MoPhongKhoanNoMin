using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using Excel = Microsoft.Office.Interop.Excel;
using WindowsForms_MoPhongKhoanNoMin.CustomControls;
using WindowsForms_MoPhongKhoanNoMin.DataAccessLayer;

namespace WindowsForms_MoPhongKhoanNoMin.BusinessLayer
{
    class BS_Main
    {
        public static void LoadingScreen()
        {
            Application.Run(new Loading());
        }

        public static bool ExcelExport<T>(List<T> dataSource)
        {
            Thread t = new Thread(new ThreadStart(LoadingScreen));
            t.Start();
            //convert từ List sang DataTable
            //http://www.c-sharpcorner.com/UploadFile/deveshomar/exporting-generic-listt-to-excel-in-C-Sharp-using-interop/
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            System.Data.DataTable dataTable = new System.Data.DataTable();
            foreach (PropertyDescriptor prop in properties)
            {
                dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }              
            foreach (T item in dataSource)
            {
                DataRow row = dataTable.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                dataTable.Rows.Add(row);
            }
            //xuất ra file excel
            try
            {
                if (dataTable == null || dataTable.Columns.Count == 0)
                    throw new Exception("ExportToExcel: Bảng trống hoặc không tồn tại!\n");
                // load excel, and create a new workbook
                Excel.Application excelApp = new Excel.Application();
                excelApp.Workbooks.Add();
                // single worksheet
                Excel._Worksheet workSheet = excelApp.ActiveSheet;
                workSheet.Name = "ExportSheet";
                // column headings
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    workSheet.Cells[1, (i + 1)] = dataTable.Columns[i].ColumnName;
                    
                }
                // rows
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    // to do: format datetime values before printing
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        workSheet.Cells[(i + 2), (j + 1)] = dataTable.Rows[i][j];
                    }
                }
                string ExcelFilePath = null;
                if (ExcelFilePath != null && ExcelFilePath != "")
                {
                    try
                    {
                        workSheet.SaveAs(ExcelFilePath);
                        excelApp.Quit();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ExportToExcel: Không thể lưu file Excel, kiểm tra đường dẫn.\n" + ex.Message);
                    }
                }
                else    // no filepath is given
                {
                    excelApp.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
            }
            t.Abort();
            return true;
        }

        public static bool PrintData<T>(List<T> dataSource)
        {
            Thread t = new Thread(new ThreadStart(LoadingScreen));
            t.Start();
            //convert từ List sang DataTable
            //http://www.c-sharpcorner.com/UploadFile/deveshomar/exporting-generic-listt-to-excel-in-C-Sharp-using-interop/
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            System.Data.DataTable dataTable = new System.Data.DataTable();
            foreach (PropertyDescriptor prop in properties)
            {
                dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            foreach (T item in dataSource)
            {
                DataRow row = dataTable.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                dataTable.Rows.Add(row);
            }
            //xuất ra file excel
            try
            {
                if (dataTable == null || dataTable.Columns.Count == 0)
                    throw new Exception("ExportToExcel: Bảng trống hoặc không tồn tại!\n");
                // load excel, and create a new workbook
                Excel.Application excelApp = new Excel.Application();
                excelApp.Workbooks.Add();
                // single worksheet
                Excel._Worksheet workSheet = excelApp.ActiveSheet;
                workSheet.Name = "ExportSheet";
                // column headings
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    workSheet.Cells[1, (i + 1)] = dataTable.Columns[i].ColumnName;

                }
                // rows
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    // to do: format datetime values before printing
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        workSheet.Cells[(i + 2), (j + 1)] = dataTable.Rows[i][j];
                    }
                }                
                string ExcelFilePath = null;
                if (ExcelFilePath != null && ExcelFilePath != "")
                {
                    try
                    {
                        workSheet.SaveAs(ExcelFilePath);
                        excelApp.Quit();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ExportToExcel: Không thể lưu file Excel, kiểm tra đường dẫn.\n" + ex.Message);
                    }
                }
                else    // no filepath is given
                {
                    excelApp.Visible = true;
                }
                bool dialogResult =
                excelApp.Dialogs[Excel.XlBuiltInDialog.xlDialogPrintPreview].Show(
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
            }           
            t.Abort();
            return true;
        }

        /*public static void InHoChieu(String _maHoChieu)
        {
            //dữ liệu tính toán.
            double duongKhang;             // Đường Kháng 
            double KC_Hang;               // Khoảng cách giữa các hàng. (b)
            double KC_Cot;               // Khoảng cách giữa các lỗ mìn (A)
            double chieuSauThem;
            double chieuSauToanBoLK;     // Chiều dài lỗ khoan  (Lk)
            double chieuDaiBua;          //Chieu cao cột bua thiết kế  (Lbua)
            double congTB;
            int soCotMin, hangMin, tongLoMin;;
            //
            HoChieu hoChieu = new HoChieu();
            List<LoKhoan> danhSachLoKhoan = new List<LoKhoan>();
            DateTime thoiDiemNo;
            Connection conn = new Connection();
            string sql = "SELECT HoChieu.*,LoKhoan.ID,LoKhoan.MaLK,LoKhoan.BanKinhLK,LoKhoan.ChieuSauLK FROM  LoKhoan ,BanVe,HoChieu WHERE HoChieu.MaHoChieu = LoKhoan.MaHoChieu and BanVe.ID= LoKhoan.MaBanVe and HoChieu.MaHoChieu = \'" + _maHoChieu + "\'  AND BanVe.ID= \'" + BS_BanVe.BanVe(_maHoChieu).ID + "\';";
            SQLiteDataReader dr = conn.GetData(sql);
            while (dr.Read())
            {
                hoChieu.TenHoChieu = dr["TenHoChieu"].ToString();
                hoChieu.ChieuCaoTang = Convert.ToDouble(dr["ChieuCaoTang"].ToString());
                hoChieu.HeSoKC = Convert.ToDouble(dr["HeSoKC"].ToString());
                hoChieu.KichThuoc_X = Convert.ToDouble(dr["KichThuoc_X"].ToString());
                hoChieu.KichThuoc_Y = Convert.ToDouble(dr["KichThuoc_Y"].ToString());

                thoiDiemNo = DateTime.ParseExact(dr["ThoiDiemNo"].ToString(), "dd/M/yyyy hh:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

                hoChieu.MaDatDa = dr["MaDatDa"].ToString();
                hoChieu.MaCapDo = dr["MaCapDo"].ToString();
                hoChieu.MaMayKhoan = dr["MaMayKhoan"].ToString();
                hoChieu.MaThuocNo = dr["MaThuocNo"].ToString();
                hoChieu.MaCongTruong = dr["MaCongTruong"].ToString();
                danhSachLoKhoan.Add(new LoKhoan(dr["MaLK"].ToString(), Convert.ToDouble(dr["BanKinhLK"].ToString()), Convert.ToDouble(dr["ChieuSauLK"].ToString()) ));                
            }
            dr.Close();

            //Lấy hết giá trị của bảng Đất Đá 
            DatDa datDa = BS_DatDa.DatDa(hoChieu.MaDatDa);

            //Lấy hết giá trị từ bảng Cấp độ nổ
            CapDoNo capDoNo = BS_CapDoNo.CapDoNo(hoChieu.MaCapDo);

            //Lấy hết giá trị của bảng Máy khoan 
            MayKhoan mayKhoan = BS_MayKhoan.MayKhoan(hoChieu.MaMayKhoan);

            //Lấy hết giá trị của bảng Thuốc nổ
            ThuocNo thuocNo = BS_ThuocNo.ThuocNo(hoChieu.MaThuocNo);

            //Lấy hết giá trị của bảng Công trường
            CongTruong congTruong = BS_CongTruong.CongTruong(hoChieu.MaCongTruong);

            //tính toán
            congTB = Math.Round((thuocNo.KhaNangSinhCong / 360) * 100) / 100;   // Cong trung binh (e)

                //duong Khang chan tang
            duongKhang = Math.Round((53 * datDa.KCTB_KhoiNut * (mayKhoan.DuongKinhLoKhoan / 1000) * Math.Sqrt(thuocNo.MatDoNapThuoc * congTB / datDa.DungTrong) * (1.6 - 0.5 * hoChieu.HeSoKC)) * 100) / 100;
            //Khoang cach giua cac lo min  (Kí Hiệu {A})
            KC_Cot = Math.Round((hoChieu.HeSoKC * duongKhang) * 100) / 100;
            // Khoảng cách giữa các hàng  (Kí Hiệu {b})
            KC_Hang = Math.Round((0.85 * KC_Cot) * 100) / 100;
            //Chieu sau khoan them
            chieuSauThem = Math.Round((0.3 * KC_Hang) * 100) / 100;
            // Chieu dai lo khoan (Kí Hiệu {Lk})
            chieuSauToanBoLK = Math.Round((mayKhoan.ChieuSau + chieuSauThem) * 100) / 100;
            // Chieu cao cột bua thiết kế ( Kí Hiệu {Lbua})
            chieuDaiBua = Math.Round((0.75 * duongKhang) * 100) / 100;
            //Hang min
            hangMin = Convert.ToInt32(hoChieu.KichThuoc_Y / KC_Hang);
            //Hangmin = Math.Round(Hangmin * 100) / 100;
            //Cot min
            soCotMin = Convert.ToInt32((hoChieu.KichThuoc_X - duongKhang) / KC_Cot);
            // Tổng số lỗ mìn    (Kí Hiệu {Tổng số lỗ})
            tongLoMin = soCotMin * hangMin;
        }*/
    }
}
