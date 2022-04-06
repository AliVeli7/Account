using System;
using NewTask1.Utilities;

namespace NewTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("1-Send Email Mesage\n2-Send Sms Message\n0-Exit ");
                int num = Convert.ToInt32(Console.ReadLine());
                EmailSender email = new EmailSender("JackSparrow", true, "1234");
                SmsSender sms = new SmsSender("Baku", false, "WAF4tdfda8");

                switch (num)
                {
                    case 1:
                        email.SendMessage();
                        break;
                    case 2:
                        sms.SendMessage();
                        break;
                    case 0:
                        break;

                    default:
                        Console.WriteLine("Wrong");
                        break;
                }               }
            
            catch (FingerPrintException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(SecurityRiskException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            

        }
    }
}
