
namespace Do_An_NoSQL.GUI
{
    partial class HoaDon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon));
            this.btnTK = new System.Windows.Forms.ToolStripButton();
            this.btnCT_HD = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReload_Data = new System.Windows.Forms.ToolStripButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dataGridHD = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.txtTK = new System.Windows.Forms.ToolStripTextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHD)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTK
            // 
            this.btnTK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTK.Image = ((System.Drawing.Image)(resources.GetObject("btnTK.Image")));
            this.btnTK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(29, 29);
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // btnCT_HD
            // 
            this.btnCT_HD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCT_HD.Image = ((System.Drawing.Image)(resources.GetObject("btnCT_HD.Image")));
            this.btnCT_HD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCT_HD.Name = "btnCT_HD";
            this.btnCT_HD.Size = new System.Drawing.Size(29, 29);
            this.btnCT_HD.Text = "toolStripButton9";
            this.btnCT_HD.Click += new System.EventHandler(this.btnCT_HD_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // btnReload_Data
            // 
            this.btnReload_Data.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReload_Data.Image = ((System.Drawing.Image)(resources.GetObject("btnReload_Data.Image")));
            this.btnReload_Data.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReload_Data.Name = "btnReload_Data";
            this.btnReload_Data.Size = new System.Drawing.Size(29, 29);
            this.btnReload_Data.Click += new System.EventHandler(this.btnReload_Data_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.dataGridHD);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 32);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1235, 736);
            this.kryptonPanel1.TabIndex = 18;
            // 
            // dataGridHD
            // 
            this.dataGridHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridHD.Location = new System.Drawing.Point(0, 0);
            this.dataGridHD.Name = "dataGridHD";
            this.dataGridHD.ReadOnly = true;
            this.dataGridHD.RowHeadersWidth = 51;
            this.dataGridHD.RowTemplate.Height = 24;
            this.dataGridHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridHD.Size = new System.Drawing.Size(1235, 736);
            this.dataGridHD.TabIndex = 0;
            this.dataGridHD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHD_CellDoubleClick);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReload_Data,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.btnCT_HD,
            this.btnTK,
            this.txtTK});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1235, 32);
            this.toolStrip2.TabIndex = 17;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // txtTK
            // 
            this.txtTK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTK.Margin = new System.Windows.Forms.Padding(10, 3, 1, 3);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(250, 26);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "HoTen";
            this.Column3.HeaderText = "Họ & Tên";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgayDat";
            this.Column4.HeaderText = "Ngày đặt";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TongSL";
            this.Column5.HeaderText = "Số lượng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DiaChiGH";
            this.Column6.HeaderText = "Địa chỉ Giao hàng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ThanhTien";
            this.Column7.HeaderText = "Thành tiền";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "HoaDon";
            this.Size = new System.Drawing.Size(1235, 768);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHD)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripButton btnTK;
        private System.Windows.Forms.ToolStripButton btnCT_HD;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnReload_Data;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGridHD;
        private System.Windows.Forms.ToolStripTextBox txtTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}
