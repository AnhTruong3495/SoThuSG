namespace Sothu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstthumoi = new System.Windows.Forms.ListBox();
            this.lstdanhsach = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblthoigian = new System.Windows.Forms.Label();
            this.btnluu = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hoSoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuload = new System.Windows.Forms.ToolStripMenuItem();
            this.luuDanhSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuclose = new System.Windows.Forms.ToolStripMenuItem();
            this.suaDoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saoChepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstthumoi
            // 
            this.lstthumoi.FormattingEnabled = true;
            this.lstthumoi.Location = new System.Drawing.Point(21, 69);
            this.lstthumoi.Name = "lstthumoi";
            this.lstthumoi.Size = new System.Drawing.Size(120, 160);
            this.lstthumoi.TabIndex = 0;
            // 
            // lstdanhsach
            // 
            this.lstdanhsach.AllowDrop = true;
            this.lstdanhsach.FormattingEnabled = true;
            this.lstdanhsach.Location = new System.Drawing.Point(166, 69);
            this.lstdanhsach.Name = "lstdanhsach";
            this.lstdanhsach.Size = new System.Drawing.Size(120, 160);
            this.lstdanhsach.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thu moi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sach thu";
            // 
            // lblthoigian
            // 
            this.lblthoigian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblthoigian.AutoSize = true;
            this.lblthoigian.Location = new System.Drawing.Point(18, 261);
            this.lblthoigian.Name = "lblthoigian";
            this.lblthoigian.Size = new System.Drawing.Size(35, 13);
            this.lblthoigian.TabIndex = 4;
            this.lblthoigian.Text = "label3";
            // 
            // btnluu
            // 
            this.btnluu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluu.ImageIndex = 0;
            this.btnluu.ImageList = this.imageList1;
            this.btnluu.Location = new System.Drawing.Point(208, 285);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(101, 23);
            this.btnluu.TabIndex = 5;
            this.btnluu.Text = "Luu danh sach";
            this.btnluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnluu, "Luu danh sach thu vao file danhsachthu.txt");
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnsave);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "floppy.ico");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hoSoToolStripMenuItem,
            this.suaDoiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(321, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hoSoToolStripMenuItem
            // 
            this.hoSoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuload,
            this.luuDanhSachToolStripMenuItem,
            this.mnuclose});
            this.hoSoToolStripMenuItem.Name = "hoSoToolStripMenuItem";
            this.hoSoToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.hoSoToolStripMenuItem.Text = "Ho so";
            // 
            // mnuload
            // 
            this.mnuload.Image = ((System.Drawing.Image)(resources.GetObject("mnuload.Image")));
            this.mnuload.Name = "mnuload";
            this.mnuload.Size = new System.Drawing.Size(152, 22);
            this.mnuload.Text = "Tai danh sach";
            this.mnuload.Click += new System.EventHandler(this.mnuload_Click);
            // 
            // luuDanhSachToolStripMenuItem
            // 
            this.luuDanhSachToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("luuDanhSachToolStripMenuItem.Image")));
            this.luuDanhSachToolStripMenuItem.Name = "luuDanhSachToolStripMenuItem";
            this.luuDanhSachToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.luuDanhSachToolStripMenuItem.Text = "Luu danh sach";
            // 
            // mnuclose
            // 
            this.mnuclose.Image = ((System.Drawing.Image)(resources.GetObject("mnuclose.Image")));
            this.mnuclose.Name = "mnuclose";
            this.mnuclose.Size = new System.Drawing.Size(152, 22);
            this.mnuclose.Text = "Ket thuc";
            this.mnuclose.Click += new System.EventHandler(this.mnuclose_Click);
            // 
            // suaDoiToolStripMenuItem
            // 
            this.suaDoiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saoChepToolStripMenuItem,
            this.catToolStripMenuItem,
            this.danToolStripMenuItem});
            this.suaDoiToolStripMenuItem.Name = "suaDoiToolStripMenuItem";
            this.suaDoiToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.suaDoiToolStripMenuItem.Text = "Sua doi";
            // 
            // saoChepToolStripMenuItem
            // 
            this.saoChepToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saoChepToolStripMenuItem.Image")));
            this.saoChepToolStripMenuItem.Name = "saoChepToolStripMenuItem";
            this.saoChepToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.saoChepToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.saoChepToolStripMenuItem.Text = "Sao chep";
            // 
            // catToolStripMenuItem
            // 
            this.catToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("catToolStripMenuItem.Image")));
            this.catToolStripMenuItem.Name = "catToolStripMenuItem";
            this.catToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.catToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.catToolStripMenuItem.Text = "Cat";
            // 
            // danToolStripMenuItem
            // 
            this.danToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("danToolStripMenuItem.Image")));
            this.danToolStripMenuItem.Name = "danToolStripMenuItem";
            this.danToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.danToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.danToolStripMenuItem.Text = "Dan";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 320);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.lblthoigian);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstdanhsach);
            this.Controls.Add(this.lstthumoi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstthumoi;
        private System.Windows.Forms.ListBox lstdanhsach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblthoigian;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hoSoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuload;
        private System.Windows.Forms.ToolStripMenuItem luuDanhSachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuclose;
        private System.Windows.Forms.ToolStripMenuItem suaDoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saoChepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

