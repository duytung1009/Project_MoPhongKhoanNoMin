using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using Excel = Microsoft.Office.Interop.Excel;
using WindowsForms_MoPhongKhoanNoMin.CustomControls;

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
    }
}
