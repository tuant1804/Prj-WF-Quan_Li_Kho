using Prj_WF_Quan_Li_Kho.Entities;
using Prj_WF_Quan_Li_Kho.Entities.SQL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_WF_Quan_Li_Kho
{
    internal static class Program
    {
        private static SqlConnection conn { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            /*Dòng này kích hoạt các kiểu trực quan cho ứng dụng,
            điều này cho phép ứng dụng sử dụng kiểu trực quan của chủ đề hệ điều hành hiện tại.
            */
            Application.EnableVisualStyles();

            /*Dòng này đặt chế độ hiển thị văn bản tương thích.*/
            Application.SetCompatibleTextRenderingDefault(false);


            try
            {
                Run_Control();
                //Gọi form đăng nhập

                frm_Dang_Nhap v_frm_Dang_Nhap = new frm_Dang_Nhap();
                Application.Run(v_frm_Dang_Nhap);

            }
            catch (Exception ex)//Tránh ngắt chương trình
            {
                MessageBox.Show(ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        static void Run_Control()
        {
            //Lấy chuỗi kết nối thông qua app.config
            CConfig.Connection_String_Sql = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            
            CSQL.Create_Connection(CConfig.Connection_String_Sql);
            
        }
    }
}
