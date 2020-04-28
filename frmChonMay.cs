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
    public partial class frmChonMay : Form
    {
        
        DataTable tableThueMay;
        public frmChonMay()
        {
            InitializeComponent();
        }

        private void FrmChonMay_Load(object sender, EventArgs e)
        {
            functions.FillCombo("select MaPhong, TenPhong from Phong ", cboMaPhong, "MaPhong", "MaPhong");
            cboMaPhong.SelectedIndex = -1;
        }
        private void loadDataToGridView()
        {
            string sql = " select  a.MaPhong , a.MaMay , a.TenMay ,TinhTrang from MayTinh a join ThueMay b on a.MaMay = b.MaMay";
            DataTable table = functions.GetDataToTable(sql);
            dataGridView_ChonMay.DataSource = table;
        }

        private void ResetValues()
        {
            txtTenKhach.Text = "";
            txtNgayThue.Text = DateTime.Now.ToShortDateString();
            txtTenPhong.Text = "";
            cboMaPhong.Text = "";
            txtGioVao.Text = DateTime.Now.ToString();

        }
        private void btnTimLai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dataGridView_ChonMay.DataSource = null;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            txtNgayThue.Text = DateTime.Now.ToShortDateString();
            txtGioVao.Text = DateTime.Now.TimeOfDay.ToString();

            if (cboMaPhong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaPhong.Focus();
                return;
            }
            if (txtTenPhong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần nhập tên phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenPhong.Focus();
                return;
            }
            if (txtTenKhach.Text == "")
            {
                MessageBox.Show("Bạn cần nhập tên mình ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhach.Focus();
                return;
            }

            sql = "select a.MaPhong, a.MaMay, a.TenMay,a.TinhTrang from MayTinh a join ThueMay b on a.MaMay = b.MaMay WHERE 1=1";
            if (cboMaPhong.Text != "")
            {
                sql = sql + " AND a.MaPhong Like N'%" + cboMaPhong.Text + "%'";
                sql = sql + " AND a.TinhTrang = 'Trống'";
            }
            tableThueMay = functions.GetDataToTable(sql);
            if (tableThueMay.Rows.Count == 0)
                MessageBox.Show(" Không còn máy trống trong phòng này! ", " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có" + tableThueMay.Rows.Count + " máy còn trống trong phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dataGridView_ChonMay.DataSource = tableThueMay;
            
        }

        private void cboMaPhong_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaPhong.Text == "")
            {
                txtTenPhong.Text = "";
            }
            else
            {
                str = " select TenPhong from Phong where MaPhong = N'" + cboMaPhong.SelectedValue + "'";
                txtTenPhong.Text = GetField(str);
            }
        }

        private void dataGridView_ChonMay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMay.Text = dataGridView_ChonMay.CurrentRow.Cells["MaMay"].Value.ToString();
            var item = dataGridView_ChonMay.Rows[e.RowIndex].Cells[0].Value;
            
            if (MessageBox.Show("Bạn muốn chọn máy này? ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(" Cảm ơn bạn đã lựa chọn dịch vụ!", " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }


        }
        public string GetField(string sql)
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            frmTraMay frm = new frmTraMay();
            frm.Message = txtGioVao.Text;
            frm.Message1 = cboMaPhong.Text;
            frm.Message2 = txtTenKhach.Text;
            frm.Message3 = txtMaMay.Text;
            frm.Message4 = txtNgayThue.Text;
            frm.Show();

            
        }

    }
}
