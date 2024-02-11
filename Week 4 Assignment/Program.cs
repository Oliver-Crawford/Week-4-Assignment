using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment
{
    internal class Program
    {
        interface Interface1
        {
            void DoSomeWork();
        }
        class Customer : Interface1
        {
            public string customerID;
            public string shippingAddress;
            public Customer(string conCustomerID, string conShippingAddress)
            {
                customerID = conCustomerID;
                shippingAddress = conShippingAddress;
            }
            public void DoSomeWork() { Console.WriteLine($"This is a customer, {customerID}, {shippingAddress}"); }
        }
        class Emp : Interface1
        {
            public string department;
            public string salary;
            public Emp(string conDepartment, string conSalary)
            {
                department = conDepartment;
                salary = conSalary;
            }
            public void DoSomeWork() { Console.WriteLine($"This is a employee, {department}, {salary}"); }
        }
        class Student : Interface1
        {
            public string rollNumber;
            public string studyingClass;
            public Student(string conRollNumber, string conStudyingClass)
            {
                rollNumber = conRollNumber;
                studyingClass = conStudyingClass;
            }
            public void DoSomeWork() { Console.WriteLine($"This is a student, {rollNumber}, {studyingClass}"); }
        }
        static void Main(string[] args)
        {
            Customer CustomerExample = new Customer("1", "867 W. Street");
            Emp EmployeeExample = new Emp("Sales", "not enough");
            Student StudentExmaple = new Student("4751", "2357");

            CustomerExample.DoSomeWork();
            EmployeeExample.DoSomeWork();
            StudentExmaple.DoSomeWork();
            Console.ReadLine();
        }
    }
}
