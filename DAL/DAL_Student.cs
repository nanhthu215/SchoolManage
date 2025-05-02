using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace DAL
{
    public class DAL_Student
    {
        DTO_Student p;

        public DAL_Student(string maHS, string hoTen, string diaChi, string sDT, DateTime ngaySinh, string gioiTinh, string maLop)
        {
            p = new DTO.DTO_Student(maHS, hoTen, diaChi, sDT, ngaySinh, gioiTinh, maLop);
        }

        public void addQuery()
        {
            string query = "INSERT INTO HocSinh (MaHS, HoTen, NgaySinh, GioiTinh, DiaChi, SDT, MaLop) VALUES (@MaHS, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SDT, @MaLop)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHS", p.maHS),
                new SqlParameter("@HoTen", p.hoTen),
                new SqlParameter("@NgaySinh", p.ngaySinh),
                new SqlParameter("@GioiTinh", p.gioiTinh),
                new SqlParameter("@DiaChi", p.diaChi),
                new SqlParameter("@SDT", p.sDT),
                new SqlParameter("@MaLop", p.maLop)
            };
            Connection.actionQuery(query, parameters);
        }


        public void updateQuery()
        {
            string query = "UPDATE HocSinh SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DiaChi = @DiaChi, SDT = @SDT, MaLop = @MaLop WHERE MaHS = @MaHS";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHS", p.maHS),
                new SqlParameter("@HoTen", p.hoTen),
                new SqlParameter("@NgaySinh", p.ngaySinh),
                new SqlParameter("@GioiTinh", p.gioiTinh),
                new SqlParameter("@DiaChi", p.diaChi),
                new SqlParameter("@SDT", p.sDT),
                new SqlParameter("@MaLop", p.maLop)
            };
            Connection.actionQuery(query, parameters);
        }

        public DataTable selectQuery_Student(string MaHS)
        {
            string s = "select * from HocSinh where MaHS = '" + MaHS + "'";
            return Connection.selectQuery(s);
        }

        public void deleteQuery()
        {
            string query = "DELETE FROM HocSinh WHERE MaHS = @MaHS";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaHS", p.maHS)
            };
            Connection.actionQuery(query, parameters);
        }

        public DataTable selectClassList()
        {
            string query = "SELECT MaLop, TenLop FROM Lop";
            return Connection.selectQuery(query);
        }


        public DataTable selectQuery()
        {
            string s = "select * from HocSinh";
            return Connection.selectQuery(s);
        }
        public DataTable getStudentDesc()
        {
            string s = "select top 1 MaHS from HocSinh order by MaHS desc";
            return Connection.selectQuery(s);
        }
    }
}
