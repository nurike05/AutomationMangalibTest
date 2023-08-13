using AuthorizationCianPageTests.Model;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace AuthorizationCianPageTests.Service
{
    public static class UserCreator
    {
        public static readonly string USER_NAME = "nurike05";
        public static readonly string USER_PASSWORD = "achacha";

        public static User SetWithCredentialsFromProperty()
        {
            return new User(USER_NAME, USER_PASSWORD);
        }
    }
}
