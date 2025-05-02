using BUS;
using Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TeacherManage : Form
    {
        BUS_Teacher bt;
        int dk = 0;
        public TeacherManage()
        {
            InitializeComponent();
        }

        private void vohieuhoa(bool b)
        {
            txtName.ReadOnly = b;
            dt.Enabled = !b;
            txtAddress.ReadOnly = b;
            txtSDT.ReadOnly = b;
            cbGT.Enabled = !b;
            txtE.ReadOnly = b;
        }

        private void TeacherManage_Load(object sender, EventArgs e)
        {
            bt = new BUS_Teacher("", "", "", "", DateTime.Now, "", "");
            grd.DataSource = bt.selectQuery();

            cbGT.Items.Clear();
            cbGT.Items.Add("Nam");
            cbGT.Items.Add("Nữ");
            cbGT.SelectedIndex = -1;
            bSave.Enabled = false;
            vohieuhoa(true);
            if (Program.Role == "Giaovien")
            {
                txtTID.Focus();
                bAdd.Enabled = false;
                bSave.Enabled = false;
                bDel.Enabled = false;
                bEdit.Enabled = false;
                bCal.Enabled = false;
            }
            else
            {

            }

        }
        private void txtTID_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string maGV = txtTID.Text.Trim();
                if (!string.IsNullOrEmpty(maGV))
                {
                    var result = bt.selectQuery_Teacher(maGV);
                    if (result.Rows.Count > 0)
                    {
                        grd.DataSource = result;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy giáo viên!");
                        grd.DataSource = bt.selectQuery();
                    }
                }
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            dk = 1;
            vohieuhoa(false);
            txtTID.Text = bt.getTID();
            txtName.Focus();
            txtName.Clear();
            txtAddress.Clear();
            txtSDT.Clear();
            txtE.Clear();
            cbGT.SelectedIndex = -1;
            dt.Value = DateTime.Now;
            bEdit.Enabled = false;
            bDel.Enabled = false; 
            bSave.Enabled = true;
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (grd.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa giáo viên này?", "Chắc chắn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string tid = grd.CurrentRow.Cells["MaGV"].Value.ToString();

                    bt = new BUS_Teacher(tid, "", "", "", DateTime.Now, "", "");
                    bt.deleteQuery();

                    MessageBox.Show("Xóa Giáo Viên thành công!");
                    grd.DataSource = bt.selectQuery();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn giáo viên muốn xóa.");
            }
            bSave.Enabled = false;
            txtTID.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtSDT.Clear();
            txtE.Clear();
            cbGT.SelectedIndex = -1;
            dt.Value = DateTime.Now;
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTID.Text))
            {
                MessageBox.Show("Vui lòng chọn giáo viên muốn chỉnh sửa.");
                return;
            }
            if (Program.Role == "Admin")
            {
                vohieuhoa(false);
                dk = 2;
                txtName.Focus();
                txtTID.ReadOnly = true;
                bAdd.Enabled = false;
                bDel.Enabled = false;
                bSave.Enabled = true;
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTID.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(dt.Text) || string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(cbGT.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            string gioiTinh = cbGT.Text;

            if (dk == 1)
            {
                // Thêm mới
                bt = new BUS_Teacher(txtTID.Text, txtName.Text, txtAddress.Text, txtSDT.Text, DateTime.Parse(dt.Text), gioiTinh, txtE.Text);
                bt.addQuery();
            }
            else if (dk == 2)
            {
                // Chỉnh sửa
                bt = new BUS_Teacher(txtTID.Text, txtName.Text, txtAddress.Text, txtSDT.Text, DateTime.Parse(dt.Text), gioiTinh, txtE.Text);
                bt.updateQuery();
            }
            dk = 0;
            txtTID.ReadOnly = !true;
            bAdd.Enabled = true; 
            bDel.Enabled = true; 
            bEdit.Enabled = true; 
            bSave.Enabled = false;
            txtTID.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtSDT.Text = "";
            txtE.Text = "";
            cbGT.SelectedIndex = -1;
            dt.Value = DateTime.Now;
            grd.DataSource = bt.selectQuery();  
        }


        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = grd.Rows[e.RowIndex];

                txtTID.Text = row.Cells["MaGV"].Value.ToString();
                txtName.Text = row.Cells["HoTen"].Value.ToString();
                txtAddress.Text = row.Cells["DiaChi"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                cbGT.Text = row.Cells["GioiTinh"].Value.ToString();
                dt.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                txtE.Text = row.Cells["Email"].Value.ToString();
            }
        }

        private void bCal_Click(object sender, EventArgs e)
        {
            TeacherManage_Load(sender, e);
            txtTID.Clear();
            txtAddress.Clear();
            txtSDT.Clear();
            txtE.Clear();
            cbGT.SelectedIndex = -1;
            dt.Value = DateTime.Now;
            bAdd.Enabled = true;
            bDel.Enabled = true;
            bEdit.Enabled = true;
        }
    }
}
