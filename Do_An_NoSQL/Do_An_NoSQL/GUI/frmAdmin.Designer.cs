
namespace Do_An_NoSQL.GUI
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDS_SP = new System.Windows.Forms.ToolStripButton();
            this.btnQL = new System.Windows.Forms.ToolStripButton();
            this.btnKH = new System.Windows.Forms.ToolStripButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnUserControl = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnHD = new System.Windows.Forms.ToolStripButton();
            this.menuStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnUserControl)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip2.Size = new System.Drawing.Size(1275, 28);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đăngXuấtToolStripMenuItem.Image")));
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoátToolStripMenuItem.Image")));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDS_SP,
            this.btnQL,
            this.btnKH,
            this.btnHD});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1275, 109);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDS_SP
            // 
            this.btnDS_SP.Image = ((System.Drawing.Image)(resources.GetObject("btnDS_SP.Image")));
            this.btnDS_SP.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDS_SP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDS_SP.Name = "btnDS_SP";
            this.btnDS_SP.Size = new System.Drawing.Size(128, 106);
            this.btnDS_SP.Text = "     SẢN PHẨM     ";
            this.btnDS_SP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDS_SP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDS_SP.Click += new System.EventHandler(this.btnDS_SP_Click);
            // 
            // btnQL
            // 
            this.btnQL.Image = ((System.Drawing.Image)(resources.GetObject("btnQL.Image")));
            this.btnQL.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnQL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQL.Name = "btnQL";
            this.btnQL.Size = new System.Drawing.Size(129, 106);
            this.btnQL.Text = "       QUẢN LÝ       ";
            this.btnQL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQL.Click += new System.EventHandler(this.btnQuanLy_Click);
            // 
            // btnKH
            // 
            this.btnKH.Image = ((System.Drawing.Image)(resources.GetObject("btnKH.Image")));
            this.btnKH.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnKH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKH.Name = "btnKH";
            this.btnKH.Size = new System.Drawing.Size(149, 106);
            this.btnKH.Text = "     KHÁCH HÀNG     ";
            this.btnKH.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKH.Click += new System.EventHandler(this.btnKH_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(1267, 28);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(8, 8);
            this.kryptonButton1.TabIndex = 8;
            this.kryptonButton1.Values.Text = "kryptonButton1";
            // 
            // pnUserControl
            // 
            this.pnUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnUserControl.Location = new System.Drawing.Point(0, 137);
            this.pnUserControl.Name = "pnUserControl";
            this.pnUserControl.Size = new System.Drawing.Size(1275, 518);
            this.pnUserControl.TabIndex = 12;
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(1199, 116);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(8, 8);
            this.kryptonButton2.TabIndex = 14;
            this.kryptonButton2.Values.Text = "kryptonButton2";
            // 
            // btnHD
            // 
            this.btnHD.Image = ((System.Drawing.Image)(resources.GetObject("btnHD.Image")));
            this.btnHD.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHD.Name = "btnHD";
            this.btnHD.Size = new System.Drawing.Size(138, 106);
            this.btnHD.Text = "       HÓA ĐƠN       ";
            this.btnHD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHD.Click += new System.EventHandler(this.btnHD_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 655);
            this.Controls.Add(this.kryptonButton2);
            this.Controls.Add(this.pnUserControl);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CỬA HÀNG MỸ PHẨM NHUNG TIN LY";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnUserControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDS_SP;
        private System.Windows.Forms.ToolStripButton btnKH;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnUserControl;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private System.Windows.Forms.ToolStripButton btnQL;
        private System.Windows.Forms.ToolStripButton btnHD;
    }
}