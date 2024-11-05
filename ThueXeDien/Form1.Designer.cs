namespace ThueXeDien
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.btnDung = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvXe = new System.Windows.Forms.DataGridView();
            this.MaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangTrai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvXeChay = new System.Windows.Forms.DataGridView();
            this.MaXeChay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThuTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXeChay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(336, 50);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 39);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm xe";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnBatDau
            // 
            this.btnBatDau.Location = new System.Drawing.Point(675, 43);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(99, 39);
            this.btnBatDau.TabIndex = 1;
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // btnDung
            // 
            this.btnDung.Location = new System.Drawing.Point(820, 43);
            this.btnDung.Name = "btnDung";
            this.btnDung.Size = new System.Drawing.Size(99, 39);
            this.btnDung.TabIndex = 2;
            this.btnDung.Text = "Dừng";
            this.btnDung.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã xe";
            // 
            // txtMaXe
            // 
            this.txtMaXe.Location = new System.Drawing.Point(128, 56);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(141, 26);
            this.txtMaXe.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1121, 43);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 39);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvXe
            // 
            this.dgvXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaXe,
            this.TrangTrai});
            this.dgvXe.Location = new System.Drawing.Point(30, 134);
            this.dgvXe.Name = "dgvXe";
            this.dgvXe.RowHeadersWidth = 62;
            this.dgvXe.RowTemplate.Height = 28;
            this.dgvXe.Size = new System.Drawing.Size(567, 304);
            this.dgvXe.TabIndex = 6;
            this.dgvXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXe_CellClick);
            // 
            // MaXe
            // 
            this.MaXe.DataPropertyName = "MaXe";
            this.MaXe.HeaderText = "Mã xe";
            this.MaXe.MinimumWidth = 8;
            this.MaXe.Name = "MaXe";
            this.MaXe.Width = 150;
            // 
            // TrangTrai
            // 
            this.TrangTrai.DataPropertyName = "TrangTrai";
            this.TrangTrai.HeaderText = "Trạng thái";
            this.TrangTrai.MinimumWidth = 8;
            this.TrangTrai.Name = "TrangTrai";
            this.TrangTrai.Width = 150;
            // 
            // dgvXeChay
            // 
            this.dgvXeChay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXeChay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaXeChay,
            this.ThuTien,
            this.ThoiGian});
            this.dgvXeChay.Location = new System.Drawing.Point(618, 134);
            this.dgvXeChay.Name = "dgvXeChay";
            this.dgvXeChay.RowHeadersWidth = 62;
            this.dgvXeChay.RowTemplate.Height = 28;
            this.dgvXeChay.Size = new System.Drawing.Size(617, 304);
            this.dgvXeChay.TabIndex = 7;
            // 
            // MaXeChay
            // 
            this.MaXeChay.DataPropertyName = "MaXeChay";
            this.MaXeChay.HeaderText = "Mã xe";
            this.MaXeChay.MinimumWidth = 8;
            this.MaXeChay.Name = "MaXeChay";
            this.MaXeChay.Width = 150;
            // 
            // ThuTien
            // 
            this.ThuTien.DataPropertyName = "ThuTien";
            this.ThuTien.HeaderText = "Thu tiền";
            this.ThuTien.MinimumWidth = 8;
            this.ThuTien.Name = "ThuTien";
            this.ThuTien.Width = 150;
            // 
            // ThoiGian
            // 
            this.ThoiGian.DataPropertyName = "ThoiGian";
            this.ThoiGian.HeaderText = "Thời gian";
            this.ThoiGian.MinimumWidth = 8;
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.Width = 150;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(475, 50);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 39);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 450);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvXeChay);
            this.Controls.Add(this.dgvXe);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtMaXe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDung);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.btnThem);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXeChay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Button btnDung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvXe;
        private System.Windows.Forms.DataGridView dgvXeChay;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangTrai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaXeChay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThuTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
    }
}

