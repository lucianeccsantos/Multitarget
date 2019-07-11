using System;
using Core;
using Core22;

namespace Standard
{
    public class Class1
    {
        public static string MyString()
        {
            return "Hello Standard 2.0";
        }

        public static string MyStringCore()
        {
            return Core.Class1.MyString();
        }

        public static string MyStringCore2()
        {
            return Core22.Class1.MyString();
        }
    }
}
