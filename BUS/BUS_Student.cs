using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DAL;

namespace BUS
{
    public class BUS_Student
    {
        DAL_Student p;

        public BUS_Student(string maHS, string hoTen, string diaChi, string sDT, DateTime ngaySinh, string gioiTinh, string maLop)
        {
            p = new DAL_Student(maHS, hoTen, diaChi, sDT, ngaySinh, gioiTinh, maLop);
        }

        public void addQuery()
        {
            p.addQuery();
        }

        public void updateQuery()
        {
            p.updateQuery();
        }

        public void deleteQuery()
        {
            p.deleteQuery();
        }

        public DataTable selectQuery()
        {
            return p.selectQuery();
        }
        public DataTable selectQuery_Student(string maHS)
        {
            return p.selectQuery_Student(maHS); 
        }

        public DataTable selectClassList()
        {
            return p.selectClassList();
        }

        public string getSID()
        {
            DataTable tb = p.getStudentDesc();
            if (tb.Rows.Count > 0)
            {
                string res = tb.Rows[0][0].ToString();

                if (res.Length >= 5)
                {
                    try
                    {
                        int stt = int.Parse(res.Substring(2, 3)) + 1;

                        // Đảm bảo số thứ tự có 3 chữ số
                        res = "HS" + stt.ToString().PadLeft(3, '0');

                        return res;
                    }
                    catch (FormatException)
                    {
                        return "HS001";
                    }
                }
                else
                {
                    return "HS001";
                }
            }
            else
            {
                return "HS001";
            }
        }

    }
}
