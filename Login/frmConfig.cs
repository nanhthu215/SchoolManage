using System;
using System.IO;
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
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            if (ckW.Checked == true)
            {
                txtUID.Enabled = false;
                txtPW.Enabled = false;
            }
            else
            {
                txtUID.Enabled = true;
                txtPW.Enabled = true;
            }
        }

        private void ckW_CheckedChanged(object sender, EventArgs e)
        {
            if (ckW.Checked == true)
            {
                txtUID.Enabled = false;
                txtPW.Enabled = false;
            }
            else
            {
                txtUID.Enabled = true;
                txtPW.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = txtServer.Text;
            string db = txtDB.Text;
            string uid = txtUID.Text; // Tên đăng nhập, nếu sử dụng SQL Authentication
            string pw = txtPW.Text;   // Mật khẩu, nếu sử dụng SQL Authentication

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(server) || string.IsNullOrWhiteSpace(db))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Server và Database!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(Application.StartupPath, "config.txt")))
                {
                    if (ckW.Checked) // Nếu checkbox "Windows Authentication" được tích
                    {
                        sw.WriteLine("windows");
                        sw.WriteLine(server);
                        sw.WriteLine(db);
                    }
                    else // Nếu checkbox không được tích, sử dụng SQL Authentication
                    {
                        // Kiểm tra nếu người dùng chưa nhập tên đăng nhập hoặc mật khẩu khi sử dụng SQL Authentication
                        if (string.IsNullOrWhiteSpace(uid) || string.IsNullOrWhiteSpace(pw))
                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu khi sử dụng SQL Authentication!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        sw.WriteLine("sql");
                        sw.WriteLine(server);
                        sw.WriteLine(db);
                        sw.WriteLine(uid);
                        sw.WriteLine(pw);
                    }
                }

                // Thông báo khi lưu thành công
                MessageBox.Show("Cấu hình đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

            }
            catch (Exception ex)
            {
                // Thông báo lỗi nếu có
                MessageBox.Show("Có lỗi khi lưu cấu hình: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}