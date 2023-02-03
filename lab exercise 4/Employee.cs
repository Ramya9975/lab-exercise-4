using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_exercise_4
{
    internal class Employee
    {
        public int id;
        public string name;
        public int age;
        public int DOB;
        public int Basic;
        public int HRA;

        public void EmployeeDetails()
        {
            Console.WriteLine("Enter the employee name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter the employee age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the DOB:");
            DOB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the employee basic:");
            Basic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the employee HRA:");
            HRA = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("The employee name is: {0}", name);
            Console.WriteLine("The employee age is: {0}", age);
            Console.WriteLine("The employee DOB is: {0}", DOB);
            Console.WriteLine("The employee Basic is:{0}", Basic);
            Console.WriteLine("The employee HRA is: {0}", HRA);
            Console.ReadLine();

        }

    }
}

