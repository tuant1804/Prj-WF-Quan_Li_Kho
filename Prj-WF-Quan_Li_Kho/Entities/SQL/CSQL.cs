using OfficeOpenXml.ConditionalFormatting.Contracts;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Prj_WF_Quan_Li_Kho.Entities.SQL
{
    public class CSQL
    {
        public static SqlConnection Connection { get; set; }

        public CSQL()
        {

        }
        public static SqlConnection Create_Connection(string p_strConnec_string)
        {
            return Connection = new SqlConnection(p_strConnec_string);
        }


        #region Option

        /// <summary>
        /// Thực hiện chức năng (Insert, Update, Delete) từ C# vào SQL thông qua stored
        /// </summary>
        /// <param name="p_conn"></param>
        /// <param name="p_strStoredName"></param>
        /// <param name="p_arrParams"></param>
        public static void FSQL_Execute_Non_Query(SqlConnection p_conn, string p_strStoredName, params object[] p_arrParams)
        {
            try
            {
                if (p_conn == null)
                {
                    p_conn = Connection;
                    if (p_conn == null)
                    {
                        throw new Exception("Chuỗi kết nối rỗng !\nVui lòng kiểm tra chuỗi kết nối trong App.config");
                    }
                }
                p_conn.Open();

                // Sử dụng SqlCommand để thực thi stored procedure
                SqlCommand v_command = new SqlCommand(p_strStoredName.Trim(), p_conn);

                // Đặt loại CommandType là StoredProcedure
                v_command.CommandType = CommandType.StoredProcedure;
                // Lấy danh sách các tham số của stored procedure
                SqlCommandBuilder.DeriveParameters(v_command);

                // Nếu có tham số, thêm chúng vào SqlCommand
                if (p_arrParams.Length + 1 != v_command.Parameters.Count)
                {
                    throw new Exception("Parameters truyền vào sai số lượng vui lòng kiểm tra lại");
                }

                if (p_arrParams != null)
                {
                    for (int i = 0; i < p_arrParams.Length; i++)
                    {
                        if (p_arrParams[i] == null)
                        {
                            v_command.Parameters[i + 1].Value = DBNull.Value;
                        }
                        else
                        {
                            // Đặt giá trị và kiểu dữ liệu cho từng tham số
                            v_command.Parameters[i + 1].Value = p_arrParams[i];
                        }
                    }
                }
                // Thực thi stored procedure
                v_command.ExecuteNonQuery();

                //Cờ lia param
                v_command.Parameters.Clear();

            }
            catch (Exception)
            {
                // Nếu có lỗi xảy ra, ném ngoại lệ
                throw;
            }
            finally
            {
                p_conn.Close();
            }
        }
        /// <summary>
        /// Thực hiện 1 stored
        /// </summary>
        /// <param name="p_conn"></param>
        /// <param name="p_strStoredName"></param>
        /// <param name="p_arrParams"></param>
        /// <returns>Kết quả của stord đó (Giá trị đơn)</returns>
        public static object FSQL_Execute_Scalar(SqlConnection p_conn, string p_strStoredName, params object[] p_arrParams)
        {
            object v_objRes = null;

            try
            {
                if (p_conn == null)
                {
                    p_conn = Connection;
                    if (p_conn == null)
                    {
                        throw new Exception("Chuỗi kết nối rỗng !\nVui lòng kiểm tra chuỗi kết nối trong App.config");
                    }
                }
                p_conn.Open();

                // Sử dụng SqlCommand để thực thi stored procedure
                SqlCommand v_command = new SqlCommand(p_strStoredName.Trim(), p_conn);

                // Đặt loại CommandType là StoredProcedure
                v_command.CommandType = CommandType.StoredProcedure;

                // Lấy danh sách các tham số của stored procedure
                SqlCommandBuilder.DeriveParameters(v_command);

                //Cho thời gian delay
                v_command.CommandTimeout = 300;

                // Nếu có tham số, thêm chúng vào SqlCommand
                if (p_arrParams.Length + 1 != v_command.Parameters.Count)
                {
                    throw new Exception("Parameters truyền vào sai số lượng vui lòng kiểm tra lại");
                }

                if (p_arrParams != null)
                {
                    for (int i = 0; i < p_arrParams.Length; i++)
                    {
                        if (p_arrParams[i] == null)
                        {
                            v_command.Parameters[i + 1].Value = DBNull.Value;
                        }
                        else
                        {
                            // Đặt giá trị và kiểu dữ liệu cho từng tham số
                            v_command.Parameters[i + 1].Value = p_arrParams[i];
                        }
                    }
                }
                // Thực thi stored procedure
                v_objRes = v_command.ExecuteScalar();
                v_command.Parameters.Clear();

            }
            catch (Exception)
            {
                // Nếu có lỗi xảy ra, ném ngoại lệ
                throw;
            }
            finally
            {
                p_conn.Close();
            }
            return v_objRes;
        }
        /// <summary>
        /// Hàm này được sử dụng để lấy dữ liệu thông qua stored procedure trong SQL Server
        /// </summary>
        /// <param name="p_conn"></param>
        /// <param name="p_strStoredName"></param>
        /// <param name="p_arrParams"></param>
        /// <returns></returns>
        public static DataTable FSQL_Get_Data_By_Stored(SqlConnection p_conn, string p_strStoredName, params object[] p_arrParams)
        {

            // Tạo một DataTable mới để lưu trữ dữ liệu
            DataTable v_dt = new DataTable();
            try
            {
                //Check chuỗi kết nối
                if (p_conn == null)
                {
                    p_conn = Connection;
                    if (p_conn == null)
                    {
                        throw new Exception("Chuỗi kết nối rỗng !\nVui lòng kiểm tra chuỗi kết nối trong App.config");
                    }
                }

                p_conn.Open();

                // Sử dụng SqlCommand để thực thi stored procedure
                SqlCommand v_command = new SqlCommand(p_strStoredName.Trim(), p_conn);

                // Đặt loại CommandType là StoredProcedure
                v_command.CommandType = CommandType.StoredProcedure;

                // Lấy danh sách các tham số của stored procedure
                SqlCommandBuilder.DeriveParameters(v_command);

                //Cho thời gian delay
                v_command.CommandTimeout = 300;

                // Nếu có tham số, thêm chúng vào SqlCommand
                if (p_arrParams != null)
                {
                    for (int i = 0; i < p_arrParams.Length; i++)
                    {
                        if (p_arrParams[i] == null)
                        {
                            v_command.Parameters[i + 1].Value = DBNull.Value;
                        }
                        else
                        {
                            // Đặt giá trị và kiểu dữ liệu cho từng tham số
                            v_command.Parameters[i + 1].Value = p_arrParams[i];
                        }
                        // Thêm từng tham số vào SqlCommand
                    }
                }

                // Sử dụng SqlDataAdapter để lấy dữ liệu từ cơ sở dữ liệu và đổ vào DataTable
                SqlDataAdapter dataAdapter = new SqlDataAdapter(v_command);
                dataAdapter.Fill(v_dt);

            }
            catch (Exception)
            {
                // Nếu có lỗi xảy ra, ném ngoại lệ
                throw;
            }
            finally
            {
                p_conn.Close();
            }
            // Trả về DataTable chứa dữ liệu
            return v_dt;
        }
        #endregion

        #region Sys


        #endregion
    }
}
