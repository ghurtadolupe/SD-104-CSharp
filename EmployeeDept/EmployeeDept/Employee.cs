using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDept
{
    class Employee
    {
        string firstName;
        string lastName;
        string dept;


        //constructor
        public Employee(string firstName, string lastName, string dept)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dept = dept;

            //assign a department if none is user does not input one
            if(string.IsNullOrEmpty(dept))
            {

                dept = "IT";

            }

            //check user values
            Console.WriteLine("First Name: " + firstName + "  Last Name: " + lastName + "  Department: " + dept);
            Console.ReadLine();

        }
    }
}
