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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtGhi_Chu = new System.Windows.Forms.TextBox();
            this.txtDon_Vi_Tinh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.txtGhi_Chu);
            this.panel1.Controls.Add(this.txtDon_Vi_Tinh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 273);
            this.panel1.TabIndex = 0;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(357, 211);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 35);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtGhi_Chu
            // 
            this.txtGhi_Chu.Location = new System.Drawing.Point(196, 145);
            this.txtGhi_Chu.Name = "txtGhi_Chu";
            this.txtGhi_Chu.Size = new System.Drawing.Size(261, 26);
            this.txtGhi_Chu.TabIndex = 3;
            // 
            // txtDon_Vi_Tinh
            // 
            this.txtDon_Vi_Tinh.Location = new System.Drawing.Point(196, 71);
            this.txtDon_Vi_Tinh.Name = "txtDon_Vi_Tinh";
            this.txtDon_Vi_Tinh.Size = new System.Drawing.Size(261, 26);
            this.txtDon_Vi_Tinh.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ghi Chú";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đơn Vị Tính";
            // 
            // frm_Data_Don_Vi_Tinh_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 274);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Data_Don_Vi_Tinh_Edit";
            this.Text = "Thêm";
            this.Load += new System.EventHandler(this.frm_Data_Don_Vi_Tinh_Edit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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