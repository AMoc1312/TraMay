namespace btlquanlycuahanginternet
{
    partial class frmChonMay
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
            this.btnDong = new System.Windows.Forms.Button();
            this.btnTimLai = new System.Windows.Forms.Button();
            this.lbTenPhong = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dataGridView_ChonMay = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboMaPhong = new System.Windows.Forms.ComboBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtNgayThue = new System.Windows.Forms.TextBox();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.lbNgayThue = new System.Windows.Forms.Label();
            this.lbTenKhach = new System.Windows.Forms.Label();
            this.lbMaPhong = new System.Windows.Forms.Label();
            this.blChonMay = new System.Windows.Forms.Label();
            this.lbGioVao = new System.Windows.Forms.Label();
            this.txtGioVao = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lbMaMay = new System.Windows.Forms.Label();
            this.txtMaMay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChonMay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(418, 139);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(73, 23);
            this.btnDong.TabIndex = 43;
            this.btnDong.Text = "Đóng\r\n";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnTimLai
            // 
            this.btnTimLai.Location = new System.Drawing.Point(184, 140);
            this.btnTimLai.Name = "btnTimLai";
            this.btnTimLai.Size = new System.Drawing.Size(75, 23);
            this.btnTimLai.TabIndex = 42;
            this.btnTimLai.Text = "Tìm lại\r\n";
            this.btnTimLai.UseVisualStyleBackColor = true;
            this.btnTimLai.Click += new System.EventHandler(this.btnTimLai_Click);
            // 
            // lbTenPhong
            // 
            this.lbTenPhong.AutoSize = true;
            this.lbTenPhong.Location = new System.Drawing.Point(306, 85);
            this.lbTenPhong.Name = "lbTenPhong";
            this.lbTenPhong.Size = new System.Drawing.Size(60, 13);
            this.lbTenPhong.TabIndex = 41;
            this.lbTenPhong.Text = "Tên Phòng";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(66, 139);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(77, 23);
            this.btnTimKiem.TabIndex = 40;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dataGridView_ChonMay
            // 
            this.dataGridView_ChonMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ChonMay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.MaMay,
            this.TenMay,
            this.TinhTrang});
            this.dataGridView_ChonMay.Location = new System.Drawing.Point(34, 168);
            this.dataGridView_ChonMay.Name = "dataGridView_ChonMay";
            this.dataGridView_ChonMay.Size = new System.Drawing.Size(484, 140);
            this.dataGridView_ChonMay.TabIndex = 39;
            this.dataGridView_ChonMay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ChonMay_CellClick);
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "MaPhong";
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Width = 110;
            // 
            // MaMay
            // 
            this.MaMay.DataPropertyName = "MaMay";
            this.MaMay.HeaderText = "MaMay";
            this.MaMay.Name = "MaMay";
            this.MaMay.Width = 110;
            // 
            // TenMay
            // 
            this.TenMay.DataPropertyName = "TenMay";
            this.TenMay.HeaderText = "TenMay";
            this.TenMay.Name = "TenMay";
            this.TenMay.Width = 110;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "TinhTrang";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Width = 110;
            // 
            // cboMaPhong
            // 
            this.cboMaPhong.FormattingEnabled = true;
            this.cboMaPhong.Location = new System.Drawing.Point(388, 46);
            this.cboMaPhong.Name = "cboMaPhong";
            this.cboMaPhong.Size = new System.Drawing.Size(103, 21);
            this.cboMaPhong.TabIndex = 38;
            this.cboMaPhong.TextChanged += new System.EventHandler(this.cboMaPhong_TextChanged);
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(388, 78);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(103, 20);
            this.txtTenPhong.TabIndex = 37;
            // 
            // txtNgayThue
            // 
            this.txtNgayThue.Location = new System.Drawing.Point(141, 82);
            this.txtNgayThue.Name = "txtNgayThue";
            this.txtNgayThue.Size = new System.Drawing.Size(103, 20);
            this.txtNgayThue.TabIndex = 36;
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(141, 46);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(103, 20);
            this.txtTenKhach.TabIndex = 35;
            // 
            // lbNgayThue
            // 
            this.lbNgayThue.AutoSize = true;
            this.lbNgayThue.Location = new System.Drawing.Point(53, 85);
            this.lbNgayThue.Name = "lbNgayThue";
            this.lbNgayThue.Size = new System.Drawing.Size(60, 13);
            this.lbNgayThue.TabIndex = 34;
            this.lbNgayThue.Text = "Ngày Thuê";
            // 
            // lbTenKhach
            // 
            this.lbTenKhach.AutoSize = true;
            this.lbTenKhach.Location = new System.Drawing.Point(53, 49);
            this.lbTenKhach.Name = "lbTenKhach";
            this.lbTenKhach.Size = new System.Drawing.Size(60, 13);
            this.lbTenKhach.TabIndex = 33;
            this.lbTenKhach.Text = "Tên Khách";
            // 
            // lbMaPhong
            // 
            this.lbMaPhong.AutoSize = true;
            this.lbMaPhong.Location = new System.Drawing.Point(310, 49);
            this.lbMaPhong.Name = "lbMaPhong";
            this.lbMaPhong.Size = new System.Drawing.Size(56, 13);
            this.lbMaPhong.TabIndex = 32;
            this.lbMaPhong.Text = "Mã Phòng";
            // 
            // blChonMay
            // 
            this.blChonMay.AutoSize = true;
            this.blChonMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blChonMay.Location = new System.Drawing.Point(165, 9);
            this.blChonMay.Name = "blChonMay";
            this.blChonMay.Size = new System.Drawing.Size(212, 33);
            this.blChonMay.TabIndex = 44;
            this.blChonMay.Text = "Tìm Máy Trống\r\n";
            // 
            // lbGioVao
            // 
            this.lbGioVao.AutoSize = true;
            this.lbGioVao.Location = new System.Drawing.Point(53, 117);
            this.lbGioVao.Name = "lbGioVao";
            this.lbGioVao.Size = new System.Drawing.Size(44, 13);
            this.lbGioVao.TabIndex = 45;
            this.lbGioVao.Text = "Giờ vào";
            // 
            // txtGioVao
            // 
            this.txtGioVao.Location = new System.Drawing.Point(141, 114);
            this.txtGioVao.Name = "txtGioVao";
            this.txtGioVao.Size = new System.Drawing.Size(103, 20);
            this.txtGioVao.TabIndex = 46;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(302, 140);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 47;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lbMaMay
            // 
            this.lbMaMay.AutoSize = true;
            this.lbMaMay.Location = new System.Drawing.Point(306, 117);
            this.lbMaMay.Name = "lbMaMay";
            this.lbMaMay.Size = new System.Drawing.Size(45, 13);
            this.lbMaMay.TabIndex = 48;
            this.lbMaMay.Text = "Mã Máy";
            // 
            // txtMaMay
            // 
            this.txtMaMay.Location = new System.Drawing.Point(388, 114);
            this.txtMaMay.Name = "txtMaMay";
            this.txtMaMay.Size = new System.Drawing.Size(103, 20);
            this.txtMaMay.TabIndex = 49;
            // 
            // frmChonMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 343);
            this.Controls.Add(this.txtMaMay);
            this.Controls.Add(this.lbMaMay);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtGioVao);
            this.Controls.Add(this.lbGioVao);
            this.Controls.Add(this.blChonMay);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTimLai);
            this.Controls.Add(this.lbTenPhong);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dataGridView_ChonMay);
            this.Controls.Add(this.cboMaPhong);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.txtNgayThue);
            this.Controls.Add(this.txtTenKhach);
            this.Controls.Add(this.lbNgayThue);
            this.Controls.Add(this.lbTenKhach);
            this.Controls.Add(this.lbMaPhong);
            this.Name = "frmChonMay";
            this.Text = "FrmChonMay";
            this.Load += new System.EventHandler(this.FrmChonMay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChonMay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnTimLai;
        private System.Windows.Forms.Label lbTenPhong;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dataGridView_ChonMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.ComboBox cboMaPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtNgayThue;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.Label lbNgayThue;
        private System.Windows.Forms.Label lbTenKhach;
        private System.Windows.Forms.Label lbMaPhong;
        private System.Windows.Forms.Label blChonMay;
        private System.Windows.Forms.Label lbGioVao;
        private System.Windows.Forms.TextBox txtGioVao;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lbMaMay;
        private System.Windows.Forms.TextBox txtMaMay;
    }
}