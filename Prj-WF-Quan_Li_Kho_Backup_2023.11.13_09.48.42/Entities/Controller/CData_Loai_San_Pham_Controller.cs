using Prj_WF_Quan_Li_Kho.Entities.Data;
using Prj_WF_Quan_Li_Kho.Entities.SQL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_WF_Quan_Li_Kho.Entities.Controller
{
    public class CData_Loai_San_Pham_Controller
    {
        private void Map_Data_To_Entity(DataRow p_row, CData_Loai_San_Pham p_objData)
        {
            DataTable v_dt = p_row.Table;
            if (v_dt.Columns.Contains("Auto_ID"))
            {
                p_objData.Auto_ID = CUtilities.Convert_To_Long(p_row["Auto_ID"]);
            }
            if (v_dt.Columns.Contains("Ten_Loai_San_Pham"))
            {
                p_objData.Ten_Loai_San_Pham = CUtilities.Convert_To_String(p_row["Ten_Loai_San_Pham"]);
            }
            if (v_dt.Columns.Contains("Ghi_Chu"))
            {
                p_objData.Ghi_Chu = CUtilities.Convert_To_String(p_row["Ghi_Chu"]);
            }
            if (v_dt.Columns.Contains("Deleted"))
            {
                p_objData.Deleted = CUtilities.Convert_To_Int_32(p_row["Deleted"]);
            }
            if (v_dt.Columns.Contains("Created"))
            {
                p_objData.Created = (DateTime)CUtilities.Convert_To_DateTime(p_row["Created"]);
            }
            if (v_dt.Columns.Contains("Created_By"))
            {
                p_objData.Created_By = CUtilities.Convert_To_String(p_row["Created_By"]);
            }
            if (v_dt.Columns.Contains("Created_By_Function"))
            {
                p_objData.Created_By_Function = CUtilities.Convert_To_String(p_row["Created_By_Function"]);
            }
            if (v_dt.Columns.Contains("Last_Updated"))
            {
                p_objData.Last_Updated = (DateTime)CUtilities.Convert_To_DateTime(p_row["Last_Updated"]);
            }
            if (v_dt.Columns.Contains("Last_Updated_By"))
            {
                p_objData.Last_Updated_By = CUtilities.Convert_To_String(p_row["Created_By"]);
            }
            if (v_dt.Columns.Contains("Last_Updated_By_Function"))
            {
                p_objData.Last_Updated_By_Function = CUtilities.Convert_To_String(p_row["Created_By"]);
            }
        }

        public int Insert_Data_Loai_San_Pham(SqlConnection p_conn, CData_Loai_San_Pham p_objData)
        {
            int v_iRes = CConst.INT_VALUE_NULL;
            try
            {

                v_iRes = CUtilities.Convert_To_Int_32(CSQL.FSQL_Execute_Scalar(
                    p_conn, "sp_ins_Data_Loai_San_Pham",
                    p_objData.Ten_Loai_San_Pham, p_objData.Ghi_Chu,
                    p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }
            catch (Exception)
            {
                throw;
            }
            return v_iRes;
        }
        public List<CData_Loai_San_Pham> List_Data_Loai_San_Pham(
            SqlConnection p_conn)
        {
            DataTable v_dt = new DataTable();
            List<CData_Loai_San_Pham> v_arrRes = new List<CData_Loai_San_Pham>();
            try
            {

                v_dt = CSQL.FSQL_Get_Data_By_Stored(p_conn, "sp_sel_List_Data_Loai_San_Pham");
                foreach (DataRow v_row in v_dt.Rows)
                {
                    CData_Loai_San_Pham v_objData = new CData_Loai_San_Pham();
                    Map_Data_To_Entity(v_row, v_objData);
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
        public CData_Loai_San_Pham Get_Data_Loai_San_Pham_By_ID(SqlConnection p_conn, long p_lngAuto_ID)
        {
            DataTable v_dt = new DataTable();
            CData_Loai_San_Pham v_objData = null;
            try
            {
                v_dt = CSQL.FSQL_Get_Data_By_Stored(p_conn,
                    "sp_sel_Get_Data_Loai_San_Pham_By_ID",
                    p_lngAuto_ID);
                if (v_dt.Rows.Count > 0)
                {
                    v_objData = new CData_Loai_San_Pham();
                    Map_Data_To_Entity(v_dt.Rows[0], v_objData);
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
        public void Deleted_Data_Loai_San_Pham(SqlConnection p_conn, CData_Loai_San_Pham p_objData)
        {
            try
            {
                CSQL.FSQL_Execute_Non_Query(p_conn, "sp_del_Data_Loai_San_Pham"
                    , p_objData.Auto_ID,
                    p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Updated_Data_Loai_San_Pham(SqlConnection p_conn, CData_Loai_San_Pham p_objData)
        {
            try
            {

                CSQL.FSQL_Execute_Non_Query(p_conn, "sp_upd_Data_Loai_San_Pham",
                    p_objData.Auto_ID,
                    p_objData.Ten_Loai_San_Pham,
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
