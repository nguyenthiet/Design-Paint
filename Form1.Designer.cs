namespace designPaint
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMauTrai = new System.Windows.Forms.Button();
            this.btnHinhChuNhat = new System.Windows.Forms.Button();
            this.btnChonMau = new System.Windows.Forms.Button();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.btnMauPhai = new System.Windows.Forms.Button();
            this.btnTamGiac = new System.Windows.Forms.Button();
            this.btnDuongTron = new System.Windows.Forms.Button();
            this.btnHinhTron = new System.Windows.Forms.Button();
            this.btnDuongThang = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.homeToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(738, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMauTrai);
            this.panel1.Controls.Add(this.btnHinhChuNhat);
            this.panel1.Controls.Add(this.btnChonMau);
            this.panel1.Controls.Add(this.cmbSize);
            this.panel1.Controls.Add(this.btnMauPhai);
            this.panel1.Controls.Add(this.btnTamGiac);
            this.panel1.Controls.Add(this.btnDuongTron);
            this.panel1.Controls.Add(this.btnHinhTron);
            this.panel1.Controls.Add(this.btnDuongThang);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 62);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Size";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMauTrai
            // 
            this.btnMauTrai.BackColor = System.Drawing.Color.White;
            this.btnMauTrai.Location = new System.Drawing.Point(513, 3);
            this.btnMauTrai.Name = "btnMauTrai";
            this.btnMauTrai.Size = new System.Drawing.Size(63, 56);
            this.btnMauTrai.TabIndex = 8;
            this.btnMauTrai.UseVisualStyleBackColor = false;
            this.btnMauTrai.Click += new System.EventHandler(this.btnMauTrai_Click);
            // 
            // btnHinhChuNhat
            // 
            this.btnHinhChuNhat.Location = new System.Drawing.Point(277, 3);
            this.btnHinhChuNhat.Name = "btnHinhChuNhat";
            this.btnHinhChuNhat.Size = new System.Drawing.Size(62, 56);
            this.btnHinhChuNhat.TabIndex = 7;
            this.btnHinhChuNhat.Text = "Hình chữ nhật";
            this.btnHinhChuNhat.UseVisualStyleBackColor = true;
            this.btnHinhChuNhat.Click += new System.EventHandler(this.btnHinhChuNhat_Click);
            // 
            // btnChonMau
            // 
            this.btnChonMau.Location = new System.Drawing.Point(650, 3);
            this.btnChonMau.Name = "btnChonMau";
            this.btnChonMau.Size = new System.Drawing.Size(63, 56);
            this.btnChonMau.TabIndex = 5;
            this.btnChonMau.Text = "Chọn màu";
            this.btnChonMau.UseVisualStyleBackColor = true;
            this.btnChonMau.Click += new System.EventHandler(this.btnChonMau_Click);
            // 
            // cmbSize
            // 
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Location = new System.Drawing.Point(386, 22);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(121, 21);
            this.cmbSize.TabIndex = 6;
            this.cmbSize.SelectedIndexChanged += new System.EventHandler(this.cmbSize_SelectedIndexChanged);
            // 
            // btnMauPhai
            // 
            this.btnMauPhai.BackColor = System.Drawing.Color.Black;
            this.btnMauPhai.Location = new System.Drawing.Point(582, 3);
            this.btnMauPhai.Name = "btnMauPhai";
            this.btnMauPhai.Size = new System.Drawing.Size(62, 56);
            this.btnMauPhai.TabIndex = 4;
            this.btnMauPhai.UseVisualStyleBackColor = false;
            this.btnMauPhai.Click += new System.EventHandler(this.btnMauPhai_Click);
            // 
            // btnTamGiac
            // 
            this.btnTamGiac.Location = new System.Drawing.Point(208, 3);
            this.btnTamGiac.Name = "btnTamGiac";
            this.btnTamGiac.Size = new System.Drawing.Size(63, 56);
            this.btnTamGiac.TabIndex = 3;
            this.btnTamGiac.Text = "Tam giác";
            this.btnTamGiac.UseVisualStyleBackColor = true;
            // 
            // btnDuongTron
            // 
            this.btnDuongTron.Location = new System.Drawing.Point(140, 3);
            this.btnDuongTron.Name = "btnDuongTron";
            this.btnDuongTron.Size = new System.Drawing.Size(62, 56);
            this.btnDuongTron.TabIndex = 2;
            this.btnDuongTron.Text = "Đường tròn";
            this.btnDuongTron.UseVisualStyleBackColor = true;
            this.btnDuongTron.Click += new System.EventHandler(this.btnDuongTron_Click);
            // 
            // btnHinhTron
            // 
            this.btnHinhTron.Location = new System.Drawing.Point(71, 3);
            this.btnHinhTron.Name = "btnHinhTron";
            this.btnHinhTron.Size = new System.Drawing.Size(63, 56);
            this.btnHinhTron.TabIndex = 1;
            this.btnHinhTron.Text = "Hình tròn";
            this.btnHinhTron.UseVisualStyleBackColor = true;
            this.btnHinhTron.Click += new System.EventHandler(this.btnHinhTron_Click);
            // 
            // btnDuongThang
            // 
            this.btnDuongThang.Location = new System.Drawing.Point(3, 3);
            this.btnDuongThang.Name = "btnDuongThang";
            this.btnDuongThang.Size = new System.Drawing.Size(62, 56);
            this.btnDuongThang.TabIndex = 0;
            this.btnDuongThang.Text = "Đường thẳng";
            this.btnDuongThang.UseVisualStyleBackColor = true;
            this.btnDuongThang.Click += new System.EventHandler(this.btnDuongThang_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 504);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 21);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tọa Độ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(738, 528);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMauTrai;
        private System.Windows.Forms.Button btnHinhChuNhat;
        private System.Windows.Forms.Button btnChonMau;
        private System.Windows.Forms.Button btnMauPhai;
        private System.Windows.Forms.Button btnTamGiac;
        private System.Windows.Forms.Button btnDuongTron;
        private System.Windows.Forms.Button btnHinhTron;
        private System.Windows.Forms.Button btnDuongThang;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}

