using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class DAL_Teacher
    {
        DTO_Teacher t;

        public DAL_Teacher(string maGV, string hoTen, string diaChi, string sDT, DateTime ngaySinh, string gioiTinh, string email)
        {
            t = new DTO.DTO_Teacher(maGV, hoTen, diaChi, sDT, ngaySinh, gioiTinh, email);
        }
        public void addQuery()
        {
            string query = "INSERT INTO GiaoVien (MaGV, HoTen, NgaySinh, GioiTinh, DiaChi, SDT, Email) VALUES (@MaGV, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SDT, @Email)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaGV", t.maGV),
                new SqlParameter("@HoTen", t.hoTen),
                new SqlParameter("@NgaySinh", t.ngaySinh),
                new SqlParameter("@GioiTinh", t.gioiTinh),
                new SqlParameter("@DiaChi", t.diaChi),
                new SqlParameter("@SDT", t.sDT),
                new SqlParameter("@Email", t.email)
            };
            Connection.actionQuery(query, parameters);
        }


        public void updateQuery()
        {
            string query = "UPDATE GiaoVien SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DiaChi = @DiaChi, SDT = @SDT, Email = @Email WHERE MaGV = @MaGV";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaGV", t.maGV),
                new SqlParameter("@HoTen", t.hoTen),
                new SqlParameter("@NgaySinh", t.ngaySinh),
                new SqlParameter("@GioiTinh", t.gioiTinh),
                new SqlParameter("@DiaChi", t.diaChi),
                new SqlParameter("@SDT", t.sDT),
                new SqlParameter("@Email", t.email)
            };
            Connection.actionQuery(query, parameters);
        }
        public DataTable selectQuery_Teacher(string MaGV)
        {
            string s = "select * from Giaovien where MaGV = '" + MaGV + "'";
            return Connection.selectQuery(s);
        }

        public void deleteQuery()
        {
            string query = "DELETE FROM GiaoVien WHERE MaGV = @MaGV";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaGV", t.maGV)
            };
            Connection.actionQuery(query, parameters);
        }

        public DataTable selectQuery()
        {
            string s = "select * from GiaoVien";
            return Connection.selectQuery(s);
        }
        public DataTable getTeacherDesc()
        {
            string s = "select top 1 MaGV from GiaoVien order by MaGV desc";
            return Connection.selectQuery(s);
        }
    }
}
