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
    public class CSYS_Nhom_Quyen_Controller
    {
        //Map data to Entity
        private void Map_Data(DataRow p_row, CSYS_Nhom_Quyen p_objData)
        {
            DataTable v_dt = p_row.Table;
            if (v_dt.Columns.Contains("Nhom_Quyen_ID"))
            {
                p_objData.Nhom_Quyen_ID = CUtilities.Convert_To_Long(p_row["Nhom_Quyen_ID"]);
            }
            if (v_dt.Columns.Contains("Ma_Nhom_Quyen"))
            {
                p_objData.Ma_Nhom_Quyen = CUtilities.Convert_To_String(p_row["Ma_Nhom_Quyen"]);
            }
            if (v_dt.Columns.Contains("Ten_Nhom_Quyen"))
            {
                p_objData.Ten_Nhom_Quyen = CUtilities.Convert_To_String(p_row["Ten_Nhom_Quyen"]);
            }
        }

        public List<CSYS_Nhom_Quyen> FSys_Get_List_Nhom_Quyen(SqlConnection p_conn)
        {
            List<CSYS_Nhom_Quyen> v_arrRes = new List<CSYS_Nhom_Quyen>();
            DataTable v_dt = new DataTable();
            try
            {
                v_dt = CSQL.FSQL_Get_Data_By_Stored(p_conn,"FSys_sp_sel_Get_List_Nhom_Quyen");

                if (v_dt.Rows.Count > 0)
                {
                    foreach (DataRow v_row in v_dt.Rows)
                    {
                        CSYS_Nhom_Quyen v_objData = new CSYS_Nhom_Quyen();
                        Map_Data(v_row, v_objData);
                        v_arrRes.Add(v_objData);
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                v_dt.Dispose();
            }
            return v_arrRes;
        }

    }
}
