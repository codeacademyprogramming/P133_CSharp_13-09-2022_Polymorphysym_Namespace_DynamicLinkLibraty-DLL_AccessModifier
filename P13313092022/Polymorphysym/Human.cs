using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphysym
{
    class Human
    {
        public string Name;
        public string SurName;
        public byte Age;

        public virtual string ShowInfo()
        {
            return $"Name: {Name}\nSurName: {SurName}\nAge: {Age}";
        }

        public virtual void FullName()
        {
            Console.WriteLine($"{Name} {SurName} Code");
        }
    }
}
