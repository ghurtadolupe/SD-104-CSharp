using System;

namespace Practicing_Reference_types
{
    class Program
    {





            static void Main(string[] args)
        {
            //className ObjectName = new className();

            Employee emp = new Employee();
            emp.firstName = "Jason";
            emp.lastName = "Bourne";
            emp.Dept = null;
            



            AssignDept(emp);
            Console.WriteLine(Employee.Dept);
            Console.ReadLine();

            
        }


        static void AssignDept(Employee emp)
        {

        }




        class Employee
        {
            String firstName;
            String lastName;
            String Department;


        }
            









        }
    }
}
