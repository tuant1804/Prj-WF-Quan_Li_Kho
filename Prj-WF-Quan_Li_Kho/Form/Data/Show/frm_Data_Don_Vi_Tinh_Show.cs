using Prj_WF_Quan_Li_Kho.Entities;
using Prj_WF_Quan_Li_Kho.Entities.Controller;
using Prj_WF_Quan_Li_Kho.Entities.Data;
using Prj_WF_Quan_Li_Kho.Entities.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_WF_Quan_Li_Kho
{
    public partial class frm_Data_Don_Vi_Tinh_Show : Form
    {
        private List<CData_Don_Vi_Tinh> m_arrList_Data_Don_Vi_Tinh = new List<CData_Don_Vi_Tinh>();
        public string Last_Updated_By { get; set; } = "";

        public frm_Data_Don_Vi_Tinh_Show()
        {
            InitializeComponent();

            //Cho form xuất hiện giữa màn hình
            this.CenterToScreen();
        }

        private void frm_Data_Don_Vi_Tinh_Show_Load(object sender, EventArgs e)
        {
            try
            {
                CData_Don_Vi_Tinh_Controller v_ctrlDon_Vi_Tinh = new CData_Don_Vi_Tinh_Controller();
                m_arrList_Data_Don_Vi_Tinh = v_ctrlDon_Vi_Tinh.List_Data_Don_Vi_Tinh(CSQL.Connection);

                CCommon_Function.Load_Data_Grid_View(drGrid, m_arrList_Data_Don_Vi_Tinh);

                CCommon_Function.Format_Data_Grid_View(drGrid, 2);
            }
            catch (Exception ex)
            {
                CMessage_Box_Custom.MB_Notification(CError_Basic.List_Error_Caption, ex.Message, MessageBoxIcon.Error);
                Close();
                return;
            }
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            frm_Data_Don_Vi_Tinh_Edit newEdit = new frm_Data_Don_Vi_Tinh_Edit();

            newEdit.Last_Updated_By = Last_Updated_By;
            newEdit.m_lngAuto_ID = 0;
            newEdit.Last_Updated_By_Function = "btnThem_Click";

            newEdit.ShowDialog();

            frm_Data_Don_Vi_Tinh_Show_Load(sender, e);
        }

        private void drGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy cột cập nhật
            if (e.ColumnIndex == drGrid.Columns["Updated"].Index && e.RowIndex >= 0)
            {
                //Lấy vị trí của cột Auto_ID
                int v_intIndex = drGrid.Columns["Auto_ID"].Index;

                //Lấy giá trị của vị trí đó
                long v_lngAuto_ID = CUtilities.Convert_To_Long(drGrid.Rows[e.RowIndex].Cells[v_intIndex].Value);

                //Xử lý code
                frm_Data_Don_Vi_Tinh_Edit newEdit = new frm_Data_Don_Vi_Tinh_Edit();

                //Gán ID
                newEdit.m_lngAuto_ID = v_lngAuto_ID;
                //Gán người cập nhật cuối
                newEdit.Last_Updated_By = Last_Updated_By;
                //Gán hàm cập nhật cuối
                newEdit.Last_Updated_By_Function = "drGrid_CellContentClick_Updated";

                newEdit.ShowDialog();

                //Gọi lại hàm load
                frm_Data_Don_Vi_Tinh_Show_Load(sender, e);
            }
            try
            {
                //Lấy cột xóa
                if (e.ColumnIndex == drGrid.Columns["Deleted"].Index && e.RowIndex >= 0)
                {
                    if (DialogResult.Yes == CMessage_Box_Custom.MB_Notification(CCaption.Caption_Deleted, "Bạn có muốn xóa?", MessageBoxIcon.Question, MessageBoxButtons.YesNo))
                    {
                        //Lấy vị trí của cột Auto_ID
                        int v_intIndex = drGrid.Columns["Auto_ID"].Index;

                        //Lấy giá trị của vị trí đó
                        long v_lngAuto_ID = CUtilities.Convert_To_Long(drGrid.Rows[e.RowIndex].Cells[v_intIndex].Value);
                        
                        //Xử lý code
                        CData_Don_Vi_Tinh_Controller v_ctrlDon_Vi_Tinh = new CData_Don_Vi_Tinh_Controller();
                        CData_Don_Vi_Tinh v_objData = v_ctrlDon_Vi_Tinh.Get_Data_Don_Vi_Tinh_By_ID(CSQL.Connection, v_lngAuto_ID);

                        //Gán hàm cập nhật cuối
                        v_objData.Last_Updated_By_Function = "drGrid_CellContentClick_Deleted";

                        //Xóa
                        v_ctrlDon_Vi_Tinh.Deleted_Data_Don_Vi_Tinh(CSQL.Connection, v_objData);

                        //Gọi lại hàm load
                        frm_Data_Don_Vi_Tinh_Show_Load(sender, e);

                        //Xuất thông báo
                        CMessage_Box_Custom.MB_Notification(CCaption.Caption_Deleted, "Xóa đơn vị tính thành công", MessageBoxIcon.None);
                    }
                }
            }
            catch (Exception ex)
            {
                CMessage_Box_Custom.MB_Notification(CCaption.Caption_Deleted, "" + ex.Message.ToString(), MessageBoxIcon.Error);
                return;
            }
            //Gọi lại load data
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                CExcel v_objData = new CExcel();

                v_objData.Author = Last_Updated_By;
                v_objData.File_Name = "Đơn Vị Tính";
                v_objData.Name_Sheet = "Sheet 1";
                v_objData.Name_Title = "Danh sách đơn vị tính";

                CExcel_Controller.Export_Excel(v_objData, drGrid);

                CMessage_Box_Custom.MB_Notification(CCaption.Caption_Export_Excel, "Export thành công", MessageBoxIcon.None);
            }
            catch (Exception)
            {
                CMessage_Box_Custom.MB_Notification(CError_Basic.Not_Close_File_Excel, "File excel bạn muốn thay đổi chưa đóng", MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //Khai báo controller và entities
            CData_Don_Vi_Tinh_Controller v_ctrlDon_Vi_Tinh = new();
            CData_Don_Vi_Tinh v_objData = new();

            //Lấy file excel
            FileInfo v_fileInfo = CExcel_Controller.Get_File_Excel();

            if (v_fileInfo != null)
            {
                string v_strTextExl = v_fileInfo.Extension;

                //Kiểm tra có phải là file Excel không
                if (!CExcel_Controller.Check_Excel_File_Type(v_strTextExl))
                {
                    CMessage_Box_Custom.MB_Notification(CCaption.Caption_File_Path,
                        "File bạn chọn không phải là file Excel",
                        MessageBoxIcon.Warning, MessageBoxButtons.OK);
                    return;
                }

                //Phần xử lý code
                try
                {

                    //Fill vào table
                    DataTable v_dt = CExcel_Controller.List_Range_Value_To_End(0, "A3", "B", v_fileInfo);

                    for (int v_i = v_dt.Rows.Count - 1; v_i >= 0; v_i--)
                    {
                        //Loại đi các hàng có đơn vị tính trống
                        if (v_dt.Rows[v_i][0].ToString().Trim() == "")
                        {
                            v_dt.Rows.RemoveAt(v_i);
                        }
                    }

                    int v_iCount = 1;
                    int v_iCount_Insert_Success = 0;

                    string v_strRow_Error = "";

                    foreach (DataRow v_row in v_dt.Rows)
                    {
                        try
                        {
                            //Xử lý code
                            v_objData = new CData_Don_Vi_Tinh();

                            v_objData.Last_Updated_By = Last_Updated_By;
                            v_objData.Last_Updated_By_Function = "Import Excel";

                            v_objData.Ten_Don_Vi_Tinh = CUtilities.Convert_To_String(v_row[0]);
                            v_objData.Ghi_Chu = CUtilities.Convert_To_String(v_row[1]);
                            v_ctrlDon_Vi_Tinh.Insert_Data_Don_Vi_Tinh(CSQL.Connection, v_objData);

                            //Đếm số hàng thêm thành công
                            v_iCount_Insert_Success++;
                        }
                        catch (Exception ex) // bắt lỗi từng dòng
                        {
                            v_strRow_Error += "Hàng " + v_iCount.ToString() + " có lỗi: " + ex.Message + "\n";
                        }

                        //Tăng số dòng lên
                        v_iCount++;
                    }

                    //Xuất thông báo thêm thành công
                    string v_strMessage = "Thêm " + v_iCount_Insert_Success.ToString() + " dòng mới thành công" + "\n";

                    //Nếu có lỗi thì xuất ra luôn
                    if (v_strRow_Error != "")
                    {
                        v_strMessage += v_strRow_Error;
                    }

                    //Gọi lại hàm load
                    frm_Data_Don_Vi_Tinh_Show_Load(sender, e);

                    //Xuất thông báo
                    CMessage_Box_Custom.MB_Notification(CCaption.Caption_Import_Excel, v_strMessage);


                }
                catch (Exception ex)
                {
                    CMessage_Box_Custom.MB_Notification(CCaption.Caption_Import_Excel,
                        ex.Message,
                        MessageBoxIcon.Error, MessageBoxButtons.OK);
                }
            }
        }
    }
}

