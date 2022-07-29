
namespace Do_An_NoSQL.GUI
{
    partial class add_Person
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_Person));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnHuy = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnXN = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtDC = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtLH = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.radNu = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.radNam = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.txtNgay = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtTen = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.openAnh = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnHuy);
            this.kryptonPanel1.Controls.Add(this.btnXN);
            this.kryptonPanel1.Controls.Add(this.txtDC);
            this.kryptonPanel1.Controls.Add(this.txtLH);
            this.kryptonPanel1.Controls.Add(this.radNu);
            this.kryptonPanel1.Controls.Add(this.radNam);
            this.kryptonPanel1.Controls.Add(this.txtNgay);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.txtTen);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(694, 189);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(355, 135);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(177, 41);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Values.Text = "HỦY";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXN
            // 
            this.btnXN.Location = new System.Drawing.Point(172, 135);
            this.btnXN.Name = "btnXN";
            this.btnXN.Size = new System.Drawing.Size(177, 41);
            this.btnXN.TabIndex = 20;
            this.btnXN.Values.Text = "XÁC NHẬN";
            this.btnXN.Click += new System.EventHandler(this.btnXN_Click);
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(99, 102);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(549, 27);
            this.txtDC.TabIndex = 19;
            // 
            // txtLH
            // 
            this.txtLH.Location = new System.Drawing.Point(99, 71);
            this.txtLH.Name = "txtLH";
            this.txtLH.Size = new System.Drawing.Size(549, 27);
            this.txtLH.TabIndex = 16;
            // 
            // radNu
            // 
            this.radNu.Location = new System.Drawing.Point(207, 42);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(44, 24);
            this.radNu.TabIndex = 15;
            this.radNu.Values.Text = "Nữ";
            // 
            // radNam
            // 
            this.radNam.Checked = true;
            this.radNam.Location = new System.Drawing.Point(118, 42);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(56, 24);
            this.radNam.TabIndex = 14;
            this.radNam.Values.Text = "Nam";
            // 
            // txtNgay
            // 
            this.txtNgay.CustomFormat = "dd/MM/yyyy";
            this.txtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgay.Location = new System.Drawing.Point(472, 11);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(176, 25);
            this.txtNgay.TabIndex = 13;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(12, 43);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(73, 24);
            this.kryptonLabel5.TabIndex = 9;
            this.kryptonLabel5.Values.Text = "Giới tính:";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(12, 105);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(61, 24);
            this.kryptonLabel4.TabIndex = 6;
            this.kryptonLabel4.Values.Text = "Địa chỉ:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(365, 13);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(83, 24);
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "Ngày sinh:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 74);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(64, 24);
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "Liên hệ:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(99, 9);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(237, 27);
            this.txtTen.TabIndex = 1;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(81, 24);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Họ && Tên:";
            // 
            // openAnh
            // 
            this.openAnh.FileName = "openFileDialog1";
            // 
            // add_Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 189);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "add_Person";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MANAGEMENT PERSON";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTen;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.OpenFileDialog openAnh;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtLH;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton radNu;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton radNam;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker txtNgay;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnHuy;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnXN;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDC;
    }
}