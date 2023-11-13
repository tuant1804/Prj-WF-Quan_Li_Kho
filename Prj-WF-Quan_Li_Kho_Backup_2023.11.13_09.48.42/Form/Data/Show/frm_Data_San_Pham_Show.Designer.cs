namespace Prj_WF_Quan_Li_Kho
{
    partial class frm_Data_San_Pham_Show
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
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            drGrid = new System.Windows.Forms.DataGridView();
            Deleted = new System.Windows.Forms.DataGridViewButtonColumn();
            Updated = new System.Windows.Forms.DataGridViewButtonColumn();
            Auto_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Ten_Don_Vi_Tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Loai_San_Pham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Ma_San_Pham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Ten_San_Pham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Ghi_Chu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Don_Vi_Tinh_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Loai_San_Pham_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)drGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.Info;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Location = new System.Drawing.Point(1, 1);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1639, 87);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            panel2.Controls.Add(drGrid);
            panel2.Location = new System.Drawing.Point(1, 178);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1641, 688);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            drGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            drGrid.ColumnHeadersHeight = 34;
            drGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Deleted, Updated, Auto_ID, Ten_Don_Vi_Tinh, Loai_San_Pham, Ma_San_Pham, Ten_San_Pham, Ghi_Chu, Don_Vi_Tinh_ID, Loai_San_Pham_ID });
            drGrid.Location = new System.Drawing.Point(0, 0);
            drGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            drGrid.MultiSelect = false;
            drGrid.Name = "drGrid";
            drGrid.ReadOnly = true;
            drGrid.RowHeadersVisible = false;
            drGrid.RowHeadersWidth = 62;
            drGrid.RowTemplate.Height = 28;
            drGrid.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            drGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            drGrid.Size = new System.Drawing.Size(1641, 688);
            drGrid.TabIndex = 1;
            // 
            // Deleted
            // 
            Deleted.FillWeight = 43.0622F;
            Deleted.HeaderText = "Xóa";
            Deleted.MinimumWidth = 8;
            Deleted.Name = "Deleted";
            Deleted.ReadOnly = true;
            Deleted.Text = "Xóa";
            // 
            // Updated
            // 
            Updated.HeaderText = "Cập nhật";
            Updated.MinimumWidth = 8;
            Updated.Name = "Updated";
            Updated.ReadOnly = true;
            Updated.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Updated.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Auto_ID
            // 
            Auto_ID.HeaderText = "Auto ID";
            Auto_ID.MinimumWidth = 8;
            Auto_ID.Name = "Auto_ID";
            Auto_ID.ReadOnly = true;
            // 
            // Ten_Don_Vi_Tinh
            // 
            Ten_Don_Vi_Tinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            Ten_Don_Vi_Tinh.FillWeight = 66.02871F;
            Ten_Don_Vi_Tinh.HeaderText = "Đơn Vị Tính";
            Ten_Don_Vi_Tinh.MinimumWidth = 8;
            Ten_Don_Vi_Tinh.Name = "Ten_Don_Vi_Tinh";
            Ten_Don_Vi_Tinh.ReadOnly = true;
            Ten_Don_Vi_Tinh.Width = 500;
            // 
            // Loai_San_Pham
            // 
            Loai_San_Pham.HeaderText = "Loại Sản Phẩm";
            Loai_San_Pham.MinimumWidth = 8;
            Loai_San_Pham.Name = "Loai_San_Pham";
            Loai_San_Pham.ReadOnly = true;
            // 
            // Ma_San_Pham
            // 
            Ma_San_Pham.HeaderText = "Mã Sản Phẩm";
            Ma_San_Pham.MinimumWidth = 8;
            Ma_San_Pham.Name = "Ma_San_Pham";
            Ma_San_Pham.ReadOnly = true;
            // 
            // Ten_San_Pham
            // 
            Ten_San_Pham.HeaderText = "Ten_San_Pham";
            Ten_San_Pham.MinimumWidth = 8;
            Ten_San_Pham.Name = "Ten_San_Pham";
            Ten_San_Pham.ReadOnly = true;
            // 
            // Ghi_Chu
            // 
            Ghi_Chu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            Ghi_Chu.FillWeight = 190.9091F;
            Ghi_Chu.HeaderText = "Ghi Chú";
            Ghi_Chu.MinimumWidth = 8;
            Ghi_Chu.Name = "Ghi_Chu";
            Ghi_Chu.ReadOnly = true;
            Ghi_Chu.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            Ghi_Chu.Width = 737;
            // 
            // Don_Vi_Tinh_ID
            // 
            Don_Vi_Tinh_ID.HeaderText = "Đơn Vị Tính ID";
            Don_Vi_Tinh_ID.MinimumWidth = 8;
            Don_Vi_Tinh_ID.Name = "Don_Vi_Tinh_ID";
            Don_Vi_Tinh_ID.ReadOnly = true;
            // 
            // Loai_San_Pham_ID
            // 
            Loai_San_Pham_ID.HeaderText = "Loại Sản Phẩm ID";
            Loai_San_Pham_ID.MinimumWidth = 8;
            Loai_San_Pham_ID.Name = "Loai_San_Pham_ID";
            Loai_San_Pham_ID.ReadOnly = true;
            // 
            // frm_Data_San_Pham_Show
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(1642, 868);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frm_Data_San_Pham_Show";
            Text = "Sản phẩm";
            Load += frm_Data_San_Pham_Show_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)drGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView drGrid;
        private System.Windows.Forms.DataGridViewButtonColumn Deleted;
        private System.Windows.Forms.DataGridViewButtonColumn Updated;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auto_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_Don_Vi_Tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai_San_Pham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_San_Pham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_San_Pham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghi_Chu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Don_Vi_Tinh_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai_San_Pham_ID;
    }
}