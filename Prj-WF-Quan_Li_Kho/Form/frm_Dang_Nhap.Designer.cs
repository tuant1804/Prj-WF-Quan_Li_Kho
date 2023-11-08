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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Subscribe = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_User_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Subscribe);
            this.panel1.Controls.Add(this.btn_Confirm);
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Controls.Add(this.txt_User_Name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 401);
            this.panel1.TabIndex = 0;
            // 
            // btn_Subscribe
            // 
            this.btn_Subscribe.Location = new System.Drawing.Point(318, 283);
            this.btn_Subscribe.Name = "btn_Subscribe";
            this.btn_Subscribe.Size = new System.Drawing.Size(113, 39);
            this.btn_Subscribe.TabIndex = 5;
            this.btn_Subscribe.Text = "Đăng Ký";
            this.btn_Subscribe.UseVisualStyleBackColor = true;
            this.btn_Subscribe.Click += new System.EventHandler(this.btn_Subscribe_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(197, 283);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(115, 39);
            this.btn_Confirm.TabIndex = 4;
            this.btn_Confirm.Text = "Đăng Nhập";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            this.btn_Confirm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Confirm_KeyDown);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(207, 201);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(220, 26);
            this.txt_Password.TabIndex = 3;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            this.txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Confirm_KeyDown);
            // 
            // txt_User_Name
            // 
            this.txt_User_Name.Location = new System.Drawing.Point(207, 148);
            this.txt_User_Name.Name = "txt_User_Name";
            this.txt_User_Name.Size = new System.Drawing.Size(221, 26);
            this.txt_User_Name.TabIndex = 2;
            this.txt_User_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Confirm_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // frm_Dang_Nhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 394);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Dang_Nhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frm_Dang_Nhap_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Confirm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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

