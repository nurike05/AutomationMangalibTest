using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorizationCianPageTests.Model
{
    public class User
    {
        private string username;
        private string password;
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string GetUsername
        {
            get { return username; }
        }

        public string GetPassword
        { 
            get { return password; }
        }

        public string GetUsernameFromProp
        {
            get
            {
                return TestContext.Parameters["devUserName"];
            }
        }
        public string GetPasswordFromProp
        {
            get
            {
                return TestContext.Parameters["devPassword"];
            }
        }
    }
}
