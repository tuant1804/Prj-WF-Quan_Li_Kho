using Prj_WF_Quan_Li_Kho.Entities.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_WF_Quan_Li_Kho.Entities
{
    public class CCommon_Function
    {

        /// <summary>
        /// Fill dữ liệu cho Data Grid View <br/>
        /// Loại bỏ các cột không cần thiết
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="p_drData"></param>
        /// <param name="p_arrData"></param>
        /// <param name="p_IsAuto_ID"></param>
        public static void Load_Data_Grid_View<T>(DataGridView p_drData, List<T> p_arrData)
        {
            //Clear Data
            p_drData.Rows.Clear();

            //Lấy danh sách các fields
            PropertyInfo[] v_arrFields = RuntimeReflectionExtensions.GetRuntimeProperties(typeof(T)).ToArray();

            //Xóa các fields không cần thiết
            v_arrFields = Remove_Columns(v_arrFields);

            foreach (T v_data in p_arrData)
            {
                //Thêm một hàng mới
                int iRow = p_drData.Rows.Add();

                //Cột bắt buộc phải có
                p_drData.Rows[iRow].Cells[0].Value = "Xóa";
                p_drData.Rows[iRow].Cells[1].Value = "Cập nhật";

                int v_intIndex = 2;

                foreach (PropertyInfo v_fields in v_arrFields)
                {
                    //Gán dữ liệu
                    p_drData.Rows[iRow].Cells[v_intIndex].Value = v_fields.GetValue(v_data);
                    v_intIndex++;
                }

            }
        }
        /// <summary>
        /// Bỏ các col không dùng đến trong datagrid
        /// </summary>
        /// <param name="p_arrFields"></param>
        /// <returns></returns>
        static PropertyInfo[] Remove_Columns(PropertyInfo[] p_arrFields)
        {
            int v_iCount = p_arrFields.Length - 7;
            PropertyInfo[] v_arrFields = new PropertyInfo[v_iCount];
            int v_index = 0;

            for (int i = 0; i < p_arrFields.Length; i++)
            {
                if (
                    !(
                        p_arrFields[i].Name.ToLower().Contains("deleted") ||
                        p_arrFields[i].Name.ToLower().Contains("created") ||
                        p_arrFields[i].Name.ToLower().Contains("created_by") ||
                        p_arrFields[i].Name.ToLower().Contains("created_by_function") ||
                        p_arrFields[i].Name.ToLower().Contains("last_updated") ||
                        p_arrFields[i].Name.ToLower().Contains("last_updated_by") ||
                        p_arrFields[i].Name.ToLower().Contains("last_updated_by_function")
                    )
                )
                {
                    v_arrFields[v_index++] = p_arrFields[i];
                }
            }
            return v_arrFields;
        }

        /// <summary>
        /// Format Data Grid View
        /// </summary>
        /// <param name="p_drData"></param>
        /// <param name="p_arrIndex_Col_Hide"></param>
        public static void Format_Data_Grid_View(DataGridView p_drData, params int[] p_arrIndex_Col_Hide)
        {
           
            //Tạo một HashSet từ mảng chỉ số cột cần ẩn
            var v_setIndex_Col_Hide = new HashSet<int>(p_arrIndex_Col_Hide);
           
            //Tính toán độ rộng các with
            int v_intWidth = (p_drData.Size.Width - 150) / (p_drData.Columns.Count - v_setIndex_Col_Hide.Count);

            //Set chiều rộng cho các cột updated và delete
            p_drData.Columns[0].Width = 75;
            p_drData.Columns[1].Width = 75;

            for (int i = 2; i < p_drData.Columns.Count; i++)
            {
                if (v_setIndex_Col_Hide.Contains(i))
                {
                    p_drData.Columns[i].Visible = false;
                }
                else
                {
                    //Set độ rộng cho các col
                    p_drData.Columns[i].Visible = true;
                    p_drData.Columns[i].Width = v_intWidth;
                }
            }

          

        }

    }
}
