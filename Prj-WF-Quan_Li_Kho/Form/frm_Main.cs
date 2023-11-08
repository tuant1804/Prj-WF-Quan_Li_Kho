using Newtonsoft.Json.Linq;
using Prj_WF_Quan_Li_Kho.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_WF_Quan_Li_Kho
{
    public partial class frm_Main : Form
    {

        public CSYS_Thanh_Vien m_objThanh_Vien { get; set; }
        public bool Is_Valid { get; set; }

        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            try
            {
                

            }
            catch (Exception ex)
            {
                Message_Box_Custom.MB_Notification(Error_Basic.List_Error_Caption, ex.Message.ToString());
                return;
            }


        }

        private void frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!this.userControl11.Is_Valid_Account)
            {
                Is_Valid = false;
            }
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            this.userControl11.m_frmInstead = this;
            this.userControl11.m_objThanh_Vien = m_objThanh_Vien;
            this.userControl11.Is_Valid_Account = Is_Valid;

        }
    }
}
