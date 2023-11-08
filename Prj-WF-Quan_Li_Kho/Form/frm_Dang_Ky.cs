using Prj_WF_Quan_Li_Kho.Entities;
using Prj_WF_Quan_Li_Kho.Entities.Controller;
using Prj_WF_Quan_Li_Kho.Entities.SQL;
using Prj_WF_Quan_Li_Kho.Entities.Sys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prj_WF_Quan_Li_Kho
{
    public partial class frm_Dang_Ky : Form
    {
        //Fields thành viên
        private CSYS_Thanh_Vien m_objData_Thanh_Vien = new CSYS_Thanh_Vien();
        private CSYS_Thanh_Vien_Chi_Tiet m_objData_Thanh_Vien_Chi_Tiet = new CSYS_Thanh_Vien_Chi_Tiet();
        private CSYS_Thanh_Vien_Controller m_objCtr = new CSYS_Thanh_Vien_Controller();

        //Fields nhóm quyền
        private List<CSYS_Nhom_Quyen> m_arrNhom_Quyen = new List<CSYS_Nhom_Quyen>();


        public frm_Dang_Ky()
        {

            //Khởi tạo các item
            InitializeComponent();
            //
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            /*Khai báo*/
           
            try
            {
                if (String.Compare(txt_Password.Text, txt_Nhap_Lai_Password.Text, true) != 0)
                {
                    throw new Exception("Mật khẩu không trùng nhau");
                }

                m_objData_Thanh_Vien.User_Name = txt_User_Name.Text;
                m_objData_Thanh_Vien.PassWord = txt_Password.Text;
                m_objData_Thanh_Vien_Chi_Tiet.Ho_Ten = txt_Name.Text;
                m_objData_Thanh_Vien_Chi_Tiet.Dia_Chi = txt_Dia_Chi.Text;

                string v_strEmail = txt_Email.Text;
                if (v_strEmail != CConst.STR_VALUE_NULL && !Kiem_Tra_Email(v_strEmail))
                {
                    throw new Exception("Email không hợp lệ!");
                }

                m_objData_Thanh_Vien_Chi_Tiet.Email = txt_Email.Text;
                if (rdbtn_Nam.Checked)
                {
                    m_objData_Thanh_Vien_Chi_Tiet.Gioi_Tinh = "Nam";

                }
                else if (rdbtn_Nu.Checked)
                {
                    m_objData_Thanh_Vien_Chi_Tiet.Gioi_Tinh = "Nữ";
                }

                m_objData_Thanh_Vien_Chi_Tiet.Nhom_Quyen_ID = CUtilities.Convert_To_Long(cBNhom_Quyen.SelectedValue);

                //Cập nhật người làm
                m_objData_Thanh_Vien.Last_Updated_By = m_objData_Thanh_Vien.User_Name;
                m_objData_Thanh_Vien_Chi_Tiet.Last_Updated_By = m_objData_Thanh_Vien.User_Name;

                //Insert data vào database
                int v_iThanh_Vien_ID = m_objCtr.FSys_Insert_Thanh_Vien(CSQL.SqlConnection, m_objData_Thanh_Vien);
                m_objData_Thanh_Vien_Chi_Tiet.Thanh_Vien_ID = v_iThanh_Vien_ID;
                m_objCtr.FSys_Insert_Thanh_Vien_Chi_Tiet(CSQL.SqlConnection, m_objData_Thanh_Vien_Chi_Tiet);

                //Thông báo
                MessageBox.Show("Thông báo", "Đăng kí thành công", MessageBoxButtons.OK);

                //Đóng form khi thực hiện xong form thông báo
                this.Close();
            }
            catch (Exception ex) // Bắt lỗi
            {
                MessageBox.Show(ex.Message.ToString(), "Đăng kí thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frm_Dang_Ky_Load(object sender, EventArgs e)
        {
            //Khởi tạo đối tượng khi đăng kí 
            m_objData_Thanh_Vien = new CSYS_Thanh_Vien();
            m_objData_Thanh_Vien_Chi_Tiet = new CSYS_Thanh_Vien_Chi_Tiet();


            CSYS_Nhom_Quyen_Controller v_objCrl_Nhom_Quyen = new CSYS_Nhom_Quyen_Controller();
            //Tạo danh sách
            m_arrNhom_Quyen = v_objCrl_Nhom_Quyen.FSys_Get_List_Nhom_Quyen(
                CSQL.SqlConnection);


            txt_User_Name.Text = CConst.STR_VALUE_NULL;
            txt_Password.Text = CConst.STR_VALUE_NULL;
            txt_Name.Text = CConst.STR_VALUE_NULL;
            txt_Dia_Chi.Text = CConst.STR_VALUE_NULL;
            txt_Email.Text = CConst.STR_VALUE_NULL;

            //set list cho combo
            cBNhom_Quyen.DataSource = m_arrNhom_Quyen.ToList();
            cBNhom_Quyen.DisplayMember = "Ten_Nhom_Quyen";
            cBNhom_Quyen.ValueMember = "Nhom_Quyen_ID";

        }

        private void txt_Nhap_Lai_Password_TextChanged(object sender, EventArgs e)
        {
            txt_Nhap_Lai_Password.PasswordChar = '*';
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            txt_Password.PasswordChar = '*';
        }

        private bool Kiem_Tra_Email(string p_strEmail)
        {
            return p_strEmail.Contains("@gmail.com") || (p_strEmail.Contains('@') && p_strEmail.Length > 10);
        }
    }
}
