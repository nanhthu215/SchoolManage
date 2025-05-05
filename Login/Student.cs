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
using System.Xml.Linq;

namespace GUI
{
    public partial class Student : Form
    {
        BUS_Student bs;
        int dk = 0;
        public Student()
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
            cbClass.Enabled = !b;
        }

        private void LoadClassList()
        {
            cbClass.DataSource = bs.selectClassList();
            cbClass.DisplayMember = "TenLop";
            cbClass.ValueMember = "MaLop";
        }


        private void Student_Load(object sender, EventArgs e)
        {
            bs = new BUS_Student("", "", "", "", DateTime.Now, "", "");
            grd.DataSource = bs.selectQuery();
            LoadClassList();
            bSave.Enabled = false;
            cbGT.Items.Clear();
            cbGT.Items.Add("Nam");
            cbGT.Items.Add("Nữ");
            cbGT.SelectedIndex = -1;
            cbFilter.Items.Clear();
            cbFilter.Items.Add("Tất cả");
            cbFilter.Items.Add("Đang học");
            cbFilter.Items.Add("Đã tốt nghiệp");
            cbFilter.SelectedIndex = -1;
            vohieuhoa(true);
            if (Program.Role == "Phuhuynh")
            {
                txtSID.Focus();
                bAdd.Enabled = false;
                bSave.Enabled = false;
                bDel.Enabled = false;
                bEdit.Enabled = false;
                bCal.Enabled = false;
                grd.Columns["Datotnghiep"].ReadOnly = true;
            }
            else
            {
                grd.Columns["Datotnghiep"].ReadOnly = true;
            }
        }

        private void txtSID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string maHS = txtSID.Text.Trim();
                if (!string.IsNullOrEmpty(maHS))
                {
                    var result = bs.selectQuery_Student(maHS);
                    if (result.Rows.Count > 0)
                    {
                        grd.DataSource = result;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên!");
                        grd.DataSource = bs.selectQuery();
                    }
                }
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            dk = 1;
            vohieuhoa(false);
            txtSID.Text = bs.getSID();
            txtName.Focus();
            bEdit.Enabled = false;
            bDel.Enabled = false;
            bSave.Enabled = true;
            txtName.Text = "";
            txtAddress.Text = "";
            txtSDT.Text = "";
            cbGT.Text = "";
            dt.Value = DateTime.Now;
            cbClass.SelectedIndex = -1;
            cbFilter.Enabled = false;
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (grd.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa học sinh này?", "Chắc chắn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sid = grd.CurrentRow.Cells["MaHS"].Value.ToString();

                    bs = new BUS_Student(sid, "", "", "", DateTime.Now, "", "");
                    bs.deleteQuery();

                    MessageBox.Show("Xóa Sinh viên thành công!");
                    grd.DataSource = bs.selectQuery();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn học sinh muốn xóa.");
            }
            bSave.Enabled = false;
            txtSID.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtSDT.Text = "";
            cbGT.Text = "";
            dt.Value = DateTime.Now;
            cbClass.SelectedIndex = -1;
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSID.Text))
            {
                MessageBox.Show("Vui lòng chọn học sinh muốn chỉnh sửa.");
                return;
            }
            if (Program.Role == "Admin" || Program.Role == "Giaovien")
            {
                vohieuhoa(false);
                dk = 2;
                txtName.Focus();
                txtSID.ReadOnly = true;
                bAdd.Enabled = false;
                bDel.Enabled = false;
                bSave.Enabled = true;
                cbFilter.Enabled = false;
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSID.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(dt.Text) || string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtSDT.Text) || string.IsNullOrWhiteSpace(cbGT.Text) || string.IsNullOrWhiteSpace(cbClass.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            string maLop = cbClass.SelectedValue.ToString();
            string gioiTinh = cbGT.Text;

            if (dk == 1)
            {
                // Thêm mới
                bs = new BUS_Student(txtSID.Text, txtName.Text, txtAddress.Text, txtSDT.Text, DateTime.Parse(dt.Text), gioiTinh, maLop);
                bs.addQuery();
            }
            else if (dk == 2)
            {
                // Chỉnh sửa
                bs = new BUS_Student(txtSID.Text, txtName.Text, txtAddress.Text, txtSDT.Text, DateTime.Parse(dt.Text), gioiTinh, maLop);
                bs.updateQuery();
            }
            dk = 0;
            bAdd.Enabled = true;
            bDel.Enabled = true;
            bEdit.Enabled = true;
            bSave.Enabled = false;
            txtSID.ReadOnly = false;
            cbFilter.Enabled = true;
            txtSID.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtSDT.Text = "";
            cbGT.Text = "";
            dt.Value = DateTime.Now;
            cbClass.SelectedIndex = -1;
            grd.DataSource = bs.selectQuery();
            Student_Load(sender, e);
        }

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = grd.Rows[e.RowIndex];

                txtSID.Text = row.Cells["MaHS"].Value.ToString();
                txtName.Text = row.Cells["HoTen"].Value.ToString();
                txtAddress.Text = row.Cells["DiaChi"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                cbGT.Text = row.Cells["GioiTinh"].Value.ToString();
                dt.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                cbClass.SelectedValue = row.Cells["MaLop"].Value.ToString();
            }
        }

        private void bCal_Click(object sender, EventArgs e)
        {
            Student_Load(sender, e);
            txtSID.Clear();
            txtName.Text = "";
            txtAddress.Text = "";
            txtSDT.Text = "";
            cbGT.Text = "";
            dt.Value = DateTime.Now;
            cbClass.SelectedIndex = -1;
            cbFilter.Enabled = true;
            txtSID.ReadOnly = false;
            bAdd.Enabled = true;
            bDel.Enabled = true;
            bEdit.Enabled = true;
        }

        private void cbFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string whereClause = "";

            switch (cbFilter.SelectedIndex)
            {
                case 1: // Đang học (Graduated = 0)
                    whereClause = "WHERE Datotnghiep = 0";
                    break;
                case 2: // Đã tốt nghiệp (Graduated = 1)
                    whereClause = "WHERE Datotnghiep = 1";
                    break;
                default:
                    whereClause = ""; // Tất cả
                    break;
            }

            grd.DataSource = bs.selectQuery(whereClause);
        }
    }
}
