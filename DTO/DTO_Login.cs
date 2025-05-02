using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Login
    {
        private string Username, Password, Role;

        public string GetUser
        {
            get { return Username; }
            set { Username = value; }
        }

        public string GetPassword
        {
            get { return Password; }
            set { Password = value; }
        }

        public string GetRoles
        {
            get { return Role; }
            set { Role = value; }
        }

        public DTO_Login(string Username, string Password, string Role)
        {
            this.Username = Username;
            this.Password = Password;
            this.Role = Role;
        }
    }
}
