using Microsoft.Office.Interop.Excel;

using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_WF_Quan_Li_Kho.Entities
{
    public class CExcel
    {
        private string m_strFile_Path;
        private string m_strFile_Name;
        private string m_strAuthor;
        private string m_strName_Sheet;

        private string m_strName_Title;

        public CExcel()
        {
            Reset_Data();
        }

        public string File_Path { get => m_strFile_Path; set => m_strFile_Path = value.Trim(); }
        public string File_Name { get => m_strFile_Name; set => m_strFile_Name = value.Trim(); }
        public string Author { get => m_strAuthor; set => m_strAuthor = value.Trim(); }
        public string Name_Sheet { get => m_strName_Sheet; set => m_strName_Sheet = value.Trim(); }
        public string Name_Title { get => m_strName_Title; set => m_strName_Title = value.Trim(); }

        public void Reset_Data()
        {
            m_strFile_Path = CConst.STR_VALUE_NULL;
            m_strFile_Name = CConst.STR_VALUE_NULL;
            m_strAuthor = CConst.STR_VALUE_NULL;
            m_strName_Sheet = CConst.STR_VALUE_NULL;
            m_strName_Title = CConst.STR_VALUE_NULL;
        }
    }
}
