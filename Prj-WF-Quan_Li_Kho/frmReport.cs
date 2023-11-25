using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.Reporting;

namespace Prj_WF_Quan_Li_Kho
{
    public partial class frmReport : Form
    {
        private string m_strReport_Source;
        public frmReport(string p_strReport_Source)
        {
            InitializeComponent(p_strReport_Source);   
        }

        private void ReportViewerForm1_Load(object sender, EventArgs e)
        {
           
            reportViewer1.RefreshReport();
        }
    }
}
