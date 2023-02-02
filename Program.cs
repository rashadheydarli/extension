using System;
namespace extensionmethod
{
    public class Program
    {
        static void Main()
        {
            var user1 = new User();
            user1.Name ="Rashad";
            user1.Surname = "Heydarli";
            user1.RegistrationMonth = RegistrationMonth.September;
            user1.PIN = 3D83JX6;
            Console.WriteLine(user1.GetDetail()); 







        }
    }
}


