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
    public partial class frm_Data_Phieu_Nhap_Kho_Show : Form
    {
        public frm_Data_Phieu_Nhap_Kho_Show()
        {
            InitializeComponent();
        }

        private void frm_Data_Phieu_Nhap_Kho_Show_Load(object sender, EventArgs e)
        {
          
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frm_Data_Don_Vi_Tinh_Edit newDon_Vi_Tinh = new frm_Data_Don_Vi_Tinh_Edit();
            newDon_Vi_Tinh.ShowDialog();
        }
    }
}
