using System;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_Login
    {
        DAL_Login p;

        public BUS_Login(string Username, string Password, string Role)
        {
            p = new DAL_Login(Username, Password, Role);
        }
        public DataTable selectQuery(string user, string pass)
        {
            return p.selectQuery(user, pass);
        }
        public bool ChangePassword(string oldPwd, string newPwd, string confirmPwd)
        {
            if (newPwd != confirmPwd)
            {
                return false;
            }

            string username = Session.CurrentUsername;

            DAL_Login dal = new DAL_Login("", "", "");
            return dal.UpdatePassword(username, oldPwd, newPwd);
        }

        public BUS_Login()
        {
            // Constructor mặc định
        }
    }
}
