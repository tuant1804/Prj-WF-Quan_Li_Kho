using Prj_WF_Quan_Li_Kho.Entities.Data;
using Prj_WF_Quan_Li_Kho.Entities.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Prj_WF_Quan_Li_Kho.Entities.Controller
{
    public class CData_Don_Vi_Tinh_Controller
    {

        public int Insert_Data_Don_Vi_Tinh(SqlConnection p_conn, CData_Don_Vi_Tinh p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;
            try
            {

                v_iRes = CUtilities.Convert_To_Int_32(CSQL.FSQL_Execute_Scalar(
                    p_conn, "sp_ins_Data_Don_Vi_Tinh",
                    p_objData.Ten_Don_Vi_Tinh, p_objData.Ghi_Chu,
                    p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }
            catch (Exception)
            {
                throw;
            }
            return v_iRes;
        }
        public List<CData_Don_Vi_Tinh> List_Data_Don_Vi_Tinh(
            SqlConnection p_conn)
        {
            DataTable v_dt = new DataTable();
            List<CData_Don_Vi_Tinh> v_arrRes = new List<CData_Don_Vi_Tinh>();
            try
            {

                v_dt = CSQL.FSQL_Get_Data_By_Stored(p_conn, "sp_sel_List_Data_Don_Vi_Tinh");
                foreach (DataRow v_row in v_dt.Rows)
                {
                    CData_Don_Vi_Tinh v_objData = CUtilities.Map_Data_To_Entity<CData_Don_Vi_Tinh>(v_row);

                    v_arrRes.Add(v_objData);
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
        public CData_Don_Vi_Tinh Get_Data_Don_Vi_Tinh_By_ID(SqlConnection p_conn, long p_lngAuto_ID)
        {
            DataTable v_dt = new DataTable();
            CData_Don_Vi_Tinh v_objData = null;
            try
            {
                v_dt = CSQL.FSQL_Get_Data_By_Stored(p_conn,
                    "sp_sel_Get_Data_Don_Vi_Tinh_By_ID",
                    p_lngAuto_ID);
                if (v_dt.Rows.Count > 0)
                {
                    v_objData = CUtilities.Map_Data_To_Entity<CData_Don_Vi_Tinh>(v_dt.Rows[0]);
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
            return v_objData;
        }
        public void Deleted_Data_Don_Vi_Tinh(SqlConnection p_conn, CData_Don_Vi_Tinh p_objData)
        {
            try
            {
                CSQL.FSQL_Execute_Non_Query(p_conn, "sp_del_Data_Don_Vi_Tinh"
                    , p_objData.Auto_ID,
                    p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Updated_Data_Don_Vi_Tinh(SqlConnection p_conn, CData_Don_Vi_Tinh p_objData)
        {
            try
            {

                CSQL.FSQL_Execute_Non_Query(p_conn, "sp_upd_Data_Don_Vi_Tinh",
                    p_objData.Auto_ID,
                    p_objData.Ten_Don_Vi_Tinh,
                    p_objData.Ghi_Chu,
                    p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
