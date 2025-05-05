using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace DAL
{
    public class DAL_Class
    {
        DTO_Class c;

        public DAL_Class(string maLop, string tenLop, string gvcn, string nienKhoa)
        {
            c = new DTO.DTO_Class(maLop, tenLop, gvcn, nienKhoa);
        }

        public void addQuery()
        {
            string query = "INSERT INTO Lop (MaLop, TenLop, GVCN, NienKhoa) VALUES (@MaLop, @TenLop, @GVCN, @NienKhoa)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaLop", c.maLop),
                new SqlParameter("@TenLop", c.tenLop),
                new SqlParameter("@GVCN", c.gvcn),
                new SqlParameter("@NienKhoa", c.nienKhoa),
            };
            Connection.actionQuery(query, parameters);
        }


        public void updateQuery()
        {
            string query = "UPDATE Lop SET TenLop = @TenLop, GVCN = @GVCN, NienKhoa = @NienKhoa WHERE MaLop = @MaLop";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaLop", c.maLop),
                new SqlParameter("@TenLop", c.tenLop),
                new SqlParameter("@GVCN", c.gvcn),
                new SqlParameter("@NienKhoa", c.nienKhoa),
            };
            Connection.actionQuery(query, parameters);
        }

        public DataTable selectQuery_Class(string MaLop)
        {
            string s = "select * from Lop where MaLop = '" + MaLop + "'";
            return Connection.selectQuery(s);
        }

        public void deleteQuery()
        {
            string query = "DELETE FROM Lop WHERE MaLop = @MaLop";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaLop", c.maLop)
            };
            Connection.actionQuery(query, parameters);
        }

        public DataTable selectStudentList(string maLop)
        {
            string query = "SELECT * FROM HocSinh WHERE MaLop = @MaLop";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaLop", maLop)
            };
            return Connection.selectQuery(query, parameters);
        }
        public DataTable selectTeacherList()
        {
            string query = "SELECT MaGV, HoTen FROM GiaoVien";
            return Connection.selectQuery(query);
        }

        public DataTable selectQuery()
        {
            string s = "select * from Lop";
            return Connection.selectQuery(s);
        }
        public DataTable getClassDesc()
        {
            string s = "select top 1 MaLop from Lop order by MaLop desc";
            return Connection.selectQuery(s);
        }
        public int CountStudentsInClass(string classId)
        {
            int count = 0;
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
            {
                string query = "SELECT COUNT(*) FROM HocSinh WHERE MaLop = @MaLop";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaLop", classId);
                conn.Open();
                count = (int)cmd.ExecuteScalar();
            }
            return count;
        }


    }
}
