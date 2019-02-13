using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task7.DAL
{
    public class Login
    {
        private string name;
        private string password;
        private string role;
        
        public Login(string name, string password, string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
        }

        public string Role
        {
            get
            {
                return this.role;
            }
        }
    }
}
