using Prj_WF_Quan_Li_Kho.Entities;
using Prj_WF_Quan_Li_Kho.Entities.Controller;
using Prj_WF_Quan_Li_Kho.Entities.Data;
using Prj_WF_Quan_Li_Kho.Entities.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_WF_Quan_Li_Kho
{
    public partial class frm_Data_Don_Vi_Tinh_Edit : Form
    {

        //Parameters
        public long m_lngAuto_ID { get; set; }
        public bool m_Is_Updated = false;
        public string Last_Updated_By { get; set; } = "";
        public string Last_Updated_By_Function { get; set; } = "";

        private CData_Don_Vi_Tinh m_objData = new CData_Don_Vi_Tinh();

        public frm_Data_Don_Vi_Tinh_Edit()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (m_Is_Updated == true)
            {
                m_objData.Ten_Don_Vi_Tinh = txtDon_Vi_Tinh.Text;
                m_objData.Ghi_Chu = txtGhi_Chu.Text;

                Updated();
            }
            else
            {
                Add();
            }
        }

        private void frm_Data_Don_Vi_Tinh_Edit_Load(object sender, EventArgs e)
        {
            CData_Don_Vi_Tinh_Controller v_ctrlDon_Vi_Tinh = new CData_Don_Vi_Tinh_Controller();
            m_objData = v_ctrlDon_Vi_Tinh.Get_Data_Don_Vi_Tinh_By_ID(CSQL.SqlConnection, m_lngAuto_ID);

            if (m_objData == null)
            {
                //Set tiêu đề form
                this.Text = "Thêm";

                m_objData = new CData_Don_Vi_Tinh();
                m_Is_Updated = false;
            }
            else
            {
                //Set tiêu đề form
                this.Text = "Chỉnh sửa";

                m_Is_Updated = true;
            }
            txtDon_Vi_Tinh.Text = m_objData.Ten_Don_Vi_Tinh;
            txtGhi_Chu.Text = m_objData.Ghi_Chu;

            m_objData.Last_Updated_By = Last_Updated_By;
            m_objData.Last_Updated_By_Function = Last_Updated_By_Function;
        }

        private void Updated()
        {
            try
            {
                CData_Don_Vi_Tinh_Controller v_ctrlDon_Vi_Tinh = new CData_Don_Vi_Tinh_Controller();
                m_objData.Last_Updated_By_Function = "Updated";
                v_ctrlDon_Vi_Tinh.Updated_Data_Don_Vi_Tinh(CSQL.SqlConnection, m_objData);
                CMessage_Box_Custom.MB_Notification(CCaption.Caption_Updated, "Cập nhật đơn vị tính thành công", MessageBoxIcon.None);
                Close();

            }
            catch (Exception ex)
            {
                CMessage_Box_Custom.MB_Notification(CCaption.Caption_Updated, ex.ToString(), MessageBoxIcon.Error);
                return;
            }
        }

        private void Add()
        {
            try
            {
                m_objData.Ten_Don_Vi_Tinh = txtDon_Vi_Tinh.Text;
                m_objData.Ghi_Chu = txtGhi_Chu.Text;

                CData_Don_Vi_Tinh_Controller v_ctrlDon_Vi_Tinh = new CData_Don_Vi_Tinh_Controller();
                v_ctrlDon_Vi_Tinh.Insert_Data_Don_Vi_Tinh(CSQL.SqlConnection, m_objData);
                m_objData.Last_Updated_By_Function = "Add";

                Close();
                CMessage_Box_Custom.MB_Notification(CCaption.Caption_Insert, "Thêm 1 đơn vị tính thành công", MessageBoxIcon.None);


            }
            catch (Exception ex)
            {
                CMessage_Box_Custom.MB_Notification(CCaption.Caption_Insert, CError_Basic.Insert_Error_Caption + ex.Message, MessageBoxIcon.Error);
                return;
            }
        }

    }
}
