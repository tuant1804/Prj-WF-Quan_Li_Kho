namespace Prj_WF_Quan_Li_Kho
{
    partial class frm_Data_Phieu_Nhap_Kho_Show
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.drGrid = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.So_Phieu_Nhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nha_Cung_Cap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_Nhap_Kho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.So_Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tong_Tri_Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ghi_Chu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1475, 70);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.drGrid);
            this.panel2.Location = new System.Drawing.Point(1, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1477, 550);
            this.panel2.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(1319, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(132, 41);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // drGrid
            // 
            this.drGrid.AllowUserToOrderColumns = true;
            this.drGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.drGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.drGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.So_Phieu_Nhap,
            this.Nha_Cung_Cap,
            this.Kho,
            this.Ngay_Nhap_Kho,
            this.So_Luong,
            this.Tong_Tri_Gia,
            this.Ghi_Chu});
            this.drGrid.Location = new System.Drawing.Point(51, 92);
            this.drGrid.MultiSelect = false;
            this.drGrid.Name = "drGrid";
            this.drGrid.RowHeadersWidth = 62;
            this.drGrid.RowTemplate.Height = 28;
            this.drGrid.Size = new System.Drawing.Size(1361, 436);
            this.drGrid.TabIndex = 0;
            // 
            // Edit
            // 
            this.Edit.FillWeight = 43.0622F;
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            // 
            // So_Phieu_Nhap
            // 
            this.So_Phieu_Nhap.HeaderText = "Số Phiếu Nhập";
            this.So_Phieu_Nhap.MinimumWidth = 8;
            this.So_Phieu_Nhap.Name = "So_Phieu_Nhap";
            this.So_Phieu_Nhap.ReadOnly = true;
            // 
            // Nha_Cung_Cap
            // 
            this.Nha_Cung_Cap.HeaderText = " Nhà Cung Cấp";
            this.Nha_Cung_Cap.MinimumWidth = 8;
            this.Nha_Cung_Cap.Name = "Nha_Cung_Cap";
            this.Nha_Cung_Cap.ReadOnly = true;
            // 
            // Kho
            // 
            this.Kho.HeaderText = "Kho";
            this.Kho.MinimumWidth = 8;
            this.Kho.Name = "Kho";
            this.Kho.ReadOnly = true;
            // 
            // Ngay_Nhap_Kho
            // 
            this.Ngay_Nhap_Kho.HeaderText = "Ngày Nhập Kho";
            this.Ngay_Nhap_Kho.MinimumWidth = 8;
            this.Ngay_Nhap_Kho.Name = "Ngay_Nhap_Kho";
            this.Ngay_Nhap_Kho.ReadOnly = true;
            // 
            // So_Luong
            // 
            this.So_Luong.HeaderText = "Số Lượng";
            this.So_Luong.MinimumWidth = 8;
            this.So_Luong.Name = "So_Luong";
            this.So_Luong.ReadOnly = true;
            // 
            // Tong_Tri_Gia
            // 
            this.Tong_Tri_Gia.HeaderText = "Tổng Trị Giá";
            this.Tong_Tri_Gia.MinimumWidth = 8;
            this.Tong_Tri_Gia.Name = "Tong_Tri_Gia";
            this.Tong_Tri_Gia.ReadOnly = true;
            // 
            // Ghi_Chu
            // 
            this.Ghi_Chu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Ghi_Chu.FillWeight = 190.9091F;
            this.Ghi_Chu.HeaderText = "Ghi Chú";
            this.Ghi_Chu.MinimumWidth = 8;
            this.Ghi_Chu.Name = "Ghi_Chu";
            this.Ghi_Chu.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Ghi_Chu.Width = 300;
            // 
            // frm_Data_Phieu_Nhap_Kho_Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1478, 694);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Data_Phieu_Nhap_Kho_Show";
            this.Text = "Phiếu nhập kho";
            this.Load += new System.EventHandler(this.frm_Data_Phieu_Nhap_Kho_Show_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView drGrid;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_Phieu_Nhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nha_Cung_Cap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_Nhap_Kho;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tong_Tri_Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghi_Chu;
    }
}