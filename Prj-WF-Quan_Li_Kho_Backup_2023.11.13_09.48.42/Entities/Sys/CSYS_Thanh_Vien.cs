using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_WF_Quan_Li_Kho.Entities
{
    public class CSYS_Thanh_Vien
    {
        private long m_lgAuto_ID;

        private string m_strUser_Name;
        private string m_strPassWord;

       

        //Fields bắt buộc phải có
        private DateTime m_dtmCreated;
        private string m_strCreated_By;
        private string m_strCreated_By_Function;

        private DateTime m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        private string m_strLast_Updated_By_Function;

        private int m_intDeleted;

        //Entities
        public long Auto_ID { get => m_lgAuto_ID; set => m_lgAuto_ID = value; }
        public string User_Name { get => m_strUser_Name; set => m_strUser_Name = value.Trim(); }
        public string PassWord { get => m_strPassWord; set => m_strPassWord = value.Trim(); }
       
        public DateTime Created { get => m_dtmCreated; set => m_dtmCreated = value; }
        public string Created_By { get => m_strCreated_By; set => m_strCreated_By = value.Trim(); }
        public string Created_By_Function { get => m_strCreated_By_Function; set => m_strCreated_By_Function = value.Trim(); }
        public DateTime Last_Updated { get => m_dtmLast_Updated; set => m_dtmLast_Updated = value; }
        public string Last_Updated_By { get => m_strLast_Updated_By; set => m_strLast_Updated_By = value.Trim(); }
        public string Last_Updated_By_Function { get => m_strLast_Updated_By_Function; set => m_strLast_Updated_By_Function = value.Trim(); }
        public int Deleted { get => m_intDeleted; set => m_intDeleted = value; }

        /// <summary>
        /// New
        /// </summary>
        public CSYS_Thanh_Vien()
        {
            Reset_Data();
        }

        //Func bổ trợ
        public void Reset_Data()
        {
            m_lgAuto_ID = CConst.LONG_VALUE_NULL;

            m_strUser_Name = CConst.STR_VALUE_NULL;
            m_strPassWord = CConst.STR_VALUE_NULL;


            m_dtmCreated = (DateTime)CConst.DTM_VALUE_NULL;
            m_strCreated_By = CConst.STR_VALUE_NULL;
            m_strCreated_By_Function = CConst.STR_VALUE_NULL;

            m_dtmLast_Updated = (DateTime)CConst.DTM_VALUE_NULL;
            m_strLast_Updated_By = CConst.STR_VALUE_NULL;
            m_strLast_Updated_By_Function = CConst.STR_VALUE_NULL;
        }
    }
}
