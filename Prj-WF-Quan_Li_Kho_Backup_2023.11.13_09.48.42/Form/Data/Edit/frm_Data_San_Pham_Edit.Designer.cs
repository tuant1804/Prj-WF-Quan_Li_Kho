namespace Prj_WF_Quan_Li_Kho
{
    partial class frm_Data_San_Pham_Edit
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtMa_San_Pham = new System.Windows.Forms.TextBox();
            txtTen_San_Pham = new System.Windows.Forms.TextBox();
            cbDon_Vi_Tinh = new System.Windows.Forms.ComboBox();
            cbLoai_San_Pham = new System.Windows.Forms.ComboBox();
            btnLuu = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(cbLoai_San_Pham);
            panel1.Controls.Add(cbDon_Vi_Tinh);
            panel1.Controls.Add(txtTen_San_Pham);
            panel1.Controls.Add(txtMa_San_Pham);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(568, 369);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(23, 49);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(118, 22);
            label1.TabIndex = 0;
            label1.Text = "Mã Sản Phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(23, 99);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(122, 22);
            label2.TabIndex = 1;
            label2.Text = "Tên Sản Phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(23, 156);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(109, 22);
            label3.TabIndex = 2;
            label3.Text = "Đơn Vị Tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(23, 208);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(128, 22);
            label4.TabIndex = 3;
            label4.Text = "Loại Sản Phẩm";
            // 
            // txtMa_San_Pham
            // 
            txtMa_San_Pham.Location = new System.Drawing.Point(187, 43);
            txtMa_San_Pham.Name = "txtMa_San_Pham";
            txtMa_San_Pham.Size = new System.Drawing.Size(251, 31);
            txtMa_San_Pham.TabIndex = 4;
            // 
            // txtTen_San_Pham
            // 
            txtTen_San_Pham.Location = new System.Drawing.Point(187, 93);
            txtTen_San_Pham.Name = "txtTen_San_Pham";
            txtTen_San_Pham.Size = new System.Drawing.Size(251, 31);
            txtTen_San_Pham.TabIndex = 5;
            // 
            // cbDon_Vi_Tinh
            // 
            cbDon_Vi_Tinh.FormattingEnabled = true;
            cbDon_Vi_Tinh.Location = new System.Drawing.Point(187, 150);
            cbDon_Vi_Tinh.Name = "cbDon_Vi_Tinh";
            cbDon_Vi_Tinh.Size = new System.Drawing.Size(251, 33);
            cbDon_Vi_Tinh.TabIndex = 6;
            // 
            // cbLoai_San_Pham
            // 
            cbLoai_San_Pham.FormattingEnabled = true;
            cbLoai_San_Pham.Location = new System.Drawing.Point(187, 202);
            cbLoai_San_Pham.Name = "cbLoai_San_Pham";
            cbLoai_San_Pham.Size = new System.Drawing.Size(251, 33);
            cbLoai_San_Pham.TabIndex = 7;
            // 
            // btnLuu
            // 
            btnLuu.Location = new System.Drawing.Point(227, 300);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new System.Drawing.Size(112, 34);
            btnLuu.TabIndex = 8;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // frm_Data_San_Pham_Edit
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(568, 369);
            Controls.Add(panel1);
            Name = "frm_Data_San_Pham_Edit";
            Text = "Sản Phẩm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbLoai_San_Pham;
        private System.Windows.Forms.ComboBox cbDon_Vi_Tinh;
        private System.Windows.Forms.TextBox txtTen_San_Pham;
        private System.Windows.Forms.TextBox txtMa_San_Pham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuu;
    }
}