using System.Collections.Generic;

namespace EmployeeOnVacation
{
    public class Employee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public int Salary { get; set; }

        public Employee(string lastName, string firstName, string middleName,int salary)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            Salary = salary;
        }

        public List<Employee> GetAllEmployee()
        {
            List<Employee> listEmployees = new List<Employee>();
            Employee first = new Employee("Иванов", "Иван", "Иванович", 8500000);
            Employee second = new Employee("Петров", "Петр", "Петрович", 7500000);
            Employee third = new Employee("Сидоров", "Сидор", "Сидорович", 9500000);
            Employee four = new Employee("Семенов", "Семен", "Семенович", 6500000);
            listEmployees.Add(first);
            listEmployees.Add(second);
            listEmployees.Add(third);
            listEmployees.Add(four);
            return listEmployees;
        }

        public Employee()
        {
                
        }
    }
}
