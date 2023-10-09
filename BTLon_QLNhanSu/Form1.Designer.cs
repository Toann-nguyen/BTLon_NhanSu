namespace BTLon_QLNhanSu
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.bangNhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpBảngNhânvienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpBảngMãPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpBảngChứcVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpBảngPhụCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Indanhsach = new System.Windows.Forms.Button();
            this.Inbaocao = new System.Windows.Forms.Button();
            this.Xuatexcel_cacbang = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Check_tenbang = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bangNhanVienToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // bangNhanVienToolStripMenuItem
            // 
            this.bangNhanVienToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpBảngNhânvienToolStripMenuItem,
            this.nhậpBảngMãPhòngToolStripMenuItem,
            this.nhậpBảngChứcVụToolStripMenuItem,
            this.nhậpBảngPhụCấpToolStripMenuItem});
            this.bangNhanVienToolStripMenuItem.Name = "bangNhanVienToolStripMenuItem";
            this.bangNhanVienToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.bangNhanVienToolStripMenuItem.Text = "Nhập dữ liệu";
            // 
            // nhậpBảngNhânvienToolStripMenuItem
            // 
            this.nhậpBảngNhânvienToolStripMenuItem.Name = "nhậpBảngNhânvienToolStripMenuItem";
            this.nhậpBảngNhânvienToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.nhậpBảngNhânvienToolStripMenuItem.Text = "Nhập bảng nhân viên";
            this.nhậpBảngNhânvienToolStripMenuItem.Click += new System.EventHandler(this.nhậpBảngNhânvienToolStripMenuItem_Click);
            // 
            // nhậpBảngMãPhòngToolStripMenuItem
            // 
            this.nhậpBảngMãPhòngToolStripMenuItem.Name = "nhậpBảngMãPhòngToolStripMenuItem";
            this.nhậpBảngMãPhòngToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.nhậpBảngMãPhòngToolStripMenuItem.Text = "Nhập bảng mã phòng";
            // 
            // nhậpBảngChứcVụToolStripMenuItem
            // 
            this.nhậpBảngChứcVụToolStripMenuItem.Name = "nhậpBảngChứcVụToolStripMenuItem";
            this.nhậpBảngChứcVụToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.nhậpBảngChứcVụToolStripMenuItem.Text = "Nhập bảng chức vụ";
            this.nhậpBảngChứcVụToolStripMenuItem.Click += new System.EventHandler(this.nhậpBảngChứcVụToolStripMenuItem_Click);
            // 
            // nhậpBảngPhụCấpToolStripMenuItem
            // 
            this.nhậpBảngPhụCấpToolStripMenuItem.Name = "nhậpBảngPhụCấpToolStripMenuItem";
            this.nhậpBảngPhụCấpToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.nhậpBảngPhụCấpToolStripMenuItem.Text = "Nhập bảng phụ cấp";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(142, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(535, 218);
            this.dataGridView1.TabIndex = 2;
            // 
            // Indanhsach
            // 
            this.Indanhsach.Location = new System.Drawing.Point(155, 146);
            this.Indanhsach.Name = "Indanhsach";
            this.Indanhsach.Size = new System.Drawing.Size(147, 23);
            this.Indanhsach.TabIndex = 3;
            this.Indanhsach.Text = "In danh sách";
            this.Indanhsach.UseVisualStyleBackColor = true;
            // 
            // Inbaocao
            // 
            this.Inbaocao.Location = new System.Drawing.Point(346, 146);
            this.Inbaocao.Name = "Inbaocao";
            this.Inbaocao.Size = new System.Drawing.Size(163, 23);
            this.Inbaocao.TabIndex = 4;
            this.Inbaocao.Text = "In báo cáo";
            this.Inbaocao.UseVisualStyleBackColor = true;
            // 
            // Xuatexcel_cacbang
            // 
            this.Xuatexcel_cacbang.Location = new System.Drawing.Point(546, 146);
            this.Xuatexcel_cacbang.Name = "Xuatexcel_cacbang";
            this.Xuatexcel_cacbang.Size = new System.Drawing.Size(176, 23);
            this.Xuatexcel_cacbang.TabIndex = 5;
            this.Xuatexcel_cacbang.Text = "Xuat excel tat cac bang";
            this.Xuatexcel_cacbang.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Linen;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nhan_Vien",
            "Phucap",
            "Chuc_Vu",
            "Ma_Phong"});
            this.comboBox1.Location = new System.Drawing.Point(265, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(299, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // Check_tenbang
            // 
            this.Check_tenbang.Location = new System.Drawing.Point(600, 13);
            this.Check_tenbang.Name = "Check_tenbang";
            this.Check_tenbang.Size = new System.Drawing.Size(143, 23);
            this.Check_tenbang.TabIndex = 7;
            this.Check_tenbang.Text = "Kiem tra ten bang";
            this.Check_tenbang.UseVisualStyleBackColor = true;
            this.Check_tenbang.Click += new System.EventHandler(this.Check_tenbang_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Check_tenbang);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Xuatexcel_cacbang);
            this.Controls.Add(this.Inbaocao);
            this.Controls.Add(this.Indanhsach);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem bangNhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpBảngNhânvienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpBảngMãPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpBảngChứcVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpBảngPhụCấpToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Indanhsach;
        private System.Windows.Forms.Button Inbaocao;
        private System.Windows.Forms.Button Xuatexcel_cacbang;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Check_tenbang;
    }
}

