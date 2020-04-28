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
    public partial class frmPhong : Form
    {
        DataTable tablePhong;
        public frmPhong()
        {
            InitializeComponent();
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            functions.Connect();
            loadDataToGridView();

        }
        private void loadDataToGridView()
        {
            string sql = " select * from Phong";
            DataTable table = functions.GetDataToTable(sql);
            dataGridView_Phong.DataSource = table;
        }

        private void dataGridView_Phong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhong.Text = dataGridView_Phong.CurrentRow.Cells["MaPhong"].Value.ToString();
            txtTenPhong.Text = dataGridView_Phong.CurrentRow.Cells["TenPhong"].Value.ToString();
            txtSoMay.Text = dataGridView_Phong.CurrentRow.Cells["SoMay"].Value.ToString();
            txtMaPhong.Enabled = false;
        }
        private void ResetValues()
        {
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            txtSoMay.Text = "";
        }

        private void txtSoMay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
            (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtMaPhong.Enabled = true;
            txtMaPhong.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaPhong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "Delete from Phong where MaPhong='" + txtMaPhong.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, functions.con);
                cmd.ExecuteNonQuery();
                loadDataToGridView();
                ResetValues();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "Update Phong set TenPhong='" + txtTenPhong.Text + "',SoMay='" + txtSoMay.Text + "'" +
                  "where MaPhong='" + txtMaPhong.Text + "' ";
            if (txtTenPhong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần nhập tên phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenPhong.Focus();
                return;
            }
            if (txtSoMay.Text == "")
            {
                MessageBox.Show("Bạn cần nhập số máy ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoMay.Focus();
                return;
            }
            txtMaPhong.Enabled = false;
            functions.RunSQL(sql);
            loadDataToGridView();
            ResetValues();
           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "SELECT MaPhong FROM Phong WHERE MaPhong='" + txtMaPhong.Text + "'";
            SqlDataAdapter adp = new SqlDataAdapter(sql, functions.con);
            DataTable tablePhong = new DataTable();
            adp.Fill(tablePhong);
            if (tablePhong.Rows.Count > 0)
            {
                MessageBox.Show("Mã phòng đã tồn tại");
                return;
            }
            if (txtMaPhong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhong.Focus();
                return;
            }
            if (txtTenPhong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần nhập tên phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenPhong.Focus();
                return;
            }
            if (txtSoMay.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoMay.Focus();
                return;
            }
            else
            {
                sql = "insert into Phong values('" + txtMaPhong.Text + "','" + txtTenPhong.Text + "'";
                if (txtSoMay.Text != "")
                    sql = sql + "," + txtSoMay.Text.Trim();
                sql = sql + ")";

                try
                {
                    SqlCommand cmd = new SqlCommand(sql, functions.con);
                    cmd.ExecuteNonQuery();
                    loadDataToGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaPhong.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình không?", "Thông báo"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            functions.DisConnect();
            this.Close();
        }

    }
}
