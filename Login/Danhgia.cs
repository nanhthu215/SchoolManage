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
    public partial class Danhgia : Form
    {
        BUS_DanhGia bc;
        public Danhgia()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDanhGia.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            bc = new BUS_DanhGia((int)n1.Value, txtDanhGia.Text);
            bc.addQuery();

            BUS_DanhGia loader = new BUS_DanhGia(1, ""); // Provide default arguments  
            grd.DataSource = loader.selectQuery();
            txtDanhGia.Clear();
            n1.Value = 1;
            txtDanhGia.ReadOnly = true;
            n1.ReadOnly = true;
            bSave.Enabled = false;
        }


        private void bAdd_Click_1(object sender, EventArgs e)
        {
            txtDanhGia.ReadOnly = false;
            txtDanhGia.Clear();
            n1.ReadOnly = false;
            n1.Value = 1; // giá trị mặc định hợp lệ  
            bSave.Enabled = true;
        }

        private void Danhgia_Load(object sender, EventArgs e)
        {
            // Set giá trị giới hạn cho n1  
            n1.Minimum = 1;
            n1.Maximum = 10;
            n1.Value = 1;

            txtDanhGia.ReadOnly = true;
            n1.ReadOnly = true;
            bSave.Enabled = false;

            BUS_DanhGia loader = new BUS_DanhGia(1, ""); // Provide default arguments  
            grd.DataSource = loader.selectQuery();
            if (Program.Role == "Admin")
            {
                txtDanhGia.Focus();
                txtDanhGia.ReadOnly = true;
                n1.ReadOnly=true;
                bAdd.Enabled = false;
                bSave.Enabled = false;
            }
            else
            {

            }
        }

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = grd.Rows[e.RowIndex];

                txtDanhGia.Text = row.Cells["NhanXet"].Value.ToString();
                n1.Value = Convert.ToDecimal(row.Cells["Diem"].Value);
            }
        }
    }
}
