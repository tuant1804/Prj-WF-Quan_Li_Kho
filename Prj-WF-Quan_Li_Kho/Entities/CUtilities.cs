using Prj_WF_Quan_Li_Kho.Entities.Sys;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_WF_Quan_Li_Kho.Entities
{
    public class CUtilities
    {
        private static StreamWriter m_swWrite_File = null;
        private Random m_rd = new Random();

        #region Nhóm convert
        public static int Convert_To_Int_32(object p_objData)
        {
            if (p_objData != null)
            {
                return Convert.ToInt32(p_objData);
            }
            return CConst.INT_VALUE_NULL;
        }
        public static string Convert_To_String(object p_objData)
        {
            if (p_objData != null)
            {
                return p_objData.ToString();
            }
            return CConst.STR_VALUE_NULL;
        }
        public static long Convert_To_Long(object p_objData)
        {
            if (p_objData != null)
            {
                return (long)Convert.ToDecimal(p_objData);
            }
            return CConst.LONG_VALUE_NULL;
        }
        public static DateTime? Convert_To_DateTime(object p_objData)
        {
            if (p_objData != null)
            {

                return DateTime.Parse(p_objData.ToString());
            }
            else
                return CConst.DTM_VALUE_NULL;
        }
        #endregion

        #region Tool

        //
        public static void Luu_Thong_Tin_User_Dang_Nhap(CSYS_Thanh_Vien p_objData_1, CSYS_Thanh_Vien_Chi_Tiet p_objData_2)
        {
            m_swWrite_File = new StreamWriter(CConfig.File_Name_Session_Luu_Vet_Dang_Nhap);

            m_swWrite_File.WriteLine(p_objData_1.Auto_ID);
            m_swWrite_File.WriteLine(p_objData_1.User_Name);
            m_swWrite_File.WriteLine(p_objData_1.PassWord);

            m_swWrite_File.WriteLine(p_objData_2.Nhom_Quyen_ID);

            m_swWrite_File.Dispose();
            m_swWrite_File.Close();

        }


        #endregion


        #region Nhóm random

        #endregion
    }
}
