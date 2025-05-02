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
    public partial class HealthCare : Form
    {
        BUS_Health bh;
        public HealthCare()
        {
            InitializeComponent();
        }

        private void vohieuhoa(bool b)
        {
            txtCC.ReadOnly = b;
            dt.Enabled = !b;
            txtCN.ReadOnly = b;
            txtS.ReadOnly = b;
            dt.Enabled = !b;
        }
        private void LoadStudentList()
        {
            cbSID.DataSource = bh.selectStudentList();
            cbSID.DisplayMember = "HoTen";
            cbSID.ValueMember = "MaHS";
            cbSID.SelectedIndex = -1;
        }

        private void HealthCare_Load(object sender, EventArgs e)
        {
            bh = new BUS_Health("", 0, 0, "", DateTime.Now);
            grd.DataSource = bh.selectQuery();
            bSave.Enabled = false;
            LoadStudentList();

            vohieuhoa(true);
            if (Program.Role == "Phuhuynh")
            {
                cbSID.Focus();
                bSave.Enabled = false;
                bDel.Enabled = false;
                bEdit.Enabled = false;
                bCal.Enabled = false;
            }
            else
            {

            }
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (grd.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này?", "Chắc chắn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sid = grd.CurrentRow.Cells["MaHS"].Value.ToString();

                    bh = new BUS_Health(sid, 0, 0, "", DateTime.Now);
                    bh.deleteQuery();

                    MessageBox.Show("Xóa thành công!");
                    grd.DataSource = bh.selectQuery();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu muốn xóa.");
            }
            bSave.Enabled = false;
            bDel.Enabled = true;
            bEdit.Enabled = true;
            cbSID.Enabled = true;
            cbSID.Text = "";
            txtCN.Text = "";
            txtCC.Text = "";
            txtS.Text = "";
            dt.Value = DateTime.Now;
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbSID.Text))
            {
                MessageBox.Show("Vui lòng chọn học sinh cần chỉnh sửa thông tin.");
                return;
            }
            if (Program.Role == "Admin" || Program.Role == "Giaovien")
            {
                vohieuhoa(false);
                txtCN.Focus();
                cbSID.Enabled = false;
                bDel.Enabled = false;
                bSave.Enabled = true;
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbSID.Text) || string.IsNullOrWhiteSpace(txtS.Text) || string.IsNullOrWhiteSpace(txtCN.Text) || string.IsNullOrWhiteSpace(txtCC.Text) || string.IsNullOrWhiteSpace(dt.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            string maHS = cbSID.SelectedValue.ToString();

            if (decimal.TryParse(txtCN.Text, out decimal canNang) && decimal.TryParse(txtCC.Text, out decimal chieuCao))
            {
                bh = new BUS_Health(maHS, canNang, chieuCao, txtS.Text, DateTime.Parse(dt.Text));

                // Kiểm tra học sinh đã có dữ liệu hay chưa
                var check = bh.selectQuery_Student(maHS);
                if (check.Rows.Count > 0)
                {
                    bh.updateQuery();
                }
                else
                {
                    bh.addQuery();
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu cân nặng, chiều cao phải là số. Vui lòng nhập lại!");
                return;
            }

            bDel.Enabled = true;
            bEdit.Enabled = true;
            bSave.Enabled = false;
            cbSID.SelectedIndex = -1;
            cbSID.Enabled = true;
            txtCN.Text = "";
            txtCC.Text = "";
            txtS.Text = "";
            dt.Value = DateTime.Now;
            grd.DataSource = bh.selectQuery();
            HealthCare_Load(sender,e);
        }

        private void bCal_Click(object sender, EventArgs e)
        {
            HealthCare_Load(sender, e);
            cbSID.SelectedIndex = -1;
            cbSID.Enabled = true;
            txtCN.Text = "";
            txtCC.Text = "";
            txtS.Text = "";
            dt.Value = DateTime.Now;

            bDel.Enabled = true;
            bEdit.Enabled = true;
        }

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = grd.Rows[e.RowIndex];

                cbSID.Text = row.Cells["MaHS"].Value.ToString();
                txtCN.Text = row.Cells["CanNang"].Value.ToString();
                txtCC.Text = row.Cells["ChieuCao"].Value.ToString();
                txtS.Text = row.Cells["TinhTrangSucKhoe"].Value.ToString();
                dt.Value = Convert.ToDateTime(row.Cells["NgayKiemTra"].Value);
            }
        }

        private void cbSID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSID.SelectedValue != null)
            {
                string maHS = cbSID.SelectedValue.ToString();
                var result = bh.selectQuery_Student(maHS);
                grd.DataSource = result;
                if (result.Rows.Count > 0)
                {
                    DataRow row = result.Rows[0];
                    txtCN.Text = row["CanNang"].ToString();
                    txtCC.Text = row["ChieuCao"].ToString();
                    txtS.Text = row["TinhTrangSucKhoe"].ToString();
                    dt.Value = Convert.ToDateTime(row["NgayKiemTra"]);
                }
                else
                {
                    txtCN.Clear();
                    txtCC.Clear();
                    txtS.Clear();
                    dt.Value = DateTime.Now;
                }
            }
        }
    }
}
