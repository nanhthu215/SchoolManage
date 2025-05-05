using BUS;
using iTextSharp.text.pdf;
using iTextSharp.text;
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
    public partial class ClassManage : Form
    {
        BUS_Class bc;
        int dk = 0;
        public ClassManage()
        {
            InitializeComponent();
        }
        private void vohieuhoa(bool b)
        {
            txtName.ReadOnly = b;
            txtYear.ReadOnly = b;
            cbGVCN.Enabled = !b;
            txtCID.Focus();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ClassManage_Load(object sender, EventArgs e)
        {
            bc = new BUS_Class("", "", "", "");
            grd.DataSource = bc.selectQuery();
            LoadTeacherList();
            vohieuhoa(true);
            bSave.Enabled = false;
            if (Program.Role == "Giaovien")
            {
                txtCID.Focus();
                bAdd.Enabled = false;
                bSave.Enabled = false;
                bDel.Enabled = false;
                bEdit.Enabled = false;
                bCal.Enabled = false;
                cbGVCN.Enabled = false;
                bMarkGraduated.Enabled = false;
            }
            else
            {

            }
        }
        private void txtCID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string maLop = txtCID.Text.Trim();
                if (!string.IsNullOrEmpty(maLop))
                {
                    var result = bc.selectQuery_Class(maLop);
                    if (result.Rows.Count > 0)
                    {
                        grd.DataSource = result;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy lớp học!");
                        grd.DataSource = bc.selectQuery();
                    }
                }
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            dk = 1;
            vohieuhoa(false);
            txtCID.Text = bc.getCID();
            txtName.Focus();
            bEdit.Enabled = false;
            bDel.Enabled = false;
            bSave.Enabled = true;
            txtName.Clear();
            txtYear.Clear();
            cbGVCN.SelectedIndex = -1;
            bMarkGraduated.Enabled = false; 
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (grd.CurrentRow != null)
            {
                string cid = grd.CurrentRow.Cells["MaLop"].Value.ToString();

                bc = new BUS_Class(cid, "", "", "");
                int studentCount = bc.CountStudentsInClass(cid);

                if (studentCount > 0)
                {
                    MessageBox.Show("Không thể xóa lớp vì vẫn còn học sinh trong lớp này.");
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa lớp học này?", "Chắc chắn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bc = new BUS_Class(cid, "", "", "");
                    bc.deleteQuery();

                    MessageBox.Show("Xóa lớp học thành công!");
                    grd.DataSource = bc.selectQuery();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lớp học muốn xóa.");
            }

            bSave.Enabled = false;
            txtCID.Clear();
            txtName.Clear();
            txtYear.Clear();
            cbGVCN.SelectedIndex = -1;
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCID.Text))
            {
                MessageBox.Show("Vui lòng chọn lớp học muốn chỉnh sửa.");
                return;
            }
            if (Program.Role == "Admin")
            {
                vohieuhoa(false);
                dk = 2;
                txtName.Focus();
                txtCID.ReadOnly = true;
                bAdd.Enabled = false;
                bDel.Enabled = false;
                bSave.Enabled = true;
                bMarkGraduated.Enabled = false;
            }
        }
        private void bSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCID.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(cbGVCN.Text) || string.IsNullOrWhiteSpace(txtYear.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            string gvcn = cbGVCN.SelectedValue.ToString();

            if (dk == 1)
            {
                // Thêm mới
                bc = new BUS_Class(txtCID.Text, txtName.Text, gvcn, txtYear.Text);
                bc.addQuery();
            }
            else if (dk == 2)
            {
                // Chỉnh sửa
                bc = new BUS_Class(txtCID.Text, txtName.Text, gvcn, txtYear.Text);
                bc.updateQuery();
            }
            dk = 0;
            bAdd.Enabled = true;
            bDel.Enabled = true;
            bEdit.Enabled = true;
            bSave.Enabled = false;
            txtCID.ReadOnly = !true;
            bMarkGraduated.Enabled = true;
            txtCID.Clear();
            txtName.Clear();
            txtYear.Clear();
            cbGVCN.SelectedIndex = -1;
            vohieuhoa(true);
            grd.DataSource = bc.selectQuery();
            ClassManage_Load(sender, e);

        }

        private void bCal_Click(object sender, EventArgs e)
        {
            ClassManage_Load(sender, e);
            txtCID.Clear();
            txtName.Clear();
            txtYear.Clear();
            cbGVCN.SelectedIndex = -1;
            bAdd.Enabled = true;
            bDel.Enabled = true;
            bEdit.Enabled = true;
            grd.Enabled = true;
        }

        private void bPDF_Click(object sender, EventArgs e)
        {
            if (grd.Rows.Count - 1 > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Dữ liệu lớp học.pdf";
                bool fileError = false;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Không thể ghi dữ liệu xuống đĩa." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                            BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);

                            PdfPTable pdfTable = new PdfPTable(grd.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT;

                            // Add columns  
                            foreach (DataGridViewColumn column in grd.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                                pdfTable.AddCell(cell);
                            }

                            // Add rows  
                            for (int i = 0; i < grd.Rows.Count - 1; ++i)
                            {
                                for (int j = 0; j < grd.Columns.Count; ++j)
                                {
                                    pdfTable.AddCell(new Phrase(grd.Rows[i].Cells[j].Value.ToString(), font));
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document();
                                iTextSharp.text.pdf.PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(new iTextSharp.text.Paragraph("Danh sách lớp học", font));
                                pdfDoc.Add(new iTextSharp.text.Paragraph("\n", font));
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Dữ liệu xuất ra thành công!!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất!!!", "Info");
            }
        }

        private void LoadTeacherList()
        {
            cbGVCN.DataSource = bc.selectTeacherList();
            cbGVCN.DisplayMember = "HoTen";
            cbGVCN.ValueMember = "MaGV";
        }

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = grd.Rows[e.RowIndex];

                txtCID.Text = row.Cells["MaLop"].Value.ToString();
                txtName.Text = row.Cells["TenLop"].Value.ToString();
                txtYear.Text = row.Cells["NienKhoa"].Value.ToString();
                cbGVCN.Text = row.Cells["GVCN"].Value.ToString();
            }
        }

        private void bShow_Click(object sender, EventArgs e)
        {
            string maLop = txtCID.Text.Trim();

            if (!string.IsNullOrEmpty(maLop))
            {
                BUS_Class bus = new BUS_Class("", "", "", "");
                DataTable dt = bus.selectStudentList(maLop);
                vohieuhoa(true);
                bAdd.Enabled = false;
                bDel.Enabled = false;
                bEdit.Enabled = false;
                bSave.Enabled = false;
                grd.ReadOnly = true;

                grd.Enabled = false;  

                if (dt.Rows.Count > 0)
                {
                    grd.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy học sinh nào trong lớp " + maLop);
                    grd.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã lớp!");
            }
        }


        private void bMarkGraduated_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCID.Text))
            {
                MessageBox.Show("Vui lòng chọn lớp học.");
                return;
            }

            string maLop = txtCID.Text.Trim();

            DialogResult result = MessageBox.Show("Bạn có chắc muốn đánh dấu tất cả học sinh trong lớp này là đã tốt nghiệp? Điều này sẽ xóa tất cả học sinh trong lớp.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bc.MarkAllGraduated(maLop);

                grd.DataSource = bc.selectStudentList(maLop);

                MessageBox.Show("Đã đánh dấu tất cả học sinh trong lớp là đã tốt nghiệp và xóa danh sách học sinh.");
            }
        }

    }
}

