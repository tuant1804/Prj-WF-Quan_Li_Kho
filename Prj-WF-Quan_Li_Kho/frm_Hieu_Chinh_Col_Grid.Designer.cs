namespace Prj_WF_Quan_Li_Kho
{
    partial class frm_Hieu_Chinh_Col_Grid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            clb_list_col = new System.Windows.Forms.CheckedListBox();
            btnXac_Nhan = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(48, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(285, 38);
            label1.TabIndex = 0;
            label1.Text = "Danh Sách Các Cột";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            panel1.Controls.Add(btnXac_Nhan);
            panel1.Controls.Add(clb_list_col);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(378, 538);
            panel1.TabIndex = 1;
            // 
            // clb_list_col
            // 
            clb_list_col.FormattingEnabled = true;
            clb_list_col.Location = new System.Drawing.Point(0, 78);
            clb_list_col.Name = "clb_list_col";
            clb_list_col.Size = new System.Drawing.Size(378, 368);
            clb_list_col.TabIndex = 1;
            clb_list_col.SelectedIndexChanged += clb_list_col_SelectedIndexChanged;
            // 
            // btnXac_Nhan
            // 
            btnXac_Nhan.Location = new System.Drawing.Point(243, 471);
            btnXac_Nhan.Name = "btnXac_Nhan";
            btnXac_Nhan.Size = new System.Drawing.Size(112, 34);
            btnXac_Nhan.TabIndex = 2;
            btnXac_Nhan.Text = "Xác Nhận";
            btnXac_Nhan.UseVisualStyleBackColor = true;
            btnXac_Nhan.Click += btnXac_Nhan_Click;
            // 
            // frm_Hieu_Chinh_Col_Grid
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(378, 538);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_Hieu_Chinh_Col_Grid";
            Text = "Ẩn Hiện Column";
            TopMost = true;
            Load += frm_Hieu_Chinh_Col_Grid_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox clb_list_col;
        private System.Windows.Forms.Button btnXac_Nhan;
    }
}