namespace BTLon_QLNhanSu
{
    partial class Form_Chuvu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Machucvu = new System.Windows.Forms.TextBox();
            this.Tenchucvu = new System.Windows.Forms.TextBox();
            this.dataGridViewChucVu = new System.Windows.Forms.DataGridView();
            this.ma_chuc_vu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_chuc_vu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Insert = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Xuat_excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã chức vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên chức vụ";
            // 
            // Machucvu
            // 
            this.Machucvu.Location = new System.Drawing.Point(235, 26);
            this.Machucvu.Name = "Machucvu";
            this.Machucvu.Size = new System.Drawing.Size(294, 22);
            this.Machucvu.TabIndex = 2;
            this.Machucvu.TextChanged += new System.EventHandler(this.Machucvu_TextChanged);
            // 
            // Tenchucvu
            // 
            this.Tenchucvu.Location = new System.Drawing.Point(235, 95);
            this.Tenchucvu.Name = "Tenchucvu";
            this.Tenchucvu.Size = new System.Drawing.Size(294, 22);
            this.Tenchucvu.TabIndex = 3;
            // 
            // dataGridViewChucVu
            // 
            this.dataGridViewChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChucVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_chuc_vu,
            this.Ten_chuc_vu});
            this.dataGridViewChucVu.Location = new System.Drawing.Point(138, 295);
            this.dataGridViewChucVu.Name = "dataGridViewChucVu";
            this.dataGridViewChucVu.RowHeadersWidth = 51;
            this.dataGridViewChucVu.RowTemplate.Height = 24;
            this.dataGridViewChucVu.Size = new System.Drawing.Size(335, 239);
            this.dataGridViewChucVu.TabIndex = 4;
            this.dataGridViewChucVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChucVu_CellContentClick);
            this.dataGridViewChucVu.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.chondong);
            // 
            // ma_chuc_vu
            // 
            this.ma_chuc_vu.DataPropertyName = "Ma_chuc_vu";
            this.ma_chuc_vu.HeaderText = "mã chức vụ";
            this.ma_chuc_vu.MinimumWidth = 6;
            this.ma_chuc_vu.Name = "ma_chuc_vu";
            this.ma_chuc_vu.Width = 125;
            // 
            // Ten_chuc_vu
            // 
            this.Ten_chuc_vu.DataPropertyName = "Ten_chuc_vu";
            this.Ten_chuc_vu.HeaderText = "Tên chức vụ";
            this.Ten_chuc_vu.MinimumWidth = 6;
            this.Ten_chuc_vu.Name = "Ten_chuc_vu";
            this.Ten_chuc_vu.Width = 125;
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(32, 229);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 5;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(154, 230);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 6;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(295, 230);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Xuat_excel
            // 
            this.Xuat_excel.Location = new System.Drawing.Point(430, 230);
            this.Xuat_excel.Name = "Xuat_excel";
            this.Xuat_excel.Size = new System.Drawing.Size(75, 23);
            this.Xuat_excel.TabIndex = 9;
            this.Xuat_excel.Text = "xuất excel";
            this.Xuat_excel.UseVisualStyleBackColor = true;
            this.Xuat_excel.Click += new System.EventHandler(this.Xuat_excel_Click);
            // 
            // Form_Chuvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 546);
            this.Controls.Add(this.Xuat_excel);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.dataGridViewChucVu);
            this.Controls.Add(this.Tenchucvu);
            this.Controls.Add(this.Machucvu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Chuvu";
            this.Text = "Form_Chuvu";
            this.Load += new System.EventHandler(this.Form_Chuvu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChucVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Machucvu;
        private System.Windows.Forms.TextBox Tenchucvu;
        private System.Windows.Forms.DataGridView dataGridViewChucVu;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Xuat_excel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_chuc_vu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_chuc_vu;
    }
}