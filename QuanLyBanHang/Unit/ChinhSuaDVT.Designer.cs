namespace QuanLyBanHang
{
    partial class ChinhSuaDVT
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.bt_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.bt_LuuVaDong = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Huy = new DevExpress.XtraEditors.SimpleButton();
            this.tb_TenDVT = new DevExpress.XtraEditors.TextEdit();
            this.tb_MaDVT = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_TenDVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MaDVT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Location = new System.Drawing.Point(12, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã ĐVT:";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Location = new System.Drawing.Point(12, 82);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên ĐVT:";
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = global::QuanLyBanHang.Properties.Resources.weightedpies_16x16;
            this.groupControl1.Controls.Add(this.bt_Luu);
            this.groupControl1.Controls.Add(this.bt_LuuVaDong);
            this.groupControl1.Controls.Add(this.bt_Huy);
            this.groupControl1.Controls.Add(this.tb_TenDVT);
            this.groupControl1.Controls.Add(this.tb_MaDVT);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(305, 149);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thông Tin Đơn Vị Tính";
            // 
            // bt_Luu
            // 
            this.bt_Luu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_Luu.ImageOptions.Image = global::QuanLyBanHang.Properties.Resources.save_16x16;
            this.bt_Luu.Location = new System.Drawing.Point(12, 114);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(75, 23);
            this.bt_Luu.TabIndex = 44;
            this.bt_Luu.Text = "F1 - Lưu";
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click);
            // 
            // bt_LuuVaDong
            // 
            this.bt_LuuVaDong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_LuuVaDong.ImageOptions.Image = global::QuanLyBanHang.Properties.Resources.save_16x16;
            this.bt_LuuVaDong.Location = new System.Drawing.Point(93, 114);
            this.bt_LuuVaDong.Name = "bt_LuuVaDong";
            this.bt_LuuVaDong.Size = new System.Drawing.Size(117, 23);
            this.bt_LuuVaDong.TabIndex = 45;
            this.bt_LuuVaDong.Text = "F2 - Lưu và đóng";
            this.bt_LuuVaDong.Click += new System.EventHandler(this.bt_LuuVaDong_Click);
            // 
            // bt_Huy
            // 
            this.bt_Huy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_Huy.ImageOptions.Image = global::QuanLyBanHang.Properties.Resources.cancel_16x16;
            this.bt_Huy.Location = new System.Drawing.Point(216, 114);
            this.bt_Huy.Name = "bt_Huy";
            this.bt_Huy.Size = new System.Drawing.Size(75, 23);
            this.bt_Huy.TabIndex = 46;
            this.bt_Huy.Text = "Esc - Hủy";
            this.bt_Huy.Click += new System.EventHandler(this.bt_Huy_Click);
            // 
            // tb_TenDVT
            // 
            this.tb_TenDVT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_TenDVT.Location = new System.Drawing.Point(59, 79);
            this.tb_TenDVT.Name = "tb_TenDVT";
            this.tb_TenDVT.Size = new System.Drawing.Size(232, 20);
            this.tb_TenDVT.TabIndex = 3;
            // 
            // tb_MaDVT
            // 
            this.tb_MaDVT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_MaDVT.Location = new System.Drawing.Point(59, 36);
            this.tb_MaDVT.Name = "tb_MaDVT";
            this.tb_MaDVT.Size = new System.Drawing.Size(232, 20);
            this.tb_MaDVT.TabIndex = 2;
            // 
            // ChinhSuaDVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 149);
            this.Controls.Add(this.groupControl1);
            this.KeyPreview = true;
            this.Name = "ChinhSuaDVT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn Vị Tính";
            this.Load += new System.EventHandler(this.ChinhSuaDVT_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChinhSuaDVT_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_TenDVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MaDVT.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit tb_TenDVT;
        private DevExpress.XtraEditors.TextEdit tb_MaDVT;
        private DevExpress.XtraEditors.SimpleButton bt_Luu;
        private DevExpress.XtraEditors.SimpleButton bt_LuuVaDong;
        private DevExpress.XtraEditors.SimpleButton bt_Huy;
    }
}