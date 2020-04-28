using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using btlquanlycuahanginternet.Class;
using System.Data.SqlClient;

namespace btlquanlycuahanginternet
{
    public partial class frmMayTinh : Form
    {
        DataTable tableMayTinh;
        public frmMayTinh()
        {
            InitializeComponent();
        }

        private void frmMayTinh_Load(object sender, EventArgs e)
        {
            functions.Connect();
            loadDataToGridView();
            functions.FillCombo(" select MaPhong, TenPhong from Phong ", cboMaPhong, "MaPhong", "TenPhong");
            cboMaPhong.SelectedIndex = -1;
            functions.FillCombo(" select MaOCung, TenOCung from O_Cung ", cboMaOCung, "MaOCung", "TenOCung");
            cboMaOCung.SelectedIndex = -1;
            functions.FillCombo(" select MaDLuong, TenDLuong from Dung_Luong ", cboMaDLuong, "MaDLuong", "TenDLuong");
            cboMaDLuong.SelectedIndex = -1;
            functions.FillCombo(" select MaChip, TenChip from Chip ", cboMaChip, "MaChip", "TenChip");
            cboMaChip.SelectedIndex = -1;
            functions.FillCombo(" select MaRam, TenRam from Ram ", cboMaRam, "MaRam", "TenRam");
            cboMaRam.SelectedIndex = -1;
            functions.FillCombo(" select MaTocDo, TenTocDo from Toc_Do ", cboMaTocDo, "MaTocDo", "TenTocDo");
            cboMaTocDo.SelectedIndex = -1;
            functions.FillCombo(" select MaManHinh, TenManHinh from Man_Hinh ", cboMaManHinh, "MaManHinh", "TenManHinh");
            cboMaManHinh.SelectedIndex = -1;
            functions.FillCombo(" select MaSizeMH, TenSizeMH from SizeMH ", cboMaSizeMH, "MaSizeMH", "TenSizeMH");
            cboMaSizeMH.SelectedIndex = -1;
            functions.FillCombo(" select MaChuot, TenChuot from Chuot ", cboMaChuot, "MaChuot", "TenChuot");
            cboMaChuot.SelectedIndex = -1;
            functions.FillCombo(" select MaBanPhim, TenBanPhim from BanPhim ", cboMaBanPhim, "MaBanPhim", "TenBanPhim");
            cboMaBanPhim.SelectedIndex = -1;
            functions.FillCombo(" select MaODia, TenODia from O_Dia ", cboMaODia, "MaODia", "TenODia");
            cboMaODia.SelectedIndex = -1;
            functions.FillCombo(" select MaLoa, TenLoa from Loa ", cboMaLoa, "MaLoa", "TenLoa");
            cboMaLoa.SelectedIndex = -1;
            ResetValues();
        }
        private void loadDataToGridView()
        {
            string sql = " select  * from MayTinh ";
            DataTable table = functions.GetDataToTable(sql);
            dataGridView_MayTinh.DataSource = table;
        }

        
        private void ResetValues()
        {
            txtGhiChu.Text = "";
            cboMaBanPhim.Text = "";
            cboMaChip.Text = "";
            cboMaChuot.Text = "";
            cboMaDLuong.Text = "";
            cboMaLoa.Text = "";
            cboMaManHinh.Text = "";
            txtMaMay.Text = "";
            cboMaOCung.Text = "";
            cboMaODia.Text = "";
            cboMaPhong.Text = "";
            cboMaRam.Text = "";
            cboMaSizeMH.Text = "";
            cboMaTocDo.Text = "";
            txtTenMay.Text = "";
            txtTinhTrang.Text = "";
            
        }

       
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            ResetValues();
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            cboMaPhong.Enabled = true;
            cboMaPhong.Focus();
            cboMaBanPhim.Enabled = true;
            cboMaBanPhim.Focus();
            cboMaChip.Enabled = true;
            cboMaChip.Focus();
            cboMaChuot.Enabled = true;
            cboMaChuot.Focus();
            cboMaDLuong.Enabled = true;
            cboMaDLuong.Focus();
            cboMaLoa.Enabled = true;
            cboMaLoa.Focus();
            cboMaManHinh.Enabled = true;
            cboMaManHinh.Focus();
            txtMaMay.Enabled = true;
            txtMaMay.Focus();
            cboMaOCung.Enabled = true;
            cboMaOCung.Focus();
            cboMaODia.Enabled = true;
            cboMaODia.Focus();
            cboMaRam.Enabled = true;
            cboMaRam.Focus();
            cboMaSizeMH.Enabled = true;
            cboMaSizeMH.Focus();
            cboMaTocDo.Enabled = true;
            cboMaTocDo.Focus();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string sql;
            if (tableMayTinh.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaMay.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblHang WHERE MaHang=N'" + txtMaMay.Text + "'";
                functions.RunSqlDel(sql);
                loadDataToGridView();
                ResetValues();
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            string sql;
            if (txtMaMay.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã máy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaMay.Focus();
                return;
            }
            if (txtTenMay.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên máy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenMay.Focus();
                return;
            }
            if (cboMaPhong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaPhong.Focus();
                return;
            }
            if (txtTinhTrang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tình trạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTinhTrang.Focus();
                return;
            }
            if (cboMaOCung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã ổ cứng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaOCung.Focus();
                return;
            }
            if (cboMaDLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã dung lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaDLuong.Focus();
                return;
            }
            if (cboMaChip.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chip", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaChip.Focus();
                return;
            }
            if (cboMaRam.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã ram", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaRam.Focus();
                return;
            }
            if (cboMaTocDo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã tốc độ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaTocDo.Focus();
                return;
            }
            if (cboMaManHinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã màn hình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaManHinh.Focus();
                return;
            }
            if (cboMaSizeMH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã size màn hình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaSizeMH.Focus();
                return;
            }
            if (cboMaBanPhim.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã bàn phím", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaBanPhim.Focus();
                return;
            }
            if (cboMaODia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã ổ đĩa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaODia.Focus();
                return;
            }
            if (cboMaChuot.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chuột", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaChuot.Focus();
                return;
            }
            if (cboMaLoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã loa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaLoa.Focus();
                return;
            }
            sql = "UPDATE MayTinh SET TenMay='" + txtTenMay.Text.Trim() + "',MaPhong='" + cboMaPhong.Text + "',MaOCung='" +cboMaOCung.SelectedValue +
                "',MaRam='" + cboMaRam.SelectedValue + "',MaDLuong='" + cboMaDLuong.SelectedValue + "',MaChip='" + cboMaChip.SelectedValue + "'," +
                ",MaTocDo='" + cboMaTocDo.SelectedValue + "',MaManHinh='" + cboMaManHinh.SelectedValue + "'," +
                "MaSizeMH='" + cboMaSizeMH.SelectedValue + "',MaChuot='" + cboMaChuot.SelectedValue + "',MaBanPhim='" + cboMaBanPhim.SelectedValue + "'," +
                "MaODia='" + cboMaODia.SelectedValue + "',MaLoa='" + cboMaLoa.SelectedValue + "',TinhTrang='" + txtTinhTrang.Text + "'," +
                "GhiChu='" + txtGhiChu.Text + "'";
            functions.RunSQL(sql);
            loadDataToGridView();
            ResetValues();
            btnHuy.Enabled = false;
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            string sql = "SELECT MaMay FROM MayTinh WHERE MaMay=N'" + txtMaMay.Text + "'";
            SqlDataAdapter adp = new SqlDataAdapter(sql, functions.con);
            DataTable tableMayTinh = new DataTable();
            adp.Fill(tableMayTinh);
            if (txtMaMay.Text == "")
            {
                MessageBox.Show("Bạn cần nhập Mã máy ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaMay.Focus();
                return;
            }
            if (txtTenMay.Text == "")
            {
                MessageBox.Show("Bạn cần nhập tên máy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenMay.Focus();
                return;
            }
            if (cboMaPhong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần chọn mã phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaPhong.Focus();
                return;
            }
            if (cboMaOCung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần chọn Mã ổ cứng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaOCung.Focus();
                return;
            }

            if (cboMaDLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần chọn mã dung lượng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaDLuong.Focus();
                return;

            }
            if (cboMaChip.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần chọn mã chip", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaChip.Focus();
                return;
            }
            if (cboMaRam.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần chọn mã ram", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaRam.Focus();
                return;
            }
            if (cboMaTocDo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần chọn mã tốc độ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaTocDo.Focus();
                return;
            }
            if (cboMaManHinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần chọn mã Màn hình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaManHinh.Focus();
                return;
            }
            if (cboMaSizeMH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần chọn Mã size MH", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaSizeMH.Focus();
                return;
            }
            if (cboMaChuot.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần chọn mã chuột", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaChuot.Focus();
                return;
            }
            if (cboMaBanPhim.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần chọn Mã bàn phím", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaBanPhim.Focus();
                return;
            }
            if (cboMaODia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần chọn tình trạng máy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaODia.Focus();
                return;
            }
            if (cboMaLoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần chọn tình trạng máy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaLoa.Focus();
                return;
            }
            if (txtTinhTrang.Text == "")
            {
                MessageBox.Show("Bạn cần nhập tình trạng máy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTinhTrang.Focus();
                return;
            }
            else
            {
                sql = "insert into MayTinh values('" + txtMaMay.Text + "','" + txtTenMay.Text + "','" + cboMaPhong.SelectedValue + "','" +
                    cboMaOCung.SelectedValue + "','" + cboMaDLuong.SelectedValue + "','" + cboMaChip.SelectedValue + "','" + cboMaRam.SelectedValue + "'" +
                  ",'" + cboMaTocDo.SelectedValue + "','" + cboMaManHinh.SelectedValue + "','" + cboMaSizeMH.SelectedValue + "','" + cboMaChuot.SelectedValue +
                  "','" + cboMaBanPhim.SelectedValue + "','" + cboMaODia.SelectedValue + "','" +
                  cboMaLoa.SelectedValue + "','" + txtTinhTrang.Text + "','" + txtGhiChu.Text + "')";
                functions.RunSQL(sql);
                ResetValues();
                loadDataToGridView();

            }
            if (tableMayTinh.Rows.Count > 0)
            {
                MessageBox.Show("Mã máy đã tồn tại");
                MessageBox.Show("Bạn phải nhập mã máy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaMay.Focus();
                return;
            }
           
            else 
            {
                string sql1 = " update Phong set SoMay = SoMay +1 WHERE MaPhong = '" + cboMaPhong.SelectedValue + "'";
                functions.RunSQL(sql1);

                double sl = Convert.ToDouble(GetFieldValues(" select somay from Phong where MaPhong = '" + cboMaPhong.SelectedValue + "'"));
                MessageBox.Show(" số máy sau khi cập nhật là " + sl, " thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            ResetValues();
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThoat.Enabled = true;
            txtMaMay.Enabled = false;
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, functions.con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
        }

        private void dataGridView_MayTinh_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaMay.Focus();
                return;
            }
            txtMaMay.Text = dataGridView_MayTinh.CurrentRow.Cells["MaMay"].Value.ToString();
            txtTenMay.Text = dataGridView_MayTinh.CurrentRow.Cells["TenMay"].Value.ToString();
            cboMaPhong.Text = dataGridView_MayTinh.CurrentRow.Cells["MaPhong"].Value.ToString();
            txtTinhTrang.Text = dataGridView_MayTinh.CurrentRow.Cells["TinhTrang"].Value.ToString();
            txtGhiChu.Text = dataGridView_MayTinh.CurrentRow.Cells["GhiChu"].Value.ToString();
            cboMaOCung.Text = dataGridView_MayTinh.CurrentRow.Cells["MaOCung"].Value.ToString();
            cboMaChuot.Text = dataGridView_MayTinh.CurrentRow.Cells["MaChuot"].Value.ToString();
            cboMaBanPhim.Text = dataGridView_MayTinh.CurrentRow.Cells["MaBanPhim"].Value.ToString();
            cboMaDLuong.Text = dataGridView_MayTinh.CurrentRow.Cells["MaDLuong"].Value.ToString();
            cboMaLoa.Text = dataGridView_MayTinh.CurrentRow.Cells["MaLoa"].Value.ToString();
            cboMaManHinh.Text = dataGridView_MayTinh.CurrentRow.Cells["MaManHinh"].Value.ToString();
            cboMaODia.Text = dataGridView_MayTinh.CurrentRow.Cells["MaODia"].Value.ToString();
            cboMaRam.Text = dataGridView_MayTinh.CurrentRow.Cells["MaRam"].Value.ToString();
            cboMaSizeMH.Text = dataGridView_MayTinh.CurrentRow.Cells["MaSizeMH"].Value.ToString();
            cboMaTocDo.Text = dataGridView_MayTinh.CurrentRow.Cells["MaTocDo"].Value.ToString();
            cboMaChip.Text = dataGridView_MayTinh.CurrentRow.Cells["MaChip"].Value.ToString();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;

        }
    }
}
