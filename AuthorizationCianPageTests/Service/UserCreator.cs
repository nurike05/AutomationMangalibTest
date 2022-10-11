using AuthorizationCianPageTests.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorizationCianPageTests.Service
{
    public static class UserCreator
    {

        public static readonly string USER_NAME = "nurike05";
        public static readonly string USER_PASSWORD = "1718121707a";

        public static User SetWithCredentialsFromProperty()
        {
            return new User(USER_NAME, USER_PASSWORD);
        }

        public static User SetWithEmptyUsername()
        {
            return new User("", USER_PASSWORD);
        }

        public static User SetWithEmptyPassword()
        {
            return new User(USER_NAME, "");
        }
    }
}
