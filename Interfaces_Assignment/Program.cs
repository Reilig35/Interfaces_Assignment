using System;

namespace Interfaces_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Sample = new Employee();
            Sample.fName = "Sample";
            Sample.lName = "Student";

            Sample.SayName();

            IQuittable Iquit = new Employee();

            Iquit.Quit();
        }
    }
}