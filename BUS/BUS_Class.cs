﻿using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BUS
{
    public class BUS_Class
    {
        DAL_Class dc;

        public BUS_Class(string maLop, string tenLop, string gvcn, string nienKhoa)
        {
            dc = new DAL_Class(maLop, tenLop, gvcn, nienKhoa);
        }

        public void addQuery()
        {
            dc.addQuery();
        }

        public void updateQuery()
        {
            dc.updateQuery();
        }

        public void deleteQuery()
        {
            dc.deleteQuery();
        }

        public DataTable selectQuery()
        {
            return dc.selectQuery();
        }
        public DataTable selectQuery_Class(string maLop)
        {
            return dc.selectQuery_Class(maLop);
        }

        public DataTable selectStudentList(string maLop)
        {
            return dc.selectStudentList(maLop);
        }
        public DataTable selectTeacherList()
        {
            return dc.selectTeacherList();
        }

        public int CountStudentsInClass(string classId)
        {
            DAL_Class dal = new DAL_Class("", "", "", "");
            return dal.CountStudentsInClass(classId);
        }
        public string getCID()
        {
            DataTable tb = dc.getClassDesc();
            if (tb.Rows.Count > 0)
            {
                string res = tb.Rows[0][0].ToString();

                if (res.StartsWith("L") && res.Length >= 2)
                {
                    try
                    {
                        int stt = int.Parse(res.Substring(1)) + 1;

                        return "L" + stt.ToString("D2");
                    }
                    catch (FormatException)
                    {
                        return "L01";
                    }
                }
            }
            return "L01";
        }


        public void MarkAllGraduated(string maLop)
        {
            string query = @"
        UPDATE HocSinh 
        SET Datotnghiep = 1, MaLop = NULL 
        WHERE MaLop = @MaLop";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaLop", maLop)
            };

            // Gọi phương thức truy vấn để thực hiện câu lệnh
            Connection.ActionQueryNoReturn(query, parameters);
        }

    }
}
