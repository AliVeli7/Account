using System;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {

            User user1 = new User();
            user1.Password = "12345Avbn";
            
            user1.ShoeInfo();
            

            Console.WriteLine(user1.PasswordChecker(user1.Password));




        }
    }
}
