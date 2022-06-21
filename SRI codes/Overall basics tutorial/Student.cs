using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string Aname, string Amajor, double Agpa)
        {
            this.name = Aname;
            major = Amajor;
            gpa = Agpa;
        }

        public bool HasHonors()
        {
            if (gpa >= 7.5)
                return true;
            else
                return false;
        }
    }
}
