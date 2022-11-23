using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstract__Interface
{
    internal class User
    {
        string _username;
        string _password;
        protected string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length > 6)
                {
                    _username = value;
                }
            }
        }
        protected string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (CheckPassword(value))
                {
                    _password = value;
                }
            }
        }

        public User(string username, string pw)
        {
            Username = username;
            Password = pw;
        }

        public static bool CheckPassword(string pw)
        {
            bool hasDigit = false;
            bool hasLower = false;
            bool hasUpper = false;
            bool result=false;
            char[] digits = { '0', '1', '2', '3' };
            foreach (char charachter in pw)
            {
                foreach (var item in digits)
                {
                    if(charachter == item)
                    {
                        hasDigit = true;
                    }
                }

                //hasDigit = char.IsDigit(charachter) ? true : false; shorthand if else

                if (char.IsDigit(charachter))
                {
                    hasDigit = true;
                }
                else if (char.IsLower(charachter))
                {
                    hasLower = true;
                }
                else if (char.IsUpper(charachter))
                {
                    hasUpper = true;
                }
                result = hasDigit && hasLower && hasUpper;
                if (result)
                {
                    break;
                }

            }
            return result;
        }
    }
}
