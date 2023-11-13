using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_WF_Quan_Li_Kho.Entities
{
    public class CUtility_DateTime
    {
        public static string Convert_DateTime_To_String(DateTime? p_dtmData, string p_strFormat)
        {
            DateTime v_dtmRes = DateTime.Parse(p_dtmData.ToString());
            return v_dtmRes.ToString(p_strFormat);
        }
        public static DateTime? Convert_String_To_Date_Time(string p_strTime)
        {
            DateTime v_dtmRes = new DateTime(); ;
            CultureInfo v_provider = CultureInfo.InvariantCulture;

            try
            {
                v_dtmRes = DateTime.ParseExact(p_strTime, new string[] { "M/d/yyyy", "dd/MM/yyyy", "yyyy-MM-dd", "M/d/yyyy h:mm:ss tt" }, 
                    v_provider, DateTimeStyles.None);
            }
            catch (Exception)
            {
                throw;
            }
            return v_dtmRes;
        }
    }
}
