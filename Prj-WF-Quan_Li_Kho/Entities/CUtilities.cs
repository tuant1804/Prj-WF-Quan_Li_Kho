using Prj_WF_Quan_Li_Kho.Entities.Sys;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
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
        public static double Convert_To_Double(object p_objData)
        {
            if ((p_objData != System.DBNull.Value) && (Convert_To_String(p_objData) != ""))
                return Convert.ToDouble(p_objData);
            else
                return CConst.DBL_VALUE_NULL;
        }
        public static bool Convert_To_Bool(object p_objData)
        {
            if (p_objData != System.DBNull.Value)
                return Convert.ToBoolean(p_objData);
            else
                return CConst.IS_VALUE_NULL;
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

        public static T Map_Data_To_Entity<T>(DataRow p_row) where T : new()
        {
            //Tạo biến chứa
            T v_objRes = new T();

            foreach (DataColumn v_col in p_row.Table.Columns)
            {
                //Lấy field của cột
                PropertyInfo v_info = v_objRes.GetType().GetProperty(v_col.ColumnName);

                //Check cột null hoặc dữ liệu null
                if (v_info != null && p_row[v_col] != DBNull.Value)
                {
                    //Lấy kiểu dữ liệu để set value hợp lý
                    string v_strTypedata = v_col.DataType.Name;

                    switch (v_strTypedata)
                    {
                        case "String":
                            v_info.SetValue(v_objRes, Convert_To_String(p_row[v_col]));
                            break;
                        case "Int16":
                            v_info.SetValue(v_objRes, Convert_To_Int_32(p_row[v_col]));
                            break;
                        case "Int32":
                            v_info.SetValue(v_objRes, Convert_To_Int_32(p_row[v_col]));
                            break;
                        case "Int64":
                            v_info.SetValue(v_objRes, Convert_To_Int_32(p_row[v_col]));
                            break;
                        case "DateTime":
                            v_info.SetValue(v_objRes, Convert_To_DateTime(p_row[v_col]));
                            break;
                        case "DateTime?":
                            v_info.SetValue(v_objRes, Convert_To_DateTime(p_row[v_col]));
                            break;
                        case "Double":
                            v_info.SetValue(v_objRes, Convert_To_Double(p_row[v_col]), null);
                            break;
                        case "Decimal":
                            v_info.SetValue(v_objRes, Convert_To_Double(p_row[v_col]), null);
                            break;
                        case "Boolean":
                            v_info.SetValue(v_objRes, Convert_To_Bool(p_row[v_col]), null);
                            break;
                    }
                }
            }
            return v_objRes;
        }
        public static int Calculate_Width_Grid_View(DataGridView p_drData)
        {
            int v_intRes = 0;
            foreach(DataGridViewColumn v_col in p_drData.Columns)
            {
                v_intRes += v_col.Width;
            }
            return v_intRes;
        }
        #region Nhóm random

        #endregion
    }
}
