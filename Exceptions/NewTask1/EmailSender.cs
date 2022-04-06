using System;
using System.Collections.Generic;
using System.Text;
using NewTask1.Utilities;

namespace NewTask1
{
    public  class EmailSender : MessageSender
    {
        public EmailSender(String adress, bool FingerPrint, string password)
        {
            Adress = adress;
            if (FingerPrint == false)
            {
                throw new FingerPrintException("FingerPrint is not True");
            }
            else
            {
                FingerPrintSecurity = FingerPrint;
            }

            bool IsUpper = false;
            bool IsDigit = false;
            bool IsLower = false;

            if (password.Length < 8)
            {

                throw new SecurityRiskException("PAssword is not safe");

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
                        IsUpper = true;
                    }
                }
            }



            if (IsUpper == false || IsLower == false || IsDigit == false)
            {
                throw new SecurityRiskException("PAssword is not safe");
            }
            else
            {
                Password = password;
            }
        }
        public override void SendMessage()
        {
           
            Console.WriteLine("Email Message sent");
        }
    
    
        
    }
}
