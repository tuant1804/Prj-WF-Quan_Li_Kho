namespace Prj_WF_Quan_Li_Kho
{
    partial class frm_Data_Don_Vi_Tinh_Edit
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
            panel1 = new System.Windows.Forms.Panel();
            btnLuu = new System.Windows.Forms.Button();
            txtGhi_Chu = new System.Windows.Forms.TextBox();
            txtDon_Vi_Tinh = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(txtGhi_Chu);
            panel1.Controls.Add(txtDon_Vi_Tinh);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(642, 341);
            panel1.TabIndex = 0;
            // 
            // btnLuu
            // 
            btnLuu.Location = new System.Drawing.Point(397, 264);
            btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new System.Drawing.Size(111, 44);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtGhi_Chu
            // 
            txtGhi_Chu.Location = new System.Drawing.Point(218, 181);
            txtGhi_Chu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtGhi_Chu.Name = "txtGhi_Chu";
            txtGhi_Chu.Size = new System.Drawing.Size(290, 31);
            txtGhi_Chu.TabIndex = 3;
            // 
            // txtDon_Vi_Tinh
            // 
            txtDon_Vi_Tinh.Location = new System.Drawing.Point(218, 89);
            txtDon_Vi_Tinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDon_Vi_Tinh.Name = "txtDon_Vi_Tinh";
            txtDon_Vi_Tinh.Size = new System.Drawing.Size(290, 31);
            txtDon_Vi_Tinh.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(37, 185);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(74, 25);
            label2.TabIndex = 1;
            label2.Text = "Ghi Chú";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(37, 96);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(135, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên Đơn Vị Tính";
            // 
            // frm_Data_Don_Vi_Tinh_Edit
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(642, 342);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_Data_Don_Vi_Tinh_Edit";
            Text = "Edit";
            Load += frm_Data_Don_Vi_Tinh_Edit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtGhi_Chu;
        private System.Windows.Forms.TextBox txtDon_Vi_Tinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}