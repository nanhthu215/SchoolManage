using System;
using System.IO;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;
using GUI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Login
{
    public partial class Login : Form
    {
        SqlConnection cn;
        BUS_Login l;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load_1(object sender, EventArgs e)
        {
            // Kiểm tra sự tồn tại của file cấu hình
            if (File.Exists("config.txt"))
            {
                StreamReader rd = new StreamReader("config.txt");
                string s = rd.ReadLine();
                string server, db;

                if (s.Equals("windows"))
                {
                    Program.server = rd.ReadLine();
                    Program.db = rd.ReadLine();
                }
                else
                {
                    Program.server = rd.ReadLine();
                    Program.db = rd.ReadLine();
                    Program.uid = rd.ReadLine();
                    Program.pw = rd.ReadLine();
                }
                rd.Close();

                // Test the connection once
                if (!TestDatabaseConnection())
                {
                    MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu. Vui lòng cấu hình lại thông tin kết nối.", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    frmConfig configForm = new frmConfig();
                    configForm.ShowDialog();
                }
            }
            else
            {
                frmConfig f = new frmConfig();
                f.ShowDialog();
            }

            l = new BUS_Login("", "", "");
            txtDN.Focus();
        }

        private bool TestDatabaseConnection()
        {
            try
            {
                string sql;
                if (Program.uid == null || Program.pw == null) // If no UID or PW, use Windows Authentication
                {
                    sql = "initial catalog = " + Program.db + "; data source = " + Program.server + "; integrated security = true";
                }
                else
                {
                    // Use SQL Authentication
                    sql = "initial catalog = " + Program.db + "; data source = " + Program.server + "; User ID = " + Program.uid + "; Password = " + Program.pw + "; integrated security = true";
                }

                cn = new SqlConnection(sql);
                cn.Open();  // Test connection
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool signin(string username, string password)
        {

            DataTable dt = new DataTable();
            dt = l.selectQuery(username, password);
            if (dt.Rows.Count > 0)
            {
                Program.Username = dt.Rows[0][0].ToString();
                Program.Role = dt.Rows[0][2].ToString();
                return true;
            }
            else
                return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDN.Text) || string.IsNullOrWhiteSpace(txtMK.Text))
            {
                MessageBox.Show("Nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDN.Clear();
                txtMK.Clear();
                txtDN.Focus();
                return;
            }

            if (signin(txtDN.Text, txtMK.Text))
            {
                Session.CurrentUsername = txtDN.Text;
                this.Hide();
                Home home = new Home();
                home.WindowState = FormWindowState.Maximized;
                DialogResult result = home.ShowDialog();

                if (result == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                else
                {
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDN.Clear();
                txtMK.Clear();
                txtDN.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
