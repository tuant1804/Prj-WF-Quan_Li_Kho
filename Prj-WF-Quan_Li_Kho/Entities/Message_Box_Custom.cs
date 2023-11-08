using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_WF_Quan_Li_Kho.Entities
{
    public class Message_Box_Custom
    {
        public static DialogResult MB_Notification(string p_strCaption, string p_strText)
        {
            return MessageBox.Show(p_strText, p_strCaption, MessageBoxButtons.OK);
        }
    }
}
