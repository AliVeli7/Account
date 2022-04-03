using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    class User : IAccount
    {


        public string FullName;


        public string EMail;


        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                bool result = PasswordChecker(value);
                if (result == false)
                {
                    Console.WriteLine("sire en az 8 element, 1 boyuk herf 1 kicik herf ve bir reqem olmalidir");
                }
                else
                {
                    _password = value;
                }
            }
        }


        public bool PasswordChecker(string password)
        {
            bool IsUpper = false;
            bool IsDigit = false;
            bool IsLower = false;

            if (password.Length<8)
            {

                return false;
                
            }
            else
            {
                foreach (char item in password)
                {
                    if (char.IsDigit(item))
                    {
                        IsDigit = true;
                    }
                    if (char.IsLower(item))
                    {
                        IsLower = true;
                    }
                    if (char.IsUpper(item))
                    {
                        IsUpper= true;
                    }
                }
            }



            if (IsUpper==false||IsLower==false||IsDigit==false)
            {
                return false;
            }
            else
            {
                return true;
            }
            
            
           
        }

        public void ShoeInfo()
        {
            Console.WriteLine($"FullName:{FullName} Email:{EMail}");
        }
    }
}
