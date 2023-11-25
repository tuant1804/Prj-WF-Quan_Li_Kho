using Prj_WF_Quan_Li_Kho.Entities.Data;
using Prj_WF_Quan_Li_Kho.Entities.SQL;
using Prj_WF_Quan_Li_Kho.Entities.Sys;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_WF_Quan_Li_Kho.Entities.Controller
{
    public class CSYS_History_Controller
    {
        private void Map_Data_To_Entity(DataRow p_row, CSys_History p_objData)
        {
            DataTable v_dt = p_row.Table;
            if (v_dt.Columns.Contains("Auto_ID"))
            {
                p_objData.Auto_ID = CUtilities.Convert_To_Long(p_row["Auto_ID"]);
            }
            if (v_dt.Columns.Contains("Ma_Chuc_Nang"))
            {
                p_objData.Ma_Chuc_Nang = CUtilities.Convert_To_String(p_row["Ma_Chuc_Nang"]);
            }
            if (v_dt.Columns.Contains("Ten_Chuc_Nang"))
            {
                p_objData.Ten_Chuc_Nang = CUtilities.Convert_To_String(p_row["Ten_Chuc_Nang"]);
            }
            if (v_dt.Columns.Contains("Deleted"))
            {
                p_objData.Content = CUtilities.Convert_To_String(p_row["Content"]);
            }
            if (v_dt.Columns.Contains("Title"))
            {
                p_objData.Title = CUtilities.Convert_To_String(p_row["Title"]);
            }
            if (v_dt.Columns.Contains("Edit_Date"))
            {
                p_objData. Deletion_Date= (DateTime)CUtilities.Convert_To_DateTime(p_row["Edit_Date"]);
            }
            if (v_dt.Columns.Contains("Implementer"))
            {
                p_objData.Implementer = CUtilities.Convert_To_String(p_row["Implementer"]);
            }
            if (v_dt.Columns.Contains("Implementation_function"))
            {
                p_objData.Implementation_Function = CUtilities.Convert_To_String(p_row["Implementation_function"]);
            }
        }


        public List<CSys_History> List_Sys_History(SqlConnection p_conn)
        {
            List<CSys_History> v_arrRes = new List<CSys_History>();
            DataTable v_dt = new DataTable();

            try
            {
                v_dt = CSQL.FSQL_Get_Data_By_Stored(p_conn, "sp_sel_List_Sys_History");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_History v_objRes = new CSys_History();
                    Map_Data_To_Entity(v_row, v_objRes);
                    v_arrRes.Add(v_objRes);
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
        public long Insert_Sys_History(SqlConnection p_conn,CSys_History p_objData)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSQL.FSQL_Execute_Scalar(p_conn, "sp_ins_Sys_History",
                    p_objData.Ma_Chuc_Nang,
                    p_objData.Ten_Chuc_Nang,
                    p_objData.Content, 
                    p_objData.Title, 
                    p_objData.Deletion_Date,
                    p_objData.Implementer,
                    p_objData.Implementation_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }
    }
}
