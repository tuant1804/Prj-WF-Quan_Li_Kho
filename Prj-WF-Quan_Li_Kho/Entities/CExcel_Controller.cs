
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Prj_WF_Quan_Li_Kho.Entities
{
    public class CExcel_Controller
    {
        public static void Export_Excel(CExcel p_objData, DataGridView p_drGrid)
        {
            //Đăng ký bản quyền
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            //Khai báo
            ExcelPackage v_epData = new();
            SaveFileDialog v_dialog = new();

            //Đếm số lượng cột bị ẩn
            HashSet<string> v_has = new HashSet<string>();
            for (int i = 2; i < p_drGrid.Columns.Count; i++)
            {
                if (!p_drGrid.Columns[i].Visible)
                {
                    v_has.Add(p_drGrid.Columns[i].Name);
                }
            }

            string[] v_arrCol_Header = new string[p_drGrid.Columns.Count - 2];

            //Chỉ lọc ra các file có định dạng Excel
            v_dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";

            //Nâng cấp giao diện với mỗi win
            v_dialog.AutoUpgradeEnabled = true;

            //Gán tên file
            v_dialog.FileName = Auto_Generate_File_Name(CConfig.Excel_File_Path_Export, p_objData.File_Name);

            // Gán địa chỉ lưu
            v_dialog.InitialDirectory = CConfig.Excel_File_Path_Export;
            //Gán cứng địa chỉ lưu
            v_dialog.RestoreDirectory = true;

            //Gán địa chỉ lưu
            //v_dialog.CustomPlaces.Add(CConfig.Excel_File_Path_Export + "/"+p_objData.File_Name);

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (v_dialog.ShowDialog() == DialogResult.OK)
            {
                p_objData.File_Path = v_dialog.FileName;
            }

            if (string.IsNullOrEmpty(p_objData.File_Path))
            {
                throw new Exception("Thêm không thành công !");
            }

            try
            {
                //Set các thuộc tính
                v_epData.Workbook.Properties.Author = p_objData.Author;

                v_epData.Workbook.Properties.Title = p_objData.File_Name;

                v_epData.Workbook.Worksheets.Add(p_objData.Name_Sheet);

                //Lấy sheet đó ra xử lý
                ExcelWorksheet v_ewSheet = v_epData.Workbook.Worksheets[0];

                v_ewSheet.Cells.Style.Font.Size = 11;
                // font family mặc định cho cả sheet
                v_ewSheet.Cells.Style.Font.Name = "Calibri";

                //Lấy số lượng col
                int v_iCount_Col = v_arrCol_Header.Length - v_has.Count;
                v_ewSheet.Cells[1, 1].Value = p_objData.Name_Title;

                //Gôm cột lại
                v_ewSheet.Cells[1, 1, 1, v_iCount_Col].Merge = true;
                v_ewSheet.Cells[1, 1, 1, v_iCount_Col].Style.Font.Bold = true;
                v_ewSheet.Cells[1, 1, 1, v_iCount_Col].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                int v_colIndex = 1;
                int v_rowIndex = 2;

                //Tạo Header
                int v_icol_index = 0;
                for (int i = 2; i < p_drGrid.Columns.Count; i++)
                {
                    if (p_drGrid.Columns[i].Visible)
                    {
                        v_arrCol_Header[v_icol_index] = p_drGrid.Columns[i].HeaderText;
                        v_icol_index++;
                    }
                }

                foreach (var v_item in v_arrCol_Header)
                {
                    if (v_item != null)
                    {
                        var v_cell = v_ewSheet.Cells[v_rowIndex, v_colIndex];

                        //Set màu thành gray
                        var v_fill = v_cell.Style.Fill;
                        v_fill.PatternType = ExcelFillStyle.Solid;
                        v_fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);

                        //Căn chỉnh các border
                        var v_border = v_cell.Style.Border;
                        v_border.Bottom.Style =
                        v_border.Top.Style =
                        v_border.Left.Style =
                        v_border.Right.Style = ExcelBorderStyle.Thin;

                        //Gán giá trị
                        v_cell.Value = v_item;

                        //Tự động fix width
                        v_ewSheet.Cells[v_rowIndex, v_colIndex].AutoFitColumns();

                        v_colIndex++;
                    }
                }
                //Lấy các cột dòng bắt đầu
                int v_iRow = 3;
                int v_iCol = 1;
                // Lấy liệu từ DataGrid

                for (int i = 2; i < p_drGrid.Rows.Count; i++)
                {
                    v_iCol = 1;//Gán lại chỉ số col
                    for (int j = 2; j < p_drGrid.Columns.Count; j++)
                    {
                        if (!v_has.Contains(p_drGrid.Columns[j].Name))
                        {
                            v_ewSheet.Cells[v_iRow, (v_iCol++)].Value = p_drGrid.Rows[i].Cells[j].Value;
                        }
                    }
                    v_iRow++; // Tăng số dòng
                }


                //Lưu file lại
                Byte[] v_bin = v_epData.GetAsByteArray();
                File.WriteAllBytes(p_objData.File_Path, v_bin);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static FileInfo Get_File_Excel()
        {
            CExcel v_objData = new CExcel();
            OpenFileDialog v_dialog = new();

            //Gán địa chỉ mặc định
            v_dialog.InitialDirectory = CConfig.Excel_File_Path_Import;

            //Nâng cấp giao diện với mỗi win
            v_dialog.AutoUpgradeEnabled = true;

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (v_dialog.ShowDialog() == DialogResult.OK)
            {
                v_objData.File_Path = v_dialog.FileName;
            }
            else
            {
                return null;
            }

            //Lấy file
            return new FileInfo(v_objData.File_Path);
        }
        public static System.Data.DataTable List_Range_Value_To_End(int p_intSheet_Index, string p_strCell_From, string p_strCell_End, FileInfo p_fileInfo)
        {
            System.Data.DataTable v_dt = new System.Data.DataTable();
            //Đăng ký bản quyền
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage v_excelPackage = new ExcelPackage(p_fileInfo))
            {
                //Lấy sheet ra 
                ExcelWorksheet v_excelWorkSheet = v_excelPackage.Workbook.Worksheets[p_intSheet_Index];

                //Gán hàng bắt đầu
                int v_intRowStart = v_excelWorkSheet.Cells[p_strCell_From].End.Row;

                //Gán cột bắt đầu
                int v_intColumnStart = v_excelWorkSheet.Cells[p_strCell_From].End.Column;

                //Gán hàng kết thúc
                int v_intRowEnd = v_excelWorkSheet.Dimension.End.Row;

                //Gán đầy đủ vùng cần lấy của bảng
                p_strCell_End = p_strCell_End + v_intRowEnd.ToString();

                //Gán cột kết thúc
                int v_intColumnEnd = v_excelWorkSheet.Cells[p_strCell_End].End.Column;

                //Gán tên cột
                foreach (var cell in v_excelWorkSheet.Cells[1, v_intColumnStart, 1, v_intColumnEnd])
                {
                    string v_strColumnName = cell.Text.Trim();
                    v_dt.Columns.Add(v_strColumnName);
                }

                //Gán giá trị
                for (int i = v_intRowStart; i <= v_intRowEnd; i++)
                {
                    var row = v_excelWorkSheet.Cells[i, v_intColumnStart, i, v_intColumnEnd];
                    //Thêm một dòng mới
                    DataRow v_Row = v_dt.NewRow();
                    int v_intColumn = 0;
                    for (int j = v_intColumnStart; j <= v_intColumnEnd; j++)
                    {
                        v_Row[v_intColumn] = row[i, j].Value;
                        v_intColumn++;
                    }
                    v_dt.Rows.Add(v_Row);
                }

            }
            return v_dt;
        }
        static string Auto_Generate_File_Name(string p_strFile_Path, string p_strFile_Name)
        {
            string v_strFile_Name = p_strFile_Name;
            string v_strFile_Path = p_strFile_Path + "\\" + v_strFile_Name + ".xlsx";
            FileInfo v_fi = new(v_strFile_Path);

            int v_iCount = 1;
            while (v_fi.Exists)
            {
                v_strFile_Name = p_strFile_Name + $"({v_iCount})";
                v_strFile_Path = p_strFile_Path + "\\" + v_strFile_Name + ".xlsx";
                v_fi = new FileInfo(v_strFile_Path);
                v_iCount++;
            }

            return v_strFile_Name + ".xlsx";
        }
        public string Get_Cell_Value(int p_intSheet_Index, string p_strCell, FileInfo p_fileInfo)
        {
            string v_strCell_Value = CConst.STR_VALUE_NULL;
            //Đăng ký bản quyền
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;


            using (ExcelPackage v_excelPackage = new ExcelPackage(p_fileInfo))
            {
                //Lấy sheet
                ExcelWorksheet v_excelWorksheet = v_excelPackage.Workbook.Worksheets[$"Sheet{p_intSheet_Index}"];

                //Nếu giá trị của ô cần lấy null
                if (v_excelWorksheet.Cells[p_strCell].Value != null)
                    v_strCell_Value = v_excelWorksheet.Cells[p_strCell].Value.ToString();
            }
            return v_strCell_Value;
        }
        public string Get_Cell_Value(string p_strCell, FileInfo p_fileInfo)
        {
            return Get_Cell_Value(1, p_strCell, p_fileInfo);
        }
        public static bool Check_Excel_File_Type(string p_strFileName)
        {
            return p_strFileName == ".xls" || p_strFileName == ".xlsx";
        }

    }
}
