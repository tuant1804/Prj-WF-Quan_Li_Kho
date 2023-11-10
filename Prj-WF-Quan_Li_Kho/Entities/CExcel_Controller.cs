using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.IO;
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
            //Khai báo
            ExcelPackage v_epData = new ExcelPackage();
            SaveFileDialog dialog = new SaveFileDialog();

            string[] v_arrCol_Header = new string[p_drGrid.Columns.Count];

            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                p_objData.File_Path = dialog.FileName;
            }

            if (string.IsNullOrEmpty(p_objData.File_Path))
            {
                CMessage_Box_Custom.MB_Notification(CError_Basic.Error_File_Path, "Đường dẫn không hợp lệ!");
                return;
            }

            try
            {
                //Set các thuộc tính
                v_epData.Workbook.Properties.Author = p_objData.Author;

                v_epData.Workbook.Properties.Title = p_objData.File_Name;

                v_epData.Workbook.Worksheets.Add(p_objData.Name_Sheet);

                //Lấy sheet đó ra xử lý
                ExcelWorksheet v_ewSheet = v_epData.Workbook.Worksheets[1];

                v_ewSheet.Cells.Style.Font.Size = 11;
                // font family mặc định cho cả sheet
                v_ewSheet.Cells.Style.Font.Name = "Calibri";

                //Lấy số lượng col
                int v_iCount_Col = v_arrCol_Header.Length;
                v_ewSheet.Cells[1, 1].Value = p_objData.Name_Title;

                //Gôm cột lại
                v_ewSheet.Cells[1, 1, 1, v_iCount_Col].Merge = true;
                v_ewSheet.Cells[1, 1, 1, v_iCount_Col].Style.Font.Bold = true;
                v_ewSheet.Cells[1, 1, 1, v_iCount_Col].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                int v_colIndex = 1;
                int v_rowIndex = 2;

                foreach (var item in v_arrCol_Header)
                {
                    var cell = v_ewSheet.Cells[v_colIndex, v_rowIndex];

                    //set màu thành gray
                    var fill = cell.Style.Fill;
                    fill.PatternType = ExcelFillStyle.Solid;
                    fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);

                    //căn chỉnh các border
                    var border = cell.Style.Border;
                    border.Bottom.Style =
                    border.Top.Style =
                    border.Left.Style =
                    border.Right.Style = ExcelBorderStyle.Thin;

                    //gán giá trị
                    cell.Value = item;

                    v_colIndex++;
                }

                // lấy liệu từ DataGrid
                List<object> v_arrData_Excel = (List<object>)p_drGrid.DataSource;
                foreach (var item in v_arrData_Excel)
                {
                    // bắt đầu ghi từ cột 1. Excel bắt đầu từ 1 không phải từ 0
                    v_colIndex = 1;

                    // rowIndex tương ứng từng dòng dữ liệu
                    v_rowIndex++;

                    //gán giá trị cho từng cell                      
                    //    v_ewSheet.Cells[v_rowIndex, v_colIndex++].Value = item.Name;

                    //    // lưu ý phải .ToShortDateString để dữ liệu khi in ra Excel là ngày như ta vẫn thấy.Nếu không sẽ ra tổng số :v
                    //    v_ewSheet.Cells[rowIndex, colIndex++].Value = item.Birthday.ToShortDateString();

                    //}
                    //Lưu file lại
                    Byte[] bin = v_epData.GetAsByteArray();
                    File.WriteAllBytes(p_objData.File_Path, bin);

                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
