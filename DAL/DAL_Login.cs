using System;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_Login
    {
        private DTO_Login p;

        public DAL_Login(string Username, string Password, string Role)
        {
            p = new DTO_Login(Username, Password, Role);  
        }
        public void addQuery()
        {
            string query = "insert into Users values ('" + p.GetUser + "', '" + p.GetPassword + "', '" + p.GetRoles + "')";
            Connection.actionQuery(query);
        }

        public bool UpdatePassword(string username, string oldPwd, string newPwd)
        {
            string query = "UPDATE Users SET Password = @newPwd WHERE Username = @username AND Password = @oldPwd";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@newPwd", newPwd),
        new SqlParameter("@username", username),
        new SqlParameter("@oldPwd", oldPwd)
            };

            int rowsAffected = Connection.ActionQuery(query, parameters);
            return rowsAffected > 0;
        }

        public DataTable selectQuery(string Username, string Password)
        {
            string s = "select * from Users where Username = '" + Username + "' and Password = '" + Password + "'";
            return Connection.selectQuery(s);
        }
    }
}
