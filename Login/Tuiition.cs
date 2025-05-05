using BUS;
using DAL;
using Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using System.IO;
using iText.Layout;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iText.StyledXmlParser.Jsoup.Nodes;
using iTextSharp.text.pdf;
using PdfSharp;
using iTextSharp.text;
using Document = iText.Layout.Document;
using Font = iTextSharp.text.Font;


namespace GUI
{
    public partial class Tuiition : Form
    {
        BUS_Tuition bt;
        int dk = 0;
        bool isAdding = false;

        public Tuiition()
        {
            InitializeComponent();
        }
        private void vohieuhoa(bool b)
        {
            txtTID.ReadOnly = b;
            dt.Enabled = !b;
            //txtSID1.ReadOnly = b;
            cbStatus.Enabled = !b;
            txtA.ReadOnly = b;
        }

        private void LoadStudentList()
        {
            cbSID.DataSource = bt.selectStudentList();
            cbSID.DisplayMember = "HoTen";
            cbSID.ValueMember = "MaHS";
            cbSID.SelectedIndex = -1;
        }

        private void Tuiition_Load(object sender, EventArgs e)
        {
            bt = new BUS_Tuition(cbSID.Text, DateTime.Parse(dt.Text), 0, cbStatus.Text);
            LoadStudentList();
            grd.DataSource = bt.selectQuery();
            bSave.Enabled = false;
            cbStatus.Items.Clear();
            cbStatus.Items.Add("Đã thanh toán");
            cbStatus.Items.Add("Chưa thanh toán");
            cbStatus.SelectedIndex = -1;

            vohieuhoa(true);
            if (Program.Role == "Phuhuynh")
            {
                cbSID.Focus();
                bAdd.Enabled = false;
                bSave.Enabled = false;
                bDel.Enabled = false;
                bEdit.Enabled = false;
                bCal.Enabled = false;
            }
            else
            {
                bPayment.Visible = false;
            }
        }

        private void txtSID1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string maHS = cbSID.Text.Trim();
                if (!string.IsNullOrEmpty(maHS))
                {
                    var result = bt.selectQuery_Student(maHS);
                    if (result.Rows.Count > 0)
                    {
                        grd.DataSource = result;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên!");
                        grd.DataSource = bt.selectQuery();
                    }
                }
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            isAdding = true;
            dk = 1;
            vohieuhoa(false);
            cbSID.Focus();
            bEdit.Enabled = false;
            bDel.Enabled = false;
            bSave.Enabled = true;
            cbSID.Text = "";
            txtA.Text = "";
            dt.Value = DateTime.Now;
            cbStatus.SelectedIndex = -1;
            cbSID.SelectedIndex = -1;
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (grd.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này?", "Chắc chắn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string tuitionID = grd.CurrentRow.Cells["TuitionID"].Value.ToString();

                    BUS_Tuition bt = new BUS_Tuition();
                    bt.DeleteByID(tuitionID); // Gọi hàm xóa có tham số

                    MessageBox.Show("Xóa học phí thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grd.DataSource = bt.selectQuery(); // Load lại bảng
                }
            }

            else
            {
                MessageBox.Show("Vui lòng chọn học sinh muốn xóa.");
            }
            bSave.Enabled = false;
            cbSID.Focus();
            bEdit.Enabled = false;
            bDel.Enabled = false;
            cbSID.Text = "";
            txtA.Text = "";
            dt.Value = DateTime.Now;
            cbStatus.SelectedIndex = -1;
            cbSID.SelectedIndex = -1;
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbSID.Text))
            {
                MessageBox.Show("Vui lòng chọn học sinh muốn chỉnh sửa.");
                return;
            }
            vohieuhoa(false);
            dk = 2;
            cbSID.Focus();
            cbSID.Enabled = false;
            bAdd.Enabled = false;
            bDel.Enabled = false;
            bSave.Enabled = true;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbSID.Text) || string.IsNullOrWhiteSpace(cbStatus.Text) || string.IsNullOrWhiteSpace(dt.Text) || string.IsNullOrWhiteSpace(txtA.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            string status = cbStatus.Text;
            string maHS = cbSID.SelectedValue.ToString();


            if (dk == 1)
            {//string maHS, DateTime duedate, decimal amount, string status
                // Thêm mới
                bt = new BUS_Tuition(maHS, DateTime.Parse(dt.Text), decimal.Parse(txtA.Text), status);
                bt.addQuery();
            }
            else if (dk == 2)
            {
                // Chỉnh sửa
                bt = new BUS_Tuition(maHS, DateTime.Parse(dt.Text), decimal.Parse(txtA.Text), status);
                bt.updateQuery();
            }
            dk = 0;
            vohieuhoa(true);
            bAdd.Enabled = true;
            bDel.Enabled = true;
            bEdit.Enabled = true;
            bSave.Enabled = false;
            cbSID.Enabled = true;
            isAdding = false;
            cbSID.Text = "";
            txtA.Text = "";
            cbStatus.Text = "";
            dt.Value = DateTime.Now;
            cbSID.SelectedIndex = -1;
            grd.DataSource = bt.selectQuery();
        }

        private void bCal_Click(object sender, EventArgs e)
        {
            Tuiition_Load(sender, e);
            cbSID.Text = "";
            txtA.Text = "";
            txtTID.Text = "";
            isAdding = false;
            dt.Value = DateTime.Now;
            cbStatus.SelectedIndex = -1;

            bAdd.Enabled = true;
            bDel.Enabled = true;
            bEdit.Enabled = true;
        }

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = grd.Rows[e.RowIndex];

                cbSID.Text = row.Cells["MaHS"].Value.ToString();
                txtA.Text = row.Cells["Amount"].Value.ToString();
                //txtTID.Text = row.Cells["Tuition"].Value.ToString();
                cbStatus.Text = row.Cells["Status"].Value.ToString();
                dt.Value = Convert.ToDateTime(row.Cells["DueDate"].Value);
            }
        }

        private void bPayment_Click(object sender, EventArgs e)
        {
            if (grd.CurrentRow != null)
            {
                string tuitionID = grd.CurrentRow.Cells["TuitionID"].Value.ToString();

                DialogResult result = MessageBox.Show("Xác nhận thanh toán học phí?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DAL_Tuition dal = new DAL_Tuition();
                    dal.MarkAsPaid(tuitionID);

                    MessageBox.Show("Đã thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grd.DataSource = new BUS_Tuition().selectQuery();
                }
            }
        }

        private void bPDF_Click(object sender, EventArgs e)
        {
            if (grd.Rows.Count - 1 > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Dữ liệu học phí.pdf";
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
                                pdfDoc.Add(new iTextSharp.text.Paragraph("Danh sách học phí", font));
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

        private void selectStudentList()
        {
            cbSID.DataSource = bt.selectStudentList();
            cbSID.DisplayMember = "HoTen";
            cbSID.ValueMember = "MaHS";
        }

        private void grd_SelectionChanged(object sender, EventArgs e)
        {
            if (grd.CurrentRow != null)
            {
                if (Program.Role == "Admin")
                {
                    bPayment.Visible = false;
                }
                else
                {
                    var status = grd.CurrentRow.Cells["Status"].Value.ToString().Trim();
                    if (status == "Đã thanh toán" || status == "1")
                    {
                        bPayment.Visible = false;  
                    }
                    else
                    {
                        bPayment.Visible = true; 
                    }
                }
            }
        }


        private void cbSID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isAdding) return;
            if (cbSID.SelectedValue != null)
            {
                string maHS = cbSID.SelectedValue.ToString();
                var result = bt.selectQuery_Student(maHS);
                grd.DataSource = result;
                if (result.Rows.Count > 0)
                {
                    DataRow row = result.Rows[0];
                    txtA.Text = row["Amount"].ToString();
                    //txtTID.Text = row["Tuition"].ToString();
                    cbStatus.Text = row["Status"].ToString();
                    dt.Value = Convert.ToDateTime(row["DueDate"]);
                }
                else
                {
                    txtA.Clear();
                    cbStatus.Text = "";
                    dt.Value = DateTime.Now;
                }
            }
        }
    }
}