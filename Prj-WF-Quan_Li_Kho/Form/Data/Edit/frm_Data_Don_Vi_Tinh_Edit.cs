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
        public bool m_Is_Updated { get; set; } = false;
        public string Last_Updated_By { get; set; } = "";


        private CDaTa_Don_Vi_Tinh m_objData;

        public frm_Data_Don_Vi_Tinh_Edit()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (m_Is_Updated == true)
            {
                Updated();
            }
            else
            {
                Add();
            }
            this.Close();
        }

        private void frm_Data_Don_Vi_Tinh_Edit_Load(object sender, EventArgs e)
        {
            CData_Don_Vi_Tinh_Controller v_ctrlDon_Vi_Tinh = new CData_Don_Vi_Tinh_Controller();
            m_objData = v_ctrlDon_Vi_Tinh.Get_Data_Don_Vi_Tinh_By_ID(CSQL.SqlConnection, m_lngAuto_ID);

            if (m_objData == null)
            {
                m_objData = new CDaTa_Don_Vi_Tinh();
                m_Is_Updated = false;
            }
            else
            {
                m_Is_Updated = true;
            }
            txtDon_Vi_Tinh.Text = m_objData.Ten_Don_Vi_Tinh;
            txtGhi_Chu.Text = m_objData.Ghi_Chu;

            m_objData.Last_Updated_By = Last_Updated_By;
        }

        private void Updated()
        {
            try
            {
                CData_Don_Vi_Tinh_Controller v_ctrlDon_Vi_Tinh = new CData_Don_Vi_Tinh_Controller();
                v_ctrlDon_Vi_Tinh.Updated_Data_Don_Vi_Tinh(CSQL.SqlConnection, m_objData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                    Error_Basic.Updated_Error_Caption,
                    MessageBoxButtons.OK);
            }

        }

        private void Add()
        {
            try
            {
                m_objData.Ten_Don_Vi_Tinh = txtDon_Vi_Tinh.Text;
                m_objData.Ghi_Chu = txtDon_Vi_Tinh.Text;

                CData_Don_Vi_Tinh_Controller v_ctrlDon_Vi_Tinh = new CData_Don_Vi_Tinh_Controller();
                v_ctrlDon_Vi_Tinh.Insert_Data_Don_Vi_Tinh(CSQL.SqlConnection, m_objData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                    Error_Basic.Add_Error_Caption,
                    MessageBoxButtons.OK);
            }
        }
    }
}
