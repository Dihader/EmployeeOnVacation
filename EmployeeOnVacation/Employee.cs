using System.Collections.Generic;

namespace EmployeeOnVacation
{
    public class Employee
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public int Salary { get; set; }

        public Employee(int id,string lastName, string firstName, string middleName,int salary)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            Salary = salary;
            ID = id;
        }
    }
}
