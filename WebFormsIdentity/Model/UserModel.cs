using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsIdentity.Model
{
    public class UserModel
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string  fullName;

        public string  FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        private string  email;

        public string  Email
        {
            get { return email; }
            set { email = value; }
        }

        private string  loginName;

        public string  LoginName
        {
            get { return loginName; }
            set { loginName = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string confirmPassword;

        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set { confirmPassword = value; }
        }

        public UserModel(int id,string FullName, string Email, string LoginName, string Password, string ConfirmPassword)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            LoginName = loginName;
            Password = password;
            ConfirmPassword = confirmPassword;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}