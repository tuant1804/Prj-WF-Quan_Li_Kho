using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Prj_WF_Quan_Li_Kho
{
    public partial class frm_Hieu_Chinh_Col_Grid : Form
    {
        //Parameters
        public List<int> List_Col_Hide_Index { set; get; }
        public DataGridView Grid { get; set; }
        public frm_Hieu_Chinh_Col_Grid()
        {
            InitializeComponent();
        }

        private void frm_Hieu_Chinh_Col_Grid_Load(object sender, EventArgs e)
        {
            //Clear các item trước đó
            clb_list_col.Items.Clear();

            //Tạo hash để chứa các vị trí cột cần ẩn
            var v_check_col_da_an = new HashSet<int>(List_Col_Hide_Index);

            foreach (DataGridViewColumn v_col in Grid.Columns)
            {
                if (v_col.Name.ToLower() != "deleted" && v_col.Name.ToLower() != "updated")
                {
                    clb_list_col.Items.Add(v_col.Name);
                }
            }

            if (v_check_col_da_an.Count > 0)
            {
                foreach (int i in v_check_col_da_an)
                {
                    if (i < clb_list_col.Items.Count)
                    {
                        clb_list_col.SetItemChecked(i - 2, true);
                    }
                }
            }
        }

        private void clb_list_col_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXac_Nhan_Click(object sender, EventArgs e)
        {
            List_Col_Hide_Index = new List<int>();

            foreach (int v_index in clb_list_col.CheckedIndices)
            {
                List_Col_Hide_Index.Add(v_index + 2);
            }

            Close();
        }
    }
}
