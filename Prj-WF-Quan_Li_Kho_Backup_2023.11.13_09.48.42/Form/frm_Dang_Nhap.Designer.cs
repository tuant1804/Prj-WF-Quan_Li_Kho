namespace Prj_WF_Quan_Li_Kho
{
    partial class frm_Dang_Nhap
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
            btn_Subscribe = new System.Windows.Forms.Button();
            btn_Confirm = new System.Windows.Forms.Button();
            txt_Password = new System.Windows.Forms.TextBox();
            txt_User_Name = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Subscribe);
            panel1.Controls.Add(btn_Confirm);
            panel1.Controls.Add(txt_Password);
            panel1.Controls.Add(txt_User_Name);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(0, 2);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(666, 490);
            panel1.TabIndex = 0;
            // 
            // btn_Subscribe
            // 
            btn_Subscribe.Location = new System.Drawing.Point(353, 354);
            btn_Subscribe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_Subscribe.Name = "btn_Subscribe";
            btn_Subscribe.Size = new System.Drawing.Size(126, 49);
            btn_Subscribe.TabIndex = 5;
            btn_Subscribe.Text = "Đăng Ký";
            btn_Subscribe.UseVisualStyleBackColor = true;
            btn_Subscribe.Click += btn_Subscribe_Click;
            // 
            // btn_Confirm
            // 
            btn_Confirm.Location = new System.Drawing.Point(219, 354);
            btn_Confirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_Confirm.Name = "btn_Confirm";
            btn_Confirm.Size = new System.Drawing.Size(128, 49);
            btn_Confirm.TabIndex = 4;
            btn_Confirm.Text = "Đăng Nhập";
            btn_Confirm.UseVisualStyleBackColor = true;
            btn_Confirm.Click += btn_Confirm_Click;
            btn_Confirm.KeyDown += btn_Confirm_KeyDown;
            // 
            // txt_Password
            // 
            txt_Password.Location = new System.Drawing.Point(230, 251);
            txt_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new System.Drawing.Size(244, 31);
            txt_Password.TabIndex = 3;
            txt_Password.TextChanged += txt_Password_TextChanged;
            txt_Password.KeyDown += btn_Confirm_KeyDown;
            // 
            // txt_User_Name
            // 
            txt_User_Name.Location = new System.Drawing.Point(230, 185);
            txt_User_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_User_Name.Name = "txt_User_Name";
            txt_User_Name.Size = new System.Drawing.Size(245, 31);
            txt_User_Name.TabIndex = 2;
            txt_User_Name.KeyDown += btn_Confirm_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(47, 255);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(47, 189);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(99, 25);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // frm_Dang_Nhap
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(664, 492);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frm_Dang_Nhap";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            Load += frm_Dang_Nhap_Load;
            KeyDown += btn_Confirm_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Subscribe;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_User_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

