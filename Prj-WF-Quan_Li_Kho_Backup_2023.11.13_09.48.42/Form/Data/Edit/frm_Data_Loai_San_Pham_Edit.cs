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
    public partial class frm_Data_Loai_San_Pham_Edit : Form
    {

        //Parameters
        public long m_lngAuto_ID { get; set; }
        public bool m_Is_Updated = false;
        public string Last_Updated_By { get; set; } = "";
        public string Last_Updated_By_Function { get; set; } = "";

        private CData_Loai_San_Pham m_objData = new CData_Loai_San_Pham();

        public frm_Data_Loai_San_Pham_Edit()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (m_Is_Updated == true)
            {
                m_objData.Ten_Loai_San_Pham = txtLoai_San_Pham.Text;
                m_objData.Ghi_Chu = txtGhi_Chu.Text;
                Updated();
            }
            else
            {
                Add();
            }
        }

        private void frm_Data_Loai_San_Pham_Edit_Load(object sender, EventArgs e)
        {
            CData_Loai_San_Pham_Controller v_ctrlDon_Vi_Tinh = new CData_Loai_San_Pham_Controller();
            m_objData = v_ctrlDon_Vi_Tinh.Get_Data_Loai_San_Pham_By_ID(CSQL.SqlConnection, m_lngAuto_ID);

            if (m_objData == null)
            {
                //Set tiêu đề form
                this.Text = "Thêm";

                m_objData = new CData_Loai_San_Pham();
                m_Is_Updated = false;
            }
            else
            {
                //Set tiêu đề form
                this.Text = "Chỉnh sửa";

                m_Is_Updated = true;
            }
            txtLoai_San_Pham.Text = m_objData.Ten_Loai_San_Pham;
            txtGhi_Chu.Text = m_objData.Ghi_Chu;

            m_objData.Last_Updated_By = Last_Updated_By;
            m_objData.Last_Updated_By_Function = Last_Updated_By_Function;
        }

        private void Updated()
        {
            try
            {
                CData_Loai_San_Pham_Controller v_ctrlDon_Vi_Tinh = new CData_Loai_San_Pham_Controller();
                v_ctrlDon_Vi_Tinh.Updated_Data_Loai_San_Pham(CSQL.SqlConnection, m_objData);

                Close();
                CMessage_Box_Custom.MB_Notification(CCaption.Caption_Updated, "Cập nhật loại sản phẩm thành công", MessageBoxIcon.None);

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
                m_objData.Ten_Loai_San_Pham = txtLoai_San_Pham.Text;
                m_objData.Ghi_Chu = txtGhi_Chu.Text;

                CData_Loai_San_Pham_Controller v_ctrlDon_Vi_Tinh = new CData_Loai_San_Pham_Controller();
                v_ctrlDon_Vi_Tinh.Insert_Data_Loai_San_Pham(CSQL.SqlConnection, m_objData);

                Close();
                CMessage_Box_Custom.MB_Notification(CCaption.Caption_Insert, "Thêm 1 loại sản phẩm thành công", MessageBoxIcon.None);

            }
            catch (Exception ex)
            {
                CMessage_Box_Custom.MB_Notification(CCaption.Caption_Insert, CError_Basic.Insert_Error_Caption + ex.Message, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
