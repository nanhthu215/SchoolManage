using BUS;
using iText.Layout.Splitting;
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
    public partial class ChangePwd : Form
    {
        BUS_Login l;
        public ChangePwd()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangePwd_Load(object sender, EventArgs e)
        {
        }

        private void bChange_Click(object sender, EventArgs e)
        {
            BUS_Login l = new BUS_Login();
            string oldPwd = txtMKC.Text;
            string newPwd = txtMKM.Text;
            string confirmPwd = txtXN.Text;

            if (string.IsNullOrEmpty(oldPwd) || string.IsNullOrEmpty(newPwd) || string.IsNullOrEmpty(confirmPwd))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMKC.Clear();
                txtMKM.Clear();
                txtXN.Clear();
                return;
            }

            if (newPwd != confirmPwd)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMKC.Clear();
                txtMKM.Clear();
                txtXN.Clear();
                return;
            }

            bool success = l.ChangePassword(oldPwd, newPwd,confirmPwd); 

            if (success)
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKC.Clear();
                txtMKM.Clear();
                txtXN.Clear();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu cũ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMKC.Clear();
                txtMKM.Clear();
                txtXN.Clear();
                return ;
            }
        }
        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}

