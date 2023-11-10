using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_WF_Quan_Li_Kho.Entities
{
    public class CMessage_Box_Custom
    {
        public static DialogResult MB_Notification(string p_strCaption, string p_strText, MessageBoxIcon p_icType = MessageBoxIcon.None, MessageBoxButtons p_bbType = MessageBoxButtons.OK)
        {
            return MessageBox.Show(p_strText, p_strCaption, p_bbType, p_icType);
        }
    }
}
