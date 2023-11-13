using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_WF_Quan_Li_Kho.Entities.Sys
{
    public class CSYS_Nhom_Quyen
    {
        //Fields
        private long m_lgNhom_Quyen_ID;
        private string m_strMa_Nhom_Quyen;
        private string m_strTen_Nhom_Quyen;

        //Constructors
        public CSYS_Nhom_Quyen()
        {
            Reset_Data();
        }

        //Properties
        public long Nhom_Quyen_ID { get => m_lgNhom_Quyen_ID; set => m_lgNhom_Quyen_ID = value; }
        public string Ma_Nhom_Quyen { get => m_strMa_Nhom_Quyen; set => m_strMa_Nhom_Quyen = value.Trim(); }
        public string Ten_Nhom_Quyen { get => m_strTen_Nhom_Quyen; set => m_strTen_Nhom_Quyen = value.Trim(); }

        //Hàm reset data
        public void Reset_Data()
        {
            m_lgNhom_Quyen_ID = CConst.LONG_VALUE_NULL;
            m_strMa_Nhom_Quyen = CConst.STR_VALUE_NULL;
            m_strTen_Nhom_Quyen = CConst.STR_VALUE_NULL;
        }
    }
}
