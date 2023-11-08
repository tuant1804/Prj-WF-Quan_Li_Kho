using Prj_WF_Quan_Li_Kho.Entities;
using Prj_WF_Quan_Li_Kho.Entities.Controller;
using Prj_WF_Quan_Li_Kho.Entities.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Prj_WF_Quan_Li_Kho
{
    public partial class frm_Dang_Nhap : Form
    {

        public CSYS_Thanh_Vien m_objData = new CSYS_Thanh_Vien();

        List<CSYS_Thanh_Vien> m_lstThanh_Vien = new List<CSYS_Thanh_Vien>();

        private CSYS_Thanh_Vien_Controller m_objCtrl_Thanh_Vien = new CSYS_Thanh_Vien_Controller();

        private frm_Main m_frmMain;

        /// <summary>
        /// Parameter
        /// </summary>
        public bool Is_Check_Account_Valid { get; set; } = false;

        public frm_Dang_Nhap() : base()
        {
            Is_Check_Account_Valid = false;
            InitializeComponent();
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            txt_Password.PasswordChar = '*';
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            m_objData = new CSYS_Thanh_Vien();

            //Lấy thông tin người dùng nhập
            m_objData.User_Name = txt_User_Name.Text;
            m_objData.PassWord = txt_Password.Text.ToString();

            try
            {
                foreach (CSYS_Thanh_Vien v_data in m_lstThanh_Vien)
                {
                    //Check user_name và pass_word
                    if (v_data.User_Name == m_objData.User_Name &&
                        v_data.PassWord == m_objData.PassWord)
                    {

                        m_objData = v_data;

                        //Bật cờ
                        Is_Check_Account_Valid = true;

                        break;
                    }
                }
                //Nếu tài khoản mật khẩu không tồn tại thì văng lỗi
                if (!Is_Check_Account_Valid)
                {
                    throw new Exception("Tên đăng nhập không tồn tại hoặc mật khẩu sai!");
                }
                else
                {
                    Hide();
                    m_frmMain = new frm_Main();
                    m_frmMain.Is_Valid = true;
                    m_frmMain.m_objThanh_Vien = m_objData;

                    m_frmMain.ShowDialog();

                    Is_Check_Account_Valid = m_frmMain.Is_Valid;
                    if (Is_Check_Account_Valid)
                    {
                        Close();
                    }
                    else
                    {
                        Show();
                    }
                }

            }
            catch (Exception ex)
            {
                Message_Box_Custom.MB_Notification("Thông báo", ex.Message.ToString());
                return;
            }
        }

        private void frm_Dang_Nhap_Load(object sender, EventArgs e)
        {
            try
            {
                //Tạo list            
                m_lstThanh_Vien.Clear();
                m_lstThanh_Vien = m_objCtrl_Thanh_Vien.FSys_Get_List_Thanh_Vien(CSQL.SqlConnection);

                txt_User_Name.Text = m_objData.User_Name;
                txt_Password.Text = m_objData.PassWord;
            }
            catch (Exception ex)
            {
                Message_Box_Custom.MB_Notification(Error_Basic.List_Error_Caption, ex.Message.ToString());
                return;
            }

        }

        /// <summary>
        /// Event: Khi nhấn vào sẽ hiện ra form đăng kí
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Subscribe_Click(object sender, EventArgs e)
        {
            /*Khai báo*/
            frm_Dang_Ky frm_Sub = new frm_Dang_Ky();

            //Ẩn form đăng nhập
            this.Hide();

            //Show form đăng kí
            frm_Sub.ShowDialog();

            //Hiện lại form sau khi đã đăng ký xong
            this.Show();
        }

        private void btn_Confirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btn_Confirm_Click(sender, e);
            }
        }
    }
}
