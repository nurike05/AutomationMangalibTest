using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorizationCianPageTests.Model
{
    public class User
    {
        public string GetUsername { get; }
        public string GetPassword { get; }
        public User(string username, string password)
        {
            GetUsername = username;
            GetPassword = password;
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
