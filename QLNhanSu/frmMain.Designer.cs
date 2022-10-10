namespace QLNhanSu
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoSo = new System.Windows.Forms.ToolStripMenuItem();
            this.khaiBáoHồSơNhânSựToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuPhongBan = new System.Windows.Forms.ToolStripMenuItem();
            this.cấuHìnhHệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýChứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhMuc,
            this.mnuHoSo,
            this.mnuHeThong});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1087, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChucVu,
            this.mnuPhongBan});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(90, 24);
            this.mnuDanhMuc.Text = "Danh mục";
            // 
            // mnuChucVu
            // 
            this.mnuChucVu.Name = "mnuChucVu";
            this.mnuChucVu.Size = new System.Drawing.Size(224, 26);
            this.mnuChucVu.Text = "Danh sách chức vụ";
            this.mnuChucVu.Click += new System.EventHandler(this.mnuChucVu_Click);
            // 
            // mnuHoSo
            // 
            this.mnuHoSo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khaiBáoHồSơNhânSựToolStripMenuItem});
            this.mnuHoSo.Name = "mnuHoSo";
            this.mnuHoSo.Size = new System.Drawing.Size(128, 24);
            this.mnuHoSo.Text = "Quản lý nhân sự";
            // 
            // khaiBáoHồSơNhânSựToolStripMenuItem
            // 
            this.khaiBáoHồSơNhânSựToolStripMenuItem.Name = "khaiBáoHồSơNhânSựToolStripMenuItem";
            this.khaiBáoHồSơNhânSựToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.khaiBáoHồSơNhânSựToolStripMenuItem.Text = "Khai báo hồ sơ nhân sự";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mnuPhongBan
            // 
            this.mnuPhongBan.Name = "mnuPhongBan";
            this.mnuPhongBan.Size = new System.Drawing.Size(224, 26);
            this.mnuPhongBan.Text = "Phòng ban";
            // 
            // cấuHìnhHệThốngToolStripMenuItem
            // 
            this.cấuHìnhHệThốngToolStripMenuItem.Name = "cấuHìnhHệThốngToolStripMenuItem";
            this.cấuHìnhHệThốngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cấuHìnhHệThốngToolStripMenuItem.Text = "Cấu hình hệ thống";
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            // 
            // quảnLýChứcNăngToolStripMenuItem
            // 
            this.quảnLýChứcNăngToolStripMenuItem.Name = "quảnLýChứcNăngToolStripMenuItem";
            this.quảnLýChứcNăngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quảnLýChứcNăngToolStripMenuItem.Text = "Quản lý chức năng";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cấuHìnhHệThốngToolStripMenuItem,
            this.quảnLýTàiKhoảnToolStripMenuItem,
            this.quảnLýChứcNăngToolStripMenuItem});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(136, 24);
            this.mnuHeThong.Text = "Quản lý hệ thống";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 545);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hồ sơ nhân sự ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuChucVu;
        private System.Windows.Forms.ToolStripMenuItem mnuHoSo;
        private System.Windows.Forms.ToolStripMenuItem khaiBáoHồSơNhânSựToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuPhongBan;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem cấuHìnhHệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýChứcNăngToolStripMenuItem;
    }
}