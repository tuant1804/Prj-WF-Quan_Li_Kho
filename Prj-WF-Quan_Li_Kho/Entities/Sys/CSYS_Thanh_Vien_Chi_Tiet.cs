using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_WF_Quan_Li_Kho.Entities.Sys
{
    public class CSYS_Thanh_Vien_Chi_Tiet
    {
        private long m_lgAuto_ID;

        private string m_strHo_Ten;
        private string m_strGioi_Tinh;
        private string m_strDia_Chi;
        private string m_strEmail;

        private long m_lgThanh_Vien_ID;
        private long m_lgNhom_Quyen_ID;

        //Fields bắt buộc phải có
        private DateTime m_dtmCreated;
        private string m_strCreated_By;
        private string m_strCreated_By_Function;

        private DateTime m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        private string m_strLast_Updated_By_Function;

        private int m_intDeleted;

        public long Auto_ID { get => m_lgAuto_ID; set => m_lgAuto_ID = value; }

        public string Ho_Ten
        {
            get => m_strHo_Ten;
            set
            {
                if (value == "")
                {
                    throw new Exception("Họ tên không được để trống");
                }
                m_strHo_Ten = value.Trim();
            }
        }
        public string Gioi_Tinh
        {
            get => m_strGioi_Tinh;
            set
            {
                if (value == "")
                {
                    throw new Exception("Giới tính không được để trống");
                }
                m_strGioi_Tinh = value.Trim();
            }
        }
        public string Dia_Chi
        {
            get => m_strDia_Chi;
            set
            {
                
                m_strHo_Ten = value.Trim();
            }
        }
        public string Email { get => m_strEmail; set => m_strEmail = value.Trim(); }
        public long Nhom_Quyen_ID { get => m_lgNhom_Quyen_ID; set => m_lgNhom_Quyen_ID = value; }

        public DateTime Created { get => m_dtmCreated; set => m_dtmCreated = value; }
        public string Created_By { get => m_strCreated_By; set => m_strCreated_By = value.Trim(); }
        public string Created_By_Function { get => m_strCreated_By_Function; set => m_strCreated_By_Function = value.Trim(); }
        public DateTime Last_Updated { get => m_dtmLast_Updated; set => m_dtmLast_Updated = value; }
        public string Last_Updated_By { get => m_strLast_Updated_By; set => m_strLast_Updated_By = value.Trim(); }
        public string Last_Updated_By_Function { get => m_strLast_Updated_By_Function; set => m_strLast_Updated_By_Function = value.Trim(); }
        public int Deleted { get => m_intDeleted; set => m_intDeleted = value; }
        public long Thanh_Vien_ID { get => m_lgThanh_Vien_ID; set => m_lgThanh_Vien_ID = value; }

        public CSYS_Thanh_Vien_Chi_Tiet()
        {
            Reset_Data();
        }

        public void Reset_Data()
        {
            m_lgAuto_ID = CConst.LONG_VALUE_NULL;

            m_strHo_Ten = CConst.STR_VALUE_NULL;
            m_strGioi_Tinh = CConst.STR_VALUE_NULL;
            m_strDia_Chi = CConst.STR_VALUE_NULL;
            m_strEmail = CConst.STR_VALUE_NULL;

            m_lgThanh_Vien_ID = CConst.LONG_VALUE_NULL;
            m_lgNhom_Quyen_ID = CConst.LONG_VALUE_NULL;

            m_dtmCreated = (DateTime)CConst.DTM_VALUE_NULL;
            m_strCreated_By = CConst.STR_VALUE_NULL;
            m_strCreated_By_Function = CConst.STR_VALUE_NULL;

            m_dtmLast_Updated = (DateTime)CConst.DTM_VALUE_NULL;
            m_strLast_Updated_By = CConst.STR_VALUE_NULL;
            m_strLast_Updated_By_Function = CConst.STR_VALUE_NULL;
        }

    }
}
