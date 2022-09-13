using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Name Daxil Et:");
            User user = new User(Console.ReadLine());
            Console.WriteLine("Passwordu Daxil Et:");
            user.Password = Console.ReadLine();

            Console.WriteLine($"User Name: {user.UserName}\nPassword: {user.Password}");
        }
    }
}
