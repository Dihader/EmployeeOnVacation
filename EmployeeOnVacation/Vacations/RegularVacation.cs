using System;
using EmployeeOnVacation.Vacations;

namespace EmployeeOnVacation
{
    public class RegularVacation : Vacation
    {
        public bool IsConfirmed { get; set; }
        public RegularVacation(string name, Employee employee, DateTime dateStartVacation, DateTime dateEndVacation, string description, bool isConfirmed)
        {
            EmployeeOnVacation = employee;
            DateEndVacation = dateEndVacation;
            DateStartVacation = dateStartVacation;
            Description = description;
            Name = name;
            IsConfirmed = isConfirmed;
        }

        public override double GetMoneyVacation()
        {
            TimeSpan ts = DateEndVacation - DateStartVacation;
            int day = ts.Days;
            return day * (EmployeeRepository.GetAvgSalary() / 30);
        }
    }
}