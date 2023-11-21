using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_WF_Quan_Li_Kho.Entities.Sys
{
    public class CSys_History
    {
        private long m_lngAuto_ID;
        private string m_strMa_Chuc_Nang;
        private string m_strTen_Chuc_Nang;
        private string m_strContent;
        private string m_strTitle;
        private DateTime? m_dtmDeletion_Date;
        private string m_strImplementer;
        private string m_strImplementation_function;

        public CSys_History()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_lngAuto_ID = CConst.INT_VALUE_NULL;
            m_strMa_Chuc_Nang = CConst.STR_VALUE_NULL;
            m_strTen_Chuc_Nang = CConst.STR_VALUE_NULL;
            m_strContent = CConst.STR_VALUE_NULL;
            m_strTitle = CConst.STR_VALUE_NULL;
            m_dtmDeletion_Date = CConst.DTM_VALUE_NULL;
            m_strImplementer = CConst.STR_VALUE_NULL;
            m_strImplementation_function = CConst.STR_VALUE_NULL;
        }

        public long Auto_ID
        {
            get
            {
                return m_lngAuto_ID;
            }
            set
            {
                m_lngAuto_ID = value;
            }
        }

        public string Ma_Chuc_Nang
        {
            get
            {
                return m_strMa_Chuc_Nang;
            }
            set
            {
                m_strMa_Chuc_Nang = value.Trim();
            }
        }

        public string Ten_Chuc_Nang
        {
            get
            {
                return m_strTen_Chuc_Nang;
            }
            set
            {
                m_strTen_Chuc_Nang = value.Trim();
            }
        }

        public string Content
        {
            get
            {
                return m_strContent;
            }
            set
            {
                m_strContent = value.Trim();
            }
        }

        public string Title
        {
            get
            {
                return m_strTitle;
            }
            set
            {
                m_strTitle = value.Trim();
            }
        }

        public DateTime? Edit_Date
        {
            get
            {
                return m_dtmDeletion_Date;
            }
            set
            {
                m_dtmDeletion_Date = value;
            }
        }

        public string Implementer
        {
            get
            {
                return m_strImplementer;
            }
            set
            {
                m_strImplementer = value.Trim();
            }
        }

        public string Implementation_Function
        {
            get
            {
                return m_strImplementation_function;
            }
            set
            {
                m_strImplementation_function = value.Trim();
            }
        }
    }
}
