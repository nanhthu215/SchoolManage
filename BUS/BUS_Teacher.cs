using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BUS
{
    public class BUS_Teacher
    {
        DAL_Teacher t;

        public BUS_Teacher(string maGV, string hoTen, string diaChi, string sDT, DateTime ngaySinh, string gioiTinh, string email)
        {
            t = new DAL_Teacher(maGV, hoTen, diaChi, sDT, ngaySinh, gioiTinh, email);
        }

        public void addQuery()
        {
            t.addQuery();
        }

        public void updateQuery()
        {
            t.updateQuery();
        }

        public void deleteQuery()
        {
            t.deleteQuery();
        }

        public DataTable selectQuery()
        {
            return t.selectQuery();
        }
        public DataTable selectQuery_Teacher(string maGV)
        {
            return t.selectQuery_Teacher(maGV);
        }

        public string getTID()
        {
            DataTable tb = t.getTeacherDesc();
            if (tb.Rows.Count > 0)
            {
                string res = tb.Rows[0][0].ToString();

                if (res.Length >= 5)
                {
                    try
                    {
                        int stt = int.Parse(res.Substring(2, 3)) + 1;

                        res = "GV" + stt.ToString().PadLeft(3, '0');

                        return res;
                    }
                    catch (FormatException)
                    {
                        return "GV001";
                    }
                }
                else
                {
                    return "GV001";
                }
            }
            else
            {
                return "GV001";
            }
        }
    }
}
