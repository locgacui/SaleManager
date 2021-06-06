namespace QuanLyBanHang
{
    partial class ChinhSuaNhomMH
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tb_MaNhom = new DevExpress.XtraEditors.TextEdit();
            this.tb_TenNhom = new DevExpress.XtraEditors.TextEdit();
            this.bt_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.bt_LuuVaDong = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Huy = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MaNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_TenNhom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = global::QuanLyBanHang.Properties.Resources.recentlyuse_16x16;
            this.groupControl1.Controls.Add(this.bt_Luu);
            this.groupControl1.Controls.Add(this.bt_LuuVaDong);
            this.groupControl1.Controls.Add(this.bt_Huy);
            this.groupControl1.Controls.Add(this.tb_TenNhom);
            this.groupControl1.Controls.Add(this.tb_MaNhom);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(305, 133);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông Tin Nhóm Mặt Hàng";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã Nhóm:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên Nhóm:";
            // 
            // tb_MaNhom
            // 
            this.tb_MaNhom.Location = new System.Drawing.Point(111, 32);
            this.tb_MaNhom.Name = "tb_MaNhom";
            this.tb_MaNhom.Properties.NullText = "Để trống tự sinh";
            this.tb_MaNhom.Size = new System.Drawing.Size(180, 20);
            this.tb_MaNhom.TabIndex = 2;
            // 
            // tb_TenNhom
            // 
            this.tb_TenNhom.Location = new System.Drawing.Point(111, 63);
            this.tb_TenNhom.Name = "tb_TenNhom";
            this.tb_TenNhom.Size = new System.Drawing.Size(180, 20);
            this.tb_TenNhom.TabIndex = 3;
            // 
            // bt_Luu
            // 
            this.bt_Luu.ImageOptions.Image = global::QuanLyBanHang.Properties.Resources.save_16x16;
            this.bt_Luu.Location = new System.Drawing.Point(12, 96);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(75, 23);
            this.bt_Luu.TabIndex = 43;
            this.bt_Luu.Text = "F1 - Lưu";
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click);
            // 
            // bt_LuuVaDong
            // 
            this.bt_LuuVaDong.ImageOptions.Image = global::QuanLyBanHang.Properties.Resources.save_16x16;
            this.bt_LuuVaDong.Location = new System.Drawing.Point(93, 96);
            this.bt_LuuVaDong.Name = "bt_LuuVaDong";
            this.bt_LuuVaDong.Size = new System.Drawing.Size(117, 23);
            this.bt_LuuVaDong.TabIndex = 44;
            this.bt_LuuVaDong.Text = "F2 - Lưu và đóng";
            this.bt_LuuVaDong.Click += new System.EventHandler(this.bt_LuuVaDong_Click);
            // 
            // bt_Huy
            // 
            this.bt_Huy.ImageOptions.Image = global::QuanLyBanHang.Properties.Resources.cancel_16x16;
            this.bt_Huy.Location = new System.Drawing.Point(216, 96);
            this.bt_Huy.Name = "bt_Huy";
            this.bt_Huy.Size = new System.Drawing.Size(75, 23);
            this.bt_Huy.TabIndex = 45;
            this.bt_Huy.Text = "Esc - Hủy";
            this.bt_Huy.Click += new System.EventHandler(this.bt_Huy_Click);
            // 
            // ChinhSuaNhomMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 133);
            this.Controls.Add(this.groupControl1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChinhSuaNhomMH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh Sửa Nhóm Mặt Hàng";
            this.Load += new System.EventHandler(this.ChinhSuaNhomMH_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChinhSuaNhomMH_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MaNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_TenNhom.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tb_TenNhom;
        private DevExpress.XtraEditors.TextEdit tb_MaNhom;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton bt_Luu;
        private DevExpress.XtraEditors.SimpleButton bt_LuuVaDong;
        private DevExpress.XtraEditors.SimpleButton bt_Huy;
    }
}