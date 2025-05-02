using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace DAL
{
    public class Connection
    {
        //private static string connectionString = "initial catalog = SchoolManage; data source = NANHTHU215\\NANHTHU; integrated security = true";
        private static string connectionString = ReadConnectionString();

        private static string ReadConnectionString()
        {
            string[] lines = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.txt"));

            if (lines.Length >= 3)
            {
                string authType = lines[0];
                string server = lines[1];
                string database = lines[2];

                if (authType.ToLower() == "windows")
                {
                    return $"Data Source={server};Initial Catalog={database};Integrated Security=True";
                }
                else if (authType.ToLower() == "sql" && lines.Length >= 5)
                {
                    string uid = lines[3];
                    string pw = lines[4];
                    return $"Data Source={server};Initial Catalog={database};User ID={uid};Password={pw}";
                }
            }

            throw new Exception("Lỗi cấu hình kết nối. Vui lòng kiểm tra lại file config.txt.");
        }

        private static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static void actionQuery(string sql, SqlParameter[] parameters = null)
        {
            using (SqlConnection cn = GetConnection())
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    // Thêm các tham số nếu có
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Trong class Connection
        public static int ActionQuery(string query, SqlParameter[] parameters)
        {
            using (SqlConnection conn = GetConnection()) 
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteNonQuery(); // Trả về số dòng bị ảnh hưởng
            }
        }


        // Thực hiện truy vấn SQL trả về dữ liệu (SELECT)
        public static DataTable selectQuery(string sql)
        {
            using (SqlConnection cn = GetConnection())
            {
                cn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, cn);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                return dt;
            }
        }
        public static DataTable selectQuery(string sql, SqlParameter[] parameters = null)
        {
            using (SqlConnection cn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}
