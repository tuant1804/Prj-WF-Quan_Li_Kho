﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_WF_Quan_Li_Kho
{
    public partial class frm_Data_Phieu_Xuat_Kho_Show : Form
    {
        public frm_Data_Phieu_Xuat_Kho_Show()
        {
            InitializeComponent();
        }

        private void frm_Data_Phieu_Xuat_Kho_Show_Load(object sender, EventArgs e)
        {
            this.userControl11.m_frmInstead = this;

        }
    }
}
