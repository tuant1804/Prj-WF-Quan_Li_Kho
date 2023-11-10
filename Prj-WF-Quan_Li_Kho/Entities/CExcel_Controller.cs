using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            string[] v_arrCol_Header = new string[p_drGrid.Columns.Count];

            //Chỉ lọc ra các file có định dạng Excel
            v_dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";

            //Gán tên file
            v_dialog.FileName = Auto_Generate_File_Name(CConfig.Excel_File_Path, p_objData.File_Name);

            //Gán địa chỉ lưu
            v_dialog.CustomPlaces.Add(CConfig.Excel_File_Path);

            //Nâng cấp giao diện với mỗi win
            v_dialog.AutoUpgradeEnabled = true;

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (v_dialog.ShowDialog() == DialogResult.OK)
            {
                p_objData.File_Path = v_dialog.FileName;
            }

            if (string.IsNullOrEmpty(p_objData.File_Path))
            {
                CMessage_Box_Custom.MB_Notification(CError_Basic.File_Path, "Đường dẫn không hợp lệ!",MessageBoxIcon.Error);
                return;
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
                int v_iCount_Col = v_arrCol_Header.Length - 3;
                v_ewSheet.Cells[1, 1].Value = p_objData.Name_Title;

                //Gôm cột lại
                v_ewSheet.Cells[1, 1, 1, v_iCount_Col].Merge = true;
                v_ewSheet.Cells[1, 1, 1, v_iCount_Col].Style.Font.Bold = true;
                v_ewSheet.Cells[1, 1, 1, v_iCount_Col].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                int v_colIndex = 1;
                int v_rowIndex = 2;

                //Tạo Header
                for (int i = 3; i < p_drGrid.Columns.Count; i++)
                {
                    v_arrCol_Header[i] = p_drGrid.Columns[i].HeaderText;
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

                // Lấy liệu từ DataGrid
                for (int i = 0; i < p_drGrid.Rows.Count; i++)
                {
                    for (int j = 0; j < p_drGrid.Columns.Count - 3; j++)
                    {
                        v_ewSheet.Cells[i + 3, j + 1].Value = p_drGrid.Rows[i].Cells[j + 3].Value;
                    }
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
    }
}
