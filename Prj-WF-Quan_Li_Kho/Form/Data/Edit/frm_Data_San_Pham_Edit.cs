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
    public partial class frm_Data_San_Pham_Edit : Form
    {

        //Parameters
        public long m_lngAuto_ID { get; set; }
        public bool m_Is_Updated = false;
        public string Last_Updated_By { get; set; } = "";
        public string Last_Updated_By_Function { get; set; } = "";


        private CData_San_Pham m_objData = new CData_San_Pham();

        private List<CData_Don_Vi_Tinh> m_arrDon_Vi_Tinh = new List<CData_Don_Vi_Tinh>();
        private List<CData_Loai_San_Pham> m_arrLoai_San_Pham = new List<CData_Loai_San_Pham>();

        public frm_Data_San_Pham_Edit()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (m_Is_Updated == true)
            {
                m_objData.Ma_San_Pham = txtMa_San_Pham.Text;
                m_objData.Ten_San_Pham = txtTen_San_Pham.Text;


                Updated();
            }
            else
            {
                Add();
            }
        }

        private void frm_Data_San_Pham_Edit_Load(object sender, EventArgs e)
        {
            CData_San_Pham_Controller v_ctrlSan_Pham = new CData_San_Pham_Controller();
            m_objData = v_ctrlSan_Pham.Get_Data_San_Pham_By_ID(CSQL.Connection, m_lngAuto_ID);

            if (m_objData == null)
            {
                //Set tiêu đề form
                this.Text = "Thêm";

                m_objData = new CData_San_Pham();
                m_Is_Updated = false;
            }
            else
            {
                //Set tiêu đề form
                this.Text = "Chỉnh sửa";

                m_Is_Updated = true;
            }
            txtMa_San_Pham.Text = m_objData.Ma_San_Pham;
            txtTen_San_Pham.Text = m_objData.Ten_San_Pham;

            m_objData.Last_Updated_By = Last_Updated_By;
            m_objData.Last_Updated_By_Function = Last_Updated_By_Function;
        }

        private void Updated()
        {
            try
            {
                CData_San_Pham_Controller v_ctrlSan_Pham = new CData_San_Pham_Controller();
                v_ctrlSan_Pham.Updated_Data_San_Pham(CSQL.Connection, m_objData);
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
                m_objData.Ten_San_Pham = txtMa_San_Pham.Text;
                m_objData.Ghi_Chu = txtTen_San_Pham.Text;

                CData_San_Pham_Controller v_ctrlSan_Pham = new CData_San_Pham_Controller();
                v_ctrlSan_Pham.Insert_Data_San_Pham(CSQL.Connection, m_objData);

                CMessage_Box_Custom.MB_Notification(CCaption.Caption_Insert, "Thêm 1 đơn vị tính thành công", MessageBoxIcon.None);
                Close();

            }
            catch (Exception ex)
            {
                CMessage_Box_Custom.MB_Notification(CCaption.Caption_Insert, CError_Basic.Insert_Error_Caption + ex.Message, MessageBoxIcon.Error);
                return;
            }
        }


    }
}
