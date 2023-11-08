using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Prj_WF_Quan_Li_Kho.Entities.Data
{
    public class CDaTa_Don_Vi_Tinh
    {
        //ID
        private long m_iAuto_ID;


        //Thông tin Entity
        private string m_strTen_Don_Vi_Tinh;
        private string m_strGhi_Chu;


        //Fields Bắt buộc
        private int m_iDeleted;
        private DateTime m_dtmCreated;
        private string m_strCreated_By;
        private string m_strCreated_By_Function;
        private DateTime m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        private string m_strLast_Updated_By_Function;


        public CDaTa_Don_Vi_Tinh()
        {
            Resed_Data();
        }

        public long Auto_ID { get => m_iAuto_ID; set => m_iAuto_ID = value; }
        public string Ten_Don_Vi_Tinh { get => m_strTen_Don_Vi_Tinh; set => m_strTen_Don_Vi_Tinh = value; }
        public string Ghi_Chu { get => m_strGhi_Chu; set => m_strGhi_Chu = value; }
        public int Deleted { get => m_iDeleted; set => m_iDeleted = value; }
        public DateTime Created { get => m_dtmCreated; set => m_dtmCreated = value; }
        public string Created_By { get => m_strCreated_By; set => m_strCreated_By = value; }
        public string Created_By_Function { get => m_strCreated_By_Function; set => m_strCreated_By_Function = value; }
        public DateTime Last_Updated { get => m_dtmLast_Updated; set => m_dtmLast_Updated = value; }
        public string Last_Updated_By { get => m_strLast_Updated_By; set => m_strLast_Updated_By = value; }
        public string Last_Updated_By_Function { get => m_strLast_Updated_By_Function; set => m_strLast_Updated_By_Function = value; }

        public void Resed_Data()
        {
            m_iAuto_ID = CConst.LONG_VALUE_NULL;

            m_strTen_Don_Vi_Tinh = CConst.STR_VALUE_NULL;
            m_strGhi_Chu = CConst.STR_VALUE_NULL;

            m_iDeleted = CConst.INT_VALUE_NULL;
            m_dtmCreated = (DateTime)CConst.DTM_VALUE_NULL;
            m_strCreated_By = CConst.STR_VALUE_NULL;
            m_strCreated_By_Function = CConst.STR_VALUE_NULL;
            m_dtmLast_Updated = (DateTime)CConst.DTM_VALUE_NULL;
            m_strLast_Updated_By = CConst.STR_VALUE_NULL;
            m_strLast_Updated_By_Function = CConst.STR_VALUE_NULL;
        }
    }
}
