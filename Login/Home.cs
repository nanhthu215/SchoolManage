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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.Text = " School Management System - Xin chào: " + Program.Username + "!";
            if (Program.Role == "Phuhuynh")
            {
                qUẢNLÝLỚPHỌCToolStripMenuItem.Enabled = false;
                qUẢNLÝGIÁOVIÊNToolStripMenuItem1.Enabled = false;
            }
            else if (Program.Role == "Giaovien")
            {
                qUẢNLÝHỌCSINHToolStripMenuItem1.Enabled = false;
                hỌCPHÍToolStripMenuItem.Enabled = false;
            }
        }

        private void menuStrip9_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void qUẢNLÝHỌCSINHToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();

            Student student = new Student();
            student.TopLevel = false;
            student.Dock = DockStyle.Fill;

            panel3.Controls.Add(student);
            student.Show();
        }

        private void qUẢNLÝLỚPHỌCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();

            ClassManage cm = new ClassManage();
            cm.TopLevel = false;
            cm.Dock = DockStyle.Fill;

            panel3.Controls.Add(cm);
            cm.Show();
        }

        private void qUẢNLÝGIÁOVIÊNToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();

            TeacherManage teacher = new TeacherManage();
            teacher.TopLevel = false;
            teacher.Dock = DockStyle.Fill;

            panel3.Controls.Add(teacher);
            teacher.Show();
        }

        private void qUẢNLÝSỨCKHỎEHỌCSINHToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();

            HealthCare htlcare = new HealthCare();
            htlcare.TopLevel = false;
            htlcare.Dock = DockStyle.Fill;

            panel3.Controls.Add(htlcare);
            htlcare.Show();
        }

        private void qUẢNLÝLỚPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();

            ChangePwd cpwd = new ChangePwd();
            cpwd.TopLevel = false;
            cpwd.Dock = DockStyle.Fill;

            panel3.Controls.Add(cpwd);
            cpwd.Show();
        }

        private void menuStrip5_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void qUẢNLÝGIÁOVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login.Login loginForm = new Login.Login();

                DialogResult loginResult = loginForm.ShowDialog();

                if (loginResult == DialogResult.OK)
                {
                    this.Show();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void qUẢNLÝHỌCSINHToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();

            Danhgia dg = new Danhgia();
            dg.TopLevel = false;
            dg.Dock = DockStyle.Fill;

            panel3.Controls.Add(dg);
            dg.Show();
        }

        private void hỌCPHÍToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();

            Tuiition tt = new Tuiition();
            tt.TopLevel = false;
            tt.Dock = DockStyle.Fill;

            panel3.Controls.Add(tt);
            tt.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
