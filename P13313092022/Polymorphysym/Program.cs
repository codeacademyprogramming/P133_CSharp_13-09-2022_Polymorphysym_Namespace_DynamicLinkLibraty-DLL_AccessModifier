//using Demo;
using System;
using Demo.DemoNested;
using Demo;
using Polymorphysym.Models;
using P133Library;
using P133ExternalLibrary;

namespace Polymorphysym
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();
            //student.Name = "Aqil";
            //student.SurName = "Soltanli";
            //student.Age = 19;
            //student.Grade = 56;
            //student.Education = "Code Acadey";

            Demo.Student stu = new Demo.Student();
            Demo.DemoNested.Car car = new Demo.DemoNested.Car();
            Models.Car car1 = new Models.Car();
            //Console.WriteLine(student.ShowInfo());
            //student.FullName();

            P133ExternalLibrary.Student student = new P133ExternalLibrary.Student();
            
        }
    }

    class Test : P133ExternalLibrary.Student
    {
        public Test()
        {
            Name = "Hamid";
        }
    }
}
