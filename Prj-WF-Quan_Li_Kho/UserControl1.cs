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
    public partial class UserControl1 : UserControl
    {
        public Form m_frmInstead { get; set; }
        Form m_frmData = new Form();
        public bool Is_Valid_Account { get; set; }

        public CSYS_Thanh_Vien m_objThanh_Vien { get; set; }
        public UserControl1()
        {
            InitializeComponent();
        }
        private void Show_Form_Item(Form p_frmData)
        {
            try
            {
                if (p_frmData.GetType() != m_frmInstead.GetType())
                {
                    m_frmData = p_frmData;

                    m_frmData.ShowDialog();

                }
            }
            catch (Exception)
            {
            }
        }
        private void Log_Out_Accout(Form p_frmData)
        {
            p_frmData.Close();
        }

        #region Menu
        private void Don_Vi_Tinh_Item_Click(object sender, EventArgs e)
        {
            frm_Data_Don_Vi_Tinh_Show frmDon_Vi_Tinh_Show = new frm_Data_Don_Vi_Tinh_Show();
            frmDon_Vi_Tinh_Show.Last_Updated_By = m_objThanh_Vien.User_Name;
            Show_Form_Item(frmDon_Vi_Tinh_Show);
        }

        private void Loai_San_Pham_Item_Click(object sender, EventArgs e)
        {
            Show_Form_Item(new frm_Data_Loai_San_Pham_Edit());
        }


        private void San_Pham_Item_Click(object sender, EventArgs e)
        {
            Show_Form_Item(new frm_Data_San_Pham_Show());

        }

        private void Kho_Item_2_Click(object sender, EventArgs e)
        {
            Show_Form_Item(new frm_Kho_Show());
        }

        private void Nha_Cung_Cap_Item_Click(object sender, EventArgs e)
        {
            Show_Form_Item(new frm_Nha_Cung_Cap_Show());
        }

        private void Kho_User_Item_Click(object sender, EventArgs e)
        {
            Show_Form_Item(new frm_CN_Phan_Quyen_Kho_User());
        }

        private void Phieu_Nhap_Item_Click(object sender, EventArgs e)
        {
            Show_Form_Item(new frm_Data_Phieu_Nhap_Kho_Show());

        }

        private void Quan_Li_Phieu_Nhap_Item_Click(object sender, EventArgs e)
        {
            Show_Form_Item(new frm_Data_Phieu_Nhap_Kho_Show());

        }

        private void Ton_Kho_Item_Click(object sender, EventArgs e)
        {
            Show_Form_Item(new frm_Data_Ton_Kho_Show());
        }

        private void Phieu_Xuat_Item_Click(object sender, EventArgs e)
        {
            Show_Form_Item(new frm_Data_Phieu_Xuat_Kho_Show());
        }

        private void Quan_Li_Phieu_Xuat_Item_Click(object sender, EventArgs e)
        {
            Show_Form_Item(new frm_Data_Phieu_Xuat_Kho_Show());
        }

        private void Thong_Tin_Item_Click(object sender, EventArgs e)
        {
            Show_Form_Item(new frm_Sys_Thong_Tin_Show(m_objThanh_Vien.Auto_ID));
        }

        private void Doi_Mat_Khau_Item_Click(object sender, EventArgs e)
        {
            Show_Form_Item(new frm_Sys_Thong_Tin_Edit(m_objThanh_Vien.Auto_ID));
        }

        private void Dang_Xuat_Item_Click(object sender, EventArgs e)
        {
            Is_Valid_Account = false;

            Log_Out_Accout(m_frmInstead);
        }
        #endregion

    }
}
