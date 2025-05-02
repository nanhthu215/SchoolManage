using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace DAL
{
    public class DAL_DanhGia
    {
        DTO_DanhGia c;

        public DAL_DanhGia(int Diem, string NhanXet)
        {
            c = new DTO.DTO_DanhGia(Diem, NhanXet);
        }

        public void addQuery()
        {
            string query = "INSERT INTO DanhGia (Diem, NhanXet) VALUES (@Diem, @NhanXet)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Diem", c.diem),
                new SqlParameter("@NhanXet", c.nhanxet),
            };
            Connection.actionQuery(query, parameters);
        }

        public DataTable selectQuery()
        {
            string s = "select * from DanhGia";
            return Connection.selectQuery(s);
        }
    }
}
