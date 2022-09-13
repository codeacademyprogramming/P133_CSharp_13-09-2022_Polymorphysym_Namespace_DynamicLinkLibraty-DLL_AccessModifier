using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphysym
{
    class Student : Human
    {
        public double Grade;
        public string Education;

        public override string ShowInfo()
        {
            return base.ShowInfo();
        }

        public override void FullName()
        {

        }
    }
}
