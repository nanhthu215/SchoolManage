using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace DAL
{
    public class DAL_Health
    {
        DTO_Health h;

        public DAL_Health(string maHS, decimal canNang, decimal chieuCao, string tinhTrang, DateTime ngayKiemTra)
        {
            h = new DTO.DTO_Health(maHS, canNang, chieuCao, tinhTrang, ngayKiemTra);
        }

        public void addQuery()
        {
            string query = "INSERT INTO SucKhoeTre (MaHS, CanNang, ChieuCao, TinhTrangSucKhoe, NgayKiemTra) VALUES (@MaHS, @CanNang, @ChieuCao, @TinhTrangSucKhoe, @NgayKiemTra)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHS", h.maHS),
                new SqlParameter("@CanNang", h.canNang),
                new SqlParameter("@ChieuCao", h.chieuCao),
                new SqlParameter("@TinhTrangSucKhoe", h.TinhTrang),
                new SqlParameter("@NgayKiemTra",h.ngayKiemTra),
            };
            Connection.actionQuery(query, parameters);
        }

        public void updateQuery()
        {
            string query = "UPDATE SucKhoeTre SET CanNang = @CanNang, ChieuCao = @ChieuCao, TinhTrangSucKhoe = @TinhTrangSucKhoe, NgayKiemTra = @NgayKiemTra WHERE MaHS = @MaHS";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHS", h.maHS),
                new SqlParameter("@CanNang", h.canNang),
                new SqlParameter("@ChieuCao", h.chieuCao),
                new SqlParameter("@TinhTrangSucKhoe", h.TinhTrang),
                new SqlParameter("@NgayKiemTra",h.ngayKiemTra),
            };
            Connection.actionQuery(query, parameters);
        }

        public DataTable selectQuery_Student(string MaHS)
        {
            string s = "select * from SucKhoeTre where MaHS = '" + MaHS + "'";
            return Connection.selectQuery(s);
        }

        public void deleteQuery()
        {
            string query = "DELETE FROM SucKhoeTre WHERE MaHS = @MaHS";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaHS", h.maHS)
            };
            Connection.actionQuery(query, parameters);
        }
        public DataTable selectStudentList()
        {
            string query = "SELECT MaHS, HoTen FROM HocSinh";
            return Connection.selectQuery(query);
        }

        public DataTable selectQuery()
        {
            string s = "select * from SucKhoeTre";
            return Connection.selectQuery(s);
        }
    }
}
