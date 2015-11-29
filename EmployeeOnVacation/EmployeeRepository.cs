using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOnVacation
{
    public static class EmployeeRepository
    {
        public static List<Employee> GetAllEmployee()
        {
            List<Employee> listEmployees = new List<Employee>();
            Employee first = new Employee(1, "Иванов", "Иван", "Иванович", 8500000);
            Employee second = new Employee(2, "Петров", "Петр", "Петрович", 7500000);
            Employee third = new Employee(3, "Сидоров", "Сидор", "Сидорович", 9500000);
            Employee four = new Employee(4, "Семенов", "Семен", "Семенович", 6500000);
            listEmployees.Add(first);
            listEmployees.Add(second);
            listEmployees.Add(third);
            listEmployees.Add(four);
            return listEmployees;
        }

        public static double GetAvgSalary()
        {
            List<Employee> list = GetAllEmployee();
            double result = list.Aggregate<Employee, double>(0, (current, t) => current + t.Salary);
            return result / list.Count;
        }
        

        public static Employee GetEmployee(int id)
        {
            List<Employee> list = GetAllEmployee();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ID == id)
                {
                    return list[i];
                }
            }
            return null;
        }

    }
}
