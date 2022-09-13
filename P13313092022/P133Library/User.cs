using System;
using System.Collections.Generic;
using System.Text;

namespace P133Library
{
    public class User
    {
        //Field
        private string _userName;
        //Property
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                while (value.Length < 8)
                {
                    Console.WriteLine("User Name Deyer Minimum 8 Simvol Ola Biler");
                    value = Console.ReadLine();
                }

                _userName = value;
            }
        }

        private string _password;

        public string Password
        {
            get => _password;
            set
            {
                //bool check = true;

                while (/*check*/true)
                {
                    if (value.Length >= 8)
                    {
                        bool checkDigit = false;
                        bool checkLower = false;
                        bool checkUpper = false;

                        foreach (char item in value)
                        {
                            if (char.IsDigit(item))
                            {
                                checkDigit = true;
                            }
                            else if (char.IsLower(item))
                            {
                                checkLower = true;
                            }
                            else if (char.IsUpper(item))
                            {
                                checkUpper = true;
                            }

                            if (checkDigit && checkLower && checkUpper)
                            {
                                _password = value;
                                //check = false;
                                return;
                            }
                        }

                        Console.WriteLine("Passwod Minimum 1 Reqem 1 Boyuk Herf ve 1 kicik Herif Olmalidir");
                        value = Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine("Password Deyeri Minimum 8 Simvol Olmalidir");
                        value = Console.ReadLine();
                    }


                }
            }
        }

        public User(string userName)
        {
            UserName = userName;
        }
    }
}
