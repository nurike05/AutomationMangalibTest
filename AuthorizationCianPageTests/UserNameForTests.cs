using NUnit.Framework;
using System;
namespace AuthorizationCianPageTests
{
    public class UserNameForTests
    {
        public static string userLogin = "nurike05";
        public static string userPassword = "1718121707a";


        public string GetUserName()
        {
            return TestContext.Parameters["devUserName"];
        }

        public string GetPassword()
        {
            return TestContext.Parameters["devPassword"];
        }
    }
}
