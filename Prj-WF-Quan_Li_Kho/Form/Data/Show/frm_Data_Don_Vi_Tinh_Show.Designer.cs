namespace Prj_WF_Quan_Li_Kho
{
    partial class frm_Data_Don_Vi_Tinh_Show
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            panel1 = new System.Windows.Forms.Panel();
            btnHieu_Chinh_Col_Grid = new System.Windows.Forms.Button();
            btnImport = new System.Windows.Forms.Button();
            btnExport = new System.Windows.Forms.Button();
            btnThem = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            drGrid = new System.Windows.Forms.DataGridView();
            Deleted = new System.Windows.Forms.DataGridViewButtonColumn();
            Updated = new System.Windows.Forms.DataGridViewButtonColumn();
            Auto_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Ten_Don_Vi_Tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Ghi_Chu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Created_By = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Created_By_Function = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Last_Updated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Last_Updated_By = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Last_Updated_By_Function = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnIn_Report = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)drGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.Info;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(btnIn_Report);
            panel1.Controls.Add(btnHieu_Chinh_Col_Grid);
            panel1.Controls.Add(btnImport);
            panel1.Controls.Add(btnExport);
            panel1.Controls.Add(btnThem);
            panel1.Location = new System.Drawing.Point(1, 1);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1639, 87);
            panel1.TabIndex = 0;
            // 
            // btnHieu_Chinh_Col_Grid
            // 
            btnHieu_Chinh_Col_Grid.Location = new System.Drawing.Point(717, 20);
            btnHieu_Chinh_Col_Grid.Name = "btnHieu_Chinh_Col_Grid";
            btnHieu_Chinh_Col_Grid.Size = new System.Drawing.Size(180, 50);
            btnHieu_Chinh_Col_Grid.TabIndex = 6;
            btnHieu_Chinh_Col_Grid.Text = "Ẩn Hiện Cột";
            btnHieu_Chinh_Col_Grid.UseVisualStyleBackColor = true;
            btnHieu_Chinh_Col_Grid.Click += btnHieu_Chinh_Col_Grid_Click;
            // 
            // btnImport
            // 
            btnImport.Location = new System.Drawing.Point(947, 20);
            btnImport.Name = "btnImport";
            btnImport.Size = new System.Drawing.Size(180, 50);
            btnImport.TabIndex = 4;
            btnImport.Text = "Nhập từ Excel";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new System.Drawing.Point(1178, 20);
            btnExport.Name = "btnExport";
            btnExport.Size = new System.Drawing.Size(180, 50);
            btnExport.TabIndex = 2;
            btnExport.Text = "Trích Xuất Ra Excel";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new System.Drawing.Point(1413, 20);
            btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(180, 50);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            panel2.Controls.Add(drGrid);
            panel2.Location = new System.Drawing.Point(1, 178);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1641, 664);
            panel2.TabIndex = 1;
            // 
            // drGrid
            // 
            drGrid.AllowUserToAddRows = false;
            drGrid.AllowUserToDeleteRows = false;
            drGrid.AllowUserToOrderColumns = true;
            drGrid.AllowUserToResizeRows = false;
            drGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            drGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            drGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            drGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            drGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            drGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Deleted, Updated, Auto_ID, Ten_Don_Vi_Tinh, Ghi_Chu, delete, Created, Created_By, Created_By_Function, Last_Updated, Last_Updated_By, Last_Updated_By_Function });
            drGrid.Location = new System.Drawing.Point(0, 0);
            drGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            drGrid.MultiSelect = false;
            drGrid.Name = "drGrid";
            drGrid.ReadOnly = true;
            drGrid.RowHeadersVisible = false;
            drGrid.RowHeadersWidth = 60;
            drGrid.RowTemplate.Height = 28;
            drGrid.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            drGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            drGrid.Size = new System.Drawing.Size(1641, 664);
            drGrid.TabIndex = 0;
            drGrid.CellContentClick += drGrid_CellContentClick;
            // 
            // Deleted
            // 
            Deleted.HeaderText = "Xóa";
            Deleted.MinimumWidth = 75;
            Deleted.Name = "Deleted";
            Deleted.ReadOnly = true;
            Deleted.Text = "Xóa";
            // 
            // Updated
            // 
            Updated.HeaderText = "Cập nhật";
            Updated.MinimumWidth = 75;
            Updated.Name = "Updated";
            Updated.ReadOnly = true;
            Updated.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Updated.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Auto_ID
            // 
            Auto_ID.HeaderText = "Auto ID";
            Auto_ID.MinimumWidth = 149;
            Auto_ID.Name = "Auto_ID";
            Auto_ID.ReadOnly = true;
            // 
            // Ten_Don_Vi_Tinh
            // 
            Ten_Don_Vi_Tinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            Ten_Don_Vi_Tinh.HeaderText = "Đơn Vị Tính";
            Ten_Don_Vi_Tinh.MinimumWidth = 149;
            Ten_Don_Vi_Tinh.Name = "Ten_Don_Vi_Tinh";
            Ten_Don_Vi_Tinh.ReadOnly = true;
            Ten_Don_Vi_Tinh.Width = 149;
            // 
            // Ghi_Chu
            // 
            Ghi_Chu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            Ghi_Chu.HeaderText = "Ghi Chú";
            Ghi_Chu.MinimumWidth = 149;
            Ghi_Chu.Name = "Ghi_Chu";
            Ghi_Chu.ReadOnly = true;
            Ghi_Chu.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            Ghi_Chu.Width = 149;
            // 
            // delete
            // 
            delete.HeaderText = "Deleted";
            delete.MinimumWidth = 149;
            delete.Name = "delete";
            delete.ReadOnly = true;
            // 
            // Created
            // 
            Created.HeaderText = "Created";
            Created.MinimumWidth = 149;
            Created.Name = "Created";
            Created.ReadOnly = true;
            // 
            // Created_By
            // 
            Created_By.HeaderText = "Created By";
            Created_By.MinimumWidth = 149;
            Created_By.Name = "Created_By";
            Created_By.ReadOnly = true;
            // 
            // Created_By_Function
            // 
            Created_By_Function.HeaderText = "Created By Function";
            Created_By_Function.MinimumWidth = 149;
            Created_By_Function.Name = "Created_By_Function";
            Created_By_Function.ReadOnly = true;
            // 
            // Last_Updated
            // 
            Last_Updated.HeaderText = "Last Updated";
            Last_Updated.MinimumWidth = 149;
            Last_Updated.Name = "Last_Updated";
            Last_Updated.ReadOnly = true;
            // 
            // Last_Updated_By
            // 
            Last_Updated_By.HeaderText = "Last Updated By";
            Last_Updated_By.MinimumWidth = 149;
            Last_Updated_By.Name = "Last_Updated_By";
            Last_Updated_By.ReadOnly = true;
            // 
            // Last_Updated_By_Function
            // 
            Last_Updated_By_Function.HeaderText = "Last Updated By Function";
            Last_Updated_By_Function.MinimumWidth = 149;
            Last_Updated_By_Function.Name = "Last_Updated_By_Function";
            Last_Updated_By_Function.ReadOnly = true;
            // 
            // btnIn_Report
            // 
            btnIn_Report.Location = new System.Drawing.Point(488, 20);
            btnIn_Report.Name = "btnIn_Report";
            btnIn_Report.Size = new System.Drawing.Size(180, 50);
            btnIn_Report.TabIndex = 7;
            btnIn_Report.Text = "In Báo Cáo";
            btnIn_Report.UseVisualStyleBackColor = true;
            btnIn_Report.Click += btnIn_Report_Click;
            // 
            // frm_Data_Don_Vi_Tinh_Show
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            ClientSize = new System.Drawing.Size(1642, 844);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "frm_Data_Don_Vi_Tinh_Show";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Đơn Vị Tính";
            Load += frm_Data_Don_Vi_Tinh_Show_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)drGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView drGrid;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnHieu_Chinh_Col_Grid;
        private System.Windows.Forms.DataGridViewButtonColumn Deleted;
        private System.Windows.Forms.DataGridViewButtonColumn Updated;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auto_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_Don_Vi_Tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghi_Chu;
        private System.Windows.Forms.DataGridViewTextBoxColumn delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created_By;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created_By_Function;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Updated;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Updated_By;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Updated_By_Function;
        private System.Windows.Forms.Button btnIn_Report;
    }
}