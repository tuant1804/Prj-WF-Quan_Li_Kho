using Prj_WF_Quan_Li_Kho.Entities.SQL;
using Prj_WF_Quan_Li_Kho.Entities.Sys;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Prj_WF_Quan_Li_Kho.Entities.Controller
{
    public class CSYS_Thanh_Vien_Controller
    {
        /// <summary>
        /// Hàm này dùng để map data từ Datatable sang obj
        /// </summary>
        /// <param name="p_row"></param>
        /// <param name="p_objData"></param>
        private void Map_Data_To_Entity(DataRow p_row, CSYS_Thanh_Vien p_objData)
        {
            DataTable v_dt = p_row.Table;
            if (v_dt.Columns.Contains("Auto_ID"))
            {
                p_objData.Auto_ID = CUtilities.Convert_To_Int_32(p_row["Auto_ID"]);
            }
            if (v_dt.Columns.Contains("Ma_Dang_Nhap"))
            {
                p_objData.User_Name = CUtilities.Convert_To_String(p_row["Ma_Dang_Nhap"]);
            }
            if (v_dt.Columns.Contains("Mat_Khau"))
            {
                p_objData.PassWord = CUtilities.Convert_To_String(p_row["Mat_Khau"]);
            }
        }
        private void Map_Data_To_Entity(DataRow p_row, CSYS_Thanh_Vien_Chi_Tiet p_objData)
        {
            DataTable v_dt = p_row.Table;
            if (v_dt.Columns.Contains("Auto_ID"))
            {
                p_objData.Auto_ID = CUtilities.Convert_To_Int_32(p_row["Auto_ID"]);
            }

            if (v_dt.Columns.Contains("Ho_Ten"))
            {
                p_objData.Ho_Ten = CUtilities.Convert_To_String(p_row["Ho_Ten"]);
            }
            if (v_dt.Columns.Contains("Gioi_Tinh"))
            {
                p_objData.Gioi_Tinh = CUtilities.Convert_To_String(p_row["Gioi_Tinh"]);
            }
            if (v_dt.Columns.Contains("Dia_Chi"))
            {
                p_objData.Dia_Chi = CUtilities.Convert_To_String(p_row["Dia_Chi"]);
            }
            if (v_dt.Columns.Contains("Email"))
            {
                p_objData.Email = CUtilities.Convert_To_String(p_row["Email"]);
            }
            if (v_dt.Columns.Contains("Nhom_Quyen_ID"))
            {
                p_objData.Nhom_Quyen_ID = CUtilities.Convert_To_Int_32(p_row["Nhom_Quyen_ID"]);
            }
        }


        /// <summary>
        /// Hàm lấy danh sách các thành viên từ stoted
        /// </summary>
        /// <param name="p_conn"></param>
        /// <returns></returns>
        public List<CSYS_Thanh_Vien> FSys_Get_List_Thanh_Vien(SqlConnection p_conn)
        {
            List<CSYS_Thanh_Vien> v_arrRes = new List<CSYS_Thanh_Vien>();
            DataTable v_dt = new DataTable();
            try
            {

                v_dt = CSQL.FSQL_Get_Data_By_Stored(p_conn, "FSys_sp_sel_List_Sys_Thanh_Vien");

                if (v_dt.Rows.Count > 0)
                {
                    foreach (DataRow row in v_dt.Rows)
                    {
                        CSYS_Thanh_Vien v_objData = new CSYS_Thanh_Vien();
                        Map_Data_To_Entity(row, v_objData);
                        v_arrRes.Add(v_objData);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                v_dt.Dispose();
            }
            return v_arrRes;
        }

        public CSYS_Thanh_Vien_Chi_Tiet FSys_Get_Thanh_Vien_Chi_Tiet_By_Thanh_Vien_ID(SqlConnection p_conn, int p_iThanh_Vien_ID)
        {
            DataTable v_dt = new DataTable();
            CSYS_Thanh_Vien_Chi_Tiet v_objRes = new CSYS_Thanh_Vien_Chi_Tiet();

            try
            {
                v_dt = CSQL.FSQL_Get_Data_By_Stored(p_conn, "FSys_sp_sel_Get_Sys_Thanh_Vien_Chi_Tiet_By_ID", p_iThanh_Vien_ID);

                if (v_dt.Rows.Count > 0)
                {
                    Map_Data_To_Entity(v_dt.Rows[0], v_objRes);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                v_dt.Dispose();
            }
            return v_objRes;
        }

        /// <summary>
        /// Đăng kí thành viên
        /// </summary>
        /// <param name="p_conn"></param>
        /// <param name="p_objData"></param>
        public int FSys_Insert_Thanh_Vien(SqlConnection p_conn, CSYS_Thanh_Vien p_objData)
        {
            int v_Res = CConst.INT_VALUE_NULL;
            try
            {
                p_objData.Last_Updated_By_Function = "FSys_Insert_Thanh_Vien";

                v_Res = CUtilities.Convert_To_Int_32(CSQL.FSQL_Execute_Scalar(p_conn, "FSys_sp_ins_Sys_Thanh_Vien",
                p_objData.User_Name, p_objData.PassWord.GetHashCode().ToString(),//Lấy hash code của pass
                 p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function
                ));
            }
            catch (Exception)
            {
                throw;
            }
            return v_Res;
        }
        public int FSys_Insert_Thanh_Vien_Chi_Tiet(SqlConnection p_conn, CSYS_Thanh_Vien_Chi_Tiet p_objData)
        {
            int v_Res = CConst.INT_VALUE_NULL;

            try
            {
                //Cập nhật tên hàm 
                p_objData.Last_Updated_By_Function = "FSys_Insert_Thanh_Vien_Chi_Tiet";

                v_Res = CUtilities.Convert_To_Int_32(CSQL.FSQL_Execute_Scalar(p_conn, "FSys_sp_ins_Sys_Thanh_Vien_Chi_Tiet",
                p_objData.Auto_ID, p_objData.Nhom_Quyen_ID,
                p_objData.Ho_Ten, p_objData.Email, p_objData.Dia_Chi, p_objData.Gioi_Tinh,
                p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function
                ));

            }
            catch (Exception)
            {
                throw;
            }
            return v_Res;
        }
    }
}
