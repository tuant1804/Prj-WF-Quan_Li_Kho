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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_WF_Quan_Li_Kho
{
    public partial class frm_Data_Don_Vi_Tinh_Show : Form
    {
        private List<CDaTa_Don_Vi_Tinh> m_arrList_Data_Don_Vi_Tinh = new List<CDaTa_Don_Vi_Tinh>();
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
                m_arrList_Data_Don_Vi_Tinh = v_ctrlDon_Vi_Tinh.List_Data_Don_Vi_Tinh(CSQL.SqlConnection);

                CCommon_Function.Load_Data_Grid_View(drGrid, m_arrList_Data_Don_Vi_Tinh);

                CCommon_Function.Format_Data_Grid_View(drGrid, 2);
            }
            catch (Exception ex)
            {
                CMessage_Box_Custom.MB_Notification(CError_Basic.List_Error_Caption, ex.Message);
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
            }
            try
            {
                //Lấy cột xóa
                if (e.ColumnIndex == drGrid.Columns["Deleted"].Index && e.RowIndex >= 0)
                {
                    if (DialogResult.OK == CMessage_Box_Custom.MB_Notification(CCaption.Caption_Deleted, "Bạn có muốn xóa?"))
                    {
                        //Lấy vị trí của cột Auto_ID
                        int v_intIndex = drGrid.Columns["Auto_ID"].Index;

                        //Lấy giá trị của vị trí đó
                        long v_lngAuto_ID = CUtilities.Convert_To_Long(drGrid.Rows[e.RowIndex].Cells[v_intIndex].Value);
                        //Xử lý code
                        CData_Don_Vi_Tinh_Controller v_ctrlDon_Vi_Tinh = new CData_Don_Vi_Tinh_Controller();
                        CDaTa_Don_Vi_Tinh v_objData = v_ctrlDon_Vi_Tinh.Get_Data_Don_Vi_Tinh_By_ID(CSQL.SqlConnection, v_lngAuto_ID);
                        
                        //Gán hàm cập nhật cuối
                        v_objData.Last_Updated_By_Function = "drGrid_CellContentClick_Deleted";

                        //Xóa
                        v_ctrlDon_Vi_Tinh.Deleted_Data_Don_Vi_Tinh(CSQL.SqlConnection, v_objData);
                    }
                }
            }
            catch (Exception ex)
            {
                CMessage_Box_Custom.MB_Notification(CCaption.Caption_Deleted, "" + ex.Message.ToString());
                return;
            }
            //Gọi lại load data
            frm_Data_Don_Vi_Tinh_Show_Load(sender, e);
        }

    }
}

