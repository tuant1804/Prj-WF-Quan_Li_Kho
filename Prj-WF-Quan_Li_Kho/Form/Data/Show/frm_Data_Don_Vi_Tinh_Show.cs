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
        }

        private void frm_Data_Don_Vi_Tinh_Show_Load(object sender, EventArgs e)
        {
            try
            {
                CData_Don_Vi_Tinh_Controller v_ctrlDon_Vi_Tinh = new CData_Don_Vi_Tinh_Controller();
                m_arrList_Data_Don_Vi_Tinh = v_ctrlDon_Vi_Tinh.List_Data_Don_Vi_Tinh(CSQL.SqlConnection);

                Load_Data_Grid(drGrid);
            }
            catch (Exception ex)
            {
                Message_Box_Custom.MB_Notification(Error_Basic.List_Error_Caption, ex.Message);
                return;
            }
        }

        private void drGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frm_Data_Don_Vi_Tinh_Edit newEdit = new frm_Data_Don_Vi_Tinh_Edit();
            newEdit.ShowDialog();
            frm_Data_Don_Vi_Tinh_Show_Load(sender, e);
        }



        private void drGrid_SelectionChanged(object sender, EventArgs e)
        {
            //int index = drGrid.CurrentCell.RowIndex;//Lấy dữ ra chỉ số của row đang lựa chọn 
            //CUtilities.Convert_To_Long(drGrid.Rows[index].Cells[0].Value.ToString());
        }

        private void Load_Data_Grid(DataGridView p_drView)
        {
            //Set các thuộc tính cho DataGrid
            p_drView.AutoResizeColumns();
           
            int count = 0;
            foreach (CDaTa_Don_Vi_Tinh v_data in m_arrList_Data_Don_Vi_Tinh)
            {
                p_drView.Rows.
            }
        }

    }
}
